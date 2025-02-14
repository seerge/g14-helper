using GHelper.UI;

namespace GHelper.AutoTDP
{
    partial class AutoTDPUI
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
            labelGlobalSettings = new Label();
            checkBoxEnabled = new CheckBox();
            panelLightingContent = new Panel();
            comboBoxFPSSource = new RComboBox();
            labelFPSSource = new Label();
            comboBoxLimiter = new RComboBox();
            labelLimiter = new Label();
            buttonAddGame = new RButton();
            panelGamesHeader = new Panel();
            pictureBox1 = new PictureBox();
            labelGames = new Label();
            tableLayoutGames = new TableLayoutPanel();
            buttonGameDummy = new RButton();
            panelPerformanceHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKeyboard).BeginInit();
            panelLightingContent.SuspendLayout();
            panelGamesHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutGames.SuspendLayout();
            SuspendLayout();
            // 
            // panelPerformanceHeader
            // 
            panelPerformanceHeader.BackColor = SystemColors.ControlLight;
            panelPerformanceHeader.Controls.Add(pictureKeyboard);
            panelPerformanceHeader.Controls.Add(labelGlobalSettings);
            panelPerformanceHeader.Controls.Add(checkBoxEnabled);
            panelPerformanceHeader.Dock = DockStyle.Top;
            panelPerformanceHeader.Location = new Point(0, 0);
            panelPerformanceHeader.Margin = new Padding(2);
            panelPerformanceHeader.Name = "panelPerformanceHeader";
            panelPerformanceHeader.Size = new Size(446, 30);
            panelPerformanceHeader.TabIndex = 52;
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
            // labelGlobalSettings
            // 
            labelGlobalSettings.AutoSize = true;
            labelGlobalSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGlobalSettings.Location = new Point(22, 8);
            labelGlobalSettings.Margin = new Padding(4, 0, 4, 0);
            labelGlobalSettings.Name = "labelGlobalSettings";
            labelGlobalSettings.Size = new Size(100, 15);
            labelGlobalSettings.TabIndex = 34;
            labelGlobalSettings.Text = "General Settings";
            // 
            // checkBoxEnabled
            // 
            checkBoxEnabled.Location = new Point(244, 4);
            checkBoxEnabled.Margin = new Padding(4, 0, 4, 0);
            checkBoxEnabled.Name = "checkBoxEnabled";
            checkBoxEnabled.Size = new Size(198, 25);
            checkBoxEnabled.TabIndex = 53;
            checkBoxEnabled.Text = "Enabled";
            checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // panelLightingContent
            // 
            panelLightingContent.AutoSize = true;
            panelLightingContent.Controls.Add(comboBoxFPSSource);
            panelLightingContent.Controls.Add(labelFPSSource);
            panelLightingContent.Controls.Add(comboBoxLimiter);
            panelLightingContent.Controls.Add(labelLimiter);
            panelLightingContent.Dock = DockStyle.Top;
            panelLightingContent.Location = new Point(0, 30);
            panelLightingContent.Margin = new Padding(2);
            panelLightingContent.Name = "panelLightingContent";
            panelLightingContent.Padding = new Padding(0, 0, 0, 7);
            panelLightingContent.Size = new Size(446, 67);
            panelLightingContent.TabIndex = 56;
            // 
            // comboBoxFPSSource
            // 
            comboBoxFPSSource.BorderColor = Color.White;
            comboBoxFPSSource.ButtonColor = Color.FromArgb(255, 255, 255);
            comboBoxFPSSource.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFPSSource.FlatStyle = FlatStyle.Flat;
            comboBoxFPSSource.FormattingEnabled = true;
            comboBoxFPSSource.Location = new Point(244, 37);
            comboBoxFPSSource.Margin = new Padding(11, 0, 11, 0);
            comboBoxFPSSource.Name = "comboBoxFPSSource";
            comboBoxFPSSource.Size = new Size(191, 23);
            comboBoxFPSSource.TabIndex = 56;
            // 
            // labelFPSSource
            // 
            labelFPSSource.Location = new Point(4, 37);
            labelFPSSource.Margin = new Padding(4, 0, 4, 0);
            labelFPSSource.Name = "labelFPSSource";
            labelFPSSource.Size = new Size(211, 22);
            labelFPSSource.TabIndex = 57;
            labelFPSSource.Text = "FPS Source";
            // 
            // comboBoxLimiter
            // 
            comboBoxLimiter.BorderColor = Color.White;
            comboBoxLimiter.ButtonColor = Color.FromArgb(255, 255, 255);
            comboBoxLimiter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLimiter.FlatStyle = FlatStyle.Flat;
            comboBoxLimiter.FormattingEnabled = true;
            comboBoxLimiter.Location = new Point(244, 7);
            comboBoxLimiter.Margin = new Padding(11, 0, 11, 0);
            comboBoxLimiter.Name = "comboBoxLimiter";
            comboBoxLimiter.Size = new Size(191, 23);
            comboBoxLimiter.TabIndex = 46;
            // 
            // labelLimiter
            // 
            labelLimiter.Location = new Point(4, 7);
            labelLimiter.Margin = new Padding(4, 0, 4, 0);
            labelLimiter.Name = "labelLimiter";
            labelLimiter.Size = new Size(211, 22);
            labelLimiter.TabIndex = 47;
            labelLimiter.Text = "Power Limiter";
            // 
            // buttonAddGame
            // 
            buttonAddGame.AccessibleName = "Keyboard Color";
            buttonAddGame.Activated = false;
            buttonAddGame.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddGame.BackColor = SystemColors.ButtonHighlight;
            buttonAddGame.BorderColor = Color.Transparent;
            buttonAddGame.BorderRadius = 2;
            buttonAddGame.FlatStyle = FlatStyle.Flat;
            buttonAddGame.ForeColor = SystemColors.ControlText;
            buttonAddGame.Location = new Point(339, 3);
            buttonAddGame.Margin = new Padding(2, 4, 2, 4);
            buttonAddGame.Name = "buttonAddGame";
            buttonAddGame.Secondary = false;
            buttonAddGame.Size = new Size(103, 25);
            buttonAddGame.TabIndex = 60;
            buttonAddGame.Text = "Add Game";
            buttonAddGame.UseVisualStyleBackColor = false;
            // 
            // panelGamesHeader
            // 
            panelGamesHeader.BackColor = SystemColors.ControlLight;
            panelGamesHeader.Controls.Add(pictureBox1);
            panelGamesHeader.Controls.Add(buttonAddGame);
            panelGamesHeader.Controls.Add(labelGames);
            panelGamesHeader.Dock = DockStyle.Top;
            panelGamesHeader.Location = new Point(0, 97);
            panelGamesHeader.Margin = new Padding(2);
            panelGamesHeader.Name = "panelGamesHeader";
            panelGamesHeader.Size = new Size(446, 30);
            panelGamesHeader.TabIndex = 61;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_software_32_white;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // labelGames
            // 
            labelGames.AutoSize = true;
            labelGames.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGames.Location = new Point(22, 8);
            labelGames.Margin = new Padding(4, 0, 4, 0);
            labelGames.Name = "labelGames";
            labelGames.Size = new Size(45, 15);
            labelGames.TabIndex = 34;
            labelGames.Text = "Games";
            // 
            // tableLayoutGames
            // 
            tableLayoutGames.AutoSize = true;
            tableLayoutGames.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutGames.ColumnCount = 4;
            tableLayoutGames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutGames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutGames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutGames.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutGames.Controls.Add(buttonGameDummy, 0, 0);
            tableLayoutGames.Dock = DockStyle.Top;
            tableLayoutGames.Location = new Point(0, 127);
            tableLayoutGames.Margin = new Padding(4, 2, 4, 2);
            tableLayoutGames.Name = "tableLayoutGames";
            tableLayoutGames.RowCount = 7;
            tableLayoutGames.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutGames.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutGames.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutGames.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutGames.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutGames.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutGames.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutGames.Size = new Size(446, 420);
            tableLayoutGames.TabIndex = 62;
            // 
            // buttonGameDummy
            // 
            buttonGameDummy.AccessibleName = "DPI Setting 4";
            buttonGameDummy.Activated = false;
            buttonGameDummy.AutoSize = true;
            buttonGameDummy.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonGameDummy.BackColor = SystemColors.ControlLightLight;
            buttonGameDummy.BorderColor = Color.LightGreen;
            buttonGameDummy.BorderRadius = 5;
            buttonGameDummy.Dock = DockStyle.Fill;
            buttonGameDummy.FlatAppearance.BorderSize = 0;
            buttonGameDummy.FlatStyle = FlatStyle.Flat;
            buttonGameDummy.ForeColor = SystemColors.ControlText;
            buttonGameDummy.ImageAlign = ContentAlignment.BottomCenter;
            buttonGameDummy.Location = new Point(2, 2);
            buttonGameDummy.Margin = new Padding(2);
            buttonGameDummy.Name = "buttonGameDummy";
            buttonGameDummy.Secondary = false;
            buttonGameDummy.Size = new Size(107, 56);
            buttonGameDummy.TabIndex = 7;
            buttonGameDummy.Text = "Genshin Impact\r\n60FPS\r\n";
            buttonGameDummy.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonGameDummy.UseVisualStyleBackColor = false;
            buttonGameDummy.Visible = false;
            // 
            // AutoTDPUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 547);
            Controls.Add(tableLayoutGames);
            Controls.Add(panelGamesHeader);
            Controls.Add(panelLightingContent);
            Controls.Add(panelPerformanceHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutoTDPUI";
            ShowIcon = false;
            Text = "Auto TDP Settings";
            panelPerformanceHeader.ResumeLayout(false);
            panelPerformanceHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureKeyboard).EndInit();
            panelLightingContent.ResumeLayout(false);
            panelGamesHeader.ResumeLayout(false);
            panelGamesHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutGames.ResumeLayout(false);
            tableLayoutGames.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPerformanceHeader;
        private PictureBox pictureKeyboard;
        private Label labelGlobalSettings;
        private Panel panelLightingContent;
        private TableLayoutPanel tableLayoutGames;
        private UI.RButton rButton1;
        private CheckBox checkBoxEnabled;
        private UI.RComboBox comboBoxLightingMode;
        private Label labelLimiter;
        private UI.RComboBox comboBoxFPSSource;
        private Label labelFPSSource;
        private RComboBox comboBoxLimiter;
        private RButton buttonAddGame;
        private Panel panelGamesHeader;
        private PictureBox pictureBox1;
        private Label labelGames;
        private RButton buttonGameDummy;
    }
}