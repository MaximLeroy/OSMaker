namespace OSMaker.Formulaires
{
    partial class New_OS
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_OS = new MetroFramework.Controls.MetroTabPage();
            this.tab_Screen = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.btn_vmFolder = new MetroFramework.Controls.MetroButton();
            this.txtb_pathVM = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_osFolder = new MetroFramework.Controls.MetroButton();
            this.txtb_osPath = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtb_osSystemName = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtb_mediaFolder = new System.Windows.Forms.TextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.DateTime_creation = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtb_authors = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtb_compagny = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtb_osName = new System.Windows.Forms.TextBox();
            this.tab_Cursor = new System.Windows.Forms.TabPage();
            this.tab_Finish = new System.Windows.Forms.TabPage();
            this.btn_reset = new MetroFramework.Controls.MetroButton();
            this.btn_create = new MetroFramework.Controls.MetroButton();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtb_SCREEN_manualresolution = new System.Windows.Forms.TextBox();
            this.chk_SCREEN_autosize = new MetroFramework.Controls.MetroCheckBox();
            this.tab_BootScreen = new System.Windows.Forms.TabPage();
            this.btn_Next = new MetroFramework.Controls.MetroButton();
            this.btn_Next_2 = new MetroFramework.Controls.MetroButton();
            this.btn_Next3 = new MetroFramework.Controls.MetroButton();
            this.btn_Next4 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tab_OS.SuspendLayout();
            this.tab_Screen.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tab_Cursor.SuspendLayout();
            this.tab_Finish.SuspendLayout();
            this.tab_BootScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_OS);
            this.metroTabControl1.Controls.Add(this.tab_BootScreen);
            this.metroTabControl1.Controls.Add(this.tab_Screen);
            this.metroTabControl1.Controls.Add(this.tab_Cursor);
            this.metroTabControl1.Controls.Add(this.tab_Finish);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(15, 60);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(576, 449);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_OS
            // 
            this.tab_OS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab_OS.Controls.Add(this.btn_Next);
            this.tab_OS.Controls.Add(this.metroLabel14);
            this.tab_OS.Controls.Add(this.metroLabel13);
            this.tab_OS.Controls.Add(this.btn_vmFolder);
            this.tab_OS.Controls.Add(this.txtb_pathVM);
            this.tab_OS.Controls.Add(this.metroLabel3);
            this.tab_OS.Controls.Add(this.btn_osFolder);
            this.tab_OS.Controls.Add(this.txtb_osPath);
            this.tab_OS.Controls.Add(this.metroLabel2);
            this.tab_OS.Controls.Add(this.metroLabel6);
            this.tab_OS.Controls.Add(this.metroLabel11);
            this.tab_OS.Controls.Add(this.txtb_osSystemName);
            this.tab_OS.Controls.Add(this.metroLabel10);
            this.tab_OS.Controls.Add(this.metroLabel9);
            this.tab_OS.Controls.Add(this.txtb_mediaFolder);
            this.tab_OS.Controls.Add(this.metroPanel1);
            this.tab_OS.Controls.Add(this.metroLabel1);
            this.tab_OS.Controls.Add(this.txtb_osName);
            this.tab_OS.HorizontalScrollbarBarColor = true;
            this.tab_OS.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_OS.HorizontalScrollbarSize = 8;
            this.tab_OS.Location = new System.Drawing.Point(4, 38);
            this.tab_OS.Margin = new System.Windows.Forms.Padding(2);
            this.tab_OS.Name = "tab_OS";
            this.tab_OS.Size = new System.Drawing.Size(568, 407);
            this.tab_OS.TabIndex = 0;
            this.tab_OS.Text = "OS";
            this.tab_OS.UseCustomBackColor = true;
            this.tab_OS.VerticalScrollbarBarColor = true;
            this.tab_OS.VerticalScrollbarHighlightOnWheel = false;
            this.tab_OS.VerticalScrollbarSize = 8;
            // 
            // tab_Screen
            // 
            this.tab_Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab_Screen.Controls.Add(this.btn_Next3);
            this.tab_Screen.Controls.Add(this.metroLabel15);
            this.tab_Screen.Controls.Add(this.txtb_SCREEN_manualresolution);
            this.tab_Screen.Controls.Add(this.chk_SCREEN_autosize);
            this.tab_Screen.HorizontalScrollbarBarColor = true;
            this.tab_Screen.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Screen.HorizontalScrollbarSize = 8;
            this.tab_Screen.Location = new System.Drawing.Point(4, 38);
            this.tab_Screen.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Screen.Name = "tab_Screen";
            this.tab_Screen.Size = new System.Drawing.Size(568, 407);
            this.tab_Screen.TabIndex = 1;
            this.tab_Screen.Text = "Screen";
            this.tab_Screen.UseCustomBackColor = true;
            this.tab_Screen.VerticalScrollbarBarColor = true;
            this.tab_Screen.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Screen.VerticalScrollbarSize = 8;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel14.ForeColor = System.Drawing.Color.Black;
            this.metroLabel14.Location = new System.Drawing.Point(91, 46);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(292, 15);
            this.metroLabel14.TabIndex = 145;
            this.metroLabel14.Text = "Your Cpcdos\'s OVA virtual machine file (Already bootable)";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.ForeColor = System.Drawing.Color.Black;
            this.metroLabel13.Location = new System.Drawing.Point(91, 96);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(249, 15);
            this.metroLabel13.TabIndex = 144;
            this.metroLabel13.Text = "Where are operating systems (eg : c:\\cpcdos\\os)";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // btn_vmFolder
            // 
            this.btn_vmFolder.BackgroundImage = global::OSMaker.My.Resources.Resources.OpenFolder_16x;
            this.btn_vmFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_vmFolder.Location = new System.Drawing.Point(471, 23);
            this.btn_vmFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_vmFolder.Name = "btn_vmFolder";
            this.btn_vmFolder.Size = new System.Drawing.Size(26, 19);
            this.btn_vmFolder.TabIndex = 128;
            this.btn_vmFolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_vmFolder.UseSelectable = true;
            // 
            // txtb_pathVM
            // 
            this.txtb_pathVM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_pathVM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_pathVM.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_pathVM.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_pathVM.Location = new System.Drawing.Point(91, 23);
            this.txtb_pathVM.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_pathVM.Name = "txtb_pathVM";
            this.txtb_pathVM.Size = new System.Drawing.Size(376, 21);
            this.txtb_pathVM.TabIndex = 127;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(47, 23);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 25);
            this.metroLabel3.TabIndex = 143;
            this.metroLabel3.Text = "VM";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // btn_osFolder
            // 
            this.btn_osFolder.BackgroundImage = global::OSMaker.My.Resources.Resources.OpenFolder_16x;
            this.btn_osFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_osFolder.Location = new System.Drawing.Point(471, 73);
            this.btn_osFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_osFolder.Name = "btn_osFolder";
            this.btn_osFolder.Size = new System.Drawing.Size(26, 19);
            this.btn_osFolder.TabIndex = 131;
            this.btn_osFolder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_osFolder.UseSelectable = true;
            // 
            // txtb_osPath
            // 
            this.txtb_osPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_osPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_osPath.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_osPath.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_osPath.Location = new System.Drawing.Point(91, 73);
            this.txtb_osPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_osPath.Name = "txtb_osPath";
            this.txtb_osPath.Size = new System.Drawing.Size(376, 21);
            this.txtb_osPath.TabIndex = 129;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(1, 73);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 25);
            this.metroLabel2.TabIndex = 142;
            this.metroLabel2.Text = "OS\'s path";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(91, 205);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(345, 15);
            this.metroLabel6.TabIndex = 141;
            this.metroLabel6.Text = "Put here your media folder (this create clone with media folder base)";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(261, 150);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(175, 30);
            this.metroLabel11.TabIndex = 140;
            this.metroLabel11.Text = "Put here OS\'s system name folder\r\nNo spaces, dots, 8 char max";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // txtb_osSystemName
            // 
            this.txtb_osSystemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_osSystemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_osSystemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_osSystemName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_osSystemName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_osSystemName.Location = new System.Drawing.Point(261, 127);
            this.txtb_osSystemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_osSystemName.MaxLength = 8;
            this.txtb_osSystemName.Name = "txtb_osSystemName";
            this.txtb_osSystemName.Size = new System.Drawing.Size(119, 21);
            this.txtb_osSystemName.TabIndex = 133;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.ForeColor = System.Drawing.Color.Black;
            this.metroLabel10.Location = new System.Drawing.Point(91, 150);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(88, 15);
            this.metroLabel10.TabIndex = 139;
            this.metroLabel10.Text = "Official OS name";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(1, 178);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 25);
            this.metroLabel9.TabIndex = 138;
            this.metroLabel9.Text = "Media dir";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // txtb_mediaFolder
            // 
            this.txtb_mediaFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_mediaFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_mediaFolder.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_mediaFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_mediaFolder.Location = new System.Drawing.Point(91, 182);
            this.txtb_mediaFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_mediaFolder.Name = "txtb_mediaFolder";
            this.txtb_mediaFolder.Size = new System.Drawing.Size(376, 21);
            this.txtb_mediaFolder.TabIndex = 134;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.DateTime_creation);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txtb_authors);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtb_compagny);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(90, 249);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(293, 129);
            this.metroPanel1.TabIndex = 135;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.ForeColor = System.Drawing.Color.Black;
            this.metroLabel8.Location = new System.Drawing.Point(84, 9);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(134, 15);
            this.metroLabel8.TabIndex = 91;
            this.metroLabel8.Text = "Developer(s) informations";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // DateTime_creation
            // 
            this.DateTime_creation.Location = new System.Drawing.Point(84, 87);
            this.DateTime_creation.Margin = new System.Windows.Forms.Padding(2);
            this.DateTime_creation.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime_creation.Name = "DateTime_creation";
            this.DateTime_creation.Size = new System.Drawing.Size(182, 29);
            this.DateTime_creation.TabIndex = 39;
            this.DateTime_creation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(17, 87);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Created :";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // txtb_authors
            // 
            this.txtb_authors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_authors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_authors.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_authors.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_authors.Location = new System.Drawing.Point(84, 36);
            this.txtb_authors.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_authors.Name = "txtb_authors";
            this.txtb_authors.Size = new System.Drawing.Size(182, 21);
            this.txtb_authors.TabIndex = 37;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 36);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Author(s) :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // txtb_compagny
            // 
            this.txtb_compagny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_compagny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_compagny.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_compagny.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_compagny.Location = new System.Drawing.Point(84, 61);
            this.txtb_compagny.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_compagny.Name = "txtb_compagny";
            this.txtb_compagny.Size = new System.Drawing.Size(182, 21);
            this.txtb_compagny.TabIndex = 38;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(7, 61);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Company :";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(27, 123);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 25);
            this.metroLabel1.TabIndex = 130;
            this.metroLabel1.Text = "Name";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtb_osName
            // 
            this.txtb_osName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_osName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_osName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_osName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_osName.Location = new System.Drawing.Point(91, 127);
            this.txtb_osName.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_osName.Name = "txtb_osName";
            this.txtb_osName.Size = new System.Drawing.Size(119, 21);
            this.txtb_osName.TabIndex = 132;
            // 
            // tab_Cursor
            // 
            this.tab_Cursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab_Cursor.Controls.Add(this.btn_Next4);
            this.tab_Cursor.Location = new System.Drawing.Point(4, 38);
            this.tab_Cursor.Name = "tab_Cursor";
            this.tab_Cursor.Size = new System.Drawing.Size(568, 407);
            this.tab_Cursor.TabIndex = 2;
            this.tab_Cursor.Text = "Cursor";
            // 
            // tab_Finish
            // 
            this.tab_Finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab_Finish.Controls.Add(this.btn_reset);
            this.tab_Finish.Controls.Add(this.btn_create);
            this.tab_Finish.Location = new System.Drawing.Point(4, 38);
            this.tab_Finish.Name = "tab_Finish";
            this.tab_Finish.Size = new System.Drawing.Size(568, 407);
            this.tab_Finish.TabIndex = 3;
            this.tab_Finish.Text = "Finish";
            // 
            // btn_reset
            // 
            this.btn_reset.Highlight = true;
            this.btn_reset.Location = new System.Drawing.Point(220, 189);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(62, 28);
            this.btn_reset.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_reset.TabIndex = 139;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_reset.UseSelectable = true;
            // 
            // btn_create
            // 
            this.btn_create.Highlight = true;
            this.btn_create.Location = new System.Drawing.Point(286, 189);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(62, 28);
            this.btn_create.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_create.TabIndex = 138;
            this.btn_create.Text = "Create";
            this.btn_create.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_create.UseSelectable = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel15.ForeColor = System.Drawing.Color.Black;
            this.metroLabel15.Location = new System.Drawing.Point(30, 79);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(135, 30);
            this.metroLabel15.TabIndex = 115;
            this.metroLabel15.Text = "Set here your compatible \r\nscreen resolution";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel15.UseCustomBackColor = true;
            // 
            // txtb_SCREEN_manualresolution
            // 
            this.txtb_SCREEN_manualresolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtb_SCREEN_manualresolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb_SCREEN_manualresolution.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SCREEN_manualresolution.ForeColor = System.Drawing.SystemColors.Control;
            this.txtb_SCREEN_manualresolution.Location = new System.Drawing.Point(30, 56);
            this.txtb_SCREEN_manualresolution.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_SCREEN_manualresolution.Name = "txtb_SCREEN_manualresolution";
            this.txtb_SCREEN_manualresolution.Size = new System.Drawing.Size(104, 21);
            this.txtb_SCREEN_manualresolution.TabIndex = 113;
            // 
            // chk_SCREEN_autosize
            // 
            this.chk_SCREEN_autosize.AutoSize = true;
            this.chk_SCREEN_autosize.Checked = true;
            this.chk_SCREEN_autosize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SCREEN_autosize.Location = new System.Drawing.Point(30, 37);
            this.chk_SCREEN_autosize.Margin = new System.Windows.Forms.Padding(2);
            this.chk_SCREEN_autosize.Name = "chk_SCREEN_autosize";
            this.chk_SCREEN_autosize.Size = new System.Drawing.Size(73, 15);
            this.chk_SCREEN_autosize.TabIndex = 112;
            this.chk_SCREEN_autosize.Text = "Auto-size";
            this.chk_SCREEN_autosize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chk_SCREEN_autosize.UseSelectable = true;
            // 
            // tab_BootScreen
            // 
            this.tab_BootScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tab_BootScreen.Controls.Add(this.btn_Next_2);
            this.tab_BootScreen.Location = new System.Drawing.Point(4, 38);
            this.tab_BootScreen.Name = "tab_BootScreen";
            this.tab_BootScreen.Size = new System.Drawing.Size(568, 407);
            this.tab_BootScreen.TabIndex = 4;
            this.tab_BootScreen.Text = "Boot screen";
            // 
            // btn_Next
            // 
            this.btn_Next.Highlight = true;
            this.btn_Next.Location = new System.Drawing.Point(489, 364);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(62, 28);
            this.btn_Next.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Next.TabIndex = 146;
            this.btn_Next.Text = "Next";
            this.btn_Next.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Next.UseSelectable = true;
            // 
            // btn_Next_2
            // 
            this.btn_Next_2.Highlight = true;
            this.btn_Next_2.Location = new System.Drawing.Point(253, 189);
            this.btn_Next_2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next_2.Name = "btn_Next_2";
            this.btn_Next_2.Size = new System.Drawing.Size(62, 28);
            this.btn_Next_2.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Next_2.TabIndex = 147;
            this.btn_Next_2.Text = "Next";
            this.btn_Next_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Next_2.UseSelectable = true;
            // 
            // btn_Next3
            // 
            this.btn_Next3.Highlight = true;
            this.btn_Next3.Location = new System.Drawing.Point(253, 189);
            this.btn_Next3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next3.Name = "btn_Next3";
            this.btn_Next3.Size = new System.Drawing.Size(62, 28);
            this.btn_Next3.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Next3.TabIndex = 147;
            this.btn_Next3.Text = "Next";
            this.btn_Next3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Next3.UseSelectable = true;
            // 
            // btn_Next4
            // 
            this.btn_Next4.Highlight = true;
            this.btn_Next4.Location = new System.Drawing.Point(253, 189);
            this.btn_Next4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Next4.Name = "btn_Next4";
            this.btn_Next4.Size = new System.Drawing.Size(62, 28);
            this.btn_Next4.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_Next4.TabIndex = 147;
            this.btn_Next4.Text = "Next";
            this.btn_Next4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Next4.UseSelectable = true;
            // 
            // New_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 525);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_OS";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "New OS";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.metroTabControl1.ResumeLayout(false);
            this.tab_OS.ResumeLayout(false);
            this.tab_OS.PerformLayout();
            this.tab_Screen.ResumeLayout(false);
            this.tab_Screen.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tab_Cursor.ResumeLayout(false);
            this.tab_Finish.ResumeLayout(false);
            this.tab_BootScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_OS;
        private MetroFramework.Controls.MetroTabPage tab_Screen;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton btn_vmFolder;
        private System.Windows.Forms.TextBox txtb_pathVM;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_osFolder;
        private System.Windows.Forms.TextBox txtb_osPath;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.TextBox txtb_osSystemName;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox txtb_mediaFolder;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime DateTime_creation;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txtb_authors;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox txtb_compagny;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txtb_osName;
        private System.Windows.Forms.TabPage tab_Cursor;
        private System.Windows.Forms.TabPage tab_Finish;
        private MetroFramework.Controls.MetroButton btn_reset;
        private MetroFramework.Controls.MetroButton btn_create;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.TextBox txtb_SCREEN_manualresolution;
        private MetroFramework.Controls.MetroCheckBox chk_SCREEN_autosize;
        private System.Windows.Forms.TabPage tab_BootScreen;
        private MetroFramework.Controls.MetroButton btn_Next;
        private MetroFramework.Controls.MetroButton btn_Next_2;
        private MetroFramework.Controls.MetroButton btn_Next3;
        private MetroFramework.Controls.MetroButton btn_Next4;
    }
}