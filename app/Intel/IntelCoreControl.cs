using GHelper.Helpers;
using NvAPIWrapper.Native.GPU;
using NvAPIWrapper.Native.GPU.Structures;
using Ryzen;
using System;

namespace GHelper.Intel
{
    internal class IntelCoreControl
    {
        public static readonly uint MSR_PKG_POWER_LIMIT = 0x610;
        public static readonly uint MSR_RAPL_POWER_UNIT = 0x606;

        public static readonly uint INTEL_PACKAGE_RAPL_LIMIT_0_0_0_MCHBAR_PCU = 0x59a0;


        //Lower 14 bits are the power limits
        private static readonly uint PL1_MASK = 0x3FFF;
        private static readonly uint PL2_MASK = 0x3FFF;

        private static double POWER_UNIT = 0;
        private static double TIME_UNIT = 0;

        public static bool IsIntel()
        {
            return !RyzenControl.IsAMD(); // There is no GHeloper supported ASUS laptop that has a CPU which is neither AMD nor Intel. Therefore, no need to re-invent the wheel.
        }

        public static void Initialize()
        {
            if (!ProcessHelper.IsUserAdministrator() || RyzenControl.IsAMD())
            {
                //Only for Admins and not for AMD CPUs.
                return;
            }

            if (POWER_UNIT > 0 && TIME_UNIT > 0)
            {
                return;
            }

            Ols ols = new Ols();
            ols.InitializeOls();

            POWER_UNIT = GetPowerRAPLUnit(ols);
            TIME_UNIT = GetTimeUnit(ols);

            ols.DeinitializeOls();
            ols.Dispose();
        }

        private static void LogOLSState(uint err)
        {
            switch (err)
            {
                case (uint)Ols.OlsDllStatus.OLS_DLL_NO_ERROR:
                    return;
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_NOT_LOADED:
                    Logger.WriteLine("[IntelCoreControl] Intel MSR Error: OLS_DRIVER_NOT_LOADED");
                    break;
                case (uint)Ols.OlsDllStatus.OLS_DLL_UNSUPPORTED_PLATFORM:
                    Logger.WriteLine("[IntelCoreControl] Intel MSR Error: OLS_DLL_UNSUPPORTED_PLATFORM");
                    break;
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_NOT_FOUND:
                    Logger.WriteLine("[IntelCoreControl] Intel MSR Error: OLS_DLL_DRIVER_NOT_FOUND");
                    break;
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_UNLOADED:
                    Logger.WriteLine("[IntelCoreControl] Intel MSR Error: OLS_DLL_DRIVER_UNLOADED");
                    break;
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_NOT_LOADED_ON_NETWORK:
                    Logger.WriteLine("[IntelCoreControl] Intel MSR Error: OLS_DLL_DRIVER_NOT_LOADED_ON_NETWORK");
                    break;
                case (uint)Ols.OlsDllStatus.OLS_DLL_UNKNOWN_ERROR:
                    Logger.WriteLine("[IntelCoreControl] Intel MSR Error: OLS_DLL_UNKNOWN_ERROR");
                    break;
            }
        }

        /*
         * Due to Winring0 shipped with GHelper not implementing readphysicalmemory, we cannot fix the MMIO. 
         * Therefore, Intel Dynamic Tuning can lower the power limits below what we configure.
         * However, it cannot set the limits higher than we set them in the MSRs.
         * 
         * This function is incomplete due to testing not possible
         * 
         * See: https://github.com/horshack-dpreview/setPL/blob/master/setPL.sh for how to erase the MMIO to let MSR take full control over power limits.
        public static unsafe void MMIOFix()
        {

            Ols ols = new Ols();
            ols.InitializeOls();

            uint mchbar = ols.ReadPciConfigDword(0x00, 0x48);

            bool enabled = (((mchbar & 0x1) != 0));

            //Remove enabled bit to get phyiscal address
            mchbar = (uint)((mchbar & ~1));


            uint raplLimitAddr = ((mchbar + INTEL_PACKAGE_RAPL_LIMIT_0_0_0_MCHBAR_PCU));

            byte[] buffer = new byte[4];

            fixed (byte* pBuf = buffer)
            {
                ols.ReadPhysicalMemory(raplLimitAddr + 0, pBuf, 4, 1);
            }

            byte[] buffer2 = new byte[4];

            fixed (byte* pBuf = buffer2)
            {
                ols.ReadPhysicalMemory(raplLimitAddr + 4, pBuf, 4, 1);
            }


            ols.DeinitializeOls();
            ols.Dispose();

        }
        */

        public static void LogCurrentState()
        {
            uint pl1 = GetPL1();
            uint pl2 = GetPL2();

            bool msrLocked = IsMSRLocked();
            bool pl1Clamped = IsPL1Clamped();
            bool pl2Clamped = IsPL2Clamped();

            double TAU = GetTAU();


            Logger.WriteLine("[IntelCoreControl] MSR Power State: Pl1: " + pl1 + "W " + (pl1Clamped ? "(Clamped)" : "(Unclamped)") + ", PL2: " + pl2 + "W" + (pl2Clamped ? "(Clamped)" : "(Unclamped)") + ", TAU: " + TAU + "s. MSR State: " + (msrLocked ? "Locked" : "Unlocked"));

        }

        private static double GetPowerRAPLUnit(Ols ols)
        {
            uint eax = 0;
            uint edx = 0;

            if (ols.Rdmsr(MSR_RAPL_POWER_UNIT, ref eax, ref edx) == 0)
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_RAPL_POWER_UNIT");
                LogOLSState(ols.GetDllStatus());
                return -1;
            }

            //Bits 0:3
            uint pwr = eax & 0x3;

            return 1 / Math.Pow(2, pwr);
        }

        private static double GetTimeUnit(Ols ols)
        {
            uint eax = 0;
            uint edx = 0;

            if (ols.Rdmsr(MSR_RAPL_POWER_UNIT, ref eax, ref edx) == 0)
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_RAPL_POWER_UNIT");
                LogOLSState(ols.GetDllStatus());
                return -1;
            }

            //Bits 16:19
            uint pwr = (eax & 0xF0000) >> 16;

            return 1 / Math.Pow(2, pwr);
        }

        public static List<double> AllowedTimeUnits()
        {
            Initialize();

            if (TIME_UNIT <= 0)
            {
                //Timeunit was invalid
                return new List<double>();
            }

            List<double> lst = new List<double>();
            //y has 5 bits, z has 2 bits.
            for (int y = 0; y <= 31; ++y)
            {
                for (int z = 0; z <= 3; ++z)
                {
                    //Formula as specified by Intel
                    double val = Math.Pow(2, y) * (1.0 + (z / 4.0)) * TIME_UNIT;
                    lst.Add(val);
                }
            }

            return lst;
        }

        // Forumla  2^Y * (1.0 + Z/4.0) * Time_Unit
        // See intel specification
        // Y has 5 bits, Z has 2 bits.
        private static uint ComputeTimeWindowRAPL(double seconds)
        {
            int t = (int)(seconds / TIME_UNIT);

            double r = Math.Log2(t);

            int y = (int)r;

            if (y < 0 || y > 31)
            {
                //Value is out of range for bit range
            }

            int exp = (int)Math.Pow(2, y);

            double fac = t / (double)exp;

            int z = (int)((fac - 1) * 4);

            if (z < 0 || z > 3)
            {
                //Value is out of range for bit range
            }

            uint val = 0;

            //y are the first 5 bits, then z the next 2 bits for a total of 7 bits
            val |= (uint)y;
            val |= (uint)(z << 5);

            return val;
        }

        public static bool ReadPowerMSR(ref uint eax, ref uint edx)
        {
            Ols ols = new Ols();
            ols.InitializeOls();

            bool result = ols.Rdmsr(MSR_PKG_POWER_LIMIT, ref eax, ref edx) == 1;

            ols.DeinitializeOls();
            ols.Dispose();

            return result;
        }

        public static bool IsMSRLocked()
        {
            uint eax = 0;
            uint edx = 0;

            if (!ReadPowerMSR(ref eax, ref edx))
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_PKG_POWER_LIMIT");
                return true;
            }

            //Bit 31 of edx marks whether the MSR is locked and read only or whether it is writeable
            return (edx >> 31) != 0;
        }

        public static bool IsPL1Clamped()
        {
            uint eax = 0;
            uint edx = 0;

            if (!ReadPowerMSR(ref eax, ref edx))
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_PKG_POWER_LIMIT");
                return true;
            }

            //Bit 16 of eax
            return (eax >> 16) != 0;
        }

        public static bool IsPL2Clamped()
        {
            uint eax = 0;
            uint edx = 0;

            if (!ReadPowerMSR(ref eax, ref edx))
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_PKG_POWER_LIMIT");
                return true;
            }

            //Bit 16 of edx
            return (edx >> 16) != 0;
        }

        public static uint GetPL2()
        {
            Initialize();

            uint eax = 0;
            uint edx = 0;

            if (!ReadPowerMSR(ref eax, ref edx))
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_PKG_POWER_LIMIT");
                return 0;
            }

            uint pl2 = edx & PL2_MASK;

            return (uint)(pl2 * POWER_UNIT);
        }

        public static uint GetPL1()
        {
            Initialize();

            uint eax = 0;
            uint edx = 0;

            if (!ReadPowerMSR(ref eax, ref edx))
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_PKG_POWER_LIMIT");
                return 0;
            }

            uint pl1 = eax & PL1_MASK;

            return (uint)(pl1 * POWER_UNIT);
        }

        public static double GetTAU()
        {
            Initialize();

            uint eax = 0;
            uint edx = 0;

            if (!ReadPowerMSR(ref eax, ref edx))
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_PKG_POWER_LIMIT");
                return 0;
            }

            uint y = (eax & 0x00000000003E0000) >> 17;
            uint z = (eax & 0x0000000000C00000) >> 22;


            double val = Math.Pow(2, y) * (1.0 + (z / 4.0)) * TIME_UNIT;

            return val;
        }

        /// <summary>
        /// Sets the power limts for the CPU via MSR
        /// </summary>
        /// <param name="pl1">Longterm power limit in watts</param>
        /// <param name="pl2">Shortterm power limit in watts</param>
        /// <param name="tau">PL2 turbo time limit in seconds. See: AllowedTimeUnits() for possible TAU values</param>
        /// <param name="clampPl1">Allow going below OS-requested P/T state setting during time window of PL1</param>
        /// <param name="clampPl2">Allow going below OS-requested P/T state setting during time window of PL2</param>
        /// <returns>true if changes were applied successfully</returns>
        public static bool SetPowerLimits(uint pl1, uint pl2, double tau = 0, bool clampPl1 = false, bool clampPl2 = false)
        {
            Initialize();

            if (POWER_UNIT <= 0 || TIME_UNIT <= 0)
            {
                Logger.WriteLine("[IntelCoreControl] POWER_UNIT or TIME_UNIT could not be initialized.");
                return false;
            }

            bool status = false;

            Ols ols = new Ols();
            ols.InitializeOls();


            uint eax = 0;
            uint edx = 0;


            if (ols.Rdmsr(MSR_PKG_POWER_LIMIT, ref eax, ref edx) == 0)
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Read MSR_PKG_POWER_LIMIT");
                LogOLSState(ols.GetDllStatus());
                ols.DeinitializeOls();
                ols.Dispose();
                return false;
            }

            //Bit 31 of edx marks whether the MSR is locked and read only or whether it is writeable
            bool msrLocked = (edx >> 31) != 0;

            if (msrLocked)
            {
                Logger.WriteLine("[IntelCoreControl] MSR_PKG_POWER_LIMIT is locked. Cannot change power limits");
                ols.DeinitializeOls();
                ols.Dispose();
                return false;
            }


            uint pl1Rapl = (uint)(pl1 / POWER_UNIT);
            uint pl2Rapl = (uint)(pl2 / POWER_UNIT);

            //Set power limits
            eax = (eax & ~PL1_MASK) | pl1Rapl;
            edx = (edx & ~PL1_MASK) | pl2Rapl;


            //Set clamp for PL1
            if (clampPl1)
                eax |= 0x8000;
            else
                eax = eax & ~((uint)1 << 16);


            //Set clamp for PL2
            if (clampPl2)
                edx |= 0x8000;
            else
                edx = edx & ~((uint)1 << 16);


            if (tau > 0)
            {
                //Set power limit time window for PL2
                uint tauBits = ComputeTimeWindowRAPL(tau);

                tauBits = tauBits << 17;

                //Clear old tau bits
                eax = (uint)(eax & (0xFFFFFFFFFF01FFFF));

                //Apply new tau bits
                eax |= tauBits;
            }


            if (ols.Wrmsr(0x610, eax, edx) == 0)
            {
                Logger.WriteLine("[IntelCoreControl] Failed to Write MSR_PKG_POWER_LIMIT");
                LogOLSState(ols.GetDllStatus());
            }
            else
            {
                status = true;
            }

            ols.DeinitializeOls();
            ols.Dispose();

            return status;

        }
    }
}
