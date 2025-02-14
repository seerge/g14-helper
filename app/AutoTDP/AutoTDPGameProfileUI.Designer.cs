namespace GHelper.AutoTDP
{
    partial class AutoTDPGameProfileUI
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
            panelPerformanceHeader = new Panel();
            pictureKeyboard = new PictureBox();
            labelSettings = new Label();
            checkBoxEnabled = new CheckBox();
            panelGameSettings = new Panel();
            sliderCheckInterval = new UI.Slider();
            numericCheckInterval = new NumericUpDown();
            labelCheckInterval = new Label();
            sliderFPS = new UI.Slider();
            labelMinTDP = new Label();
            labelMaxTDP = new Label();
            sliderMaxTDP = new UI.Slider();
            numericUpDownFPS = new NumericUpDown();
            sliderMinTDP = new UI.Slider();
            labelMaxTDPText = new Label();
            labeMinTDPText = new Label();
            labelTargetFPS = new Label();
            textBoxTitle = new TextBox();
            textBoxProcessName = new TextBox();
            labelFPSSource = new Label();
            labelLimiter = new Label();
            buttonSave = new UI.RButton();
            buttonDelete = new UI.RButton();
            panelPerformanceHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKeyboard).BeginInit();
            panelGameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCheckInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFPS).BeginInit();
            SuspendLayout();
            // 
            // panelPerformanceHeader
            // 
            panelPerformanceHeader.BackColor = SystemColors.ControlLight;
            panelPerformanceHeader.Controls.Add(pictureKeyboard);
            panelPerformanceHeader.Controls.Add(labelSettings);
            panelPerformanceHeader.Controls.Add(checkBoxEnabled);
            panelPerformanceHeader.Dock = DockStyle.Top;
            panelPerformanceHeader.Location = new Point(0, 0);
            panelPerformanceHeader.Margin = new Padding(2);
            panelPerformanceHeader.Name = "panelPerformanceHeader";
            panelPerformanceHeader.Size = new Size(386, 30);
            panelPerformanceHeader.TabIndex = 53;
            // 
            // pictureKeyboard
            // 
            pictureKeyboard.BackgroundImage = Properties.Resources.icons8_automation_32;
            pictureKeyboard.BackgroundImageLayout = ImageLayout.Zoom;
            pictureKeyboard.Location = new Point(3, 8);
            pictureKeyboard.Margin = new Padding(2);
            pictureKeyboard.Name = "pictureKeyboard";
            pictureKeyboard.Size = new Size(16, 16);
            pictureKeyboard.TabIndex = 35;
            pictureKeyboard.TabStop = false;
            // 
            // labelSettings
            // 
            labelSettings.AutoSize = true;
            labelSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSettings.Location = new Point(22, 8);
            labelSettings.Margin = new Padding(4, 0, 4, 0);
            labelSettings.Name = "labelSettings";
            labelSettings.Size = new Size(89, 15);
            labelSettings.TabIndex = 34;
            labelSettings.Text = "Game Settings";
            // 
            // checkBoxEnabled
            // 
            checkBoxEnabled.Location = new Point(241, 2);
            checkBoxEnabled.Margin = new Padding(4, 0, 4, 0);
            checkBoxEnabled.Name = "checkBoxEnabled";
            checkBoxEnabled.Size = new Size(136, 25);
            checkBoxEnabled.TabIndex = 53;
            checkBoxEnabled.Text = "Enabled";
            checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // panelGameSettings
            // 
            panelGameSettings.AutoSize = true;
            panelGameSettings.Controls.Add(sliderCheckInterval);
            panelGameSettings.Controls.Add(numericCheckInterval);
            panelGameSettings.Controls.Add(labelCheckInterval);
            panelGameSettings.Controls.Add(sliderFPS);
            panelGameSettings.Controls.Add(labelMinTDP);
            panelGameSettings.Controls.Add(labelMaxTDP);
            panelGameSettings.Controls.Add(sliderMaxTDP);
            panelGameSettings.Controls.Add(numericUpDownFPS);
            panelGameSettings.Controls.Add(sliderMinTDP);
            panelGameSettings.Controls.Add(labelMaxTDPText);
            panelGameSettings.Controls.Add(labeMinTDPText);
            panelGameSettings.Controls.Add(labelTargetFPS);
            panelGameSettings.Controls.Add(textBoxTitle);
            panelGameSettings.Controls.Add(textBoxProcessName);
            panelGameSettings.Controls.Add(labelFPSSource);
            panelGameSettings.Controls.Add(labelLimiter);
            panelGameSettings.Dock = DockStyle.Top;
            panelGameSettings.Location = new Point(0, 30);
            panelGameSettings.Margin = new Padding(2);
            panelGameSettings.Name = "panelGameSettings";
            panelGameSettings.Padding = new Padding(0, 0, 0, 7);
            panelGameSettings.Size = new Size(386, 174);
            panelGameSettings.TabIndex = 57;
            // 
            // sliderCheckInterval
            // 
            sliderCheckInterval.AccessibleName = "DPI Slider";
            sliderCheckInterval.Location = new Point(140, 145);
            sliderCheckInterval.Margin = new Padding(2);
            sliderCheckInterval.Max = 5000;
            sliderCheckInterval.Min = 16;
            sliderCheckInterval.Name = "sliderCheckInterval";
            sliderCheckInterval.Size = new Size(168, 20);
            sliderCheckInterval.Step = 1;
            sliderCheckInterval.TabIndex = 71;
            sliderCheckInterval.TabStop = false;
            sliderCheckInterval.Text = "FPS Slider";
            sliderCheckInterval.Value = 500;
            // 
            // numericCheckInterval
            // 
            numericCheckInterval.BorderStyle = BorderStyle.None;
            numericCheckInterval.Location = new Point(312, 145);
            numericCheckInterval.Margin = new Padding(2);
            numericCheckInterval.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericCheckInterval.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numericCheckInterval.Name = "numericCheckInterval";
            numericCheckInterval.Size = new Size(65, 19);
            numericCheckInterval.TabIndex = 70;
            numericCheckInterval.TextAlign = HorizontalAlignment.Center;
            numericCheckInterval.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // labelCheckInterval
            // 
            labelCheckInterval.Location = new Point(5, 142);
            labelCheckInterval.Margin = new Padding(4, 0, 4, 0);
            labelCheckInterval.Name = "labelCheckInterval";
            labelCheckInterval.Size = new Size(129, 22);
            labelCheckInterval.TabIndex = 69;
            labelCheckInterval.Text = "Check Interval (ms):";
            labelCheckInterval.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sliderFPS
            // 
            sliderFPS.AccessibleName = "DPI Slider";
            sliderFPS.Location = new Point(140, 66);
            sliderFPS.Margin = new Padding(2);
            sliderFPS.Max = 1000;
            sliderFPS.Min = 20;
            sliderFPS.Name = "sliderFPS";
            sliderFPS.Size = new Size(168, 20);
            sliderFPS.Step = 1;
            sliderFPS.TabIndex = 68;
            sliderFPS.TabStop = false;
            sliderFPS.Text = "FPS Slider";
            sliderFPS.Value = 60;
            // 
            // labelMinTDP
            // 
            labelMinTDP.Location = new Point(342, 91);
            labelMinTDP.Name = "labelMinTDP";
            labelMinTDP.Size = new Size(39, 22);
            labelMinTDP.TabIndex = 67;
            labelMinTDP.Text = "30W";
            labelMinTDP.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelMaxTDP
            // 
            labelMaxTDP.Location = new Point(341, 117);
            labelMaxTDP.Name = "labelMaxTDP";
            labelMaxTDP.Size = new Size(40, 22);
            labelMaxTDP.TabIndex = 66;
            labelMaxTDP.Text = "150W";
            labelMaxTDP.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sliderMaxTDP
            // 
            sliderMaxTDP.AccessibleName = "DPI Slider";
            sliderMaxTDP.Location = new Point(140, 117);
            sliderMaxTDP.Margin = new Padding(2);
            sliderMaxTDP.Max = 200;
            sliderMaxTDP.Min = 5;
            sliderMaxTDP.Name = "sliderMaxTDP";
            sliderMaxTDP.Size = new Size(204, 20);
            sliderMaxTDP.Step = 1;
            sliderMaxTDP.TabIndex = 65;
            sliderMaxTDP.TabStop = false;
            sliderMaxTDP.Text = "Max TDP Slider";
            sliderMaxTDP.Value = 0;
            // 
            // numericUpDownFPS
            // 
            numericUpDownFPS.BorderStyle = BorderStyle.None;
            numericUpDownFPS.Location = new Point(312, 66);
            numericUpDownFPS.Margin = new Padding(2);
            numericUpDownFPS.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownFPS.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownFPS.Name = "numericUpDownFPS";
            numericUpDownFPS.Size = new Size(65, 19);
            numericUpDownFPS.TabIndex = 64;
            numericUpDownFPS.TextAlign = HorizontalAlignment.Center;
            numericUpDownFPS.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // sliderMinTDP
            // 
            sliderMinTDP.AccessibleName = "DPI Slider";
            sliderMinTDP.Location = new Point(140, 93);
            sliderMinTDP.Margin = new Padding(2);
            sliderMinTDP.Max = 200;
            sliderMinTDP.Min = 5;
            sliderMinTDP.Name = "sliderMinTDP";
            sliderMinTDP.Size = new Size(204, 20);
            sliderMinTDP.Step = 1;
            sliderMinTDP.TabIndex = 63;
            sliderMinTDP.TabStop = false;
            sliderMinTDP.Text = "Min TDP Slider";
            sliderMinTDP.Value = 0;
            // 
            // labelMaxTDPText
            // 
            labelMaxTDPText.Location = new Point(5, 117);
            labelMaxTDPText.Margin = new Padding(4, 0, 4, 0);
            labelMaxTDPText.Name = "labelMaxTDPText";
            labelMaxTDPText.Size = new Size(129, 22);
            labelMaxTDPText.TabIndex = 61;
            labelMaxTDPText.Text = "Max TDP:";
            labelMaxTDPText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labeMinTDPText
            // 
            labeMinTDPText.Location = new Point(5, 91);
            labeMinTDPText.Margin = new Padding(4, 0, 4, 0);
            labeMinTDPText.Name = "labeMinTDPText";
            labeMinTDPText.Size = new Size(129, 22);
            labeMinTDPText.TabIndex = 62;
            labeMinTDPText.Text = "Min TDP:";
            labeMinTDPText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTargetFPS
            // 
            labelTargetFPS.Location = new Point(5, 63);
            labelTargetFPS.Margin = new Padding(4, 0, 4, 0);
            labelTargetFPS.Name = "labelTargetFPS";
            labelTargetFPS.Size = new Size(129, 22);
            labelTargetFPS.TabIndex = 60;
            labelTargetFPS.Text = "Target FPS:";
            labelTargetFPS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(140, 36);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(237, 23);
            textBoxTitle.TabIndex = 59;
            // 
            // textBoxProcessName
            // 
            textBoxProcessName.Location = new Point(140, 6);
            textBoxProcessName.Name = "textBoxProcessName";
            textBoxProcessName.ReadOnly = true;
            textBoxProcessName.Size = new Size(237, 23);
            textBoxProcessName.TabIndex = 58;
            textBoxProcessName.WordWrap = false;
            // 
            // labelFPSSource
            // 
            labelFPSSource.Location = new Point(4, 37);
            labelFPSSource.Margin = new Padding(4, 0, 4, 0);
            labelFPSSource.Name = "labelFPSSource";
            labelFPSSource.Size = new Size(129, 22);
            labelFPSSource.TabIndex = 57;
            labelFPSSource.Text = "Name:";
            labelFPSSource.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLimiter
            // 
            labelLimiter.Location = new Point(4, 7);
            labelLimiter.Margin = new Padding(4, 0, 4, 0);
            labelLimiter.Name = "labelLimiter";
            labelLimiter.Size = new Size(129, 22);
            labelLimiter.TabIndex = 47;
            labelLimiter.Text = "Process";
            labelLimiter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.AccessibleName = "Keyboard Color";
            buttonSave.Activated = false;
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.BackColor = SystemColors.ButtonHighlight;
            buttonSave.BorderColor = Color.Transparent;
            buttonSave.BorderRadius = 2;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = SystemColors.ControlText;
            buttonSave.Location = new Point(278, 225);
            buttonSave.Margin = new Padding(2, 4, 2, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Secondary = false;
            buttonSave.Size = new Size(103, 25);
            buttonSave.TabIndex = 61;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.AccessibleName = "Keyboard Color";
            buttonDelete.Activated = false;
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = SystemColors.ButtonHighlight;
            buttonDelete.BorderColor = Color.Transparent;
            buttonDelete.BorderRadius = 2;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(3, 225);
            buttonDelete.Margin = new Padding(2, 4, 2, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Secondary = false;
            buttonDelete.Size = new Size(103, 25);
            buttonDelete.TabIndex = 62;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // AutoTDPGameProfileUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 263);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(panelGameSettings);
            Controls.Add(panelPerformanceHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutoTDPGameProfileUI";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Game Profile";
            panelPerformanceHeader.ResumeLayout(false);
            panelPerformanceHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKeyboard).EndInit();
            panelGameSettings.ResumeLayout(false);
            panelGameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCheckInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFPS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPerformanceHeader;
        private PictureBox pictureKeyboard;
        private Label labelSettings;
        private CheckBox checkBoxEnabled;
        private Panel panelGameSettings;
        private Label labelFPSSource;
        private Label labelLimiter;
        private TextBox textBoxTitle;
        private TextBox textBoxProcessName;
        private UI.RButton buttonSave;
        private Label labelMaxTDPText;
        private Label labeMinTDPText;
        private Label labelTargetFPS;
        private UI.Slider sliderMinTDP;
        private UI.Slider sliderMaxTDP;
        private NumericUpDown numericUpDownFPS;
        private Label labelMinTDP;
        private Label labelMaxTDP;
        private UI.RButton buttonDelete;
        private UI.Slider sliderFPS;
        private UI.Slider sliderCheckInterval;
        private NumericUpDown numericCheckInterval;
        private Label labelCheckInterval;
    }
}