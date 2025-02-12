using GHelper.Mode;

namespace GHelper.AutoTDP.PowerLimiter
{
    internal class ASUSACPIPowerLimiter : IPowerLimiter
    {

        private bool allAmd;
        private bool fPPT;

        private int lastPowerLimit = 0;

        public ASUSACPIPowerLimiter()
        {
            allAmd = Program.acpi.IsAllAmdPPT();
            fPPT = Program.acpi.DeviceGet(AsusACPI.PPT_APUC1) >= 0;
        }

        public static bool IsAvailable()
        {
            return AppConfig.IsASUS();
        }
        public int GetMinInterval()
        {
            return 250;
        }

        public void Prepare()
        {
            //Program.modeControl.AutoFans(AppConfig.IsManualModeRequired() || AppConfig.IsFanRequired());
            Program.modeControl.SetPerformanceMode(Modes.GetCurrent());
        }

        public void SavePowerLimits()
        {
        }

        public void SetCPUPowerLimit(double watts)
        {

            int pl = (int)Math.Ceiling(watts);

            if (lastPowerLimit == pl)
            {
                //Do not set the same limit twice to reduce load on the ACPI driver
                return;
            }

            if (allAmd) // CPU limit all amd models
            {
                Program.acpi.DeviceSet(AsusACPI.PPT_CPUB0, pl, "PowerLimit B0");
            }
            else
            {
                Program.acpi.DeviceSet(AsusACPI.PPT_APUA3, pl, "PowerLimit A3");
                Program.acpi.DeviceSet(AsusACPI.PPT_APUA0, pl, "PowerLimit A0");
                if (fPPT) Program.acpi.DeviceSet(AsusACPI.PPT_APUC1, pl, "PowerLimit C1");
            }

            lastPowerLimit = pl;
        }


        // You can't read PPTs on ASUS :) endpoints just return 0 if they are available
        public int GetCPUPowerLimit()
        {
            return 200;
        }

        public void Dispose()
        {
            //Nothing to dispose here
        }

        // Correct Asus way to reset everything, is just to set mode again
        public void ResetPowerLimits()
        {
            Program.modeControl.SetPerformanceMode(Modes.GetCurrent());
        }
    }
}
