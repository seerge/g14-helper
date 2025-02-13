using GHelper.Display;
using GHelper.Helpers;
using GHelper.Mode;
using GHelper.USB;
using Microsoft.Win32;
using System.Diagnostics;
using System.Management;
using System.Text.RegularExpressions;

namespace GHelper.Input
{

    public class InputDispatcher
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public static bool backlightActivity = true;
        public static bool lidClose = false;

        public static Keys keyProfile = (Keys)AppConfig.Get("keybind_profile", (int)Keys.F5);
        public static Keys keyApp = (Keys)AppConfig.Get("keybind_app", (int)Keys.F12);

        public static Keys keyProfile0 = (Keys)AppConfig.Get("keybind_profile_0", (int)Keys.F17);
        public static Keys keyProfile1 = (Keys)AppConfig.Get("keybind_profile_1", (int)Keys.F18);
        public static Keys keyProfile2 = (Keys)AppConfig.Get("keybind_profile_2", (int)Keys.F16);
        public static Keys keyProfile3 = (Keys)AppConfig.Get("keybind_profile_3", (int)Keys.F19);
        public static Keys keyProfile4 = (Keys)AppConfig.Get("keybind_profile_4", (int)Keys.F20);
        public static Keys keyXGM = (Keys)AppConfig.Get("keybind_xgm", (int)Keys.F21);

        public static ModifierKeys keyModifier = GetModifierKeys("modifier_keybind", ModifierKeys.Shift | ModifierKeys.Control);
        public static ModifierKeys keyModifierAlt = GetModifierKeys("modifier_keybind_alt", ModifierKeys.Shift | ModifierKeys.Control | ModifierKeys.Alt);

        static ModeControl modeControl = Program.modeControl;
        static ScreenControl screenControl = new ScreenControl();

        static bool isTUF = AppConfig.IsTUF();

        KeyboardListener listener;
        KeyboardHook hook = new KeyboardHook();

        public InputDispatcher()
        {

            byte[] result = Program.acpi.DeviceInit();
            Debug.WriteLine($"Init: {BitConverter.ToString(result)}");

            Program.acpi.SubscribeToEvents(WatcherEventArrived);
            //Task.Run(Program.acpi.RunListener);

            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(KeyPressed);

            RegisterKeys();

            timer.Elapsed += Timer_Elapsed;

        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if (GetBacklight() == 0) return;

            TimeSpan iddle = NativeMethods.GetIdleTime();
            int kb_timeout;

            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
                kb_timeout = AppConfig.Get("keyboard_ac_timeout", 0);
            else
                kb_timeout = AppConfig.Get("keyboard_timeout", 60);

            if (kb_timeout == 0) return;

            if (backlightActivity && iddle.TotalSeconds > kb_timeout)
            {
                backlightActivity = false;
                Aura.ApplyBrightness(0, "Timeout");
            }

            if (!backlightActivity && iddle.TotalSeconds < kb_timeout)
            {
                backlightActivity = true;
                SetBacklightAuto();
            }

            //Logger.WriteLine("Iddle: " + iddle.TotalSeconds);
        }

        public void Init()
        {
            if (listener is not null) listener.Dispose();

            Program.acpi.DeviceInit();

            if (!OptimizationService.IsRunning())
            {
                Program.acpi.DeviceGet(AsusACPI.CameraShutter);
                listener = new KeyboardListener(HandleEvent);
            }
            else
            {
                Logger.WriteLine("Optimization service is running");
            }

            InitBacklightTimer();

            if (AppConfig.IsHardwareFnLock()) HardwareFnLock(AppConfig.Is("fn_lock"));

        }

        public void InitBacklightTimer()
        {
            timer.Enabled = AppConfig.Get("keyboard_timeout") > 0 && SystemInformation.PowerStatus.PowerLineStatus != PowerLineStatus.Online ||
                            AppConfig.Get("keyboard_ac_timeout") > 0 && SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online;
        }

        private static ModifierKeys GetModifierKeys(string configKey, ModifierKeys defaultModifiers)
        {
            string configValue = AppConfig.GetString(configKey, "");
                
            if (string.IsNullOrWhiteSpace(configValue))
                return defaultModifiers;

            ModifierKeys modifiers = ModifierKeys.None;
            HashSet<string> keys = new HashSet<string>(configValue.Split('-'), StringComparer.OrdinalIgnoreCase);

            if (keys.Contains("win")) modifiers |= ModifierKeys.Win;
            if (keys.Contains("shift")) modifiers |= ModifierKeys.Shift;
            if (keys.Contains("control")) modifiers |= ModifierKeys.Control;
            if (keys.Contains("alt")) modifiers |= ModifierKeys.Alt;

            return modifiers;
        }

        public void RegisterKeys()
        {
            hook.UnregisterAll();

            string actionM1 = AppConfig.GetString("m1");
            string actionM2 = AppConfig.GetString("m2");

            if (keyProfile != Keys.None)
            {
                hook.RegisterHotKey(keyModifier, keyProfile);
                hook.RegisterHotKey(keyModifierAlt, keyProfile);
            }

            if (keyApp != Keys.None) hook.RegisterHotKey(keyModifier, keyApp);

            if (!AppConfig.Is("skip_hotkeys"))
            {
                if (AppConfig.IsDUO())
                {
                    hook.RegisterHotKey(keyModifierAlt, Keys.F7);
                    hook.RegisterHotKey(keyModifierAlt, Keys.F8);
                }

                hook.RegisterHotKey(keyModifierAlt, Keys.F13);

                hook.RegisterHotKey(keyModifierAlt, Keys.F14);
                hook.RegisterHotKey(keyModifierAlt, Keys.F15);

                hook.RegisterHotKey(keyModifierAlt, keyProfile0);
                hook.RegisterHotKey(keyModifierAlt, keyProfile1);
                hook.RegisterHotKey(keyModifierAlt, keyProfile2);
                hook.RegisterHotKey(keyModifierAlt, keyProfile3);
                hook.RegisterHotKey(keyModifierAlt, keyProfile4);
                hook.RegisterHotKey(keyModifierAlt, keyXGM);

                hook.RegisterHotKey(ModifierKeys.Control, Keys.VolumeDown);
                hook.RegisterHotKey(ModifierKeys.Control, Keys.VolumeUp);
                hook.RegisterHotKey(ModifierKeys.Shift, Keys.VolumeDown);
                hook.RegisterHotKey(ModifierKeys.Shift, Keys.VolumeUp);
                hook.RegisterHotKey(keyModifier, Keys.F20);
            }

            if (!AppConfig.IsZ13() && !AppConfig.IsAlly() && !AppConfig.IsVivoZenPro())
            {
                if (actionM1 is not null && actionM1.Length > 0) hook.RegisterHotKey(ModifierKeys.None, Keys.VolumeDown);
                if (actionM2 is not null && actionM2.Length > 0) hook.RegisterHotKey(ModifierKeys.None, Keys.VolumeUp);
            }

            if (AppConfig.IsAlly())
            {
                hook.RegisterHotKey(keyModifierAlt, Keys.F1);
                hook.RegisterHotKey(keyModifierAlt, Keys.F2);
                hook.RegisterHotKey(keyModifierAlt, Keys.F3);
                hook.RegisterHotKey(keyModifierAlt, Keys.F4);
                hook.RegisterHotKey(keyModifierAlt, Keys.F6);
            }

            // FN-Lock group

            if (AppConfig.Is("fn_lock") && !AppConfig.IsHardwareFnLock())
                for (Keys i = Keys.F1; i <= Keys.F11; i++) hook.RegisterHotKey(ModifierKeys.None, i);

            // Arrow-lock group
            if (AppConfig.Is("arrow_lock") && AppConfig.IsDUO())
            {
                hook.RegisterHotKey(ModifierKeys.None, Keys.Left);
                hook.RegisterHotKey(ModifierKeys.None, Keys.Right);
                hook.RegisterHotKey(ModifierKeys.None, Keys.Up);
                hook.RegisterHotKey(ModifierKeys.None, Keys.Down);
            }

        }


        public static int[] ParseHexValues(string input)
        {
            string pattern = @"\b(0x[0-9A-Fa-f]{1,2}|[0-9A-Fa-f]{1,2})\b";

            if (!Regex.IsMatch(input, $"^{pattern}(\\s+{pattern})*$")) return new int[0];

            MatchCollection matches = Regex.Matches(input, pattern);

            int[] hexValues = new int[matches.Count];

            for (int i = 0; i < matches.Count; i++)
            {
                string hexValueStr = matches[i].Value;
                int hexValue = int.Parse(hexValueStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                    ? hexValueStr.Substring(2)
                    : hexValueStr, System.Globalization.NumberStyles.HexNumber);

                hexValues[i] = hexValue;
            }

            return hexValues;
        }


        static void CustomKey(string configKey = "m3")
        {
            string command = AppConfig.GetString(configKey + "_custom");
            int[] hexKeys = new int[0];

            try
            {
                hexKeys = ParseHexValues(command);
            }
            catch
            {
            }

            switch (hexKeys.Length)
            {
                case 1:
                    KeyboardHook.KeyPress((Keys)hexKeys[0]);
                    break;
                case 2:
                    KeyboardHook.KeyKeyPress((Keys)hexKeys[0], (Keys)hexKeys[1]);
                    break;
                case 3:
                    KeyboardHook.KeyKeyKeyPress((Keys)hexKeys[0], (Keys)hexKeys[1], (Keys)hexKeys[2]);
                    break;
                case 4:
                    KeyboardHook.KeyKeyKeyKeyPress((Keys)hexKeys[0], (Keys)hexKeys[1], (Keys)hexKeys[2], (Keys)hexKeys[3]);
                    break;
                default:
                    LaunchProcess(command);
                    break;
            }

        }


        static void SetBrightness(bool up, bool hotkey = false)
        {
            int brightness = -1;

            if (isTUF) brightness = ScreenBrightness.Get();
            if (AppConfig.SwappedBrightness() && !hotkey) up = !up;

            int step = AppConfig.Get("brightness_step", 10);
            if (step != 10)
            {
                Program.toast.RunToast(ScreenBrightness.Adjust(up ? step : -step) + "%", up ? ToastIcon.BrightnessUp : ToastIcon.BrightnessDown);
                return;
            }

            Program.acpi.DeviceSet(AsusACPI.UniversalControl, up ? AsusACPI.Brightness_Up : AsusACPI.Brightness_Down, "Brightness");

            if (isTUF)
            {
                if (AppConfig.SwappedBrightness()) return;
                if (!up && brightness <= 0) return;
                if (up && brightness >= 100) return;

                Thread.Sleep(100);
                if (brightness == ScreenBrightness.Get())
                    Program.toast.RunToast(ScreenBrightness.Adjust(up ? step : -step) + "%", up ? ToastIcon.BrightnessUp : ToastIcon.BrightnessDown);
            }

        }

        static void SetBrightnessDimming(int delta)
        {
            int brightness = VisualControl.SetBrightness(delta: delta);
            if (brightness >= 0)
                Program.toast.RunToast(brightness + "%", (delta < 0) ? ToastIcon.BrightnessDown : ToastIcon.BrightnessUp);
        }

        public void KeyPressed(object sender, KeyPressedEventArgs e)
        {

            Logger.WriteLine(e.Key.ToString() + " " + e.Modifier.ToString());

            if (e.Modifier == ModifierKeys.None)
            {
                if (AppConfig.NoMKeys())
                {
                    switch (e.Key)
                    {
                        case Keys.F2:
                            KeyboardHook.KeyPress(Keys.VolumeDown);
                            return;
                        case Keys.F3:
                            KeyboardHook.KeyPress(Keys.VolumeUp);
                            return;
                        case Keys.F4:
                            ToggleMic();
                            return;
                    }
                }

                if (AppConfig.IsProArt())
                {
                    switch (e.Key)
                    {
                        case Keys.F2:
                            KeyboardHook.KeyPress(Keys.VolumeDown);
                            return;
                        case Keys.F3:
                            KeyboardHook.KeyPress(Keys.VolumeUp);
                            return;
                        case Keys.F4:
                            HandleEvent(199); // Backlight cycle
                            return;
                        case Keys.F5:
                            SetBrightness(false);
                            return;
                        case Keys.F6:
                            SetBrightness(true);
                            return;
                        case Keys.F7:
                            KeyboardHook.KeyKeyPress(Keys.LWin, Keys.P);
                            return;
                        case Keys.F8:
                            HandleEvent(126); // Emojis
                            return;
                        case Keys.F9:
                            ToggleMic(); // MicMute
                            return;
                        case Keys.F10:
                            HandleEvent(133); // Camera Toggle
                            return;
                        case Keys.F11:
                            KeyboardHook.KeyPress(Keys.Snapshot); // PrintScreen
                            return;
                    }
                }

                if (AppConfig.IsZ13() || AppConfig.IsDUO())
                {
                    switch (e.Key)
                    {
                        case Keys.F11:
                            HandleEvent(199);
                            return;
                    }
                }

                if (AppConfig.MediaKeys())
                {
                    switch (e.Key)
                    {
                        case Keys.F2:
                            KeyboardHook.KeyPress(Keys.MediaPreviousTrack);
                            return;
                        case Keys.F3:
                            KeyboardHook.KeyPress(Keys.MediaPlayPause);
                            return;
                        case Keys.F4:
                            KeyboardHook.KeyPress(Keys.MediaNextTrack);
                            return;
                    }
                }


                switch (e.Key)
                {
                    case Keys.F1:
                        KeyboardHook.KeyPress(Keys.VolumeMute);
                        break;
                    case Keys.F2:
                        SetBacklight(-1, true);
                        break;
                    case Keys.F3:
                        SetBacklight(1, true);
                        break;
                    case Keys.F4:
                        KeyProcess("fnf4");
                        break;
                    case Keys.F5:
                        KeyProcess("fnf5");
                        break;
                    case Keys.F6:
                        KeyboardHook.KeyPress(Keys.Snapshot);
                        break;
                    case Keys.F7:
                        SetBrightness(false);
                        break;
                    case Keys.F8:
                        SetBrightness(true);
                        break;
                    case Keys.F9:
                        KeyboardHook.KeyKeyPress(Keys.LWin, Keys.P);
                        break;
                    case Keys.F10:
                        ToggleTouchpadEvent(true);
                        break;
                    case Keys.F11:
                        SleepEvent();
                        break;
                    case Keys.VolumeDown:
                        KeyProcess("m1");
                        break;
                    case Keys.VolumeUp:
                        KeyProcess("m2");
                        break;
                    case Keys.Left:
                        KeyboardHook.KeyPress(Keys.Home);
                        break;
                    case Keys.Right:
                        KeyboardHook.KeyPress(Keys.End);
                        break;
                    case Keys.Up:
                        KeyboardHook.KeyPress(Keys.PageUp);
                        break;
                    case Keys.Down:
                        KeyboardHook.KeyPress(Keys.PageDown);
                        break;
                    default:
                        break;
                }

            }

            if (e.Modifier == keyModifier)
            {
                if (e.Key == keyProfile) modeControl.CyclePerformanceMode();
                if (e.Key == keyApp) Program.SettingsToggle();
                if (e.Key == Keys.F20) ToggleMic();
            }

            if (e.Modifier == keyModifierAlt)
            {
                if (e.Key == keyProfile) modeControl.CyclePerformanceMode(true);

                if (e.Key == keyProfile0) modeControl.SetPerformanceMode(0, true);
                if (e.Key == keyProfile1) modeControl.SetPerformanceMode(1, true);
                if (e.Key == keyProfile2) modeControl.SetPerformanceMode(2, true);
                if (e.Key == keyProfile3) modeControl.SetPerformanceMode(3, true);
                if (e.Key == keyProfile4) modeControl.SetPerformanceMode(4, true);
                if (e.Key == keyXGM) Program.settingsForm.gpuControl.ToggleXGM(true);

                switch (e.Key)
                {
                    case Keys.F1:
                        SetBrightness(false);
                        break;
                    case Keys.F2:
                        SetBrightness(true);
                        break;
                    case Keys.F3:
                        Program.settingsForm.gpuControl.ToggleXGM(true);
                        break;
                    case Keys.F4:
                        Program.settingsForm.BeginInvoke(Program.settingsForm.allyControl.ToggleModeHotkey);
                        break;
                    case Keys.F6:
                        ToggleTouchScreen();
                        break;
                    case Keys.F7:
                        SetScreenpad(-10);
                        break;
                    case Keys.F8:
                        SetScreenpad(10);
                        break;
                    case Keys.F13:
                        ToggleScreenRate();
                        break;
                    case Keys.F14:
                        Program.toast.RunToast(Properties.Strings.EcoMode);
                        Program.settingsForm.gpuControl.SetGPUMode(AsusACPI.GPUModeEco);
                        break;
                    case Keys.F15:
                        Program.toast.RunToast(Properties.Strings.StandardMode);
                        Program.settingsForm.gpuControl.SetGPUMode(AsusACPI.GPUModeStandard);
                        break;
                }
            }


            if (e.Modifier == (ModifierKeys.Control))
            {
                switch (e.Key)
                {
                    case Keys.VolumeDown:
                        // Screen brightness down on CTRL+VolDown
                        SetBrightness(false);
                        break;
                    case Keys.VolumeUp:
                        // Screen brightness up on CTRL+VolUp
                        SetBrightness(true);
                        break;
                }
            }

            if (e.Modifier == (ModifierKeys.Shift))
            {
                switch (e.Key)
                {
                    case Keys.VolumeDown:
                        // Keyboard backlight down on SHIFT+VolDown
                        SetBacklight(-1);
                        break;
                    case Keys.VolumeUp:
                        // Keyboard backlight up on SHIFT+VolUp
                        SetBacklight(1);
                        break;
                }
            }
        }


        public static void KeyProcess(string name = "m3")
        {
            string action = AppConfig.GetString(name);

            if (action is null || action.Length <= 1)
            {
                if (name == "m4")
                    action = "ghelper";
                if (name == "fnf4")
                    action = "aura";
                if (name == "fnf5")
                    action = "performance";
                if (name == "m3" && !OptimizationService.IsRunning())
                    action = "micmute";
                if (name == "fnc")
                    action = "fnlock";
                if (name == "fnv")
                    action = "visual";
                if (name == "fne")
                    action = "calculator";
            }

            switch (action)
            {
                case "mute":
                    KeyboardHook.KeyPress(Keys.VolumeMute);
                    break;
                case "play":
                    KeyboardHook.KeyPress(Keys.MediaPlayPause);
                    break;
                case "screenshot":
                    KeyboardHook.KeyPress(Keys.Snapshot);
                    break;
                case "lock":
                    Logger.WriteLine("Screen lock");
                    NativeMethods.LockScreen();
                    break;
                case "screen":
                    Logger.WriteLine("Screen off toggle");
                    NativeMethods.TurnOffScreen();
                    break;
                case "miniled":
                    if (ScreenCCD.GetHDRStatus()) return;
                    string miniledName = screenControl.ToogleMiniled();
                    Program.toast.RunToast(miniledName, miniledName == Properties.Strings.OneZone ? ToastIcon.BrightnessDown : ToastIcon.BrightnessUp);
                    break;
                case "aura":
                    Program.settingsForm.BeginInvoke(Program.settingsForm.CycleAuraMode);
                    break;
                case "visual":
                    Program.settingsForm.BeginInvoke(Program.settingsForm.CycleVisualMode);
                    break;
                case "performance":
                    modeControl.CyclePerformanceMode(Control.ModifierKeys == Keys.Shift);
                    break;
                case "ghelper":
                    try
                    {
                        Program.settingsForm.BeginInvoke(delegate
                        {
                            Program.SettingsToggle();
                        });
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                    break;
                case "fnlock":
                    ToggleFnLock();
                    break;
                case "micmute":
                    ToggleMic();
                    break;
                case "brightness_up":
                    SetBrightness(true);
                    break;
                case "brightness_down":
                    SetBrightness(false);
                    break;
                case "screenpad_up":
                    SetScreenpad(10);
                    break;
                case "screenpad_down":
                    SetScreenpad(-10);
                    break;
                case "custom":
                    CustomKey(name);
                    break;
                case "calculator":
                    LaunchProcess("calc");
                    break;
                case "controller":
                    Program.settingsForm.BeginInvoke(Program.settingsForm.allyControl.ToggleModeHotkey);
                    break;
                case "touchscreen":
                    ToggleTouchScreen();
                    break;
                default:
                    break;
            }
        }


        static void ToggleTouchScreen()
        {
            var status = !TouchscreenHelper.GetStatus();
            Logger.WriteLine("Touchscreen status: " + status);
            if (status is not null)
            {
                Program.toast.RunToast(Properties.Strings.Touchscreen + " " + ((bool)status ? Properties.Strings.On : Properties.Strings.Off), ToastIcon.Touchpad);
                TouchscreenHelper.ToggleTouchscreen((bool)status);
            }
        }

        static void ToggleMic()
        {
            bool muteStatus = Audio.ToggleMute();
            Program.toast.RunToast(muteStatus ? Properties.Strings.Muted : Properties.Strings.Unmuted, muteStatus ? ToastIcon.MicrophoneMute : ToastIcon.Microphone);
            if (AppConfig.IsVivoZenbook()) Program.acpi.DeviceSet(AsusACPI.MicMuteLed, muteStatus ? 1 : 0, "MicmuteLed");
        }

        static bool GetTouchpadState()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\PrecisionTouchPad\Status", false))
            {
                Logger.WriteLine("Touchpad status:" + key?.GetValue("Enabled")?.ToString());
                return key?.GetValue("Enabled")?.ToString() == "1";
            }
        }

        static void ToggleTouchpadEvent(bool hotkey = false)
        {
            if (hotkey || !AppConfig.IsHardwareTouchpadToggle()) ToggleTouchpad();
            Thread.Sleep(200);
            Program.toast.RunToast(GetTouchpadState() ? Properties.Strings.On : Properties.Strings.Off, ToastIcon.Touchpad);
        }

        static void ToggleTouchpad()
        {
            if (AppConfig.IsROG())
            {
                AsusHid.WriteInput([AsusHid.INPUT_ID, 0xF4, 0x6B], "USB Touchpad");
            } else
            {
                KeyboardHook.KeyKeyKeyPress(Keys.LWin, Keys.LControlKey, Keys.F24, 50);
            }

        }

        static void SleepEvent()
        {
            Program.acpi.DeviceSet(AsusACPI.UniversalControl, AsusACPI.KB_Sleep, "Sleep");
        }

        public static void ToggleArrowLock()
        {
            int arLock = AppConfig.Is("arrow_lock") ? 0 : 1;
            AppConfig.Set("arrow_lock", arLock);

            Program.settingsForm.BeginInvoke(Program.inputDispatcher.RegisterKeys);
            Program.toast.RunToast("Arrow-Lock " + (arLock == 1 ? Properties.Strings.On : Properties.Strings.Off), ToastIcon.FnLock);
        }

        public static void HardwareFnLock(bool fnLock)
        {
            Program.acpi.DeviceSet(AsusACPI.FnLock, fnLock ^ AppConfig.IsInvertedFNLock() ? 1 : 0, "FnLock");
            AsusHid.WriteInput([AsusHid.INPUT_ID, 0xD0, 0x4E, fnLock ? (byte)0x00 : (byte)0x01], "USB FnLock");
        }

        public static void ToggleFnLock()
        {
            bool fnLock = !AppConfig.Is("fn_lock");
            AppConfig.Set("fn_lock", fnLock ? 1 : 0);

            if (AppConfig.IsHardwareFnLock())
                HardwareFnLock(fnLock);
            else
                Program.settingsForm.BeginInvoke(Program.inputDispatcher.RegisterKeys);

            Program.settingsForm.BeginInvoke(Program.settingsForm.VisualiseFnLock);

            Program.toast.RunToast(fnLock ? Properties.Strings.FnLockOn : Properties.Strings.FnLockOff, ToastIcon.FnLock);
        }

        public static void TabletMode()
        {
            if (AppConfig.Is("disable_tablet")) return;

            bool touchpadState = GetTouchpadState();
            bool tabletState = Program.acpi.DeviceGet(AsusACPI.TabletState) > 0;

            Logger.WriteLine("Tablet: " + tabletState + " Touchpad: " + touchpadState);

            if (tabletState && touchpadState || !tabletState && !touchpadState) ToggleTouchpad();

        }

        static void HandleEvent(int EventID)
        {
            // The ROG Ally uses different M-key codes.
            // We'll special-case the translation of those.
            if (AppConfig.IsAlly())
            {
                switch (EventID)
                {

                    // This is both the M1 and M2 keys.
                    // There's a way to differentiate, apparently, but it isn't over USB or any other obvious protocol.
                    case 165:
                        KeyProcess("paddle");
                        return;
                    // The Command Center ("play-looking") button below the select key.
                    case 166:
                        KeyProcess("cc");
                        return;
                    // The M4/ROG key.
                    case 56:
                        KeyProcess("m4");
                        return;
                    case 162:
                        OnScreenKeyboard.Show();
                        return;
                    case 124:
                        KeyProcess("m3");
                        return;

                }
            }
            // All other devices seem to use the same HID key-codes,
            // so we can process them all the same.
            else
            {
                switch (EventID)
                {
                    case 134:     // FN + F12 ON OLD DEVICES
                    case 139:     // ProArt F12
                        KeyProcess("m4");
                        return;
                    case 124:    // M3
                        KeyProcess("m3");
                        return;
                    case 56:    // M4 / Rog button
                        KeyProcess("m4");
                        return;
                    case 55:    // Arconym
                        KeyProcess("m6");
                        return;
                    case 181:    // FN + Numpad Enter
                        KeyProcess("fne");
                        return;
                    case 174:   // FN+F5
                    case 153:   // FN+F5 OLD MODELS
                    case 157:   // Zenbook DUO FN+F
                        modeControl.CyclePerformanceMode(Control.ModifierKeys == Keys.Shift);
                        return;
                    case 179:   // FN+F4
                    case 178:   // FN+F4
                        KeyProcess("fnf4");
                        return;
                    case 138:   // Fn + V
                        KeyProcess("fnv");
                        return;
                    case 158:   // Fn + C
                        KeyProcess("fnc");
                        return;
                    case 189: // Tablet mode
                        TabletMode();
                        return;
                    case 197: // FN+F2
                        SetBacklight(-1);
                        return;
                    case 196: // FN+F3
                        SetBacklight(1);
                        return;
                    case 199: // ON Z13 - FN+F11 - cycles backlight
                        SetBacklight(4);
                        return;
                    case 46: // Fn + F4 Vivobook Brightness down
                        if (Control.ModifierKeys == Keys.Control && AppConfig.IsOLED())
                        {
                            SetBrightnessDimming(-10);
                        }
                        break;
                    case 47: // Fn + F5 Vivobook Brightness up
                        if (Control.ModifierKeys == Keys.Control && AppConfig.IsOLED())
                        {
                            SetBrightnessDimming(10);
                        }
                        break;
                }
            }

            if (!OptimizationService.IsRunning())
                HandleOptimizationEvent(EventID);

        }

        // Asus Optimization service Events 
        static void HandleOptimizationEvent(int EventID)
        {
            switch (EventID)
            {
                case 16: // FN+F7
                    if (Control.ModifierKeys == Keys.Shift)
                    {
                        if (AppConfig.IsDUO()) SetScreenpad(-10);
                        else Program.settingsForm.BeginInvoke(Program.settingsForm.CycleMatrix, -1);
                    }
                    else if (Control.ModifierKeys == Keys.Control && AppConfig.IsOLED())
                    {
                        SetBrightnessDimming(-10);
                    }
                    else
                    {
                        SetBrightness(false, true);
                    }
                    break;
                case 32: // FN+F8
                    if (Control.ModifierKeys == Keys.Shift)
                    {
                        if (AppConfig.IsDUO()) SetScreenpad(10);
                        else Program.settingsForm.BeginInvoke(Program.settingsForm.CycleMatrix, 1);
                    }
                    else if (Control.ModifierKeys == Keys.Control && AppConfig.IsOLED())
                    {
                        SetBrightnessDimming(10);
                    }
                    else
                    {
                        SetBrightness(true, true);
                    }
                    break;
                case 133: // Camera Toggle
                    ToggleCamera();
                    break;
                case 107: // FN+F10
                    ToggleTouchpadEvent();
                    break;
                case 108: // FN+F11
                    SleepEvent();
                    break;
                case 106: // Screenpad button on DUO
                    if (Control.ModifierKeys == Keys.Shift)
                        ToggleScreenpad();
                    else
                        SetScreenpad(100);
                    break;
                case 51:    // Fn+F6 on old TUFs
                case 53:    // Fn+F6 on GA-502DU model
                    NativeMethods.TurnOffScreen();
                    return;
                case 126:    // Fn+F8 emojis popup
                    KeyboardHook.KeyKeyPress(Keys.LWin, Keys.OemSemicolon);
                    return;
                case 78:    // Fn + ESC
                    ToggleFnLock();
                    return;
                case 75:    // Fn + Arrow Lock
                    ToggleArrowLock();
                    return;
                case 136:    // FN + F12
                    if (!AppConfig.IsNoAirplaneMode()) Program.acpi.DeviceSet(AsusACPI.UniversalControl, AsusACPI.Airplane, "Airplane");
                    return;


            }
        }


        public static int GetBacklight()
        {
            int backlight_power = AppConfig.Get("keyboard_brightness", 1);
            int backlight_battery = AppConfig.Get("keyboard_brightness_ac", 1);
            bool onBattery = SystemInformation.PowerStatus.PowerLineStatus != PowerLineStatus.Online;

            int backlight;

            //backlight = onBattery ? Math.Min(backlight_battery, backlight_power) : Math.Max(backlight_battery, backlight_power);
            backlight = onBattery ? backlight_battery : backlight_power;

            return Math.Max(Math.Min(3, backlight), 0);
        }

        public static void AutoKeyboard()
        {
            if (AppConfig.HasTabletMode()) TabletMode();
            if (lidClose || AppConfig.Is("skip_aura")) return;

            Aura.Init();
            Aura.ApplyPower();
            Aura.ApplyAura();
            SetBacklightAuto(true);
        }


        public static void SetBacklightAuto(bool init = false)
        {
            if (lidClose) return;
            if (init) Aura.Init();
            Aura.ApplyBrightness(GetBacklight(), "Auto", init);
        }

        public static void SetBacklight(int delta, bool force = false)
        {
            int backlight_power = AppConfig.Get("keyboard_brightness", 1);
            int backlight_battery = AppConfig.Get("keyboard_brightness_ac", 1);
            bool onBattery = SystemInformation.PowerStatus.PowerLineStatus != PowerLineStatus.Online;

            int backlight = onBattery ? backlight_battery : backlight_power;
            int backlightMax = AppConfig.Get("max_brightness", 3);

            if (delta > backlightMax)
                backlight = ++backlight % (backlightMax + 1);
            else
                backlight = Math.Max(Math.Min(backlightMax, backlight + delta), 0);

            if (onBattery)
                AppConfig.Set("keyboard_brightness_ac", backlight);
            else
                AppConfig.Set("keyboard_brightness", backlight);

            if (force || !OptimizationService.IsRunning())
            {
                Aura.ApplyBrightness(backlight, "HotKey");
            }

            if (!OptimizationService.IsOSDRunning())
            {
                string[] backlightNames = new string[] { Properties.Strings.BacklightOff, Properties.Strings.BacklightLow, Properties.Strings.BacklightMid, Properties.Strings.BacklightMax };
                Program.toast.RunToast(backlightNames[backlight], delta > 0 ? ToastIcon.BacklightUp : ToastIcon.BacklightDown);
            }

        }

        public static void ToggleScreenpad()
        {
            int toggle = AppConfig.Is("screenpad_toggle") ? 0 : 1;
            int brightness = toggle == 0 ? -10 : AppConfig.Get("screenpad", 100);

            Debug.WriteLine($"Screenpad toggle = {toggle}");

            ApplyScreenpadAction(brightness, true);

            AppConfig.Set("screenpad_toggle", toggle);

            Program.toast.RunToast($"Screen Pad " + (toggle == 1 ? "On" : "Off"), toggle > 0 ? ToastIcon.BrightnessUp : ToastIcon.BrightnessDown);
        }

        public static void ToggleScreenRate()
        {
            AppConfig.Set("screen_auto", 0);
            screenControl.ToggleScreenRate();
        }

        public static void ToggleCamera()
        {
            int cameraShutter = Program.acpi.DeviceGet(AsusACPI.CameraShutter);

            if (cameraShutter == 0)
            {
                Program.acpi.DeviceSet(AsusACPI.CameraShutter, 1, "CameraShutterOn");
                Program.toast.RunToast($"Camera Off");
            }
            else if (cameraShutter == 1)
            {
                Program.acpi.DeviceSet(AsusACPI.CameraShutter, 0, "CameraShutterOff");
                Program.toast.RunToast($"Camera On");
            }
            else if (cameraShutter == 262144)
            {
                Program.toast.RunToast($"Camera Off");
            }
            else if (cameraShutter == 262145)
            {
                Program.toast.RunToast($"Camera On");
            }
            else
            {
                if (!ProcessHelper.IsUserAdministrator()) return;

                string CameraRegistryKeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\webcam";
                string CameraRegistryValueName = "Value";

                try
                {
                    var status = (string?)Registry.GetValue(CameraRegistryKeyPath, CameraRegistryValueName, "");

                    if (status == "Allow") status = "Deny";
                    else if (status == "Deny") status = "Allow";
                    else
                    {
                        Logger.WriteLine("Unknown camera status");
                        return;
                    }

                    Registry.SetValue(CameraRegistryKeyPath, CameraRegistryValueName, status, RegistryValueKind.String);
                    Program.acpi.DeviceSet(AsusACPI.CameraLed, (status == "Deny" ? 1 : 0), "Camera");
                    Program.toast.RunToast($"Camera " + (status == "Deny" ? "Off" : "On"));

                }
                catch (Exception ex)
                {
                    Logger.WriteLine(ex.ToString());
                }
            }
        }

        private static System.Threading.Timer screenpadActionTimer;
        private static int screenpadBrightnessToSet;
        public static void ApplyScreenpadAction(int brightness, bool instant = true)
        {
            var delay = AppConfig.Get("screenpad_delay", 1500);

            //Action
            Action<int> action = (b) =>
            {
                if (b >= 0) Program.acpi.DeviceSet(AsusACPI.ScreenPadToggle, 1, "ScreenpadOn");
                int[] brightnessValues = [0, 4, 9, 14, 21, 32, 48, 73, 111, 169, 255];
                Program.acpi.DeviceSet(AsusACPI.ScreenPadBrightness, brightnessValues[Math.Min(brightnessValues.Length - 1, Math.Max(0, b / 10))], "Screenpad");
                if (b < 0) Program.acpi.DeviceSet(AsusACPI.ScreenPadToggle, 0, "ScreenpadOff");
            };

            if (delay <= 0 || instant) //instant action
            {
                action(brightness);
            }
            else //delayed action
            {
                //Timer Approach
                if (screenpadActionTimer == null)
                {
                    screenpadActionTimer = new System.Threading.Timer(_ => action(screenpadBrightnessToSet), null, Timeout.Infinite, Timeout.Infinite);
                }
                //Start Timer
                screenpadBrightnessToSet = brightness;
                screenpadActionTimer.Change(delay, Timeout.Infinite);
            }
        }

        public static void SetScreenpad(int delta)
        {
            int brightness = AppConfig.Get("screenpad", 100);

            if (delta == 100)
            {
                if (brightness < 0) brightness = 100;
                else if (brightness >= 100) brightness = 0;
                else brightness = -10;
                ApplyScreenpadAction(brightness, false);
            }
            else
            {
                brightness = Math.Max(Math.Min(100, brightness + delta), 0);
                ApplyScreenpadAction(brightness);
            }

            AppConfig.Set("screenpad", brightness);

            string toast;

            if (brightness < 0) toast = "Off";
            else toast = brightness.ToString() + "%";

            Program.toast.RunToast($"Screen Pad {toast}", delta > 0 ? ToastIcon.BrightnessUp : ToastIcon.BrightnessDown);
        }

        public static void InitScreenpad()
        {
            if (!AppConfig.IsDUO()) return;
            int brightness = AppConfig.Get("screenpad");
            if (brightness >= 0) ApplyScreenpadAction(brightness);
        }

        public static void SetStatusLED(bool status)
        {
            Program.acpi.DeviceSet(AsusACPI.StatusLed, status ? 7 : 0, "StatusLED");
        }

        public static void InitStatusLed()
        {
            if (AppConfig.IsAutoStatusLed()) SetStatusLED(true);
        }

        public static void ShutdownStatusLed()
        {
            if (AppConfig.IsAutoStatusLed()) SetStatusLED(false);
        }

        static void LaunchProcess(string command = "")
        {
            if (string.IsNullOrEmpty(command)) return;
            try
            {
                if (command.StartsWith("shutdown"))
                    ProcessHelper.RunCMD("cmd", "/C " + command);
                else
                    RestrictedProcessHelper.RunAsRestrictedUser(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "cmd.exe"), "/C " + command);
            }
            catch (Exception ex)
            {
                Logger.WriteLine($"Failed to run: {command} {ex.Message}");
            }
        }

        static void WatcherEventArrived(object sender, EventArrivedEventArgs e)
        {
            if (e.NewEvent is null) return;
            int EventID = int.Parse(e.NewEvent["EventID"].ToString());
            Logger.WriteLine("WMI event " + EventID);
            if (AppConfig.NoWMI()) return;
            HandleEvent(EventID);
        }
    }
}
