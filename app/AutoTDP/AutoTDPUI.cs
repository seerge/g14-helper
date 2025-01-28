using GHelper.AutoTDP.FramerateSource;
using GHelper.AutoTDP.PowerLimiter;
using GHelper.UI;
using Ryzen;
using System.Linq;

namespace GHelper.AutoTDP
{
    public partial class AutoTDPUI : RForm
    {

        private Dictionary<string, string> ModeTexts = new Dictionary<string, string>();


        private AutoTDPGameProfileUI? profileUI;
        public AutoTDPUI()
        {
            InitializeComponent();

            InitTheme();


            ModeTexts.Add("intel_msr", "Intel MSR Power Limiter");
            ModeTexts.Add("asus_acpi", "ASUS ACPI Power Limiter");
            ModeTexts.Add("rtss", "Riva Tuner Statistics Server");

            checkBoxEnabled.CheckedChanged += CheckBoxEnabled_CheckedChanged;
            buttonAddGame.Click += ButtonAddGame_Click;

            comboBoxLimiter.DropDownClosed += ComboBoxLimiter_DropDownClosed;

            comboBoxFPSSource.DropDownClosed += ComboBoxFPSSource_DropDownClosed;

            Shown += AutoTDPUI_Shown;

            VisualizeGeneralSettings();
            VizualizeGameList();
        }

        private void ComboBoxFPSSource_DropDownClosed(object? sender, EventArgs e)
        {
            AppConfig.Set("auto_tdp_fps_source", AutoTDPService.AvailableFramerateSources().ElementAt(comboBoxFPSSource.SelectedIndex));

        }

        private void ComboBoxLimiter_DropDownClosed(object? sender, EventArgs e)
        {
            string? limiter = AppConfig.GetString("auto_tdp_limiter");
            string newLimiter = AutoTDPService.AvailablePowerLimiters().ElementAt(comboBoxLimiter.SelectedIndex);

            AppConfig.Set("auto_tdp_limiter", newLimiter);

            if (!newLimiter.Equals(limiter))
            {
                Program.autoTDPService.SwapPowerLimiter();
            }
        }

        private void CheckBoxEnabled_CheckedChanged(object? sender, EventArgs e)
        {
            AppConfig.Set("auto_tdp_enabled", checkBoxEnabled.Checked ? 1 : 0);

            if (Program.autoTDPService.IsEnabled())
            {
                Program.autoTDPService.Start();
            }
            else
            {
                Program.autoTDPService.Shutdown();
            }
        }

        private void ButtonAddGame_Click(object? sender, EventArgs e)
        {
            string? path = null;
            Thread t = new Thread(() =>
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Executables (*.exe, *.dat)|*.exe; *.dat";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            });

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            if (path is null)
            {
                //User did not select a file
                return;
            }

            GameProfile p = new GameProfile();
            p.ProcessName = Path.GetFileName(path);
            p.GameTitle = Path.GetFileName(path).Replace(".exe", "").Replace(".dat", "");
            p.Enabled = true;
            p.TargetFPS = 60;
            p.MaxTdp = 40;
            p.MinTdp = 15;
            p.Interval = AutoTDPService.INTERVAL_FPS_CHECK;

            profileUI = new AutoTDPGameProfileUI(p, this);
            profileUI.FormClosed += ProfileUI_FormClosed;
            profileUI.TopMost = AppConfig.Is("topmost") || this.TopMost;
            profileUI.ShowDialog(this);
        }

        private void ProfileUI_FormClosed(object? sender, FormClosedEventArgs e)
        {
            profileUI = null;
        }

        private void AutoTDPUI_Shown(object? sender, EventArgs e)
        {
            if (Height > Program.settingsForm.Height)
            {
                Top = Program.settingsForm.Top + Program.settingsForm.Height - Height;
            }
            else
            {
                Top = Program.settingsForm.Top;
            }

            Left = Program.settingsForm.Left - Width - 5;
        }

        private void VisualizeGeneralSettings()
        {
            checkBoxEnabled.Checked = AppConfig.Get("auto_tdp_enabled", 0) == 1;

            comboBoxLimiter.Items.Clear();
            comboBoxFPSSource.Items.Clear();

            foreach (string s in AutoTDPService.AvailablePowerLimiters())
            {
                comboBoxLimiter.Items.Add(ModeTexts[s]);
            }

            foreach (string s in AutoTDPService.AvailableFramerateSources())
            {
                comboBoxFPSSource.Items.Add(ModeTexts[s]);
            }


            string? limiter = AppConfig.GetString("auto_tdp_limiter", null);
            string? source = AppConfig.GetString("auto_tdp_fps_source", null);


            if (limiter is not null && AutoTDPService.AvailablePowerLimiters().Contains(limiter))
            {
                comboBoxLimiter.SelectedIndex = AutoTDPService.AvailablePowerLimiters().IndexOf(limiter);
            }
            else
            {
                comboBoxLimiter.SelectedIndex = 0;
            }

            if (source is not null && AutoTDPService.AvailableFramerateSources().Contains(source))
            {
                comboBoxFPSSource.SelectedIndex = AutoTDPService.AvailableFramerateSources().IndexOf(source);
            }
            else
            {
                comboBoxFPSSource.SelectedIndex = 0;
            }

        }


        private void VizualizeGameList()
        {
            //Due to my lousy skills in UI design, the game table is limited to 7x4 games.
            buttonAddGame.Enabled = Program.autoTDPService.GameProfiles.Count < 7 * 4;

            tableLayoutGames.Controls.Clear();

            foreach (GameProfile gp in Program.autoTDPService.GameProfiles)
            {
                RButton bt = new RButton();
                bt.Text = gp.GameTitle + "\n" + gp.TargetFPS + " FPS";

                bt.Dock = DockStyle.Fill;
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderColor = RForm.borderMain;
                bt.UseVisualStyleBackColor = false;
                bt.AutoSize = true;
                bt.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                bt.BackColor = RForm.buttonMain;
                bt.ForeColor = RForm.foreMain;
                bt.Click += Bt_Click;
                bt.Tag = gp;

                tableLayoutGames.Controls.Add(bt);
            }
        }

        private void Bt_Click(object? sender, EventArgs e)
        {
            GameProfile gp = (GameProfile)((RButton)sender).Tag;
            profileUI = new AutoTDPGameProfileUI(gp, this);
            profileUI.FormClosed += ProfileUI_FormClosed;
            profileUI.TopMost = AppConfig.Is("topmost") || this.TopMost;
            profileUI.ShowDialog(this);
        }

        public void DeleteGameProfile(GameProfile gp)
        {
            if (Program.autoTDPService.IsGameInList(gp.ProcessName, false))
            {
                Program.autoTDPService.GameProfiles.Remove(gp);
            }

            Program.autoTDPService.SortGameProfiles();
            Program.autoTDPService.SaveGameProfiles();
            VizualizeGameList();
        }

        public void UpdateGameProfile(GameProfile gp)
        {
            if (!Program.autoTDPService.IsGameInList(gp.ProcessName, false))
            {
                Program.autoTDPService.GameProfiles.Add(gp);
            }
            Program.autoTDPService.SortGameProfiles();
            Program.autoTDPService.SaveGameProfiles();
            VizualizeGameList();
        }
    }
}
