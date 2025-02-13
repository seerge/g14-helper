using GHelper.UI;
using System.Windows.Forms.DataVisualization.Charting;

namespace GHelper
{
    partial class Fans
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Title title1 = new Title();
            ChartArea chartArea2 = new ChartArea();
            Title title2 = new Title();
            ChartArea chartArea3 = new ChartArea();
            Title title3 = new Title();
            ChartArea chartArea4 = new ChartArea();
            Title title4 = new Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fans));
            panelFans = new Panel();
            labelTip = new Label();
            tableFanCharts = new TableLayoutPanel();
            chartGPU = new Chart();
            chartCPU = new Chart();
            chartXGM = new Chart();
            chartMid = new Chart();
            panelTitleFans = new Panel();
            buttonRename = new RButton();
            buttonRemove = new RButton();
            buttonAdd = new RButton();
            comboModes = new RComboBox();
            picturePerf = new PictureBox();
            labelFans = new Label();
            panelApplyFans = new Panel();
            buttonCalibrate = new RButton();
            labelFansResult = new Label();
            checkApplyFans = new RCheckBox();
            buttonReset = new RButton();
            comboBoost = new RComboBox();
            sliderEPP = new TrackBar();
            panelSliders = new Panel();
            panelAdvanced = new Panel();
            panelAdvancedAlways = new Panel();
            checkApplyUV = new RCheckBox();
            panelAdvancedApply = new Panel();
            buttonApplyAdvanced = new RButton();
            labelRisky = new Label();
            panelUViGPU = new Panel();
            labelUViGPU = new Label();
            labelLeftUViGPU = new Label();
            trackUViGPU = new TrackBar();
            panelUV = new Panel();
            labelUV = new Label();
            labelLeftUV = new Label();
            trackUV = new TrackBar();
            panelTitleAdvanced = new Panel();
            pictureUV = new PictureBox();
            labelTitleUV = new Label();
            panelTemperature = new Panel();
            labelTemp = new Label();
            labelLeftTemp = new Label();
            trackTemp = new TrackBar();
            panelTitleTemp = new Panel();
            pictureTemp = new PictureBox();
            labelTempLimit = new Label();
            panelDownload = new Panel();
            buttonDownload = new RButton();
            panelPower = new Panel();
            panelApplyPower = new Panel();
            checkApplyPower = new RCheckBox();
            panelCPU = new Panel();
            labelCPU = new Label();
            labelLeftCPU = new Label();
            trackCPU = new TrackBar();
            panelFast = new Panel();
            labelFast = new Label();
            labelLeftFast = new Label();
            trackFast = new TrackBar();
            panelSlow = new Panel();
            labelSlow = new Label();
            labelLeftSlow = new Label();
            trackSlow = new TrackBar();
            panelTotal = new Panel();
            labelTotal = new Label();
            labelLeftTotal = new Label();
            trackTotal = new TrackBar();
            panelTitleCPU = new Panel();
            pictureBoxCPU = new PictureBox();
            labelPowerLimits = new Label();
            panelBoost = new Panel();
            panelBoostTitle = new Panel();
            pictureBoost = new PictureBox();
            labelBoost = new Label();
            if (AppConfig.IsAlly())
            {
                panelEPP = new Panel();
                panelEPPTitle = new Panel();
                labelEPP = new Label();
                labelEPPSliderLeft = new Label();
                labelEPPSliderRight = new Label();
                pictureEPP = new PictureBox();
            }
            panelPowerMode = new Panel();
            comboPowerMode = new RComboBox();
            panelPowerModeTItle = new Panel();
            picturePowerMode = new PictureBox();
            labelPowerModeTitle = new Label();
            panelGPU = new Panel();
            panelGPUTemp = new Panel();
            labelGPUTemp = new Label();
            labelGPUTempTitle = new Label();
            trackGPUTemp = new TrackBar();
            panelGPUBoost = new Panel();
            labelGPUBoost = new Label();
            labelGPUBoostTitle = new Label();
            trackGPUBoost = new TrackBar();
            panelGPUPower = new Panel();
            labelGPUPower = new Label();
            labelGPUPowerTitle = new Label();
            trackGPUPower = new TrackBar();
            panelGPUMemory = new Panel();
            labelGPUMemory = new Label();
            labelGPUMemoryTitle = new Label();
            trackGPUMemory = new TrackBar();
            panelGPUCore = new Panel();
            labelGPUCore = new Label();
            trackGPUCore = new TrackBar();
            labelGPUCoreTitle = new Label();
            panelGPUClockLimit = new Panel();
            labelGPUClockLimit = new Label();
            trackGPUClockLimit = new TrackBar();
            labelGPUClockLimitTitle = new Label();
            panelTitleGPU = new Panel();
            pictureGPU = new PictureBox();
            labelGPU = new Label();
            panelNav = new Panel();
            tableNav = new TableLayoutPanel();
            buttonAdvanced = new RButton();
            buttonGPU = new RButton();
            buttonCPU = new RButton();
            panelFans.SuspendLayout();
            tableFanCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartXGM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMid).BeginInit();
            panelTitleFans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerf).BeginInit();
            panelApplyFans.SuspendLayout();
            panelSliders.SuspendLayout();
            panelAdvanced.SuspendLayout();
            panelAdvancedAlways.SuspendLayout();
            panelAdvancedApply.SuspendLayout();
            panelUViGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackUViGPU).BeginInit();
            panelUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackUV).BeginInit();
            panelTitleAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUV).BeginInit();
            panelTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackTemp).BeginInit();
            panelTitleTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTemp).BeginInit();
            panelDownload.SuspendLayout();
            panelPower.SuspendLayout();
            panelApplyPower.SuspendLayout();
            panelCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackCPU).BeginInit();
            panelFast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackFast).BeginInit();
            panelSlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackSlow).BeginInit();
            panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackTotal).BeginInit();
            panelTitleCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCPU).BeginInit();
            panelBoost.SuspendLayout();
            panelBoostTitle.SuspendLayout();

            if (AppConfig.IsAlly())
            {
                ((System.ComponentModel.ISupportInitialize)pictureEPP).BeginInit();
                panelEPP.SuspendLayout();
                panelEPPTitle.SuspendLayout();
                labelEPP.SuspendLayout();
                labelEPPSliderLeft.SuspendLayout();
                labelEPPSliderRight.SuspendLayout();
            }

            ((System.ComponentModel.ISupportInitialize)pictureBoost).BeginInit();
            panelPowerMode.SuspendLayout();
            panelPowerModeTItle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePowerMode).BeginInit();
            panelGPU.SuspendLayout();
            panelGPUTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUTemp).BeginInit();
            panelGPUBoost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUBoost).BeginInit();
            panelGPUPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUPower).BeginInit();
            panelGPUMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUMemory).BeginInit();
            panelGPUCore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUCore).BeginInit();
            panelGPUClockLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUClockLimit).BeginInit();
            panelTitleGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGPU).BeginInit();
            panelNav.SuspendLayout();
            tableNav.SuspendLayout();
            SuspendLayout();
            // 
            // panelFans
            // 
            panelFans.AutoSize = true;
            panelFans.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFans.Controls.Add(labelTip);
            panelFans.Controls.Add(tableFanCharts);
            panelFans.Controls.Add(panelTitleFans);
            panelFans.Controls.Add(panelApplyFans);
            panelFans.Dock = DockStyle.Fill;
            panelFans.Location = new Point(530, 0);
            panelFans.Margin = new Padding(0);
            panelFans.MinimumSize = new Size(816, 0);
            panelFans.Name = "panelFans";
            panelFans.Padding = new Padding(0, 0, 10, 0);
            panelFans.Size = new Size(820, 2119);
            panelFans.TabIndex = 12;
            // 
            // labelTip
            // 
            labelTip.AutoSize = true;
            labelTip.BackColor = SystemColors.ControlLightLight;
            labelTip.Location = new Point(684, 92);
            labelTip.Margin = new Padding(4, 0, 4, 0);
            labelTip.Name = "labelTip";
            labelTip.Padding = new Padding(4);
            labelTip.Size = new Size(105, 40);
            labelTip.TabIndex = 40;
            labelTip.Text = "500,300";
            // 
            // tableFanCharts
            // 
            tableFanCharts.AutoSize = true;
            tableFanCharts.ColumnCount = 1;
            tableFanCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableFanCharts.Controls.Add(chartGPU, 0, 1);
            tableFanCharts.Controls.Add(chartCPU, 0, 0);
            tableFanCharts.Controls.Add(chartXGM, 0, 2);
            tableFanCharts.Controls.Add(chartMid, 0, 2);
            tableFanCharts.Dock = DockStyle.Fill;
            tableFanCharts.Location = new Point(0, 66);
            tableFanCharts.Margin = new Padding(4);
            tableFanCharts.Name = "tableFanCharts";
            tableFanCharts.Padding = new Padding(10, 0, 10, 5);
            tableFanCharts.RowCount = 2;
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.Size = new Size(810, 1937);
            tableFanCharts.TabIndex = 36;
            // 
            // chartGPU
            // 
            chartArea1.Name = "ChartArea1";
            chartGPU.ChartAreas.Add(chartArea1);
            chartGPU.Dock = DockStyle.Fill;
            chartGPU.Location = new Point(12, 493);
            chartGPU.Margin = new Padding(2, 10, 2, 10);
            chartGPU.Name = "chartGPU";
            chartGPU.Size = new Size(786, 463);
            chartGPU.TabIndex = 17;
            chartGPU.Text = "chartGPU";
            title1.Name = "Title1";
            chartGPU.Titles.Add(title1);
            // 
            // chartCPU
            // 
            chartArea2.Name = "ChartArea1";
            chartCPU.ChartAreas.Add(chartArea2);
            chartCPU.Dock = DockStyle.Fill;
            chartCPU.Location = new Point(12, 10);
            chartCPU.Margin = new Padding(2, 10, 2, 10);
            chartCPU.Name = "chartCPU";
            chartCPU.Size = new Size(786, 463);
            chartCPU.TabIndex = 14;
            chartCPU.Text = "chartCPU";
            title2.Name = "Title1";
            chartCPU.Titles.Add(title2);
            // 
            // chartXGM
            // 
            chartArea3.Name = "ChartAreaXGM";
            chartXGM.ChartAreas.Add(chartArea3);
            chartXGM.Dock = DockStyle.Fill;
            chartXGM.Location = new Point(12, 1459);
            chartXGM.Margin = new Padding(2, 10, 2, 10);
            chartXGM.Name = "chartXGM";
            chartXGM.Size = new Size(786, 463);
            chartXGM.TabIndex = 14;
            chartXGM.Text = "chartXGM";
            title3.Name = "Title4";
            chartXGM.Titles.Add(title3);
            chartXGM.Visible = false;
            // 
            // chartMid
            // 
            chartArea4.Name = "ChartArea3";
            chartMid.ChartAreas.Add(chartArea4);
            chartMid.Dock = DockStyle.Fill;
            chartMid.Location = new Point(12, 976);
            chartMid.Margin = new Padding(2, 10, 2, 10);
            chartMid.Name = "chartMid";
            chartMid.Size = new Size(786, 463);
            chartMid.TabIndex = 14;
            chartMid.Text = "chartMid";
            title4.Name = "Title3";
            chartMid.Titles.Add(title4);
            chartMid.Visible = false;
            // 
            // panelTitleFans
            // 
            panelTitleFans.Controls.Add(buttonRename);
            panelTitleFans.Controls.Add(buttonRemove);
            panelTitleFans.Controls.Add(buttonAdd);
            panelTitleFans.Controls.Add(comboModes);
            panelTitleFans.Controls.Add(picturePerf);
            panelTitleFans.Controls.Add(labelFans);
            panelTitleFans.Dock = DockStyle.Top;
            panelTitleFans.Location = new Point(0, 0);
            panelTitleFans.Margin = new Padding(4);
            panelTitleFans.Name = "panelTitleFans";
            panelTitleFans.Size = new Size(810, 66);
            panelTitleFans.TabIndex = 42;
            // 
            // buttonRename
            // 
            buttonRename.Activated = false;
            buttonRename.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRename.BackColor = SystemColors.ControlLight;
            buttonRename.BorderColor = Color.Transparent;
            buttonRename.BorderRadius = 2;
            buttonRename.FlatStyle = FlatStyle.Flat;
            buttonRename.Image = Properties.Resources.icons8_edit_32;
            buttonRename.Location = new Point(380, 10);
            buttonRename.Margin = new Padding(4, 2, 4, 2);
            buttonRename.Name = "buttonRename";
            buttonRename.Secondary = true;
            buttonRename.Size = new Size(52, 46);
            buttonRename.TabIndex = 45;
            buttonRename.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            buttonRemove.Activated = false;
            buttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemove.BackColor = SystemColors.ControlLight;
            buttonRemove.BorderColor = Color.Transparent;
            buttonRemove.BorderRadius = 2;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Image = Properties.Resources.icons8_remove_64;
            buttonRemove.Location = new Point(326, 10);
            buttonRemove.Margin = new Padding(4, 2, 4, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Secondary = true;
            buttonRemove.Size = new Size(52, 46);
            buttonRemove.TabIndex = 44;
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Activated = false;
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.BorderColor = Color.Transparent;
            buttonAdd.BorderRadius = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Image = Properties.Resources.icons8_add_64;
            buttonAdd.Location = new Point(748, 10);
            buttonAdd.Margin = new Padding(4, 2, 4, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Secondary = true;
            buttonAdd.Size = new Size(52, 46);
            buttonAdd.TabIndex = 43;
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // comboModes
            // 
            comboModes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboModes.BorderColor = Color.White;
            comboModes.ButtonColor = Color.FromArgb(255, 255, 255);
            comboModes.FlatStyle = FlatStyle.Flat;
            comboModes.FormattingEnabled = true;
            comboModes.Location = new Point(440, 14);
            comboModes.Margin = new Padding(0);
            comboModes.Name = "comboModes";
            comboModes.Size = new Size(302, 40);
            comboModes.TabIndex = 42;
            // 
            // picturePerf
            // 
            picturePerf.BackgroundImage = Properties.Resources.icons8_fan_32;
            picturePerf.BackgroundImageLayout = ImageLayout.Zoom;
            picturePerf.InitialImage = null;
            picturePerf.Location = new Point(18, 18);
            picturePerf.Margin = new Padding(4, 2, 4, 2);
            picturePerf.Name = "picturePerf";
            picturePerf.Size = new Size(32, 32);
            picturePerf.TabIndex = 41;
            picturePerf.TabStop = false;
            // 
            // labelFans
            // 
            labelFans.AutoSize = true;
            labelFans.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFans.Location = new Point(53, 17);
            labelFans.Margin = new Padding(4, 0, 4, 0);
            labelFans.Name = "labelFans";
            labelFans.Size = new Size(90, 32);
            labelFans.TabIndex = 40;
            labelFans.Text = "Profile";
            // 
            // panelApplyFans
            // 
            panelApplyFans.Controls.Add(buttonCalibrate);
            panelApplyFans.Controls.Add(labelFansResult);
            panelApplyFans.Controls.Add(checkApplyFans);
            panelApplyFans.Controls.Add(buttonReset);
            panelApplyFans.Dock = DockStyle.Bottom;
            panelApplyFans.Location = new Point(0, 2003);
            panelApplyFans.Margin = new Padding(4);
            panelApplyFans.Name = "panelApplyFans";
            panelApplyFans.Size = new Size(810, 116);
            panelApplyFans.TabIndex = 43;
            // 
            // buttonCalibrate
            // 
            buttonCalibrate.Activated = false;
            buttonCalibrate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCalibrate.BackColor = SystemColors.ControlLight;
            buttonCalibrate.BorderColor = Color.Transparent;
            buttonCalibrate.BorderRadius = 2;
            buttonCalibrate.FlatStyle = FlatStyle.Flat;
            buttonCalibrate.Location = new Point(275, 40);
            buttonCalibrate.Margin = new Padding(4, 2, 4, 2);
            buttonCalibrate.Name = "buttonCalibrate";
            buttonCalibrate.Secondary = true;
            buttonCalibrate.Size = new Size(141, 50);
            buttonCalibrate.TabIndex = 43;
            buttonCalibrate.Text = "Calibrate";
            buttonCalibrate.UseVisualStyleBackColor = false;
            // 
            // labelFansResult
            // 
            labelFansResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFansResult.ForeColor = Color.Red;
            labelFansResult.Location = new Point(18, 2);
            labelFansResult.Margin = new Padding(4, 0, 4, 0);
            labelFansResult.Name = "labelFansResult";
            labelFansResult.Size = new Size(771, 32);
            labelFansResult.TabIndex = 42;
            labelFansResult.Visible = false;
            // 
            // checkApplyFans
            // 
            checkApplyFans.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkApplyFans.AutoSize = true;
            checkApplyFans.BackColor = SystemColors.ControlLight;
            checkApplyFans.Location = new Point(454, 42);
            checkApplyFans.Margin = new Padding(0);
            checkApplyFans.Name = "checkApplyFans";
            checkApplyFans.Padding = new Padding(16, 6, 16, 6);
            checkApplyFans.Size = new Size(341, 48);
            checkApplyFans.TabIndex = 19;
            checkApplyFans.Text = Properties.Strings.ApplyFanCurve;
            checkApplyFans.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            buttonReset.Activated = false;
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonReset.BackColor = SystemColors.ControlLight;
            buttonReset.BorderColor = Color.Transparent;
            buttonReset.BorderRadius = 2;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(15, 40);
            buttonReset.Margin = new Padding(4, 2, 4, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Secondary = true;
            buttonReset.Size = new Size(252, 50);
            buttonReset.TabIndex = 18;
            buttonReset.Text = Properties.Strings.FactoryDefaults;
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // comboBoost
            // 
            comboBoost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoost.BorderColor = Color.White;
            comboBoost.ButtonColor = Color.FromArgb(255, 255, 255);
            comboBoost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoost.FormattingEnabled = true;
            comboBoost.Items.AddRange(new object[] { "Disabled", "Enabled", "Aggressive", "Efficient Enabled", "Efficient Aggressive", "Aggressive at Guaranteed", "Efficient at Guaranteed" });
            comboBoost.Location = new Point(13, 12);
            comboBoost.Margin = new Padding(4);
            comboBoost.Name = "comboBoost";
            comboBoost.Size = new Size(329, 40);
            comboBoost.TabIndex = 42;

            if (AppConfig.IsAlly())
            {
                //
                // sliderEPP
                //
                sliderEPP.Location = new Point(6, 48);
                sliderEPP.Margin = new Padding(4, 2, 4, 2);
                sliderEPP.Maximum = 100;
                sliderEPP.Minimum = 0;
                sliderEPP.Name = "sliderEPP";
                sliderEPP.Size = new Size(508, 90);
                sliderEPP.TabIndex = 10;
                sliderEPP.TickFrequency = 10;
                sliderEPP.SmallChange = 10;
                sliderEPP.LargeChange = 10;
                sliderEPP.TickStyle = TickStyle.TopLeft;
            }

            // 
            // panelSliders
            // 
            panelSliders.Controls.Add(panelAdvanced);
            panelSliders.Controls.Add(panelPower);
            panelSliders.Controls.Add(panelGPU);
            panelSliders.Controls.Add(panelNav);
            panelSliders.Dock = DockStyle.Left;
            panelSliders.Location = new Point(0, 0);
            panelSliders.Margin = new Padding(0);
            panelSliders.MinimumSize = new Size(530, 0);
            panelSliders.Name = "panelSliders";
            panelSliders.Padding = new Padding(10, 0, 0, 0);
            panelSliders.Size = new Size(530, 2119);
            panelSliders.TabIndex = 13;
            // 
            // panelAdvanced
            // 
            panelAdvanced.AutoSize = true;
            panelAdvanced.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAdvanced.Controls.Add(panelAdvancedAlways);
            panelAdvanced.Controls.Add(panelAdvancedApply);
            panelAdvanced.Controls.Add(labelRisky);
            panelAdvanced.Controls.Add(panelUViGPU);
            panelAdvanced.Controls.Add(panelUV);
            panelAdvanced.Controls.Add(panelTitleAdvanced);
            panelAdvanced.Controls.Add(panelTemperature);
            panelAdvanced.Controls.Add(panelTitleTemp);
            panelAdvanced.Controls.Add(panelDownload);
            panelAdvanced.Dock = DockStyle.Top;
            panelAdvanced.Location = new Point(10, 1768);
            panelAdvanced.Name = "panelAdvanced";
            panelAdvanced.Size = new Size(520, 992);
            panelAdvanced.TabIndex = 14;
            panelAdvanced.Visible = false;
            // 
            // panelAdvancedAlways
            // 
            panelAdvancedAlways.AutoSize = true;
            panelAdvancedAlways.Controls.Add(checkApplyUV);
            panelAdvancedAlways.Dock = DockStyle.Top;
            panelAdvancedAlways.Location = new Point(0, 931);
            panelAdvancedAlways.Name = "panelAdvancedAlways";
            panelAdvancedAlways.Padding = new Padding(16, 0, 16, 15);
            panelAdvancedAlways.Size = new Size(520, 61);
            panelAdvancedAlways.TabIndex = 46;
            // 
            // checkApplyUV
            // 
            checkApplyUV.BackColor = SystemColors.ControlLight;
            checkApplyUV.Dock = DockStyle.Top;
            checkApplyUV.Enabled = false;
            checkApplyUV.Location = new Point(16, 0);
            checkApplyUV.Margin = new Padding(15, 15, 0, 0);
            checkApplyUV.Name = "checkApplyUV";
            checkApplyUV.Padding = new Padding(16, 6, 16, 6);
            checkApplyUV.Size = new Size(488, 46);
            checkApplyUV.TabIndex = 51;
            checkApplyUV.Text = "Auto Apply";
            checkApplyUV.TextAlign = ContentAlignment.MiddleCenter;
            checkApplyUV.UseVisualStyleBackColor = false;
            // 
            // panelAdvancedApply
            // 
            panelAdvancedApply.AutoSize = true;
            panelAdvancedApply.Controls.Add(buttonApplyAdvanced);
            panelAdvancedApply.Dock = DockStyle.Top;
            panelAdvancedApply.Location = new Point(0, 851);
            panelAdvancedApply.Name = "panelAdvancedApply";
            panelAdvancedApply.Padding = new Padding(15);
            panelAdvancedApply.Size = new Size(520, 80);
            panelAdvancedApply.TabIndex = 47;
            // 
            // buttonApplyAdvanced
            // 
            buttonApplyAdvanced.Activated = false;
            buttonApplyAdvanced.BackColor = SystemColors.ControlLight;
            buttonApplyAdvanced.BorderColor = Color.Transparent;
            buttonApplyAdvanced.BorderRadius = 2;
            buttonApplyAdvanced.Dock = DockStyle.Top;
            buttonApplyAdvanced.FlatStyle = FlatStyle.Flat;
            buttonApplyAdvanced.Location = new Point(15, 15);
            buttonApplyAdvanced.Margin = new Padding(4, 2, 15, 15);
            buttonApplyAdvanced.Name = "buttonApplyAdvanced";
            buttonApplyAdvanced.Secondary = true;
            buttonApplyAdvanced.Size = new Size(490, 50);
            buttonApplyAdvanced.TabIndex = 49;
            buttonApplyAdvanced.Text = "Apply";
            buttonApplyAdvanced.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonApplyAdvanced.UseVisualStyleBackColor = false;
            // 
            // labelRisky
            // 
            labelRisky.BackColor = Color.IndianRed;
            labelRisky.Dock = DockStyle.Top;
            labelRisky.ForeColor = SystemColors.ControlLightLight;
            labelRisky.Location = new Point(0, 608);
            labelRisky.Margin = new Padding(0);
            labelRisky.Name = "labelRisky";
            labelRisky.Padding = new Padding(10, 10, 10, 5);
            labelRisky.Size = new Size(520, 243);
            labelRisky.TabIndex = 46;
            labelRisky.Text = resources.GetString("labelRisky.Text");
            // 
            // panelUViGPU
            // 
            panelUViGPU.AutoSize = true;
            panelUViGPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelUViGPU.Controls.Add(labelUViGPU);
            panelUViGPU.Controls.Add(labelLeftUViGPU);
            panelUViGPU.Controls.Add(trackUViGPU);
            panelUViGPU.Dock = DockStyle.Top;
            panelUViGPU.Location = new Point(0, 484);
            panelUViGPU.Margin = new Padding(4);
            panelUViGPU.MaximumSize = new Size(0, 124);
            panelUViGPU.Name = "panelUViGPU";
            panelUViGPU.Size = new Size(520, 124);
            panelUViGPU.TabIndex = 49;
            // 
            // labelUViGPU
            // 
            labelUViGPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUViGPU.Location = new Point(347, 9);
            labelUViGPU.Margin = new Padding(4, 0, 4, 0);
            labelUViGPU.Name = "labelUViGPU";
            labelUViGPU.Size = new Size(148, 32);
            labelUViGPU.TabIndex = 13;
            labelUViGPU.Text = "UV";
            labelUViGPU.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftUViGPU
            // 
            labelLeftUViGPU.AutoSize = true;
            labelLeftUViGPU.Location = new Point(10, 10);
            labelLeftUViGPU.Margin = new Padding(4, 0, 4, 0);
            labelLeftUViGPU.Name = "labelLeftUViGPU";
            labelLeftUViGPU.Size = new Size(65, 32);
            labelLeftUViGPU.TabIndex = 12;
            labelLeftUViGPU.Text = "iGPU";
            // 
            // trackUViGPU
            // 
            trackUViGPU.Location = new Point(6, 48);
            trackUViGPU.Margin = new Padding(4, 2, 4, 2);
            trackUViGPU.Maximum = 0;
            trackUViGPU.Minimum = -40;
            trackUViGPU.Name = "trackUViGPU";
            trackUViGPU.Size = new Size(508, 90);
            trackUViGPU.TabIndex = 11;
            trackUViGPU.TickFrequency = 5;
            trackUViGPU.TickStyle = TickStyle.TopLeft;
            // 
            // panelUV
            // 
            panelUV.AutoSize = true;
            panelUV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelUV.Controls.Add(labelUV);
            panelUV.Controls.Add(labelLeftUV);
            panelUV.Controls.Add(trackUV);
            panelUV.Dock = DockStyle.Top;
            panelUV.Location = new Point(0, 360);
            panelUV.Margin = new Padding(4);
            panelUV.MaximumSize = new Size(0, 124);
            panelUV.Name = "panelUV";
            panelUV.Size = new Size(520, 124);
            panelUV.TabIndex = 46;
            // 
            // labelUV
            // 
            labelUV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUV.Location = new Point(347, 13);
            labelUV.Margin = new Padding(4, 0, 4, 0);
            labelUV.Name = "labelUV";
            labelUV.Size = new Size(148, 32);
            labelUV.TabIndex = 13;
            labelUV.Text = "UV";
            labelUV.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftUV
            // 
            labelLeftUV.AutoSize = true;
            labelLeftUV.Location = new Point(10, 10);
            labelLeftUV.Margin = new Padding(4, 0, 4, 0);
            labelLeftUV.Name = "labelLeftUV";
            labelLeftUV.Size = new Size(58, 32);
            labelLeftUV.TabIndex = 12;
            labelLeftUV.Text = "CPU";
            // 
            // trackUV
            // 
            trackUV.Location = new Point(6, 48);
            trackUV.Margin = new Padding(4, 2, 4, 2);
            trackUV.Maximum = 0;
            trackUV.Minimum = -40;
            trackUV.Name = "trackUV";
            trackUV.Size = new Size(508, 90);
            trackUV.TabIndex = 11;
            trackUV.TickFrequency = 5;
            trackUV.TickStyle = TickStyle.TopLeft;
            // 
            // panelTitleAdvanced
            // 
            panelTitleAdvanced.Controls.Add(pictureUV);
            panelTitleAdvanced.Controls.Add(labelTitleUV);
            panelTitleAdvanced.Dock = DockStyle.Top;
            panelTitleAdvanced.Location = new Point(0, 294);
            panelTitleAdvanced.Name = "panelTitleAdvanced";
            panelTitleAdvanced.Size = new Size(520, 66);
            panelTitleAdvanced.TabIndex = 48;
            // 
            // pictureUV
            // 
            pictureUV.BackgroundImage = Properties.Resources.icons8_voltage_32;
            pictureUV.BackgroundImageLayout = ImageLayout.Zoom;
            pictureUV.InitialImage = null;
            pictureUV.Location = new Point(10, 18);
            pictureUV.Margin = new Padding(4, 2, 4, 10);
            pictureUV.Name = "pictureUV";
            pictureUV.Size = new Size(32, 32);
            pictureUV.TabIndex = 48;
            pictureUV.TabStop = false;
            // 
            // labelTitleUV
            // 
            labelTitleUV.AutoSize = true;
            labelTitleUV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitleUV.Location = new Point(43, 17);
            labelTitleUV.Margin = new Padding(4, 0, 4, 0);
            labelTitleUV.Name = "labelTitleUV";
            labelTitleUV.Size = new Size(166, 32);
            labelTitleUV.TabIndex = 47;
            labelTitleUV.Text = "Undervolting";
            // 
            // panelTemperature
            // 
            panelTemperature.AutoSize = true;
            panelTemperature.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTemperature.Controls.Add(labelTemp);
            panelTemperature.Controls.Add(labelLeftTemp);
            panelTemperature.Controls.Add(trackTemp);
            panelTemperature.Dock = DockStyle.Top;
            panelTemperature.Location = new Point(0, 170);
            panelTemperature.Margin = new Padding(4);
            panelTemperature.MaximumSize = new Size(0, 124);
            panelTemperature.Name = "panelTemperature";
            panelTemperature.Size = new Size(520, 124);
            panelTemperature.TabIndex = 51;
            // 
            // labelTemp
            // 
            labelTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTemp.Location = new Point(347, 13);
            labelTemp.Margin = new Padding(4, 0, 4, 0);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(148, 32);
            labelTemp.TabIndex = 13;
            labelTemp.Text = "T";
            labelTemp.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftTemp
            // 
            labelLeftTemp.AutoSize = true;
            labelLeftTemp.Location = new Point(10, 10);
            labelLeftTemp.Margin = new Padding(4, 0, 4, 0);
            labelLeftTemp.Name = "labelLeftTemp";
            labelLeftTemp.Size = new Size(183, 32);
            labelLeftTemp.TabIndex = 12;
            labelLeftTemp.Text = "CPU Temp Limit";
            // 
            // trackTemp
            // 
            trackTemp.Location = new Point(6, 48);
            trackTemp.Margin = new Padding(4, 2, 4, 2);
            trackTemp.Maximum = 0;
            trackTemp.Minimum = -40;
            trackTemp.Name = "trackTemp";
            trackTemp.Size = new Size(508, 90);
            trackTemp.TabIndex = 11;
            trackTemp.TickFrequency = 5;
            trackTemp.TickStyle = TickStyle.TopLeft;
            // 
            // panelTitleTemp
            // 
            panelTitleTemp.Controls.Add(pictureTemp);
            panelTitleTemp.Controls.Add(labelTempLimit);
            panelTitleTemp.Dock = DockStyle.Top;
            panelTitleTemp.Location = new Point(0, 104);
            panelTitleTemp.Name = "panelTitleTemp";
            panelTitleTemp.Size = new Size(520, 66);
            panelTitleTemp.TabIndex = 50;
            // 
            // pictureTemp
            // 
            pictureTemp.BackgroundImage = Properties.Resources.icons8_temperature_32;
            pictureTemp.BackgroundImageLayout = ImageLayout.Zoom;
            pictureTemp.InitialImage = null;
            pictureTemp.Location = new Point(10, 18);
            pictureTemp.Margin = new Padding(4, 2, 4, 10);
            pictureTemp.Name = "pictureTemp";
            pictureTemp.Size = new Size(32, 32);
            pictureTemp.TabIndex = 48;
            pictureTemp.TabStop = false;
            // 
            // labelTempLimit
            // 
            labelTempLimit.AutoSize = true;
            labelTempLimit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTempLimit.Location = new Point(46, 17);
            labelTempLimit.Margin = new Padding(4, 0, 4, 0);
            labelTempLimit.Name = "labelTempLimit";
            labelTempLimit.Size = new Size(140, 32);
            labelTempLimit.TabIndex = 47;
            labelTempLimit.Text = "Temp Limit";
            // 
            // panelDownload
            // 
            panelDownload.AutoSize = true;
            panelDownload.Controls.Add(buttonDownload);
            panelDownload.Dock = DockStyle.Top;
            panelDownload.Location = new Point(0, 0);
            panelDownload.Name = "panelDownload";
            panelDownload.Padding = new Padding(20);
            panelDownload.Size = new Size(520, 104);
            panelDownload.TabIndex = 52;
            panelDownload.Visible = false;
            // 
            // buttonDownload
            // 
            buttonDownload.Activated = false;
            buttonDownload.AutoSize = true;
            buttonDownload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDownload.BackColor = SystemColors.ControlLight;
            buttonDownload.BorderColor = Color.Transparent;
            buttonDownload.BorderRadius = 2;
            buttonDownload.Dock = DockStyle.Top;
            buttonDownload.FlatStyle = FlatStyle.Flat;
            buttonDownload.Location = new Point(20, 20);
            buttonDownload.Margin = new Padding(20);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Padding = new Padding(10);
            buttonDownload.Secondary = true;
            buttonDownload.Size = new Size(480, 64);
            buttonDownload.TabIndex = 19;
            buttonDownload.Text = "Download Advanced Settings Plugin";
            buttonDownload.UseVisualStyleBackColor = false;
            // 
            // panelPower
            // 
            panelPower.AutoSize = true;
            panelPower.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPower.Controls.Add(panelApplyPower);
            panelPower.Controls.Add(panelCPU);
            panelPower.Controls.Add(panelFast);
            panelPower.Controls.Add(panelSlow);
            panelPower.Controls.Add(panelTotal);
            panelPower.Controls.Add(panelTitleCPU);
            panelPower.Controls.Add(panelEPP);
            panelPower.Controls.Add(panelEPPTitle);
            panelPower.Controls.Add(panelBoost);
            panelPower.Controls.Add(panelBoostTitle);
            panelPower.Controls.Add(panelPowerMode);
            panelPower.Controls.Add(panelPowerModeTItle);
            panelPower.Dock = DockStyle.Top;
            panelPower.Location = new Point(10, 888);
            panelPower.Margin = new Padding(4);
            panelPower.Name = "panelPower";
            panelPower.Size = new Size(520, 880);
            panelPower.TabIndex = 43;
            // 
            // panelApplyPower
            // 
            panelApplyPower.AutoSize = true;
            panelApplyPower.Controls.Add(checkApplyPower);
            panelApplyPower.Dock = DockStyle.Top;
            panelApplyPower.Location = new Point(0, 804);
            panelApplyPower.Name = "panelApplyPower";
            panelApplyPower.Padding = new Padding(15);
            panelApplyPower.Size = new Size(520, 76);
            panelApplyPower.TabIndex = 47;
            // 
            // checkApplyPower
            // 
            checkApplyPower.BackColor = SystemColors.ControlLight;
            checkApplyPower.Dock = DockStyle.Top;
            checkApplyPower.Location = new Point(15, 15);
            checkApplyPower.Margin = new Padding(0);
            checkApplyPower.Name = "checkApplyPower";
            checkApplyPower.Padding = new Padding(16, 6, 16, 6);
            checkApplyPower.Size = new Size(490, 46);
            checkApplyPower.TabIndex = 45;
            checkApplyPower.Text = "Apply Power Limits";
            checkApplyPower.UseVisualStyleBackColor = false;
            // 
            // panelCPU
            // 
            panelCPU.AutoSize = true;
            panelCPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelCPU.Controls.Add(labelCPU);
            panelCPU.Controls.Add(labelLeftCPU);
            panelCPU.Controls.Add(trackCPU);
            panelCPU.Dock = DockStyle.Top;
            panelCPU.Location = new Point(0, 680);
            panelCPU.Margin = new Padding(4);
            panelCPU.MaximumSize = new Size(0, 124);
            panelCPU.Name = "panelCPU";
            panelCPU.Size = new Size(520, 124);
            panelCPU.TabIndex = 41;
            // 
            // labelCPU
            // 
            labelCPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPU.Location = new Point(398, 8);
            labelCPU.Margin = new Padding(4, 0, 4, 0);
            labelCPU.Name = "labelCPU";
            labelCPU.Size = new Size(116, 32);
            labelCPU.TabIndex = 13;
            labelCPU.Text = "CPU";
            labelCPU.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftCPU
            // 
            labelLeftCPU.AutoSize = true;
            labelLeftCPU.Location = new Point(10, 8);
            labelLeftCPU.Margin = new Padding(4, 0, 4, 0);
            labelLeftCPU.Name = "labelLeftCPU";
            labelLeftCPU.Size = new Size(58, 32);
            labelLeftCPU.TabIndex = 12;
            labelLeftCPU.Text = "CPU";
            // 
            // trackCPU
            // 
            trackCPU.Location = new Point(6, 44);
            trackCPU.Margin = new Padding(4, 2, 4, 2);
            trackCPU.Maximum = 85;
            trackCPU.Minimum = 5;
            trackCPU.Name = "trackCPU";
            trackCPU.Size = new Size(508, 90);
            trackCPU.TabIndex = 11;
            trackCPU.TickFrequency = 5;
            trackCPU.TickStyle = TickStyle.TopLeft;
            trackCPU.Value = 80;
            // 
            // panelFast
            // 
            panelFast.AutoSize = true;
            panelFast.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFast.Controls.Add(labelFast);
            panelFast.Controls.Add(labelLeftFast);
            panelFast.Controls.Add(trackFast);
            panelFast.Dock = DockStyle.Top;
            panelFast.Location = new Point(0, 556);
            panelFast.Margin = new Padding(4);
            panelFast.MaximumSize = new Size(0, 124);
            panelFast.Name = "panelFast";
            panelFast.Size = new Size(520, 124);
            panelFast.TabIndex = 45;
            // 
            // labelFast
            // 
            labelFast.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFast.Location = new Point(396, 8);
            labelFast.Margin = new Padding(4, 0, 4, 0);
            labelFast.Name = "labelFast";
            labelFast.Size = new Size(114, 32);
            labelFast.TabIndex = 13;
            labelFast.Text = "FPPT";
            labelFast.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftFast
            // 
            labelLeftFast.AutoSize = true;
            labelLeftFast.Location = new Point(10, 8);
            labelLeftFast.Margin = new Padding(4, 0, 4, 0);
            labelLeftFast.Name = "labelLeftFast";
            labelLeftFast.Size = new Size(65, 32);
            labelLeftFast.TabIndex = 12;
            labelLeftFast.Text = "FPPT";
            // 
            // trackFast
            // 
            trackFast.Location = new Point(6, 48);
            trackFast.Margin = new Padding(4, 2, 4, 2);
            trackFast.Maximum = 85;
            trackFast.Minimum = 5;
            trackFast.Name = "trackFast";
            trackFast.Size = new Size(508, 90);
            trackFast.TabIndex = 11;
            trackFast.TickFrequency = 5;
            trackFast.TickStyle = TickStyle.TopLeft;
            trackFast.Value = 80;
            // 
            // panelSlow
            // 
            panelSlow.AutoSize = true;
            panelSlow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSlow.Controls.Add(labelSlow);
            panelSlow.Controls.Add(labelLeftSlow);
            panelSlow.Controls.Add(trackSlow);
            panelSlow.Dock = DockStyle.Top;
            panelSlow.Location = new Point(0, 432);
            panelSlow.Margin = new Padding(4);
            panelSlow.MaximumSize = new Size(0, 124);
            panelSlow.Name = "panelSlow";
            panelSlow.Size = new Size(520, 124);
            panelSlow.TabIndex = 51;
            // 
            // labelSlow
            // 
            labelSlow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSlow.Location = new Point(396, 10);
            labelSlow.Margin = new Padding(4, 0, 4, 0);
            labelSlow.Name = "labelSlow";
            labelSlow.Size = new Size(116, 32);
            labelSlow.TabIndex = 12;
            labelSlow.Text = "SPPT";
            labelSlow.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftSlow
            // 
            labelLeftSlow.AutoSize = true;
            labelLeftSlow.Location = new Point(10, 10);
            labelLeftSlow.Margin = new Padding(4, 0, 4, 0);
            labelLeftSlow.Name = "labelLeftSlow";
            labelLeftSlow.Size = new Size(66, 32);
            labelLeftSlow.TabIndex = 11;
            labelLeftSlow.Text = "SPPT";
            // 
            // trackSlow
            // 
            trackSlow.Location = new Point(6, 48);
            trackSlow.Margin = new Padding(4, 2, 4, 2);
            trackSlow.Maximum = 180;
            trackSlow.Minimum = 10;
            trackSlow.Name = "trackSlow";
            trackSlow.Size = new Size(508, 90);
            trackSlow.TabIndex = 10;
            trackSlow.TickFrequency = 5;
            trackSlow.TickStyle = TickStyle.TopLeft;
            trackSlow.Value = 125;
            // 
            // panelTotal
            // 
            panelTotal.AutoSize = true;
            panelTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTotal.Controls.Add(labelTotal);
            panelTotal.Controls.Add(labelLeftTotal);
            panelTotal.Controls.Add(trackTotal);
            panelTotal.Dock = DockStyle.Top;
            panelTotal.Location = new Point(0, 308);
            panelTotal.Margin = new Padding(4);
            panelTotal.MaximumSize = new Size(0, 124);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(520, 124);
            panelTotal.TabIndex = 40;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.Location = new Point(396, 10);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(116, 32);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "SPL";
            labelTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftTotal
            // 
            labelLeftTotal.AutoSize = true;
            labelLeftTotal.Location = new Point(10, 10);
            labelLeftTotal.Margin = new Padding(4, 0, 4, 0);
            labelLeftTotal.Name = "labelLeftTotal";
            labelLeftTotal.Size = new Size(51, 32);
            labelLeftTotal.TabIndex = 11;
            labelLeftTotal.Text = "SPL";
            // 
            // trackTotal
            // 
            trackTotal.Location = new Point(6, 48);
            trackTotal.Margin = new Padding(4, 2, 4, 2);
            trackTotal.Maximum = 180;
            trackTotal.Minimum = 10;
            trackTotal.Name = "trackTotal";
            trackTotal.Size = new Size(508, 90);
            trackTotal.TabIndex = 10;
            trackTotal.TickFrequency = 5;
            trackTotal.TickStyle = TickStyle.TopLeft;
            trackTotal.Value = 125;
            // 
            // panelTitleCPU
            // 
            panelTitleCPU.AutoSize = true;
            panelTitleCPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTitleCPU.Controls.Add(pictureBoxCPU);
            panelTitleCPU.Controls.Add(labelPowerLimits);
            panelTitleCPU.Dock = DockStyle.Top;
            panelTitleCPU.Location = new Point(0, 248);
            panelTitleCPU.Margin = new Padding(4);
            panelTitleCPU.Name = "panelTitleCPU";
            panelTitleCPU.Size = new Size(520, 60);
            panelTitleCPU.TabIndex = 42;
            // 
            // pictureBoxCPU
            // 
            pictureBoxCPU.BackgroundImage = Properties.Resources.icons8_processor_32;
            pictureBoxCPU.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCPU.InitialImage = null;
            pictureBoxCPU.Location = new Point(10, 18);
            pictureBoxCPU.Margin = new Padding(4, 2, 4, 10);
            pictureBoxCPU.Name = "pictureBoxCPU";
            pictureBoxCPU.Size = new Size(32, 32);
            pictureBoxCPU.TabIndex = 40;
            pictureBoxCPU.TabStop = false;
            // 
            // labelPowerLimits
            // 
            labelPowerLimits.AutoSize = true;
            labelPowerLimits.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPowerLimits.Location = new Point(46, 16);
            labelPowerLimits.Margin = new Padding(4, 0, 4, 0);
            labelPowerLimits.Name = "labelPowerLimits";
            labelPowerLimits.Size = new Size(160, 32);
            labelPowerLimits.TabIndex = 39;
            labelPowerLimits.Text = "Power Limits";
            // 
            // panelBoost
            // 
            panelBoost.Controls.Add(comboBoost);
            panelBoost.Dock = DockStyle.Top;
            panelBoost.Location = new Point(0, 184);
            panelBoost.Margin = new Padding(4);
            panelBoost.Name = "panelBoost";
            panelBoost.Size = new Size(520, 64);
            panelBoost.TabIndex = 13;
            // 
            // panelBoostTitle
            // 
            panelBoostTitle.AutoSize = true;
            panelBoostTitle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelBoostTitle.Controls.Add(pictureBoost);
            panelBoostTitle.Controls.Add(labelBoost);
            panelBoostTitle.Dock = DockStyle.Top;
            panelBoostTitle.Location = new Point(0, 124);
            panelBoostTitle.Margin = new Padding(4);
            panelBoostTitle.Name = "panelBoostTitle";
            panelBoostTitle.Size = new Size(520, 60);
            panelBoostTitle.TabIndex = 48;
            // 
            // pictureBoost
            // 
            pictureBoost.BackgroundImage = Properties.Resources.icons8_rocket_32;
            pictureBoost.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoost.InitialImage = null;
            pictureBoost.Location = new Point(10, 18);
            pictureBoost.Margin = new Padding(4, 2, 4, 10);
            pictureBoost.Name = "pictureBoost";
            pictureBoost.Size = new Size(32, 32);
            pictureBoost.TabIndex = 40;
            pictureBoost.TabStop = false;
            // 
            // labelBoost
            // 
            labelBoost.AutoSize = true;
            labelBoost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBoost.Location = new Point(46, 18);
            labelBoost.Margin = new Padding(4, 0, 4, 0);
            labelBoost.Name = "labelBoost";
            labelBoost.Size = new Size(133, 32);
            labelBoost.TabIndex = 39;
            labelBoost.Text = "CPU Boost";

            if (AppConfig.IsAlly())
            {
                //
                // panelEPP
                //
                panelEPP.Controls.Add(sliderEPP);
                panelEPP.Controls.Add(labelEPPSliderLeft);
                panelEPP.Controls.Add(labelEPPSliderRight);
                panelEPP.Dock = DockStyle.Top;
                panelEPP.Location = new Point(0, 184);
                panelEPP.Margin = new Padding(4);
                panelEPP.Name = "panelEPP";
                // panelEPP.Size = new Size(520, 90);
                panelTotal.MaximumSize = new Size(0, 124);
                panelEPP.TabIndex = 13;
                //
                // panelEPPTitle
                //
                panelEPPTitle.AutoSize = true;
                panelEPPTitle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                panelEPPTitle.Controls.Add(pictureEPP);
                panelEPPTitle.Controls.Add(labelEPP);
                panelEPPTitle.Dock = DockStyle.Top;
                panelEPPTitle.Location = new Point(0, 248);
                panelEPPTitle.Margin = new Padding(4);
                panelEPPTitle.Name = "panelEPPTitle";
                panelEPPTitle.Size = new Size(520, 60);
                panelEPPTitle.TabIndex = 49;
                //
                // labelEPP
                //
                labelEPP.AutoSize = true;
                labelEPP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                labelEPP.Location = new Point(46, 18);
                labelEPP.Margin = new Padding(4, 0, 4, 0);
                labelEPP.Name = "labelEPP";
                labelEPP.Size = new Size(133, 32);
                labelEPP.TabIndex = 39;
                labelEPP.Text = "EPP";
                //
                // pictureEPP
                //
                pictureEPP.BackgroundImage = Properties.Resources.icons8_leaf_48;
                pictureEPP.BackgroundImageLayout = ImageLayout.Zoom;
                pictureEPP.InitialImage = null;
                pictureEPP.Location = new Point(10, 18);
                pictureEPP.Margin = new Padding(4, 2, 4, 10);
                pictureEPP.Name = "pictureEPP";
                pictureEPP.Size = new Size(32, 32);
                pictureEPP.TabIndex = 40;
                pictureEPP.TabStop = false;
                // 
                // labelEPPSliderLeft
                // 
                labelEPPSliderLeft.AutoSize = true;
                labelEPPSliderLeft.Location = new Point(10, 10);
                labelEPPSliderLeft.Margin = new Padding(4, 0, 4, 0);
                labelEPPSliderLeft.Name = "labelEPPSliderLeft";
                labelEPPSliderLeft.Size = new Size(51, 32);
                labelEPPSliderLeft.TabIndex = 11;
                labelEPPSliderLeft.Text = "GPU Priority";
                // 
                // labelEPPSliderRight
                // 
                labelEPPSliderRight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
                labelEPPSliderRight.Location = new Point(396, 10);
                labelEPPSliderRight.Margin = new Padding(4, 0, 4, 0);
                labelEPPSliderRight.Name = "labelEPPSliderRight";
                labelEPPSliderRight.Size = new Size(116, 32);
                labelEPPSliderRight.TabIndex = 12;
                labelEPPSliderRight.Text = "%";
                labelEPPSliderRight.TextAlign = ContentAlignment.TopRight;
            }

            // 
            // panelPowerMode
            // 
            panelPowerMode.Controls.Add(comboPowerMode);
            panelPowerMode.Dock = DockStyle.Top;
            panelPowerMode.Location = new Point(0, 60);
            panelPowerMode.Margin = new Padding(4);
            panelPowerMode.Name = "panelPowerMode";
            panelPowerMode.Size = new Size(520, 64);
            panelPowerMode.TabIndex = 49;
            // 
            // comboPowerMode
            // 
            comboPowerMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboPowerMode.BorderColor = Color.White;
            comboPowerMode.ButtonColor = Color.FromArgb(255, 255, 255);
            comboPowerMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPowerMode.FormattingEnabled = true;
            comboPowerMode.Items.AddRange(new object[] { "Disabled", "Enabled", "Aggressive", "Efficient Enabled", "Efficient Aggressive", "Aggressive at Guaranteed", "Efficient at Guaranteed" });
            comboPowerMode.Location = new Point(13, 12);
            comboPowerMode.Margin = new Padding(4);
            comboPowerMode.Name = "comboPowerMode";
            comboPowerMode.Size = new Size(329, 40);
            comboPowerMode.TabIndex = 42;
            // 
            // panelPowerModeTItle
            // 
            panelPowerModeTItle.AutoSize = true;
            panelPowerModeTItle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPowerModeTItle.Controls.Add(picturePowerMode);
            panelPowerModeTItle.Controls.Add(labelPowerModeTitle);
            panelPowerModeTItle.Dock = DockStyle.Top;
            panelPowerModeTItle.Location = new Point(0, 0);
            panelPowerModeTItle.Margin = new Padding(4);
            panelPowerModeTItle.Name = "panelPowerModeTItle";
            panelPowerModeTItle.Size = new Size(520, 60);
            panelPowerModeTItle.TabIndex = 50;
            // 
            // picturePowerMode
            // 
            picturePowerMode.BackgroundImage = Properties.Resources.icons8_gauge_32;
            picturePowerMode.BackgroundImageLayout = ImageLayout.Zoom;
            picturePowerMode.InitialImage = null;
            picturePowerMode.Location = new Point(10, 18);
            picturePowerMode.Margin = new Padding(4, 2, 4, 10);
            picturePowerMode.Name = "picturePowerMode";
            picturePowerMode.Size = new Size(32, 32);
            picturePowerMode.TabIndex = 40;
            picturePowerMode.TabStop = false;
            // 
            // labelPowerModeTitle
            // 
            labelPowerModeTitle.AutoSize = true;
            labelPowerModeTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPowerModeTitle.Location = new Point(46, 18);
            labelPowerModeTitle.Margin = new Padding(4, 0, 4, 0);
            labelPowerModeTitle.Name = "labelPowerModeTitle";
            labelPowerModeTitle.Size = new Size(271, 32);
            labelPowerModeTitle.TabIndex = 39;
            labelPowerModeTitle.Text = "Windows Power Mode";
            // 
            // panelGPU
            // 
            panelGPU.AutoSize = true;
            panelGPU.Controls.Add(panelGPUTemp);
            panelGPU.Controls.Add(panelGPUBoost);
            panelGPU.Controls.Add(panelGPUPower);
            panelGPU.Controls.Add(panelGPUMemory);
            panelGPU.Controls.Add(panelGPUCore);
            panelGPU.Controls.Add(panelGPUClockLimit);
            panelGPU.Controls.Add(panelTitleGPU);
            panelGPU.Dock = DockStyle.Top;
            panelGPU.Location = new Point(10, 66);
            panelGPU.Margin = new Padding(4);
            panelGPU.Name = "panelGPU";
            panelGPU.Padding = new Padding(0, 0, 0, 18);
            panelGPU.Size = new Size(520, 822);
            panelGPU.TabIndex = 44;
            panelGPU.Visible = false;
            // 
            // panelGPUTemp
            // 
            panelGPUTemp.AutoSize = true;
            panelGPUTemp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUTemp.Controls.Add(labelGPUTemp);
            panelGPUTemp.Controls.Add(labelGPUTempTitle);
            panelGPUTemp.Controls.Add(trackGPUTemp);
            panelGPUTemp.Dock = DockStyle.Top;
            panelGPUTemp.Location = new Point(0, 680);
            panelGPUTemp.Margin = new Padding(4);
            panelGPUTemp.MaximumSize = new Size(0, 124);
            panelGPUTemp.Name = "panelGPUTemp";
            panelGPUTemp.Size = new Size(520, 124);
            panelGPUTemp.TabIndex = 47;
            // 
            // labelGPUTemp
            // 
            labelGPUTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUTemp.Location = new Point(378, 14);
            labelGPUTemp.Margin = new Padding(4, 0, 4, 0);
            labelGPUTemp.Name = "labelGPUTemp";
            labelGPUTemp.Size = new Size(124, 32);
            labelGPUTemp.TabIndex = 44;
            labelGPUTemp.Text = "87C";
            labelGPUTemp.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUTempTitle
            // 
            labelGPUTempTitle.AutoSize = true;
            labelGPUTempTitle.Location = new Point(10, 14);
            labelGPUTempTitle.Margin = new Padding(4, 0, 4, 0);
            labelGPUTempTitle.Name = "labelGPUTempTitle";
            labelGPUTempTitle.Size = new Size(173, 32);
            labelGPUTempTitle.TabIndex = 43;
            labelGPUTempTitle.Text = "Thermal Target";
            // 
            // trackGPUTemp
            // 
            trackGPUTemp.Location = new Point(6, 56);
            trackGPUTemp.Margin = new Padding(4, 2, 4, 2);
            trackGPUTemp.Maximum = 87;
            trackGPUTemp.Minimum = 75;
            trackGPUTemp.Name = "trackGPUTemp";
            trackGPUTemp.Size = new Size(496, 90);
            trackGPUTemp.TabIndex = 42;
            trackGPUTemp.TickFrequency = 5;
            trackGPUTemp.TickStyle = TickStyle.TopLeft;
            trackGPUTemp.Value = 87;
            // 
            // panelGPUBoost
            // 
            panelGPUBoost.AutoSize = true;
            panelGPUBoost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUBoost.Controls.Add(labelGPUBoost);
            panelGPUBoost.Controls.Add(labelGPUBoostTitle);
            panelGPUBoost.Controls.Add(trackGPUBoost);
            panelGPUBoost.Dock = DockStyle.Top;
            panelGPUBoost.Location = new Point(0, 556);
            panelGPUBoost.Margin = new Padding(4);
            panelGPUBoost.MaximumSize = new Size(0, 124);
            panelGPUBoost.Name = "panelGPUBoost";
            panelGPUBoost.Size = new Size(520, 124);
            panelGPUBoost.TabIndex = 46;
            // 
            // labelGPUBoost
            // 
            labelGPUBoost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUBoost.Location = new Point(374, 14);
            labelGPUBoost.Margin = new Padding(4, 0, 4, 0);
            labelGPUBoost.Name = "labelGPUBoost";
            labelGPUBoost.Size = new Size(124, 32);
            labelGPUBoost.TabIndex = 44;
            labelGPUBoost.Text = "25W";
            labelGPUBoost.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUBoostTitle
            // 
            labelGPUBoostTitle.AutoSize = true;
            labelGPUBoostTitle.Location = new Point(10, 14);
            labelGPUBoostTitle.Margin = new Padding(4, 0, 4, 0);
            labelGPUBoostTitle.Name = "labelGPUBoostTitle";
            labelGPUBoostTitle.Size = new Size(174, 32);
            labelGPUBoostTitle.TabIndex = 43;
            labelGPUBoostTitle.Text = "Dynamic Boost";
            // 
            // trackGPUBoost
            // 
            trackGPUBoost.Location = new Point(6, 48);
            trackGPUBoost.Margin = new Padding(4, 2, 4, 2);
            trackGPUBoost.Maximum = 25;
            trackGPUBoost.Minimum = 5;
            trackGPUBoost.Name = "trackGPUBoost";
            trackGPUBoost.Size = new Size(496, 90);
            trackGPUBoost.TabIndex = 42;
            trackGPUBoost.TickFrequency = 5;
            trackGPUBoost.TickStyle = TickStyle.TopLeft;
            trackGPUBoost.Value = 25;
            // 
            // panelGPUPower
            // 
            panelGPUPower.AutoSize = true;
            panelGPUPower.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUPower.Controls.Add(labelGPUPower);
            panelGPUPower.Controls.Add(labelGPUPowerTitle);
            panelGPUPower.Controls.Add(trackGPUPower);
            panelGPUPower.Dock = DockStyle.Top;
            panelGPUPower.Location = new Point(0, 432);
            panelGPUPower.Margin = new Padding(4);
            panelGPUPower.MaximumSize = new Size(0, 124);
            panelGPUPower.Name = "panelGPUPower";
            panelGPUPower.Size = new Size(520, 124);
            panelGPUPower.TabIndex = 49;
            // 
            // labelGPUPower
            // 
            labelGPUPower.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUPower.Location = new Point(374, 14);
            labelGPUPower.Margin = new Padding(4, 0, 4, 0);
            labelGPUPower.Name = "labelGPUPower";
            labelGPUPower.Size = new Size(124, 32);
            labelGPUPower.TabIndex = 44;
            labelGPUPower.Text = "105W";
            labelGPUPower.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUPowerTitle
            // 
            labelGPUPowerTitle.AutoSize = true;
            labelGPUPowerTitle.Location = new Point(10, 14);
            labelGPUPowerTitle.Margin = new Padding(4, 0, 4, 0);
            labelGPUPowerTitle.Name = "labelGPUPowerTitle";
            labelGPUPowerTitle.Size = new Size(130, 32);
            labelGPUPowerTitle.TabIndex = 43;
            labelGPUPowerTitle.Text = "GPU Power";
            // 
            // trackGPUPower
            // 
            trackGPUPower.Location = new Point(6, 48);
            trackGPUPower.Margin = new Padding(4, 2, 4, 2);
            trackGPUPower.Maximum = 25;
            trackGPUPower.Minimum = 5;
            trackGPUPower.Name = "trackGPUPower";
            trackGPUPower.Size = new Size(496, 90);
            trackGPUPower.TabIndex = 42;
            trackGPUPower.TickFrequency = 5;
            trackGPUPower.TickStyle = TickStyle.TopLeft;
            trackGPUPower.Value = 25;
            // 
            // panelGPUMemory
            // 
            panelGPUMemory.AutoSize = true;
            panelGPUMemory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUMemory.Controls.Add(labelGPUMemory);
            panelGPUMemory.Controls.Add(labelGPUMemoryTitle);
            panelGPUMemory.Controls.Add(trackGPUMemory);
            panelGPUMemory.Dock = DockStyle.Top;
            panelGPUMemory.Location = new Point(0, 308);
            panelGPUMemory.Margin = new Padding(4);
            panelGPUMemory.MaximumSize = new Size(0, 124);
            panelGPUMemory.Name = "panelGPUMemory";
            panelGPUMemory.Size = new Size(520, 124);
            panelGPUMemory.TabIndex = 45;
            // 
            // labelGPUMemory
            // 
            labelGPUMemory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUMemory.Location = new Point(344, 14);
            labelGPUMemory.Margin = new Padding(4, 0, 4, 0);
            labelGPUMemory.Name = "labelGPUMemory";
            labelGPUMemory.Size = new Size(160, 32);
            labelGPUMemory.TabIndex = 44;
            labelGPUMemory.Text = "2000 MHz";
            labelGPUMemory.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUMemoryTitle
            // 
            labelGPUMemoryTitle.AutoSize = true;
            labelGPUMemoryTitle.Location = new Point(10, 14);
            labelGPUMemoryTitle.Margin = new Padding(4, 0, 4, 0);
            labelGPUMemoryTitle.Name = "labelGPUMemoryTitle";
            labelGPUMemoryTitle.Size = new Size(241, 32);
            labelGPUMemoryTitle.TabIndex = 43;
            labelGPUMemoryTitle.Text = "Memory Clock Offset";
            // 
            // trackGPUMemory
            // 
            trackGPUMemory.LargeChange = 100;
            trackGPUMemory.Location = new Point(6, 48);
            trackGPUMemory.Margin = new Padding(4, 2, 4, 2);
            trackGPUMemory.Maximum = 300;
            trackGPUMemory.Name = "trackGPUMemory";
            trackGPUMemory.Size = new Size(496, 90);
            trackGPUMemory.SmallChange = 10;
            trackGPUMemory.TabIndex = 42;
            trackGPUMemory.TickFrequency = 50;
            trackGPUMemory.TickStyle = TickStyle.TopLeft;
            // 
            // panelGPUCore
            // 
            panelGPUCore.AutoSize = true;
            panelGPUCore.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUCore.Controls.Add(labelGPUCore);
            panelGPUCore.Controls.Add(trackGPUCore);
            panelGPUCore.Controls.Add(labelGPUCoreTitle);
            panelGPUCore.Dock = DockStyle.Top;
            panelGPUCore.Location = new Point(0, 184);
            panelGPUCore.Margin = new Padding(4);
            panelGPUCore.MaximumSize = new Size(0, 124);
            panelGPUCore.Name = "panelGPUCore";
            panelGPUCore.Size = new Size(520, 124);
            panelGPUCore.TabIndex = 44;
            // 
            // labelGPUCore
            // 
            labelGPUCore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUCore.Location = new Point(326, 16);
            labelGPUCore.Margin = new Padding(4, 0, 4, 0);
            labelGPUCore.Name = "labelGPUCore";
            labelGPUCore.Size = new Size(176, 32);
            labelGPUCore.TabIndex = 29;
            labelGPUCore.Text = "1500 MHz";
            labelGPUCore.TextAlign = ContentAlignment.TopRight;
            // 
            // trackGPUCore
            // 
            trackGPUCore.LargeChange = 100;
            trackGPUCore.Location = new Point(6, 48);
            trackGPUCore.Margin = new Padding(4, 2, 4, 2);
            trackGPUCore.Maximum = 300;
            trackGPUCore.Name = "trackGPUCore";
            trackGPUCore.RightToLeft = RightToLeft.No;
            trackGPUCore.Size = new Size(496, 90);
            trackGPUCore.SmallChange = 10;
            trackGPUCore.TabIndex = 18;
            trackGPUCore.TickFrequency = 50;
            trackGPUCore.TickStyle = TickStyle.TopLeft;
            // 
            // labelGPUCoreTitle
            // 
            labelGPUCoreTitle.AutoSize = true;
            labelGPUCoreTitle.Location = new Point(10, 16);
            labelGPUCoreTitle.Margin = new Padding(4, 0, 4, 0);
            labelGPUCoreTitle.Name = "labelGPUCoreTitle";
            labelGPUCoreTitle.Size = new Size(201, 32);
            labelGPUCoreTitle.TabIndex = 17;
            labelGPUCoreTitle.Text = "Core Clock Offset";
            // 
            // panelGPUClockLimit
            // 
            panelGPUClockLimit.AutoSize = true;
            panelGPUClockLimit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUClockLimit.Controls.Add(labelGPUClockLimit);
            panelGPUClockLimit.Controls.Add(trackGPUClockLimit);
            panelGPUClockLimit.Controls.Add(labelGPUClockLimitTitle);
            panelGPUClockLimit.Dock = DockStyle.Top;
            panelGPUClockLimit.Location = new Point(0, 60);
            panelGPUClockLimit.Margin = new Padding(4);
            panelGPUClockLimit.MaximumSize = new Size(0, 124);
            panelGPUClockLimit.Name = "panelGPUClockLimit";
            panelGPUClockLimit.Size = new Size(520, 124);
            panelGPUClockLimit.TabIndex = 48;
            // 
            // labelGPUClockLimit
            // 
            labelGPUClockLimit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPUClockLimit.Location = new Point(326, 16);
            labelGPUClockLimit.Margin = new Padding(4, 0, 4, 0);
            labelGPUClockLimit.Name = "labelGPUClockLimit";
            labelGPUClockLimit.Size = new Size(176, 32);
            labelGPUClockLimit.TabIndex = 29;
            labelGPUClockLimit.Text = "1500 MHz";
            labelGPUClockLimit.TextAlign = ContentAlignment.TopRight;
            // 
            // trackGPUClockLimit
            // 
            trackGPUClockLimit.LargeChange = 100;
            trackGPUClockLimit.Location = new Point(6, 48);
            trackGPUClockLimit.Margin = new Padding(4, 2, 4, 2);
            trackGPUClockLimit.Maximum = 3000;
            trackGPUClockLimit.Name = "trackGPUClockLimit";
            trackGPUClockLimit.RightToLeft = RightToLeft.No;
            trackGPUClockLimit.Size = new Size(496, 90);
            trackGPUClockLimit.SmallChange = 10;
            trackGPUClockLimit.TabIndex = 18;
            trackGPUClockLimit.TickFrequency = 50;
            trackGPUClockLimit.TickStyle = TickStyle.TopLeft;
            // 
            // labelGPUClockLimitTitle
            // 
            labelGPUClockLimitTitle.AutoSize = true;
            labelGPUClockLimitTitle.Location = new Point(10, 16);
            labelGPUClockLimitTitle.Margin = new Padding(4, 0, 4, 0);
            labelGPUClockLimitTitle.Name = "labelGPUClockLimitTitle";
            labelGPUClockLimitTitle.Size = new Size(188, 32);
            labelGPUClockLimitTitle.TabIndex = 17;
            labelGPUClockLimitTitle.Text = "Core Clock Limit";
            // 
            // panelTitleGPU
            // 
            panelTitleGPU.AutoSize = true;
            panelTitleGPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTitleGPU.Controls.Add(pictureGPU);
            panelTitleGPU.Controls.Add(labelGPU);
            panelTitleGPU.Dock = DockStyle.Top;
            panelTitleGPU.Location = new Point(0, 0);
            panelTitleGPU.Margin = new Padding(4);
            panelTitleGPU.Name = "panelTitleGPU";
            panelTitleGPU.Size = new Size(520, 60);
            panelTitleGPU.TabIndex = 43;
            // 
            // pictureGPU
            // 
            pictureGPU.BackgroundImage = Properties.Resources.icons8_video_card_32;
            pictureGPU.BackgroundImageLayout = ImageLayout.Zoom;
            pictureGPU.ErrorImage = null;
            pictureGPU.InitialImage = null;
            pictureGPU.Location = new Point(10, 18);
            pictureGPU.Margin = new Padding(4, 2, 4, 10);
            pictureGPU.Name = "pictureGPU";
            pictureGPU.Size = new Size(32, 32);
            pictureGPU.TabIndex = 41;
            pictureGPU.TabStop = false;
            // 
            // labelGPU
            // 
            labelGPU.AutoSize = true;
            labelGPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPU.Location = new Point(45, 17);
            labelGPU.Margin = new Padding(4, 0, 4, 0);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(162, 32);
            labelGPU.TabIndex = 40;
            labelGPU.Text = "GPU Settings";
            // 
            // panelNav
            // 
            panelNav.AutoSize = true;
            panelNav.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNav.Controls.Add(tableNav);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(10, 0);
            panelNav.Margin = new Padding(4);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(520, 66);
            panelNav.TabIndex = 45;
            // 
            // tableNav
            // 
            tableNav.ColumnCount = 3;
            tableNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableNav.Controls.Add(buttonAdvanced, 0, 0);
            tableNav.Controls.Add(buttonGPU, 0, 0);
            tableNav.Controls.Add(buttonCPU, 0, 0);
            tableNav.Dock = DockStyle.Top;
            tableNav.Location = new Point(0, 0);
            tableNav.MinimumSize = new Size(0, 62);
            tableNav.Name = "tableNav";
            tableNav.Padding = new Padding(0, 3, 0, 1);
            tableNav.RowCount = 1;
            tableNav.RowStyles.Add(new RowStyle());
            tableNav.Size = new Size(520, 66);
            tableNav.TabIndex = 42;
            // 
            // buttonAdvanced
            // 
            buttonAdvanced.Activated = false;
            buttonAdvanced.BackColor = SystemColors.ControlLight;
            buttonAdvanced.BorderColor = Color.Transparent;
            buttonAdvanced.BorderRadius = 2;
            buttonAdvanced.Dock = DockStyle.Fill;
            buttonAdvanced.FlatStyle = FlatStyle.Flat;
            buttonAdvanced.Location = new Point(350, 5);
            buttonAdvanced.Margin = new Padding(4, 2, 4, 2);
            buttonAdvanced.Name = "buttonAdvanced";
            buttonAdvanced.Secondary = true;
            buttonAdvanced.Size = new Size(166, 58);
            buttonAdvanced.TabIndex = 51;
            buttonAdvanced.Text = "Advanced";
            buttonAdvanced.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdvanced.UseVisualStyleBackColor = false;
            // 
            // buttonGPU
            // 
            buttonGPU.Activated = false;
            buttonGPU.BackColor = SystemColors.ControlLight;
            buttonGPU.BorderColor = Color.Transparent;
            buttonGPU.BorderRadius = 2;
            buttonGPU.Dock = DockStyle.Fill;
            buttonGPU.FlatStyle = FlatStyle.Flat;
            buttonGPU.Location = new Point(177, 5);
            buttonGPU.Margin = new Padding(4, 2, 4, 2);
            buttonGPU.Name = "buttonGPU";
            buttonGPU.Secondary = true;
            buttonGPU.Size = new Size(165, 58);
            buttonGPU.TabIndex = 52;
            buttonGPU.Text = "GPU";
            buttonGPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGPU.UseVisualStyleBackColor = false;
            // 
            // buttonCPU
            // 
            buttonCPU.Activated = false;
            buttonCPU.BackColor = SystemColors.ControlLight;
            buttonCPU.BorderColor = Color.Transparent;
            buttonCPU.BorderRadius = 2;
            buttonCPU.Dock = DockStyle.Fill;
            buttonCPU.FlatStyle = FlatStyle.Flat;
            buttonCPU.Location = new Point(4, 5);
            buttonCPU.Margin = new Padding(4, 2, 4, 2);
            buttonCPU.Name = "buttonCPU";
            buttonCPU.Secondary = true;
            buttonCPU.Size = new Size(165, 58);
            buttonCPU.TabIndex = 50;
            buttonCPU.Text = "CPU";
            buttonCPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCPU.UseVisualStyleBackColor = false;
            // 
            // Fans
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1350, 2119);
            Controls.Add(panelFans);
            Controls.Add(panelSliders);
            Margin = new Padding(4, 2, 4, 2);
            MinimizeBox = false;
            MinimumSize = new Size(26, 1100);
            Name = "Fans";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Fans and Power";
            panelFans.ResumeLayout(false);
            panelFans.PerformLayout();
            tableFanCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartXGM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMid).EndInit();
            panelTitleFans.ResumeLayout(false);
            panelTitleFans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerf).EndInit();
            panelApplyFans.ResumeLayout(false);
            panelApplyFans.PerformLayout();
            panelSliders.ResumeLayout(false);
            panelSliders.PerformLayout();
            panelAdvanced.ResumeLayout(false);
            panelAdvanced.PerformLayout();
            panelAdvancedAlways.ResumeLayout(false);
            panelAdvancedApply.ResumeLayout(false);
            panelUViGPU.ResumeLayout(false);
            panelUViGPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackUViGPU).EndInit();
            panelUV.ResumeLayout(false);
            panelUV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackUV).EndInit();
            panelTitleAdvanced.ResumeLayout(false);
            panelTitleAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUV).EndInit();
            panelTemperature.ResumeLayout(false);
            panelTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackTemp).EndInit();
            panelTitleTemp.ResumeLayout(false);
            panelTitleTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTemp).EndInit();
            panelDownload.ResumeLayout(false);
            panelDownload.PerformLayout();
            panelPower.ResumeLayout(false);
            panelPower.PerformLayout();
            panelApplyPower.ResumeLayout(false);
            panelCPU.ResumeLayout(false);
            panelCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackCPU).EndInit();
            panelFast.ResumeLayout(false);
            panelFast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackFast).EndInit();
            panelSlow.ResumeLayout(false);
            panelSlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackSlow).EndInit();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackTotal).EndInit();
            panelTitleCPU.ResumeLayout(false);
            panelTitleCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCPU).EndInit();
            panelBoost.ResumeLayout(false);
            panelBoostTitle.ResumeLayout(false);
            panelBoostTitle.PerformLayout();
            panelEPP.ResumeLayout(false);
            panelEPPTitle.ResumeLayout(false);
            panelEPPTitle.PerformLayout();
            labelEPPSliderLeft.ResumeLayout(false);
            labelEPPSliderRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureEPP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoost).EndInit();
            panelPowerMode.ResumeLayout(false);
            panelPowerModeTItle.ResumeLayout(false);
            panelPowerModeTItle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePowerMode).EndInit();
            panelGPU.ResumeLayout(false);
            panelGPU.PerformLayout();
            panelGPUTemp.ResumeLayout(false);
            panelGPUTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUTemp).EndInit();
            panelGPUBoost.ResumeLayout(false);
            panelGPUBoost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUBoost).EndInit();
            panelGPUPower.ResumeLayout(false);
            panelGPUPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUPower).EndInit();
            panelGPUMemory.ResumeLayout(false);
            panelGPUMemory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUMemory).EndInit();
            panelGPUCore.ResumeLayout(false);
            panelGPUCore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUCore).EndInit();
            panelGPUClockLimit.ResumeLayout(false);
            panelGPUClockLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUClockLimit).EndInit();
            panelTitleGPU.ResumeLayout(false);
            panelTitleGPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGPU).EndInit();
            panelNav.ResumeLayout(false);
            tableNav.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelFans;
        private Panel panelSliders;
        private TableLayoutPanel tableFanCharts;
        private Chart chartGPU;
        private Chart chartCPU;
        private Chart chartMid;
        private Chart chartXGM;
        private Label labelTip;
        private Panel panelPower;
        private Panel panelCPU;
        private Label labelCPU;
        private Label labelLeftCPU;
        private TrackBar trackCPU;
        private Panel panelTotal;
        private Label labelTotal;
        private Label labelLeftTotal;
        private TrackBar trackTotal;
        private Panel panelTitleCPU;
        private PictureBox pictureBoxCPU;
        private Label labelPowerLimits;
        private Panel panelGPU;
        private Panel panelGPUMemory;
        private Label labelGPUMemory;
        private Label labelGPUMemoryTitle;
        private TrackBar trackGPUMemory;
        private Panel panelGPUCore;
        private Label labelGPUCore;
        private TrackBar trackGPUCore;
        private Label labelGPUCoreTitle;
        private Panel panelTitleGPU;
        private PictureBox pictureGPU;
        private Label labelGPU;
        private RCheckBox checkApplyPower;
        private Panel panelGPUBoost;
        private Label labelGPUBoost;
        private Label labelGPUBoostTitle;
        private TrackBar trackGPUBoost;
        private Panel panelGPUTemp;
        private Label labelGPUTemp;
        private Label labelGPUTempTitle;
        private TrackBar trackGPUTemp;
        private Panel panelTitleFans;
        private Panel panelApplyFans;
        private Label labelFansResult;
        private RCheckBox checkApplyFans;
        private RButton buttonReset;
        private Label labelBoost;
        private Label labelEPP;
        private RComboBox comboBoost;
        private TrackBar sliderEPP;
        private PictureBox picturePerf;
        private Label labelFans;
        private Panel panelFast;
        private Label labelFast;
        private Label labelLeftFast;
        private TrackBar trackFast;
        private Panel panelBoost;
        private Panel panelEPP;
        private Panel panelEPPTitle;
        private Label labelEPPSliderLeft;
        private Label labelEPPSliderRight;
        private PictureBox pictureEPP;
        private RComboBox comboModes;
        private RButton buttonAdd;
        private RButton buttonRemove;
        private RButton buttonRename;
        private Panel panelUV;
        private Label labelUV;
        private Label labelLeftUV;
        private TrackBar trackUV;
        private PictureBox pictureUV;
        private Label labelTitleUV;
        private RButton buttonApplyAdvanced;
        private Panel panelApplyPower;
        private Panel panelAdvanced;
        private Panel panelAdvancedApply;
        private Panel panelTitleAdvanced;
        private Panel panelUViGPU;
        private Label labelUViGPU;
        private Label labelLeftUViGPU;
        private TrackBar trackUViGPU;
        private Panel panelNav;
        private TableLayoutPanel tableNav;
        private RButton buttonCPU;
        private RButton buttonGPU;
        private RButton buttonAdvanced;
        private Panel panelBoostTitle;
        private PictureBox pictureBoost;
        private Label labelBoostTitle;
        private Label labelRisky;
        private Panel panelTitleTemp;
        private PictureBox pictureTemp;
        private Label labelTempLimit;
        private Panel panelTemperature;
        private Label labelTemp;
        private Label labelLeftTemp;
        private TrackBar trackTemp;
        private Panel panelAdvancedAlways;
        private RCheckBox checkApplyUV;
        private Panel panelPowerMode;
        private RComboBox comboPowerMode;
        private Panel panelPowerModeTItle;
        private PictureBox picturePowerMode;
        private Label labelPowerModeTitle;
        private Panel panelGPUClockLimit;
        private Label labelGPUClockLimit;
        private TrackBar trackGPUClockLimit;
        private Label labelGPUClockLimitTitle;
        private RButton buttonCalibrate;
        private Panel panelSlow;
        private Label labelSlow;
        private Label labelLeftSlow;
        private TrackBar trackSlow;
        private Panel panelDownload;
        private RButton buttonDownload;
        private Panel panelGPUPower;
        private Label labelGPUPower;
        private Label labelGPUPowerTitle;
        private TrackBar trackGPUPower;
    }
}