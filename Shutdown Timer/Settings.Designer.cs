﻿namespace ShutdownTimer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.titlebarPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.appLabel = new System.Windows.Forms.Label();
            this.footerLabel = new System.Windows.Forms.Label();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.defaultSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.rememberStateCheckBox = new System.Windows.Forms.CheckBox();
            this.customDefaultsGroupBox = new System.Windows.Forms.GroupBox();
            this.preventSleepCheckBox = new System.Windows.Forms.CheckBox();
            this.gracefulCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clearSettingsButton = new System.Windows.Forms.Button();
            this.licenseGroupBox = new System.Windows.Forms.GroupBox();
            this.appInfoLabel = new System.Windows.Forms.Label();
            this.appLicenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.appSourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.faInfoLabel = new System.Windows.Forms.Label();
            this.faLicenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.faSourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aboutGroupBox = new System.Windows.Forms.GroupBox();
            this.aboutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.githubButton = new System.Windows.Forms.Button();
            this.emailbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarPictureBox)).BeginInit();
            this.settingsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.defaultSettingsGroupBox.SuspendLayout();
            this.customDefaultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).BeginInit();
            this.licenseGroupBox.SuspendLayout();
            this.aboutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebarPictureBox
            // 
            this.titlebarPictureBox.BackColor = System.Drawing.Color.Black;
            this.titlebarPictureBox.Location = new System.Drawing.Point(18, 43);
            this.titlebarPictureBox.Name = "titlebarPictureBox";
            this.titlebarPictureBox.Size = new System.Drawing.Size(113, 5);
            this.titlebarPictureBox.TabIndex = 6;
            this.titlebarPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(113, 31);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Settings";
            // 
            // appLabel
            // 
            this.appLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appLabel.AutoSize = true;
            this.appLabel.Location = new System.Drawing.Point(167, 9);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(155, 13);
            this.appLabel.TabIndex = 7;
            this.appLabel.Text = "ShutdownTimerClassic@v0.0.0";
            this.appLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // footerLabel
            // 
            this.footerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footerLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerLabel.Location = new System.Drawing.Point(12, 332);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(310, 20);
            this.footerLabel.TabIndex = 9;
            this.footerLabel.Text = "Made with love in Germany";
            this.footerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.Location = new System.Drawing.Point(241, 22);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(81, 13);
            this.githubLinkLabel.TabIndex = 10;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "View on GitHub";
            this.githubLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabControl.Controls.Add(this.tabPage1);
            this.settingsTabControl.Controls.Add(this.tabPage2);
            this.settingsTabControl.Location = new System.Drawing.Point(18, 54);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(304, 275);
            this.settingsTabControl.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clearSettingsButton);
            this.tabPage1.Controls.Add(this.defaultSettingsGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Application Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aboutGroupBox);
            this.tabPage2.Controls.Add(this.licenseGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // defaultSettingsGroupBox
            // 
            this.defaultSettingsGroupBox.Controls.Add(this.customDefaultsGroupBox);
            this.defaultSettingsGroupBox.Controls.Add(this.rememberStateCheckBox);
            this.defaultSettingsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.defaultSettingsGroupBox.Name = "defaultSettingsGroupBox";
            this.defaultSettingsGroupBox.Size = new System.Drawing.Size(284, 196);
            this.defaultSettingsGroupBox.TabIndex = 0;
            this.defaultSettingsGroupBox.TabStop = false;
            this.defaultSettingsGroupBox.Text = "Default settings";
            // 
            // rememberStateCheckBox
            // 
            this.rememberStateCheckBox.AutoSize = true;
            this.rememberStateCheckBox.Location = new System.Drawing.Point(6, 19);
            this.rememberStateCheckBox.Name = "rememberStateCheckBox";
            this.rememberStateCheckBox.Size = new System.Drawing.Size(122, 17);
            this.rememberStateCheckBox.TabIndex = 0;
            this.rememberStateCheckBox.Text = "Remember last state";
            this.rememberStateCheckBox.UseVisualStyleBackColor = true;
            this.rememberStateCheckBox.CheckedChanged += new System.EventHandler(this.RememberStateCheckBox_CheckedChanged);
            // 
            // customDefaultsGroupBox
            // 
            this.customDefaultsGroupBox.Controls.Add(this.hoursNumericUpDown);
            this.customDefaultsGroupBox.Controls.Add(this.secondsLabel);
            this.customDefaultsGroupBox.Controls.Add(this.hoursLabel);
            this.customDefaultsGroupBox.Controls.Add(this.minutesLabel);
            this.customDefaultsGroupBox.Controls.Add(this.minutesNumericUpDown);
            this.customDefaultsGroupBox.Controls.Add(this.secondsNumericUpDown);
            this.customDefaultsGroupBox.Controls.Add(this.preventSleepCheckBox);
            this.customDefaultsGroupBox.Controls.Add(this.gracefulCheckBox);
            this.customDefaultsGroupBox.Controls.Add(this.backgroundCheckBox);
            this.customDefaultsGroupBox.Controls.Add(this.actionLabel);
            this.customDefaultsGroupBox.Controls.Add(this.actionComboBox);
            this.customDefaultsGroupBox.Location = new System.Drawing.Point(6, 42);
            this.customDefaultsGroupBox.Name = "customDefaultsGroupBox";
            this.customDefaultsGroupBox.Size = new System.Drawing.Size(272, 148);
            this.customDefaultsGroupBox.TabIndex = 1;
            this.customDefaultsGroupBox.TabStop = false;
            this.customDefaultsGroupBox.Text = "Custom defaults";
            // 
            // preventSleepCheckBox
            // 
            this.preventSleepCheckBox.AutoSize = true;
            this.preventSleepCheckBox.Checked = true;
            this.preventSleepCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preventSleepCheckBox.Location = new System.Drawing.Point(9, 63);
            this.preventSleepCheckBox.Name = "preventSleepCheckBox";
            this.preventSleepCheckBox.Size = new System.Drawing.Size(190, 17);
            this.preventSleepCheckBox.TabIndex = 18;
            this.preventSleepCheckBox.Text = "Prevent system from going to sleep";
            this.preventSleepCheckBox.UseVisualStyleBackColor = true;
            // 
            // gracefulCheckBox
            // 
            this.gracefulCheckBox.AutoSize = true;
            this.gracefulCheckBox.Location = new System.Drawing.Point(9, 40);
            this.gracefulCheckBox.Name = "gracefulCheckBox";
            this.gracefulCheckBox.Size = new System.Drawing.Size(186, 17);
            this.gracefulCheckBox.TabIndex = 17;
            this.gracefulCheckBox.Text = "Graceful (do not force close apps)";
            this.gracefulCheckBox.UseVisualStyleBackColor = true;
            // 
            // backgroundCheckBox
            // 
            this.backgroundCheckBox.AutoSize = true;
            this.backgroundCheckBox.Location = new System.Drawing.Point(9, 86);
            this.backgroundCheckBox.Name = "backgroundCheckBox";
            this.backgroundCheckBox.Size = new System.Drawing.Size(117, 17);
            this.backgroundCheckBox.TabIndex = 16;
            this.backgroundCheckBox.Text = "Run in background";
            this.backgroundCheckBox.UseVisualStyleBackColor = true;
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(6, 16);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(87, 13);
            this.actionLabel.TabIndex = 15;
            this.actionLabel.Text = "Select an action:";
            // 
            // actionComboBox
            // 
            this.actionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.actionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Hibernate",
            "Sleep",
            "Logout",
            "Lock"});
            this.actionComboBox.Location = new System.Drawing.Point(99, 13);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(147, 21);
            this.actionComboBox.TabIndex = 14;
            this.actionComboBox.Text = "Shutdown";
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.Location = new System.Drawing.Point(9, 122);
            this.hoursNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.hoursNumericUpDown.TabIndex = 19;
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(118, 106);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(49, 13);
            this.secondsLabel.TabIndex = 24;
            this.secondsLabel.Text = "Seconds";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(6, 106);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(35, 13);
            this.hoursLabel.TabIndex = 22;
            this.hoursLabel.Text = "Hours";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(62, 106);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(44, 13);
            this.minutesLabel.TabIndex = 23;
            this.minutesLabel.Text = "Minutes";
            // 
            // minutesNumericUpDown
            // 
            this.minutesNumericUpDown.Location = new System.Drawing.Point(65, 122);
            this.minutesNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.minutesNumericUpDown.Name = "minutesNumericUpDown";
            this.minutesNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.minutesNumericUpDown.TabIndex = 20;
            // 
            // secondsNumericUpDown
            // 
            this.secondsNumericUpDown.Location = new System.Drawing.Point(121, 122);
            this.secondsNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.secondsNumericUpDown.Name = "secondsNumericUpDown";
            this.secondsNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.secondsNumericUpDown.TabIndex = 21;
            // 
            // clearSettingsButton
            // 
            this.clearSettingsButton.Location = new System.Drawing.Point(161, 220);
            this.clearSettingsButton.Name = "clearSettingsButton";
            this.clearSettingsButton.Size = new System.Drawing.Size(129, 23);
            this.clearSettingsButton.TabIndex = 1;
            this.clearSettingsButton.Text = "Clear Settings";
            this.clearSettingsButton.UseVisualStyleBackColor = true;
            this.clearSettingsButton.Click += new System.EventHandler(this.ClearSettingsButton_Click);
            // 
            // licenseGroupBox
            // 
            this.licenseGroupBox.Controls.Add(this.faSourceLinkLabel);
            this.licenseGroupBox.Controls.Add(this.faLicenseLinkLabel);
            this.licenseGroupBox.Controls.Add(this.faInfoLabel);
            this.licenseGroupBox.Controls.Add(this.appSourceLinkLabel);
            this.licenseGroupBox.Controls.Add(this.appLicenseLinkLabel);
            this.licenseGroupBox.Controls.Add(this.appInfoLabel);
            this.licenseGroupBox.Location = new System.Drawing.Point(6, 6);
            this.licenseGroupBox.Name = "licenseGroupBox";
            this.licenseGroupBox.Size = new System.Drawing.Size(284, 49);
            this.licenseGroupBox.TabIndex = 0;
            this.licenseGroupBox.TabStop = false;
            this.licenseGroupBox.Text = "Licenses && Source";
            // 
            // appInfoLabel
            // 
            this.appInfoLabel.AutoSize = true;
            this.appInfoLabel.Location = new System.Drawing.Point(6, 16);
            this.appInfoLabel.Name = "appInfoLabel";
            this.appInfoLabel.Size = new System.Drawing.Size(62, 13);
            this.appInfoLabel.TabIndex = 0;
            this.appInfoLabel.Text = "Application:";
            // 
            // appLicenseLinkLabel
            // 
            this.appLicenseLinkLabel.AutoSize = true;
            this.appLicenseLinkLabel.Location = new System.Drawing.Point(74, 16);
            this.appLicenseLinkLabel.Name = "appLicenseLinkLabel";
            this.appLicenseLinkLabel.Size = new System.Drawing.Size(66, 13);
            this.appLicenseLinkLabel.TabIndex = 1;
            this.appLicenseLinkLabel.TabStop = true;
            this.appLicenseLinkLabel.Text = "MIT License";
            this.appLicenseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppLicenseLinkLabel_LinkClicked);
            // 
            // appSourceLinkLabel
            // 
            this.appSourceLinkLabel.AutoSize = true;
            this.appSourceLinkLabel.Location = new System.Drawing.Point(146, 16);
            this.appSourceLinkLabel.Name = "appSourceLinkLabel";
            this.appSourceLinkLabel.Size = new System.Drawing.Size(65, 13);
            this.appSourceLinkLabel.TabIndex = 2;
            this.appSourceLinkLabel.TabStop = true;
            this.appSourceLinkLabel.Text = "Sourcecode";
            this.appSourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppSourceLinkLabel_LinkClicked);
            // 
            // faInfoLabel
            // 
            this.faInfoLabel.AutoSize = true;
            this.faInfoLabel.Location = new System.Drawing.Point(6, 29);
            this.faInfoLabel.Name = "faInfoLabel";
            this.faInfoLabel.Size = new System.Drawing.Size(80, 13);
            this.faInfoLabel.TabIndex = 3;
            this.faInfoLabel.Text = "Font Awesome:";
            // 
            // faLicenseLinkLabel
            // 
            this.faLicenseLinkLabel.AutoSize = true;
            this.faLicenseLinkLabel.Location = new System.Drawing.Point(92, 29);
            this.faLicenseLinkLabel.Name = "faLicenseLinkLabel";
            this.faLicenseLinkLabel.Size = new System.Drawing.Size(96, 13);
            this.faLicenseLinkLabel.TabIndex = 4;
            this.faLicenseLinkLabel.TabStop = true;
            this.faLicenseLinkLabel.Text = "CC BY 4.0 License";
            this.faLicenseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FALicenseLinkLabel_LinkClicked);
            // 
            // faSourceLinkLabel
            // 
            this.faSourceLinkLabel.AutoSize = true;
            this.faSourceLinkLabel.Location = new System.Drawing.Point(194, 29);
            this.faSourceLinkLabel.Name = "faSourceLinkLabel";
            this.faSourceLinkLabel.Size = new System.Drawing.Size(65, 13);
            this.faSourceLinkLabel.TabIndex = 5;
            this.faSourceLinkLabel.TabStop = true;
            this.faSourceLinkLabel.Text = "Sourcecode";
            this.faSourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FASourceLinkLabel_LinkClicked);
            // 
            // aboutGroupBox
            // 
            this.aboutGroupBox.Controls.Add(this.emailbutton);
            this.aboutGroupBox.Controls.Add(this.githubButton);
            this.aboutGroupBox.Controls.Add(this.aboutRichTextBox);
            this.aboutGroupBox.Location = new System.Drawing.Point(6, 61);
            this.aboutGroupBox.Name = "aboutGroupBox";
            this.aboutGroupBox.Size = new System.Drawing.Size(284, 182);
            this.aboutGroupBox.TabIndex = 1;
            this.aboutGroupBox.TabStop = false;
            this.aboutGroupBox.Text = "About this app";
            // 
            // aboutRichTextBox
            // 
            this.aboutRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.aboutRichTextBox.Name = "aboutRichTextBox";
            this.aboutRichTextBox.Size = new System.Drawing.Size(272, 128);
            this.aboutRichTextBox.TabIndex = 14;
            this.aboutRichTextBox.Text = resources.GetString("aboutRichTextBox.Text");
            // 
            // githubButton
            // 
            this.githubButton.Location = new System.Drawing.Point(178, 153);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(100, 23);
            this.githubButton.TabIndex = 15;
            this.githubButton.Text = "GitHub";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.GithubButton_Click);
            // 
            // emailbutton
            // 
            this.emailbutton.Location = new System.Drawing.Point(112, 153);
            this.emailbutton.Name = "emailbutton";
            this.emailbutton.Size = new System.Drawing.Size(60, 23);
            this.emailbutton.TabIndex = 16;
            this.emailbutton.Text = "Email";
            this.emailbutton.UseVisualStyleBackColor = true;
            this.emailbutton.Click += new System.EventHandler(this.Emailbutton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.footerLabel);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.titlebarPictureBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.settingsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlebarPictureBox)).EndInit();
            this.settingsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.defaultSettingsGroupBox.ResumeLayout(false);
            this.defaultSettingsGroupBox.PerformLayout();
            this.customDefaultsGroupBox.ResumeLayout(false);
            this.customDefaultsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumericUpDown)).EndInit();
            this.licenseGroupBox.ResumeLayout(false);
            this.licenseGroupBox.PerformLayout();
            this.aboutGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlebarPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox defaultSettingsGroupBox;
        private System.Windows.Forms.GroupBox customDefaultsGroupBox;
        private System.Windows.Forms.CheckBox rememberStateCheckBox;
        private System.Windows.Forms.CheckBox preventSleepCheckBox;
        private System.Windows.Forms.CheckBox gracefulCheckBox;
        private System.Windows.Forms.CheckBox backgroundCheckBox;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondsNumericUpDown;
        private System.Windows.Forms.Button clearSettingsButton;
        private System.Windows.Forms.GroupBox licenseGroupBox;
        private System.Windows.Forms.LinkLabel appLicenseLinkLabel;
        private System.Windows.Forms.Label appInfoLabel;
        private System.Windows.Forms.LinkLabel faLicenseLinkLabel;
        private System.Windows.Forms.Label faInfoLabel;
        private System.Windows.Forms.LinkLabel appSourceLinkLabel;
        private System.Windows.Forms.LinkLabel faSourceLinkLabel;
        private System.Windows.Forms.GroupBox aboutGroupBox;
        private System.Windows.Forms.Button emailbutton;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.RichTextBox aboutRichTextBox;
    }
}