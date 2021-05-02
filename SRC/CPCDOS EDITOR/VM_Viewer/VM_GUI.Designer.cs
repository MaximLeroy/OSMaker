namespace OSMaker.VM_Viewer
{
    partial class VM_GUI
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
            this.components = new System.ComponentModel.Container();
            this.tbFolder = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbPath = new System.Windows.Forms.ComboBox();
            this.cbDrive = new System.Windows.Forms.ComboBox();
            this.btConfig = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnPause = new MetroFramework.Controls.MetroButton();
            this.gbFullScreen = new MetroFramework.Controls.MetroPanel();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.tbControl = new System.Windows.Forms.Panel();
            this.cbFullScreen = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ckbAdmin = new MetroFramework.Controls.MetroCheckBox();
            this.exportToovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vmxSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbOpen = new MetroFramework.Controls.MetroCheckBox();
            this.mnViewer = new System.Windows.Forms.MenuStrip();
            this.Barreoblique = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnLauch = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.gbFullScreen.SuspendLayout();
            this.mnViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFolder
            // 
            this.tbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFolder.Location = new System.Drawing.Point(628, 4);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(652, 565);
            this.tbFolder.TabIndex = 52;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 20);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Drive :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 20);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "VM File :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // cbPath
            // 
            this.cbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPath.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPath.ForeColor = System.Drawing.SystemColors.Control;
            this.cbPath.FormattingEnabled = true;
            this.cbPath.Location = new System.Drawing.Point(103, 85);
            this.cbPath.Name = "cbPath";
            this.cbPath.Size = new System.Drawing.Size(483, 25);
            this.cbPath.TabIndex = 49;
            this.cbPath.TextChanged += new System.EventHandler(this.cbPath_TextChanged);
            // 
            // cbDrive
            // 
            this.cbDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDrive.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrive.ForeColor = System.Drawing.SystemColors.Control;
            this.cbDrive.FormattingEnabled = true;
            this.cbDrive.Location = new System.Drawing.Point(103, 132);
            this.cbDrive.Name = "cbDrive";
            this.cbDrive.Size = new System.Drawing.Size(483, 25);
            this.cbDrive.TabIndex = 48;
            // 
            // btConfig
            // 
            this.btConfig.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btConfig.Location = new System.Drawing.Point(361, 3);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(120, 94);
            this.btConfig.TabIndex = 31;
            this.btConfig.Text = "CONFIG";
            this.btConfig.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btConfig.UseSelectable = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btnStop
            // 
            this.btnStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStop.Location = new System.Drawing.Point(245, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 94);
            this.btnStop.TabIndex = 30;
            this.btnStop.Text = "STOP";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPause.Location = new System.Drawing.Point(123, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(116, 94);
            this.btnPause.TabIndex = 29;
            this.btnPause.Text = "PAUSE";
            this.btnPause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPause.UseSelectable = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // gbFullScreen
            // 
            this.gbFullScreen.Controls.Add(this.btConfig);
            this.gbFullScreen.Controls.Add(this.btnStop);
            this.gbFullScreen.Controls.Add(this.btnPause);
            this.gbFullScreen.Controls.Add(this.btnReset);
            this.gbFullScreen.HorizontalScrollbarBarColor = true;
            this.gbFullScreen.HorizontalScrollbarHighlightOnWheel = false;
            this.gbFullScreen.HorizontalScrollbarSize = 10;
            this.gbFullScreen.Location = new System.Drawing.Point(103, 356);
            this.gbFullScreen.Name = "gbFullScreen";
            this.gbFullScreen.Size = new System.Drawing.Size(483, 100);
            this.gbFullScreen.TabIndex = 47;
            this.gbFullScreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gbFullScreen.VerticalScrollbarBarColor = true;
            this.gbFullScreen.VerticalScrollbarHighlightOnWheel = false;
            this.gbFullScreen.VerticalScrollbarSize = 10;
            // 
            // btnReset
            // 
            this.btnReset.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnReset.Location = new System.Drawing.Point(4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 94);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "RESET";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbControl
            // 
            this.tbControl.Location = new System.Drawing.Point(446, 23);
            this.tbControl.Name = "tbControl";
            this.tbControl.Size = new System.Drawing.Size(73, 50);
            this.tbControl.TabIndex = 53;
            this.tbControl.Visible = false;
            // 
            // cbFullScreen
            // 
            this.cbFullScreen.AutoSize = true;
            this.cbFullScreen.Location = new System.Drawing.Point(269, 45);
            this.cbFullScreen.Name = "cbFullScreen";
            this.cbFullScreen.Size = new System.Drawing.Size(123, 17);
            this.cbFullScreen.TabIndex = 44;
            this.cbFullScreen.Text = "Full screen mode";
            this.cbFullScreen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbFullScreen.UseCustomBackColor = true;
            this.cbFullScreen.UseSelectable = true;
            this.cbFullScreen.CheckedChanged += new System.EventHandler(this.cbFullScreen_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(592, 85);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(30, 25);
            this.metroButton1.TabIndex = 42;
            this.metroButton1.Text = "...";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ckbAdmin
            // 
            this.ckbAdmin.AutoSize = true;
            this.ckbAdmin.Checked = true;
            this.ckbAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAdmin.Location = new System.Drawing.Point(103, 45);
            this.ckbAdmin.Name = "ckbAdmin";
            this.ckbAdmin.Size = new System.Drawing.Size(145, 17);
            this.ckbAdmin.TabIndex = 41;
            this.ckbAdmin.Text = "Run as administrator";
            this.ckbAdmin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ckbAdmin.UseCustomBackColor = true;
            this.ckbAdmin.UseSelectable = true;
            // 
            // exportToovaToolStripMenuItem
            // 
            this.exportToovaToolStripMenuItem.Name = "exportToovaToolStripMenuItem";
            this.exportToovaToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.exportToovaToolStripMenuItem.Text = "Export to .ova";
            this.exportToovaToolStripMenuItem.Click += new System.EventHandler(this.exportToovaToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToovaToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // vmxSettingsToolStripMenuItem
            // 
            this.vmxSettingsToolStripMenuItem.Name = "vmxSettingsToolStripMenuItem";
            this.vmxSettingsToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.vmxSettingsToolStripMenuItem.Text = "Open Library";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vmxSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // cbOpen
            // 
            this.cbOpen.AutoSize = true;
            this.cbOpen.Checked = true;
            this.cbOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOpen.Location = new System.Drawing.Point(103, 175);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(116, 17);
            this.cbOpen.TabIndex = 45;
            this.cbOpen.Text = "Open on mount";
            this.cbOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOpen.UseCustomBackColor = true;
            this.cbOpen.UseSelectable = true;
            // 
            // mnViewer
            // 
            this.mnViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mnViewer.Dock = System.Windows.Forms.DockStyle.None;
            this.mnViewer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnViewer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.mnViewer.Location = new System.Drawing.Point(9, 9);
            this.mnViewer.Name = "mnViewer";
            this.mnViewer.Size = new System.Drawing.Size(147, 25);
            this.mnViewer.TabIndex = 40;
            this.mnViewer.Text = "menuStrip1";
            // 
            // Barreoblique
            // 
            this.Barreoblique.AutoSize = true;
            this.Barreoblique.Location = new System.Drawing.Point(863, 207);
            this.Barreoblique.Name = "Barreoblique";
            this.Barreoblique.Size = new System.Drawing.Size(12, 17);
            this.Barreoblique.TabIndex = 54;
            this.Barreoblique.Text = "\\";
            this.Barreoblique.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::OSMaker.My.Resources.Resources.ASX_Edit_blue_16x1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Location = new System.Drawing.Point(103, 266);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(483, 53);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLauch
            // 
            this.btnLauch.BackgroundImage = global::OSMaker.My.Resources.Resources.Run_16x;
            this.btnLauch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLauch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLauch.Highlight = true;
            this.btnLauch.Location = new System.Drawing.Point(103, 207);
            this.btnLauch.Name = "btnLauch";
            this.btnLauch.Size = new System.Drawing.Size(483, 53);
            this.btnLauch.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLauch.TabIndex = 43;
            this.btnLauch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLauch.UseSelectable = true;
            this.btnLauch.Click += new System.EventHandler(this.btnLauch_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(103, 68);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(481, 11);
            this.progressBar1.TabIndex = 55;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(103, 325);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(360, 23);
            this.metroTextBox1.TabIndex = 56;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton2.Location = new System.Drawing.Point(469, 325);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 25);
            this.metroButton2.TabIndex = 57;
            this.metroButton2.Text = "UnMunt manually";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // VM_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1283, 581);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Barreoblique);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbPath);
            this.Controls.Add(this.cbDrive);
            this.Controls.Add(this.gbFullScreen);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbFullScreen);
            this.Controls.Add(this.btnLauch);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ckbAdmin);
            this.Controls.Add(this.cbOpen);
            this.Controls.Add(this.mnViewer);
            this.Name = "VM_GUI";
            this.Text = "VM_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VM_GUI_FormClosing);
            this.Load += new System.EventHandler(this.VM_GUI_Load);
            this.ResizeEnd += new System.EventHandler(this.VM_GUI_ResizeEnd);
            this.Move += new System.EventHandler(this.VM_GUI_Move);
            this.gbFullScreen.ResumeLayout(false);
            this.mnViewer.ResumeLayout(false);
            this.mnViewer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tbFolder;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btConfig;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnPause;
        private MetroFramework.Controls.MetroPanel gbFullScreen;
        private MetroFramework.Controls.MetroButton btnReset;
        private System.Windows.Forms.Panel tbControl;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroCheckBox cbFullScreen;
        private MetroFramework.Controls.MetroButton btnLauch;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox ckbAdmin;
        private System.Windows.Forms.ToolStripMenuItem exportToovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vmxSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private MetroFramework.Controls.MetroCheckBox cbOpen;
        private System.Windows.Forms.MenuStrip mnViewer;
        private System.Windows.Forms.Label Barreoblique;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox cbPath;
        public System.Windows.Forms.ComboBox cbDrive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}