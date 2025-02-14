using GHelper.Helpers;
using GHelper.Intel;
using Ryzen;

namespace GHelper.AutoTDP.PowerLimiter
{

    internal class IntelMSRPowerLimiter : IPowerLimiter
    {

        uint backupPl1 = 0;
        uint backupPl2 = 0;

        public IntelMSRPowerLimiter()
        {
            IntelCoreControl.LogCurrentState();
        }

        public int GetMinInterval()
        {
            return 33;
        }

        public void Prepare()
        {

        }

        public static bool IsAvailable()
        {
            if (!ProcessHelper.IsUserAdministrator() || !IntelCoreControl.IsIntel())
            {
                return false;
            }

            Ols o = new Ols();

            o.InitializeOls();

            uint err = o.GetDllStatus();
            o.DeinitializeOls();
            o.Dispose();

            if (err == (uint)Ols.OlsDllStatus.OLS_DLL_NO_ERROR)
            {
                return true;
            }

            return false;
        }

        public void SavePowerLimits()
        {
            backupPl1 = IntelCoreControl.GetPL1();
            backupPl2 = IntelCoreControl.GetPL2();
        }


        public void SetCPUPowerLimit(double watts)
        {
            IntelCoreControl.SetPowerLimits((uint)Math.Ceiling(watts), (uint)Math.Ceiling(watts), clampPl1: true, clampPl2: true);
        }


        public int GetCPUPowerLimit()
        {
            Logger.WriteLine("[AutoTDPService] Read Power Limit - PL1: " + IntelCoreControl.GetPL1() + "W, PL2: " + IntelCoreControl.GetPL2() + "W");

            return (int)IntelCoreControl.GetPL1();
        }


        public void ResetPowerLimits()
        {
            if (backupPl1 == 0)
            {
                return;
            }
            IntelCoreControl.SetPowerLimits(backupPl1, backupPl2);
        }

        public void Dispose()
        {
        }
    }
}
