using System.Text.Json;
using GHelper.AutoTDP.FramerateSource;
using GHelper.AutoTDP.PowerLimiter;
using Ryzen;

namespace GHelper.AutoTDP
{
    internal class AutoTDPService : IDisposable
    {

        private static readonly bool LOG_AUTO_TDP = true;
        private static readonly int INTERVAL_MIN_CHECK = 15 * 1_000;
        private static readonly int INTERVAL_APP_CHECK = 5_000;
        public static readonly int INTERVAL_FPS_CHECK = 500;

        private static readonly int INTERVAL_LOG = 1_000;
        private int LogCounter = 0;

        string GameProfileFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GHelper\\AutoTDP.json";

        IFramerateSource? framerateSouce;
        IPowerLimiter? powerLimiter;

        public List<GameProfile> GameProfiles = new List<GameProfile>();

        private bool Running = false;
        private Thread? checkerThread;
        private Thread? tdpThread;

        private double GameFPSPrevious = double.NaN;
        private double GameFPS;

        private int FramerateTargetReachedCounter;
        private int FramerateDipCounter;

        private static readonly int FPSDipHistorySize = 6;

        private List<double> FramerateLog = new List<double>();

        private double LowestTDP;
        private double LowestStableTDP;
        private long LowestStableStability = 0;
        private int LowestStableChecks = 0;
        private double CurrentTDP;
        private double LastAdjustment;
        private double LastAdjustmentTotal = 0;
        private int LastAdjustmentsWithoutImprovement = 0;

        private GameInstance? currentGame = null;
        private GameProfile? currentGameProfile = null;

        public AutoTDPService()
        {
            LoadGameProfiles();

            Start();
        }

        /// <summary>
        /// Whether the system is enabled and currently running.
        /// </summary>
        /// <returns></returns>
        public bool IsRunning()
        {
            return Running;
        }

        /// <summary>
        /// Whether a supported game is actively monitored and TDP is adjusted
        /// </summary>
        /// <returns></returns>
        public bool IsActive()
        {
            return currentGame is not null;
        }

        public static bool IsAvailable()
        {

            if (AppConfig.IsAlly())
            {
                //Not yet supported
                return false;
            }

            return AvailablePowerLimiters().Count > 0 && AvailableFramerateSources().Count > 0;
        }

        private int FPSCheckInterval()
        {
            if (powerLimiter is null)
            {
                return INTERVAL_FPS_CHECK;
            }

            int interval = INTERVAL_FPS_CHECK;

            if (currentGame is not null && currentGameProfile is not null && currentGameProfile.Interval > 0)
            {
                interval = currentGameProfile.Interval;
            }

            return (int)Math.Max(interval, powerLimiter.GetMinInterval());
        }

        public static List<string> AvailableFramerateSources()
        {
            List<string> l = new List<string>();

            if (RTSSFramerateSource.IsAvailable()) l.Add("rtss");

            Logger.WriteLine("[AutoTDPService] Available Framerate Sources: " + string.Join(", ", l.ToArray()));
            return l;
        }


        public static List<string> AvailablePowerLimiters()
        {
            List<string> l = new List<string>();

            if (IntelMSRPowerLimiter.IsAvailable()) l.Add("intel_msr");

            if (ASUSACPIPowerLimiter.IsAvailable()) l.Add("asus_acpi");


            Logger.WriteLine("[AutoTDPService] Available Power Limiters: " + string.Join(", ", l.ToArray()));

            return l;
        }

        public void SwapPowerLimiter()
        {
            IPowerLimiter? ipl = powerLimiter;
            powerLimiter = null;

            if (ipl is not null)
            {
                ipl.ResetPowerLimits();
                ipl.Dispose();
            }


            InitLimiter();

            if (powerLimiter is not null && IsActive())
            {
                powerLimiter.SavePowerLimits();
                powerLimiter.Prepare();
            }

        }

        public void Start()
        {
            if (!IsEnabled() || IsRunning() || !IsAvailable())
            {
                Logger.WriteLine("[AutoTDPService] Refusing startup. Stats: Enabled: " + IsEnabled() + ", Running: " + IsRunning() + " ,Available: " + IsAvailable());
                return;
            }

            Running = true;

            InitFramerateSource();

            InitLimiter();


            checkerThread = new Thread(() =>
            {
                while (Running)
                {
                    CheckForGame();
                    try
                    {
                        Thread.Sleep(INTERVAL_APP_CHECK);
                    }
                    catch (ThreadInterruptedException)
                    {
                        continue;
                    }
                }
            });
            checkerThread.Start();
        }

        public bool IsEnabled()
        {
            return AppConfig.Get("auto_tdp_enabled", 0) == 1;
        }

        public void InitFramerateSource()
        {
            string? source = AppConfig.GetString("auto_tdp_fps_source");

            if (source is null)
            {
                Logger.WriteLine("[AutoTDPService] No source defined in settings. Using Default");
            }
            else
            {
                Logger.WriteLine("[AutoTDPService] Framerate Source Setting: " + source);
            }

            if ((source is null || source.Equals("rtss")) && RTSSFramerateSource.IsAvailable())
            {
                Logger.WriteLine("[AutoTDPService] Initializing RTSSFramerateSource...");
                RTSSFramerateSource rtss = new RTSSFramerateSource();
                RTSSFramerateSource.Start();
                framerateSouce = rtss;
                return;
            }
        }

        public void InitLimiter()
        {
            string? limiter = AppConfig.GetString("auto_tdp_limiter");

            if (limiter is null)
            {
                Logger.WriteLine("[AutoTDPService] No limiter defined in settings. Using Default");
            }
            else
            {
                Logger.WriteLine("[AutoTDPService] Limiter Setting: " + limiter);
            }

            if (limiter is null || (limiter.Equals("asus_acpi") && ASUSACPIPowerLimiter.IsAvailable()))
            {
                Logger.WriteLine("[AutoTDPService] Initializing ASUSACPIPowerLimiter...");
                powerLimiter = new ASUSACPIPowerLimiter();
                return;
            }

            if (limiter is not null && limiter.Equals("intel_msr") && IntelMSRPowerLimiter.IsAvailable())
            {
                Logger.WriteLine("[AutoTDPService] Initializing IntelMSRPowerLimiter...");
                powerLimiter = new IntelMSRPowerLimiter();
                return;
            }
        }

        public void SaveGameProfiles()
        {
            string json = JsonSerializer.Serialize(GameProfiles, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(GameProfileFile, json);
        }

        public void SortGameProfiles()
        {
            GameProfiles.Sort();
        }


        public void LoadGameProfiles()
        {
            if (!File.Exists(GameProfileFile))
            {
                if (GameProfiles is null) GameProfiles = new List<GameProfile>();
                return;
            }

            string? json = File.ReadAllText(GameProfileFile);

            if (json == null)
            {
                return;
            }

            try
            {
                GameProfiles = JsonSerializer.Deserialize<List<GameProfile>>(json);
            }
            catch (Exception e)
            {
                Logger.WriteLine("[AutoTDPService] Deserialization failed. Creating empty list. Message: " + e.Message);
                GameProfiles = new List<GameProfile>();
            }

        }

        public void CheckForGame()
        {
            if (currentGame is not null)
            {
                //Already handling a running game. No need to check for other games
                return;
            }
            List<GameInstance> runningGames = framerateSouce.GetRunningGames();

            if (runningGames.Count == 0)
            {
                if (LOG_AUTO_TDP)
                    AutoTDPLogger.WriteLine("[AutoTDPService] No games detected");
                return;
            }

            foreach (GameInstance gi in runningGames)
            {
                if (LOG_AUTO_TDP)
                    AutoTDPLogger.WriteLine("[AutoTDPService] Detected App: " + gi.ProcessName + "  PID: " + gi.ProcessID);

                if (IsGameInList(gi.ProcessName))
                {
                    Logger.WriteLine("[AutoTDPService] Detected Supported Game: " + gi.ProcessName + "  PID: " + gi.ProcessID);
                    HandleGame(gi);
                    return;
                }
            }
        }

        public GameProfile? ProfileForGame(String? processName, bool checkForEnabled = true)
        {
            if (processName is null)
            {
                return null;
            }

            foreach (GameProfile gp in GameProfiles)
            {
                if (gp.ProcessName is not null && processName.EndsWith(gp.ProcessName, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (!gp.Enabled && checkForEnabled)
                    {
                        return null;
                    }
                    return gp;
                }
            }

            return null;
        }

        public bool IsGameInList(String? processName, bool checkForEnabled = true)
        {
            return ProfileForGame(processName, checkForEnabled) is not null;
        }


        public void HandleGame(GameInstance instance)
        {
            if (currentGame is not null)
            {
                if (LOG_AUTO_TDP)
                    AutoTDPLogger.WriteLine("[AutoTDPService] Already handling a game");
                return;
            }

            if (tdpThread is not null)
            {
                tdpThread.Join();
                tdpThread = null;
            }
            currentGame = instance;

            StartGameHandler(instance);
        }

        public void Reset()
        {
            currentGame = null;
            currentGameProfile = null;
            GameFPSPrevious = double.NaN;
            GameFPS = 0;
            LastAdjustmentsWithoutImprovement = 0;
            LastAdjustment = 0.0;
            FramerateLog = new List<double>();
            FramerateTargetReachedCounter = 0;
            FramerateDipCounter = 0;
            LowestStableStability = 0;
            LowestStableChecks = 0;
            LogCounter = 0;

            if (powerLimiter is not null)
            {
                powerLimiter.ResetPowerLimits();
                CurrentTDP = powerLimiter.GetCPUPowerLimit();
            }
        }

        public void StartGameHandler(GameInstance instance)
        {
            currentGameProfile = ProfileForGame(instance.ProcessName);
            if (currentGameProfile is null || powerLimiter is null || framerateSouce is null)
            {
                return;
            }

            Logger.WriteLine("[AutoTDPService] Start handling game: " + instance.ProcessName + "  PID: " + instance.ProcessID);

            tdpThread = new Thread(() =>
            {
                CurrentTDP = powerLimiter.GetCPUPowerLimit();
                powerLimiter.SavePowerLimits(); // save current power limits to restore them afterwards

                powerLimiter.Prepare();

                Logger.WriteLine("[AutoTDPService] Backing up Power limit: " + CurrentTDP + "W");

                LowestStableTDP = currentGameProfile.MaxTdp;
                LowestTDP = currentGameProfile.MaxTdp;

                while (currentGame is not null && Running)
                {

                    if (!currentGameProfile.Enabled)
                    {
                        //Game was disabled during session. Stop AutoTDP 
                        Logger.WriteLine("[AutoTDPService] Game profile disabled: " + currentGameProfile.GameTitle + ". Disengaging.");
                        Reset();
                        return;
                    }

                    double fps = framerateSouce.GetFramerate(instance);

                    if (LOG_AUTO_TDP && LogCounter * FPSCheckInterval() > INTERVAL_LOG)
                        AutoTDPLogger.WriteLine("[AutoTDPService] (" + instance.ProcessName + ") Framerate " + GameFPS);

                    if (fps < 0.0d)
                    {
                        //Game is not running anymore or RTSS lost its hook
                        Logger.WriteLine("[AutoTDPService] Game exited: " + instance.ProcessName + "  PID: " + instance.ProcessID);
                        Reset();
                        return;
                    }

                    //prevent FPS from going to 0 which causes issues with the math
                    GameFPS = Math.Max(5, fps);
                    AdjustPowerLimit(currentGameProfile);

                    try
                    {
                        Thread.Sleep(FPSCheckInterval());
                    }
                    catch (ThreadInterruptedException)
                    {
                        continue;
                    }

                }
            });
            tdpThread.Start();
        }

        private double FPSDipCorrection(double currentFramerate, double targetFPS)
        {
            double correction = 0.0d;


            FramerateLog.Insert(0, currentFramerate);

            //Remove last entry when exceeding the desired size.
            if (FramerateLog.Count > FPSDipHistorySize)
            {
                FramerateLog.RemoveAt(FramerateLog.Count - 1);
            }

            if (targetFPS - 1 <= currentFramerate && currentFramerate <= targetFPS + 1)
            {
                //Framerate is inside ideal range
                FramerateTargetReachedCounter++;

                if (FramerateTargetReachedCounter >= 3
                    && FramerateTargetReachedCounter < FPSDipHistorySize
                    && targetFPS - 0.5 <= FramerateLog.Take(3).Average()
                    && FramerateLog.Take(3).Average() - 0.05 <= targetFPS)
                {
                    //short dip
                    FramerateDipCounter++;
                    FramerateUnstable();

                    correction = targetFPS + 0.25 - currentFramerate;
                }
                else if (FramerateDipCounter >= 2
                    && targetFPS - 0.5 <= FramerateLog.Average()
                         && FramerateLog.Average() - 0.1 <= targetFPS)
                {
                    //long dip
                    correction = targetFPS + 0.45 - currentFramerate;
                    FramerateTargetReachedCounter = FPSDipHistorySize;
                    FramerateVeryUnstable();
                }
                else
                {
                    FramerateStable();
                }
            }
            else
            {
                //Framerate not in target range
                correction = 0.0;
                FramerateTargetReachedCounter = 0;
                FramerateDipCounter = 0;
                FramerateStable();
            }

            ProcessStability();
            return correction;
        }

        private void FramerateStable()
        {
            LowestStableStability++;
        }

        private void FramerateUnstable()
        {
            LowestStableStability -= 30;
        }
        private void FramerateVeryUnstable()
        {
            LowestStableStability = -10;
        }

        private bool Stabilize()
        {
            return LowestStableChecks * FPSCheckInterval() > INTERVAL_MIN_CHECK;
        }

        private void ProcessStability()
        {
            if (!Stabilize()) LowestStableChecks++;

            if (LowestStableStability < 0 && Stabilize())
            {
                //If unstable for too often increase lowest stable TDP
                LowestStableTDP += 1;
                LowestTDP += 1;
                LowestStableStability = 0;
                return;
            }

            if (CurrentTDP > LowestStableTDP - 0.1 && CurrentTDP < LowestStableTDP + 0.1 && Stabilize())
            {
                LowestStableStability++;

                //Stable for at least 120s
                if (LowestStableStability * FPSCheckInterval() > (120 * 1_000))
                {
                    //if stable for long time try to reduce it again
                    LowestStableTDP = currentGameProfile.MaxTdp;
                    LowestStableStability = 0;
                }
            }

            if (LowestTDP - 0.25 <= CurrentTDP && CurrentTDP <= LowestTDP + 0.25)
            {
                LowestStableStability++;

                if (LowestStableStability * FPSCheckInterval() > (5 * 1_000) && Stabilize())
                {
                    LowestStableTDP = LowestTDP + (LowestTDP * 0.10); // Add 10% additional wattage to get a smoother framerate
                }

            }

            if (CurrentTDP < LowestTDP - 0.1 && LowestStableStability > 0)
            {
                LowestStableStability = 0;
                LowestTDP = CurrentTDP;
            }

            LowestStableStability = Math.Min(LowestStableStability, (125 * 1_000) / FPSCheckInterval());
        }


        private double TDPDamper(double currentFramerate)
        {
            if (double.IsNaN(GameFPSPrevious)) GameFPSPrevious = currentFramerate;
            double dF = -0.12d;

            // PID Compute
            double deltaError = currentFramerate - GameFPSPrevious;
            double dT = deltaError / (1020.0 / 1000.0);
            double damping = CurrentTDP / currentFramerate * dF * dT;

            GameFPSPrevious = currentFramerate;

            return damping;
        }

        public void AdjustPowerLimit(GameProfile profile)
        {

            if (powerLimiter is null)
            {
                //Should not happen... but we also don't want it to crash
                return;
            }

            //For the case that someone thinks they're super smart and sets the max lower than the min, we treat them as equal and consider the MAX to be the fixed TDP.
            if (profile.MaxTdp <= profile.MinTdp)
            {
                if (CurrentTDP == profile.MaxTdp)
                {
                    return;
                }
                powerLimiter?.SetCPUPowerLimit(profile.MaxTdp);
                CurrentTDP = profile.MaxTdp;
                if (LOG_AUTO_TDP)
                    AutoTDPLogger.WriteLine("[AutoTDPService] Power Limit fixed at " + profile.MaxTdp + "W");

                return;
            }

            double newPL = CurrentTDP;
            double fpsCorrection = FPSDipCorrection(GameFPS, profile.GetTDPFPS());
            double delta = profile.GetTDPFPS() - GameFPS - fpsCorrection - 1;
            delta = Math.Clamp(delta, -15, 15);


            double adjustment = (delta * CurrentTDP / GameFPS) * 0.7;
            //Dampen the changes to not change TDP too aggressively which would cause performance issues
            adjustment += TDPDamper(GameFPS);

            adjustment = Math.Min(adjustment, (CurrentTDP * 0.1));

            if (GameFPSPrevious > profile.GetTDPFPS() && GameFPS < profile.GetTDPFPS() && FPSCheckInterval() <= 250)
            {
                if (LOG_AUTO_TDP)
                    AutoTDPLogger.WriteLine("[AutoTDPService] Single Dip, Ignore");
                //single dip. Ignore
                return;
            }

            if (LastAdjustment > 0 && GameFPS <= GameFPSPrevious + 0.1 && adjustment > 0)
            {
                LastAdjustmentsWithoutImprovement++;
                LastAdjustmentTotal += adjustment;

                //Wait for 10 consecutive power increases and at least 5W increased TDP before judging that increasing power does nothing.
                if (LastAdjustmentsWithoutImprovement >= 10 && LastAdjustmentTotal > 5)
                {
                    //Do not adjust if increasing power does not improve framerate.
                    if (LOG_AUTO_TDP)
                        AutoTDPLogger.WriteLine("[AutoTDPService] Not adjusting because no improvement from last increase");
                    return;
                }

            }
            else
            {
                LastAdjustmentsWithoutImprovement = 0;
                LastAdjustmentTotal = 0;
            }

            newPL += adjustment;
            LastAdjustment = adjustment;

            //Respect the limits that the user chose
            newPL = Math.Clamp(newPL, profile.MinTdp, profile.MaxTdp);

            if (newPL < LowestStableTDP && LowestStableTDP < profile.MaxTdp - 1)
            {
                newPL = LowestStableTDP;
            }

            if (LOG_AUTO_TDP)
            {
                if (LogCounter * FPSCheckInterval() > INTERVAL_LOG)
                {
                    LogCounter = 0;
                    AutoTDPLogger.WriteLine("[AutoTDPService] Power Limit from " + CurrentTDP + "W to " + newPL + "W, Delta:" + adjustment
                   + " Lowest: " + LowestTDP + "W, Lowest Stable(" + LowestStableStability + "): " + LowestStableTDP + "W");
                }
                else
                {
                    LogCounter++;
                }
            }


            //Apply power limits
            powerLimiter?.SetCPUPowerLimit(newPL);
            CurrentTDP = newPL;
        }

        public void StopGameHandler()
        {
            if (tdpThread is not null)
            {
                currentGame = null;
                currentGameProfile = null;
                tdpThread.Join();
                tdpThread = null;
            }

        }

        public void Shutdown()
        {
            Running = false;
            currentGame = null;
            currentGameProfile = null;

            if (checkerThread is not null)
            {
                checkerThread.Interrupt();
                checkerThread.Join();
            }


            if (tdpThread is not null)
            {
                tdpThread.Interrupt();
                tdpThread.Join();
            }

            if (powerLimiter is not null)
            {
                powerLimiter.ResetPowerLimits();
                powerLimiter.Dispose();
                powerLimiter = null;
            }

            if (framerateSouce is not null)
            {
                framerateSouce = null;
            }

            Reset();

            //Kill RTSS instance if we started one
            RTSSFramerateSource.Stop();

        }

        public void Dispose()
        {
            Shutdown();
        }
    }
}
