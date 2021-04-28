using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using WeifenLuo.WinFormsUI.Docking;
using OSMaker.Panneaux;

namespace OSMaker
{
    [DesignerGenerated()]
    public partial class EditeurCCplus : DocumentC
    {

        // UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requise par le Concepteur Windows Form
        private System.ComponentModel.IContainer components;

        // REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        // Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        // Ne la modifiez pas à l'aide de l'éditeur de code.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._Panel1 = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroFichierCCPlus = new MetroFramework.Controls.MetroTextBox();
            this.metroFichierXml = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.afficherLeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lierÀUnÉvènementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mettreAuPremierPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreÀLarrièrePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.vérouillerLesControlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.sélectionnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Panel1
            // 
            this._Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Panel1.AutoScroll = true;
            this._Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._Panel1.ForeColor = System.Drawing.Color.Black;
            this._Panel1.Location = new System.Drawing.Point(0, 33);
            this._Panel1.Margin = new System.Windows.Forms.Padding(4);
            this._Panel1.Name = "_Panel1";
            this._Panel1.Size = new System.Drawing.Size(1053, 609);
            this._Panel1.TabIndex = 13;
            this._Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this._Panel1.DoubleClick += new System.EventHandler(this._Panel1_DoubleClick);
            this._Panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._Panel1_MouseDoubleClick);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 453);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1053, 189);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Visible = false;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1045, 144);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Evènements";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.UseCustomBackColor = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroFichierCCPlus
            // 
            // 
            // 
            // 
            this.metroFichierCCPlus.CustomButton.Image = null;
            this.metroFichierCCPlus.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.metroFichierCCPlus.CustomButton.Name = "";
            this.metroFichierCCPlus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroFichierCCPlus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierCCPlus.CustomButton.TabIndex = 1;
            this.metroFichierCCPlus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroFichierCCPlus.CustomButton.UseSelectable = true;
            this.metroFichierCCPlus.CustomButton.Visible = false;
            this.metroFichierCCPlus.Lines = new string[0];
            this.metroFichierCCPlus.Location = new System.Drawing.Point(45, 3);
            this.metroFichierCCPlus.MaxLength = 32767;
            this.metroFichierCCPlus.Name = "metroFichierCCPlus";
            this.metroFichierCCPlus.PasswordChar = '\0';
            this.metroFichierCCPlus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroFichierCCPlus.SelectedText = "";
            this.metroFichierCCPlus.SelectionLength = 0;
            this.metroFichierCCPlus.SelectionStart = 0;
            this.metroFichierCCPlus.ShortcutsEnabled = true;
            this.metroFichierCCPlus.Size = new System.Drawing.Size(468, 23);
            this.metroFichierCCPlus.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierCCPlus.TabIndex = 77;
            this.metroFichierCCPlus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroFichierCCPlus.UseCustomBackColor = true;
            this.metroFichierCCPlus.UseSelectable = true;
            this.metroFichierCCPlus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroFichierCCPlus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroFichierXml
            // 
            // 
            // 
            // 
            this.metroFichierXml.CustomButton.Image = null;
            this.metroFichierXml.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.metroFichierXml.CustomButton.Name = "";
            this.metroFichierXml.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroFichierXml.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierXml.CustomButton.TabIndex = 1;
            this.metroFichierXml.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroFichierXml.CustomButton.UseSelectable = true;
            this.metroFichierXml.CustomButton.Visible = false;
            this.metroFichierXml.Lines = new string[0];
            this.metroFichierXml.Location = new System.Drawing.Point(519, 3);
            this.metroFichierXml.MaxLength = 32767;
            this.metroFichierXml.Name = "metroFichierXml";
            this.metroFichierXml.PasswordChar = '\0';
            this.metroFichierXml.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroFichierXml.SelectedText = "";
            this.metroFichierXml.SelectionLength = 0;
            this.metroFichierXml.SelectionStart = 0;
            this.metroFichierXml.ShortcutsEnabled = true;
            this.metroFichierXml.Size = new System.Drawing.Size(468, 23);
            this.metroFichierXml.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierXml.TabIndex = 71;
            this.metroFichierXml.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroFichierXml.UseCustomBackColor = true;
            this.metroFichierXml.UseSelectable = true;
            this.metroFichierXml.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroFichierXml.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLeCodeToolStripMenuItem,
            this.lierÀUnÉvènementToolStripMenuItem,
            this.toolStripMenuItem5,
            this.mettreAuPremierPlanToolStripMenuItem,
            this.mettreÀLarrièrePlanToolStripMenuItem,
            this.toolStripSeparator5,
            this.vérouillerLesControlesToolStripMenuItem,
            this.toolStripSeparator6,
            this.sélectionnerToolStripMenuItem,
            this.toolStripSeparator4,
            this.testToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.testToolStripMenuItem2,
            this.testToolStripMenuItem3,
            this.toolStripSeparator3,
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripMenuItem12,
            this.propriétésToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(236, 378);
            this.metroContextMenu1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroContextMenu1.UseStyleColors = true;
            // 
            // afficherLeCodeToolStripMenuItem
            // 
            this.afficherLeCodeToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.code_cpc_file;
            this.afficherLeCodeToolStripMenuItem.Name = "afficherLeCodeToolStripMenuItem";
            this.afficherLeCodeToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.afficherLeCodeToolStripMenuItem.Text = "Afficher le code";
            // 
            // lierÀUnÉvènementToolStripMenuItem
            // 
            this.lierÀUnÉvènementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseClickToolStripMenuItem});
            this.lierÀUnÉvènementToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.light16;
            this.lierÀUnÉvènementToolStripMenuItem.Name = "lierÀUnÉvènementToolStripMenuItem";
            this.lierÀUnÉvènementToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.lierÀUnÉvènementToolStripMenuItem.Text = "Lier à un évènement";
            // 
            // mouseClickToolStripMenuItem
            // 
            this.mouseClickToolStripMenuItem.Name = "mouseClickToolStripMenuItem";
            this.mouseClickToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.mouseClickToolStripMenuItem.Text = "MouseClick";
            this.mouseClickToolStripMenuItem.Click += new System.EventHandler(this.mouseClickToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(232, 6);
            // 
            // mettreAuPremierPlanToolStripMenuItem
            // 
            this.mettreAuPremierPlanToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.BringtoFront_16x;
            this.mettreAuPremierPlanToolStripMenuItem.Name = "mettreAuPremierPlanToolStripMenuItem";
            this.mettreAuPremierPlanToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.mettreAuPremierPlanToolStripMenuItem.Text = "Mettre au premier plan";
            // 
            // mettreÀLarrièrePlanToolStripMenuItem
            // 
            this.mettreÀLarrièrePlanToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.BringForward_16x;
            this.mettreÀLarrièrePlanToolStripMenuItem.Name = "mettreÀLarrièrePlanToolStripMenuItem";
            this.mettreÀLarrièrePlanToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.mettreÀLarrièrePlanToolStripMenuItem.Text = "Mettre à l\'arrière plan";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(232, 6);
            // 
            // vérouillerLesControlesToolStripMenuItem
            // 
            this.vérouillerLesControlesToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.Lock_16x;
            this.vérouillerLesControlesToolStripMenuItem.Name = "vérouillerLesControlesToolStripMenuItem";
            this.vérouillerLesControlesToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.vérouillerLesControlesToolStripMenuItem.Text = "Vérouiller les controles";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(232, 6);
            // 
            // sélectionnerToolStripMenuItem
            // 
            this.sélectionnerToolStripMenuItem.Name = "sélectionnerToolStripMenuItem";
            this.sélectionnerToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.sélectionnerToolStripMenuItem.Text = "Sélectionner tout";
            this.sélectionnerToolStripMenuItem.Click += new System.EventHandler(this.sélectionnerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(232, 6);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.scissors;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.testToolStripMenuItem.Text = "Couper";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Image = global::OSMaker.My.Resources.Resources.copy_paste_documents_1580__Copier_;
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.testToolStripMenuItem1.Text = "Copier";
            this.testToolStripMenuItem1.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.Image = global::OSMaker.My.Resources.Resources.clipboard;
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(235, 26);
            this.testToolStripMenuItem2.Text = "Coller";
            this.testToolStripMenuItem2.Click += new System.EventHandler(this.testToolStripMenuItem2_Click);
            // 
            // testToolStripMenuItem3
            // 
            this.testToolStripMenuItem3.Image = global::OSMaker.My.Resources.Resources.close;
            this.testToolStripMenuItem3.Name = "testToolStripMenuItem3";
            this.testToolStripMenuItem3.Size = new System.Drawing.Size(235, 26);
            this.testToolStripMenuItem3.Text = "Supprimer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.arrows___Copie;
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.arrows;
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.rétablirToolStripMenuItem.Text = "Rétablir";
            this.rétablirToolStripMenuItem.Click += new System.EventHandler(this.rétablirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(232, 6);
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.gear_1_;
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            this.propriétésToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.propriétésToolStripMenuItem.Text = "Propriétés";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.metroFichierXml);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroFichierCCPlus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 31);
            this.panel1.TabIndex = 79;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::OSMaker.My.Resources.Resources.Save_37110;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.Location = new System.Drawing.Point(4, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 23);
            this.metroButton1.TabIndex = 78;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // EditeurCCplus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1053, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this._Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditeurCCplus";
            this.Load += new System.EventHandler(this.EditeurCCplus_Load);
            this.metroTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    
        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                    _Panel1.Paint -= Panel1_Paint;
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                    _Panel1.Paint += Panel1_Paint;
                }
            }
        }

     

        internal Timer Timer1;

       
        internal ToolStripMenuItem ToolStripMenuItem1;

   

    

     

       

        
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        public MetroFramework.Controls.MetroTextBox metroFichierCCPlus;
        public MetroFramework.Controls.MetroTextBox metroFichierXml;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem1;
        private ToolStripMenuItem testToolStripMenuItem2;
        private ToolStripMenuItem testToolStripMenuItem3;
        private ToolStripMenuItem afficherLeCodeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem mettreAuPremierPlanToolStripMenuItem;
        private ToolStripMenuItem mettreÀLarrièrePlanToolStripMenuItem;
        private ToolStripMenuItem vérouillerLesControlesToolStripMenuItem;
        private ToolStripMenuItem sélectionnerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem annulerToolStripMenuItem;
        private ToolStripMenuItem rétablirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem12;
        private ToolStripMenuItem propriétésToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem lierÀUnÉvènementToolStripMenuItem;
        private ToolStripMenuItem mouseClickToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Panel panel1;
    }
}