namespace OSMaker.Panneaux
{
    partial class SolutionExplorer
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Explorer");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionExplorer));
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iUGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierTexteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renommerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._tv = new System.Windows.Forms.TreeView();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtDirectory = new MetroFramework.Controls.MetroTextBox();
            this._PictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroContextMenu1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.renommerToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(152, 100);
            this.metroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroContextMenu1.UseCustomBackColor = true;
            this.metroContextMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu1_Opening);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iUGToolStripMenuItem,
            this.bureauToolStripMenuItem,
            this.fichierCCToolStripMenuItem,
            this.fichierTexteToolStripMenuItem,
            this.dossierToolStripMenuItem});
            this.nouveauToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // iUGToolStripMenuItem
            // 
            this.iUGToolStripMenuItem.Name = "iUGToolStripMenuItem";
            this.iUGToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.iUGToolStripMenuItem.Text = "IUG";
            this.iUGToolStripMenuItem.Click += new System.EventHandler(this.iUGToolStripMenuItem_Click);
            // 
            // bureauToolStripMenuItem
            // 
            this.bureauToolStripMenuItem.Name = "bureauToolStripMenuItem";
            this.bureauToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.bureauToolStripMenuItem.Text = "Bureau";
            // 
            // fichierCCToolStripMenuItem
            // 
            this.fichierCCToolStripMenuItem.Name = "fichierCCToolStripMenuItem";
            this.fichierCCToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.fichierCCToolStripMenuItem.Text = "Fichier CC+";
            this.fichierCCToolStripMenuItem.Click += new System.EventHandler(this.fichierCCToolStripMenuItem_Click);
            // 
            // fichierTexteToolStripMenuItem
            // 
            this.fichierTexteToolStripMenuItem.Name = "fichierTexteToolStripMenuItem";
            this.fichierTexteToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.fichierTexteToolStripMenuItem.Text = "Fichier Texte";
            // 
            // dossierToolStripMenuItem
            // 
            this.dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            this.dossierToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.dossierToolStripMenuItem.Text = "Dossier";
            this.dossierToolStripMenuItem.Click += new System.EventHandler(this.dossierToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // renommerToolStripMenuItem
            // 
            this.renommerToolStripMenuItem.Name = "renommerToolStripMenuItem";
            this.renommerToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.renommerToolStripMenuItem.Text = "Renommer";
            this.renommerToolStripMenuItem.Click += new System.EventHandler(this.renommerToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this._tv);
            this.panel2.Controls.Add(this.txtDirectory);
            this.panel2.Controls.Add(this._PictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 532);
            this.panel2.TabIndex = 7;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(253, 39);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Select a folder";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(5, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 10);
            this.progressBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::OSMaker.My.Resources.Resources.actualiseer;
            this.pictureBox1.Location = new System.Drawing.Point(222, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _tv
            // 
            this._tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._tv.ContextMenuStrip = this.metroContextMenu1;
            this._tv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tv.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this._tv.LabelEdit = true;
            this._tv.Location = new System.Drawing.Point(0, 48);
            this._tv.Name = "_tv";
            treeNode1.Name = "ExplorerNode";
            treeNode1.Text = "Explorer";
            this._tv.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this._tv.Size = new System.Drawing.Size(258, 481);
            this._tv.StateImageList = this.ImageList1;
            this._tv.TabIndex = 1;
            this._tv.Visible = false;
            this._tv.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this._tv_AfterLabelEdit);
            this._tv.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this._tv_BeforeCollapse);
            this._tv.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this._tv_BeforeExpand);
            this._tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this._tv_NodeMouseDoubleClick);
            this._tv.MouseDown += new System.Windows.Forms.MouseEventHandler(this._tv_MouseDown);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "FolderClosed_blue_16x.png");
            this.ImageList1.Images.SetKeyName(1, "Cpcfile.png");
            this.ImageList1.Images.SetKeyName(2, "cube(1).png");
            this.ImageList1.Images.SetKeyName(3, "FolderOpened_blue_16x.png");
            this.ImageList1.Images.SetKeyName(4, "WindowsFormBlue_16x.png");
            this.ImageList1.Images.SetKeyName(5, "logocpcdosblack16x.png");
            this.ImageList1.Images.SetKeyName(6, "DebugTemplate_16x.png");
            this.ImageList1.Images.SetKeyName(7, "ListMembers_16x.png");
            this.ImageList1.Images.SetKeyName(8, "TextFile_16x.png");
            this.ImageList1.Images.SetKeyName(9, "Image_16x.png");
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDirectory.CustomButton.Image = null;
            this.txtDirectory.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtDirectory.CustomButton.Name = "";
            this.txtDirectory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDirectory.CustomButton.TabIndex = 1;
            this.txtDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDirectory.CustomButton.UseSelectable = true;
            this.txtDirectory.CustomButton.Visible = false;
            this.txtDirectory.Lines = new string[0];
            this.txtDirectory.Location = new System.Drawing.Point(5, 19);
            this.txtDirectory.MaxLength = 32767;
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.PasswordChar = '\0';
            this.txtDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDirectory.SelectedText = "";
            this.txtDirectory.SelectionLength = 0;
            this.txtDirectory.SelectionStart = 0;
            this.txtDirectory.ShortcutsEnabled = true;
            this.txtDirectory.Size = new System.Drawing.Size(187, 23);
            this.txtDirectory.Style = MetroFramework.MetroColorStyle.Red;
            this.txtDirectory.TabIndex = 8;
            this.txtDirectory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDirectory.UseSelectable = true;
            this.txtDirectory.UseStyleColors = true;
            this.txtDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // _PictureBox1
            // 
            this._PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this._PictureBox1.ForeColor = System.Drawing.Color.Black;
            this._PictureBox1.Image = global::OSMaker.My.Resources.Resources.OpenFolder_16x;
            this._PictureBox1.Location = new System.Drawing.Point(198, 19);
            this._PictureBox1.Name = "_PictureBox1";
            this._PictureBox1.Size = new System.Drawing.Size(18, 23);
            this._PictureBox1.TabIndex = 5;
            this._PictureBox1.TabStop = false;
            this._PictureBox1.Click += new System.EventHandler(this._PictureBox1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SolutionExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 532);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SolutionExplorer";
            this.Text = "OS explorer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SolutionExplorer_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SolutionExplorer_MouseDoubleClick);
            this.metroContextMenu1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox _PictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iUGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bureauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierTexteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        internal System.Windows.Forms.ImageList ImageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroTextBox txtDirectory;
        public System.Windows.Forms.TreeView _tv;
        private System.Windows.Forms.ToolStripMenuItem renommerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        public MetroFramework.Controls.MetroButton metroButton1;
    }
}