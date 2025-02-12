using GHelper.Peripherals.Mouse;
using GHelper.Peripherals.Mouse.Models;
using System.Runtime.CompilerServices;

namespace GHelper.Peripherals
{
    public class PeripheralsProvider
    {
        private static readonly object _LOCK = new object();

        public static List<AsusMouse> ConnectedMice = new List<AsusMouse>();

        public static event EventHandler? DeviceChanged;

        private static System.Timers.Timer timer = new System.Timers.Timer(1000);

        static PeripheralsProvider()
        {
            timer.Elapsed += DeviceTimer_Elapsed;
        }


        private static long lastRefresh;

        public static bool IsMouseConnected()
        {
            lock (_LOCK)
            {
                return ConnectedMice.Count > 0;
            }
        }

        public static bool IsDeviceConnected(IPeripheral peripheral)
        {
            return AllPeripherals().Contains(peripheral);
        }

        //Expand if keyboards or other device get supported later.
        public static bool IsAnyPeripheralConnect()
        {
            return IsMouseConnected();
        }

        public static List<IPeripheral> AllPeripherals()
        {
            List<IPeripheral> l = new List<IPeripheral>();
            lock (_LOCK)
            {
                l.AddRange(ConnectedMice);
            }
            return l;
        }

        public static void RefreshBatteryForAllDevices()
        {
            RefreshBatteryForAllDevices(false);
        }

        public static void RefreshBatteryForAllDevices(bool force)
        {
            //Polling the battery every 20s should be enough
            if (!force && Math.Abs(DateTimeOffset.Now.ToUnixTimeMilliseconds() - lastRefresh) < 20_000) return;
            lastRefresh = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            List<IPeripheral> l = AllPeripherals();

            foreach (IPeripheral m in l)
            {
                if (!m.IsDeviceReady)
                {
                    //Try to sync the device if that hasn't been done yet
                    m.SynchronizeDevice();
                }
                else
                {
                    m.ReadBattery();
                }
            }
        }

        public static void Disconnect(AsusMouse am)
        {
            lock (_LOCK)
            {
                am.Disconnect -= Mouse_Disconnect;
                am.MouseReadyChanged -= MouseReadyChanged;
                am.BatteryUpdated -= BatteryUpdated;
                ConnectedMice.Remove(am);
            }
            if (DeviceChanged is not null)
            {
                DeviceChanged(am, EventArgs.Empty);
            }
        }

        public static void Connect(AsusMouse am)
        {

            if (IsDeviceConnected(am))
            {
                //Mouse already connected;
                return;
            }

            try
            {
                am.Connect();
            }
            catch (IOException e)
            {
                Logger.WriteLine(am.GetDisplayName() + " failed to connect to device: " + e);
                return;
            }

            //The Mouse might needs a few ms to register all its subdevices or the sync will fail.
            //Retry 3 times. Do not call this on main thread! It would block the UI

            int tries = 0;
            while (!am.IsDeviceReady && tries < 3)
            {
                Thread.Sleep(250);
                Logger.WriteLine(am.GetDisplayName() + " synchronising. Try " + (tries + 1));
                am.SynchronizeDevice();
                ++tries;
            }

            lock (_LOCK)
            {
                ConnectedMice.Add(am);
            }
            Logger.WriteLine(am.GetDisplayName() + " added to the list: " + ConnectedMice.Count + " device are conneted.");


            am.Disconnect += Mouse_Disconnect;
            am.MouseReadyChanged += MouseReadyChanged;
            am.BatteryUpdated += BatteryUpdated;
            if (DeviceChanged is not null)
            {
                DeviceChanged(am, EventArgs.Empty);
            }
            UpdateSettingsView();
        }

        private static void BatteryUpdated(object? sender, EventArgs e)
        {
            UpdateSettingsView();
        }

        private static void MouseReadyChanged(object? sender, EventArgs e)
        {
            UpdateSettingsView();
        }

        private static void Mouse_Disconnect(object? sender, EventArgs e)
        {
            if (sender is null)
            {
                return;
            }

            AsusMouse am = (AsusMouse)sender;
            lock (_LOCK)
            {
                ConnectedMice.Remove(am);
            }

            Logger.WriteLine(am.GetDisplayName() + " reported disconnect. " + ConnectedMice.Count + " device are conneted.");
            am.Dispose();

            UpdateSettingsView();
        }


        private static void UpdateSettingsView()
        {
            Program.settingsForm.Invoke(delegate
            {
                Program.settingsForm.VisualizePeripherals();
            });
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void DetectAllAsusMice()
        {
            //Add one line for every supported mouse class here to support them.
            DetectMouse(new ChakramX());
            DetectMouse(new ChakramXWired());
            DetectMouse(new GladiusIIIAimpoint());
            DetectMouse(new GladiusIIIAimpointWired());
            DetectMouse(new GladiusIIOrigin());
            DetectMouse(new GladiusIIOriginPink());
            DetectMouse(new GladiusII());
            DetectMouse(new GladiusIIWireless());
            DetectMouse(new ROGKerisWireless());
            DetectMouse(new ROGKerisWirelessWired());
            DetectMouse(new ROGKeris());
            DetectMouse(new ROGKerisWirelessEvaEdition());
            DetectMouse(new ROGKerisWirelessEvaEditionWired());
            DetectMouse(new TUFM4Air());
            DetectMouse(new TUFM4Wirelss());
            DetectMouse(new TUFM4WirelssCN());
            DetectMouse(new StrixImpactIIWireless());
            DetectMouse(new StrixImpactIIWirelessWired());
            DetectMouse(new GladiusIIIWireless());
            DetectMouse(new GladiusIIIWired());
            DetectMouse(new GladiusIII());
            DetectMouse(new GladiusIIIAimpointEva2());
            DetectMouse(new GladiusIIIAimpointEva2Wired());
            DetectMouse(new HarpeAceAimLabEdition());
            DetectMouse(new HarpeAceAimLabEditionWired());
            DetectMouse(new HarpeAceAimLabEditionOmni());
            DetectMouse(new TUFM3());
            DetectMouse(new TUFM3GenII());
            DetectMouse(new TUFM5());
            DetectMouse(new KerisWirelssAimpoint());
            DetectMouse(new KerisWirelssAimpointWired());
            DetectMouse(new KerisIIAceWired());
            DetectMouse(new PugioII());
            DetectMouse(new PugioIIWired());
            DetectMouse(new StrixImpactII());
            DetectMouse(new StrixImpactIIElectroPunk());
            DetectMouse(new StrixEvolve());
            DetectMouse(new Chakram());
            DetectMouse(new ChakramWired());
            DetectMouse(new ChakramCore());
            DetectMouse(new SpathaX());
            DetectMouse(new StrixCarry());
            DetectMouse(new StrixImpactIII());
            DetectMouse(new StrixImpact());
            DetectMouse(new TXGamingMini());
            DetectMouse(new TXGamingMiniWired());
            DetectMouse(new Pugio());
        }

        public static void DetectMouse(AsusMouse am)
        {
            if (am.IsDeviceConnected() && !IsDeviceConnected(am))
            {
                Logger.WriteLine("Detected a new" + am.GetDisplayName() + " . Connecting...");
                Connect(am);
            }
        }

        public static void RegisterForDeviceEvents()
        {
            HidSharp.DeviceList.Local.Changed += Device_Changed;
        }

        public static void UnregisterForDeviceEvents()
        {
            HidSharp.DeviceList.Local.Changed -= Device_Changed;
        }

        private static void Device_Changed(object? sender, HidSharp.DeviceListChangedEventArgs e)
        {
            timer.Start();
        }

        private static void DeviceTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            Logger.WriteLine("HID Device Event: Checking for new ASUS Mice");
            DetectAllAsusMice();
            if (AppConfig.IsZ13()) Program.inputDispatcher.Init();
        }
    }
}
