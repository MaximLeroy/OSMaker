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
    public partial class IUGConceptor : DocumentC
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroButton20 = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton16 = new MetroFramework.Controls.MetroButton();
            this.metroButton15 = new MetroFramework.Controls.MetroButton();
            this.metroFichierXml = new MetroFramework.Controls.MetroTextBox();
            this.metroFichierCCPlus = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.sélectionnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton17 = new MetroFramework.Controls.MetroButton();
            this.metroButton18 = new MetroFramework.Controls.MetroButton();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroButton14 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.affichierLeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpcdosCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lierÀUnÉvènementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseClickToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mettreEnAvantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreEnArrièrePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.vérouillerLesContrôlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.annulerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.alignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.sélectionnerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherLeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lierÀUnÉvènementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreAuPremierPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mettreÀLarrièrePlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vérouillerLesControlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Panel1
            // 
            this._Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Panel1.AutoScroll = true;
            this._Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._Panel1.Controls.Add(this.panel3);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.metroButton20);
            this.panel3.Location = new System.Drawing.Point(618, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 165);
            this.panel3.TabIndex = 79;
            this.panel3.Visible = false;
            // 
            // metroButton20
            // 
            this.metroButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton20.Location = new System.Drawing.Point(3, 3);
            this.metroButton20.Name = "metroButton20";
            this.metroButton20.Size = new System.Drawing.Size(268, 23);
            this.metroButton20.TabIndex = 80;
            this.metroButton20.Text = "MouseClick()";
            this.metroButton20.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton20.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroButton16);
            this.panel2.Controls.Add(this.metroButton15);
            this.panel2.Controls.Add(this.metroFichierXml);
            this.panel2.Controls.Add(this.metroFichierCCPlus);
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 63);
            this.panel2.TabIndex = 78;
            this.panel2.Visible = false;
            // 
            // metroButton16
            // 
            this.metroButton16.BackgroundImage = global::OSMaker.My.Resources.Resources.FolderBrowserDialogControl_16x;
            this.metroButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton16.Location = new System.Drawing.Point(458, 33);
            this.metroButton16.Name = "metroButton16";
            this.metroButton16.Size = new System.Drawing.Size(35, 23);
            this.metroButton16.TabIndex = 81;
            this.metroButton16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton16.UseSelectable = true;
            // 
            // metroButton15
            // 
            this.metroButton15.BackgroundImage = global::OSMaker.My.Resources.Resources.FolderBrowserDialogControl_16x;
            this.metroButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton15.Location = new System.Drawing.Point(458, 4);
            this.metroButton15.Name = "metroButton15";
            this.metroButton15.Size = new System.Drawing.Size(35, 23);
            this.metroButton15.TabIndex = 80;
            this.metroButton15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton15.UseSelectable = true;
            // 
            // metroFichierXml
            // 
            // 
            // 
            // 
            this.metroFichierXml.CustomButton.Image = null;
            this.metroFichierXml.CustomButton.Location = new System.Drawing.Point(427, 1);
            this.metroFichierXml.CustomButton.Name = "";
            this.metroFichierXml.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroFichierXml.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierXml.CustomButton.TabIndex = 1;
            this.metroFichierXml.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroFichierXml.CustomButton.UseSelectable = true;
            this.metroFichierXml.CustomButton.Visible = false;
            this.metroFichierXml.Lines = new string[0];
            this.metroFichierXml.Location = new System.Drawing.Point(3, 4);
            this.metroFichierXml.MaxLength = 32767;
            this.metroFichierXml.Name = "metroFichierXml";
            this.metroFichierXml.PasswordChar = '\0';
            this.metroFichierXml.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroFichierXml.SelectedText = "";
            this.metroFichierXml.SelectionLength = 0;
            this.metroFichierXml.SelectionStart = 0;
            this.metroFichierXml.ShortcutsEnabled = true;
            this.metroFichierXml.Size = new System.Drawing.Size(449, 23);
            this.metroFichierXml.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierXml.TabIndex = 71;
            this.metroFichierXml.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroFichierXml.UseCustomBackColor = true;
            this.metroFichierXml.UseSelectable = true;
            this.metroFichierXml.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroFichierXml.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroFichierCCPlus
            // 
            // 
            // 
            // 
            this.metroFichierCCPlus.CustomButton.Image = null;
            this.metroFichierCCPlus.CustomButton.Location = new System.Drawing.Point(427, 1);
            this.metroFichierCCPlus.CustomButton.Name = "";
            this.metroFichierCCPlus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroFichierCCPlus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierCCPlus.CustomButton.TabIndex = 1;
            this.metroFichierCCPlus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroFichierCCPlus.CustomButton.UseSelectable = true;
            this.metroFichierCCPlus.CustomButton.Visible = false;
            this.metroFichierCCPlus.Lines = new string[0];
            this.metroFichierCCPlus.Location = new System.Drawing.Point(3, 33);
            this.metroFichierCCPlus.MaxLength = 32767;
            this.metroFichierCCPlus.Name = "metroFichierCCPlus";
            this.metroFichierCCPlus.PasswordChar = '\0';
            this.metroFichierCCPlus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroFichierCCPlus.SelectedText = "";
            this.metroFichierCCPlus.SelectionLength = 0;
            this.metroFichierCCPlus.SelectionStart = 0;
            this.metroFichierCCPlus.ShortcutsEnabled = true;
            this.metroFichierCCPlus.Size = new System.Drawing.Size(449, 23);
            this.metroFichierCCPlus.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierCCPlus.TabIndex = 77;
            this.metroFichierCCPlus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroFichierCCPlus.UseCustomBackColor = true;
            this.metroFichierCCPlus.UseSelectable = true;
            this.metroFichierCCPlus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroFichierCCPlus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(228, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(228, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(228, 6);
            // 
            // sélectionnerToolStripMenuItem
            // 
            this.sélectionnerToolStripMenuItem.Name = "sélectionnerToolStripMenuItem";
            this.sélectionnerToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.sélectionnerToolStripMenuItem.Text = "Sélectionner tout";
            this.sélectionnerToolStripMenuItem.Click += new System.EventHandler(this.sélectionnerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(228, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(228, 6);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.metroButton17);
            this.panel1.Controls.Add(this.metroButton18);
            this.panel1.Controls.Add(this.metroButton11);
            this.panel1.Controls.Add(this.metroButton12);
            this.panel1.Controls.Add(this.metroButton13);
            this.panel1.Controls.Add(this.metroButton14);
            this.panel1.Controls.Add(this.metroButton7);
            this.panel1.Controls.Add(this.metroButton8);
            this.panel1.Controls.Add(this.metroButton9);
            this.panel1.Controls.Add(this.metroButton10);
            this.panel1.Controls.Add(this.metroButton5);
            this.panel1.Controls.Add(this.metroButton6);
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 31);
            this.panel1.TabIndex = 79;
            // 
            // metroButton17
            // 
            this.metroButton17.BackgroundImage = global::OSMaker.My.Resources.Resources.EventAdded_16x;
            this.metroButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton17.Location = new System.Drawing.Point(618, 3);
            this.metroButton17.Name = "metroButton17";
            this.metroButton17.Size = new System.Drawing.Size(35, 23);
            this.metroButton17.TabIndex = 93;
            this.metroButton17.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton17.UseSelectable = true;
            // 
            // metroButton18
            // 
            this.metroButton18.BackgroundImage = global::OSMaker.My.Resources.Resources.code_cpc_file__Copier_;
            this.metroButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton18.Location = new System.Drawing.Point(577, 3);
            this.metroButton18.Name = "metroButton18";
            this.metroButton18.Size = new System.Drawing.Size(35, 23);
            this.metroButton18.TabIndex = 92;
            this.metroButton18.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton18.UseSelectable = true;
      
            // 
            // metroButton11
            // 
            this.metroButton11.BackgroundImage = global::OSMaker.My.Resources.Resources.SelectAll_16x;
            this.metroButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton11.Location = new System.Drawing.Point(537, 3);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(35, 23);
            this.metroButton11.TabIndex = 91;
            this.metroButton11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton11.UseSelectable = true;
            this.metroButton11.Click += new System.EventHandler(this.metroButton11_Click);
            // 
            // metroButton12
            // 
            this.metroButton12.BackgroundImage = global::OSMaker.My.Resources.Resources.CenterVertically_16x;
            this.metroButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton12.Location = new System.Drawing.Point(494, 3);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(35, 23);
            this.metroButton12.TabIndex = 90;
            this.metroButton12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton12.UseSelectable = true;
            this.metroButton12.Click += new System.EventHandler(this.metroButton12_Click);
            // 
            // metroButton13
            // 
            this.metroButton13.BackgroundImage = global::OSMaker.My.Resources.Resources.CenterHorizontally_16x;
            this.metroButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton13.Location = new System.Drawing.Point(455, 3);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(35, 23);
            this.metroButton13.TabIndex = 89;
            this.metroButton13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton13.UseSelectable = true;
            this.metroButton13.Click += new System.EventHandler(this.metroButton13_Click);
            // 
            // metroButton14
            // 
            this.metroButton14.BackgroundImage = global::OSMaker.My.Resources.Resources.Lock_16x;
            this.metroButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton14.Location = new System.Drawing.Point(410, 3);
            this.metroButton14.Name = "metroButton14";
            this.metroButton14.Size = new System.Drawing.Size(35, 23);
            this.metroButton14.TabIndex = 88;
            this.metroButton14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton14.UseSelectable = true;
            this.metroButton14.Click += new System.EventHandler(this.metroButton14_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.BackgroundImage = global::OSMaker.My.Resources.Resources.arriere;
            this.metroButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton7.Location = new System.Drawing.Point(366, 3);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(35, 23);
            this.metroButton7.TabIndex = 87;
            this.metroButton7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton8
            // 
            this.metroButton8.BackgroundImage = global::OSMaker.My.Resources.Resources.avant;
            this.metroButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton8.Location = new System.Drawing.Point(328, 3);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(35, 23);
            this.metroButton8.TabIndex = 86;
            this.metroButton8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton8.UseSelectable = true;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.BackgroundImage = global::OSMaker.My.Resources.Resources.DeleteAzureResource_16x;
            this.metroButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton9.Location = new System.Drawing.Point(285, 3);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(35, 23);
            this.metroButton9.TabIndex = 85;
            this.metroButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton9.UseSelectable = true;
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // metroButton10
            // 
            this.metroButton10.BackgroundImage = global::OSMaker.My.Resources.Resources.Paste_16x;
            this.metroButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton10.Location = new System.Drawing.Point(243, 3);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(35, 23);
            this.metroButton10.TabIndex = 84;
            this.metroButton10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton10.UseSelectable = true;
            this.metroButton10.Click += new System.EventHandler(this.metroButton10_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = global::OSMaker.My.Resources.Resources.Copy_16x;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton5.Location = new System.Drawing.Point(205, 3);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(35, 23);
            this.metroButton5.TabIndex = 83;
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackgroundImage = global::OSMaker.My.Resources.Resources.Cut_16x;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton6.Location = new System.Drawing.Point(167, 3);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(35, 23);
            this.metroButton6.TabIndex = 82;
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = global::OSMaker.My.Resources.Resources.Redo_16x;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton4.Location = new System.Drawing.Point(123, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(35, 23);
            this.metroButton4.TabIndex = 81;
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackgroundImage = global::OSMaker.My.Resources.Resources.Undo_16x;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.Location = new System.Drawing.Point(85, 3);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(35, 23);
            this.metroButton3.TabIndex = 80;
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.BackgroundImage = global::OSMaker.My.Resources.Resources.FolderInformation_16x;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(42, 3);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(35, 23);
            this.metroButton2.TabIndex = 79;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::OSMaker.My.Resources.Resources.Save_37110__Copier_;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(4, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(35, 23);
            this.metroButton1.TabIndex = 78;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichierLeCodeToolStripMenuItem,
            this.lierÀUnÉvènementToolStripMenuItem1,
            this.toolStripSeparator7,
            this.couperToolStripMenuItem,
            this.copierCtrlCToolStripMenuItem,
            this.collerCtrlVToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.toolStripMenuItem6,
            this.mettreEnAvantToolStripMenuItem,
            this.mettreEnArrièrePlanToolStripMenuItem,
            this.toolStripSeparator8,
            this.vérouillerLesContrôlesToolStripMenuItem,
            this.toolStripSeparator9,
            this.annulerToolStripMenuItem1,
            this.rétablirToolStripMenuItem1,
            this.toolStripSeparator11,
            this.alignerToolStripMenuItem,
            this.toolStripSeparator10,
            this.sélectionnerToutToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(199, 378);
            this.metroContextMenu1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroContextMenu1.UseStyleColors = true;
            this.metroContextMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu1_Opening);
            // 
            // affichierLeCodeToolStripMenuItem
            // 
            this.affichierLeCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpcdosCToolStripMenuItem,
            this.oSMToolStripMenuItem});
            this.affichierLeCodeToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.CodeDefinitionWindow_16x;
            this.affichierLeCodeToolStripMenuItem.Name = "affichierLeCodeToolStripMenuItem";
            this.affichierLeCodeToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.affichierLeCodeToolStripMenuItem.Text = "Show code";
            // 
            // cpcdosCToolStripMenuItem
            // 
            this.cpcdosCToolStripMenuItem.Name = "cpcdosCToolStripMenuItem";
            this.cpcdosCToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.cpcdosCToolStripMenuItem.Text = "CpcdosC+";
            // 
            // oSMToolStripMenuItem
            // 
            this.oSMToolStripMenuItem.Name = "oSMToolStripMenuItem";
            this.oSMToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.oSMToolStripMenuItem.Text = "OSM";
            // 
            // lierÀUnÉvènementToolStripMenuItem1
            // 
            this.lierÀUnÉvènementToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseClickToolStripMenuItem1,
            this.mouseMoveToolStripMenuItem});
            this.lierÀUnÉvènementToolStripMenuItem1.Image = global::OSMaker.My.Resources.Resources.EventAdded_16x;
            this.lierÀUnÉvènementToolStripMenuItem1.Name = "lierÀUnÉvènementToolStripMenuItem1";
            this.lierÀUnÉvènementToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.lierÀUnÉvènementToolStripMenuItem1.Text = "Link to an event";
            // 
            // mouseClickToolStripMenuItem1
            // 
            this.mouseClickToolStripMenuItem1.Name = "mouseClickToolStripMenuItem1";
            this.mouseClickToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.mouseClickToolStripMenuItem1.Text = "MouseClick()";
            // 
            // mouseMoveToolStripMenuItem
            // 
            this.mouseMoveToolStripMenuItem.Name = "mouseMoveToolStripMenuItem";
            this.mouseMoveToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.mouseMoveToolStripMenuItem.Text = "MouseMove()";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(239, 6);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.Cut_16x;
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.couperToolStripMenuItem.Text = "Cut           Ctrl + X";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // copierCtrlCToolStripMenuItem
            // 
            this.copierCtrlCToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.Copy_16x;
            this.copierCtrlCToolStripMenuItem.Name = "copierCtrlCToolStripMenuItem";
            this.copierCtrlCToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.copierCtrlCToolStripMenuItem.Text = "Copy        Ctrl + C";
            this.copierCtrlCToolStripMenuItem.Click += new System.EventHandler(this.copierCtrlCToolStripMenuItem_Click);
            // 
            // collerCtrlVToolStripMenuItem
            // 
            this.collerCtrlVToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.Paste_16x;
            this.collerCtrlVToolStripMenuItem.Name = "collerCtrlVToolStripMenuItem";
            this.collerCtrlVToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.collerCtrlVToolStripMenuItem.Text = "Paste        Ctrl + V";
            this.collerCtrlVToolStripMenuItem.Click += new System.EventHandler(this.collerCtrlVToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.DeleteAzureResource_16x2;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.supprimerToolStripMenuItem.Text = "Delete      Del";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(239, 6);
            // 
            // mettreEnAvantToolStripMenuItem
            // 
            this.mettreEnAvantToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.avant;
            this.mettreEnAvantToolStripMenuItem.Name = "mettreEnAvantToolStripMenuItem";
            this.mettreEnAvantToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.mettreEnAvantToolStripMenuItem.Text = "Bring to front";
            this.mettreEnAvantToolStripMenuItem.Click += new System.EventHandler(this.mettreEnAvantToolStripMenuItem_Click);
            // 
            // mettreEnArrièrePlanToolStripMenuItem
            // 
            this.mettreEnArrièrePlanToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.arriere;
            this.mettreEnArrièrePlanToolStripMenuItem.Name = "mettreEnArrièrePlanToolStripMenuItem";
            this.mettreEnArrièrePlanToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.mettreEnArrièrePlanToolStripMenuItem.Text = "Bring forward";
            this.mettreEnArrièrePlanToolStripMenuItem.Click += new System.EventHandler(this.mettreEnArrièrePlanToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(239, 6);
            // 
            // vérouillerLesContrôlesToolStripMenuItem
            // 
            this.vérouillerLesContrôlesToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.Lock_16x;
            this.vérouillerLesContrôlesToolStripMenuItem.Name = "vérouillerLesContrôlesToolStripMenuItem";
            this.vérouillerLesContrôlesToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.vérouillerLesContrôlesToolStripMenuItem.Text = "Lock controls";
            this.vérouillerLesContrôlesToolStripMenuItem.Click += new System.EventHandler(this.vérouillerLesContrôlesToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(239, 6);
            // 
            // annulerToolStripMenuItem1
            // 
            this.annulerToolStripMenuItem1.Image = global::OSMaker.My.Resources.Resources.Undo_16x;
            this.annulerToolStripMenuItem1.Name = "annulerToolStripMenuItem1";
            this.annulerToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.annulerToolStripMenuItem1.Text = "Undo";
            this.annulerToolStripMenuItem1.Click += new System.EventHandler(this.annulerToolStripMenuItem1_Click);
            // 
            // rétablirToolStripMenuItem1
            // 
            this.rétablirToolStripMenuItem1.Image = global::OSMaker.My.Resources.Resources.Redo_16x;
            this.rétablirToolStripMenuItem1.Name = "rétablirToolStripMenuItem1";
            this.rétablirToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.rétablirToolStripMenuItem1.Text = "Redo";
            this.rétablirToolStripMenuItem1.Click += new System.EventHandler(this.rétablirToolStripMenuItem1_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(239, 6);
            // 
            // alignerToolStripMenuItem
            // 
            this.alignerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalementToolStripMenuItem,
            this.verticalementToolStripMenuItem});
            this.alignerToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.FormatDocument_16x;
            this.alignerToolStripMenuItem.Name = "alignerToolStripMenuItem";
            this.alignerToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.alignerToolStripMenuItem.Text = "Center";
            // 
            // horizontalementToolStripMenuItem
            // 
            this.horizontalementToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.CenterHorizontally_16x;
            this.horizontalementToolStripMenuItem.Name = "horizontalementToolStripMenuItem";
            this.horizontalementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.horizontalementToolStripMenuItem.Text = "Horizontally";
            this.horizontalementToolStripMenuItem.Click += new System.EventHandler(this.horizontalementToolStripMenuItem_Click_1);
            // 
            // verticalementToolStripMenuItem
            // 
            this.verticalementToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.CenterVertically_16x;
            this.verticalementToolStripMenuItem.Name = "verticalementToolStripMenuItem";
            this.verticalementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verticalementToolStripMenuItem.Text = "Vertically";
            this.verticalementToolStripMenuItem.Click += new System.EventHandler(this.verticalementToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(239, 6);
            // 
            // sélectionnerToutToolStripMenuItem
            // 
            this.sélectionnerToutToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.SelectAll_16x;
            this.sélectionnerToutToolStripMenuItem.Name = "sélectionnerToutToolStripMenuItem";
            this.sélectionnerToutToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.sélectionnerToutToolStripMenuItem.Text = "Select all";
            this.sélectionnerToutToolStripMenuItem.Click += new System.EventHandler(this.sélectionnerToutToolStripMenuItem_Click_1);
            // 
            // testToolStripMenuItem3
            // 
            this.testToolStripMenuItem3.Name = "testToolStripMenuItem3";
            this.testToolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            this.propriétésToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // afficherLeCodeToolStripMenuItem
            // 
            this.afficherLeCodeToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.code_cpc_file;
            this.afficherLeCodeToolStripMenuItem.Name = "afficherLeCodeToolStripMenuItem";
            this.afficherLeCodeToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.afficherLeCodeToolStripMenuItem.Text = "Afficher le code";
            // 
            // lierÀUnÉvènementToolStripMenuItem
            // 
            this.lierÀUnÉvènementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseClickToolStripMenuItem});
            this.lierÀUnÉvènementToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.light16;
            this.lierÀUnÉvènementToolStripMenuItem.Name = "lierÀUnÉvènementToolStripMenuItem";
            this.lierÀUnÉvènementToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.lierÀUnÉvènementToolStripMenuItem.Text = "Lier à un évènement";
            // 
            // mouseClickToolStripMenuItem
            // 
            this.mouseClickToolStripMenuItem.Name = "mouseClickToolStripMenuItem";
            this.mouseClickToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.mouseClickToolStripMenuItem.Text = "MouseClick";
            this.mouseClickToolStripMenuItem.Click += new System.EventHandler(this.mouseClickToolStripMenuItem_Click);
            // 
            // mettreAuPremierPlanToolStripMenuItem
            // 
            this.mettreAuPremierPlanToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.avant;
            this.mettreAuPremierPlanToolStripMenuItem.Name = "mettreAuPremierPlanToolStripMenuItem";
            this.mettreAuPremierPlanToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.mettreAuPremierPlanToolStripMenuItem.Text = "Mettre au premier plan";
            // 
            // mettreÀLarrièrePlanToolStripMenuItem
            // 
            this.mettreÀLarrièrePlanToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.arriere;
            this.mettreÀLarrièrePlanToolStripMenuItem.Name = "mettreÀLarrièrePlanToolStripMenuItem";
            this.mettreÀLarrièrePlanToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.mettreÀLarrièrePlanToolStripMenuItem.Text = "Mettre à l\'arrière plan";
            // 
            // vérouillerLesControlesToolStripMenuItem
            // 
            this.vérouillerLesControlesToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.Lock_16x;
            this.vérouillerLesControlesToolStripMenuItem.Name = "vérouillerLesControlesToolStripMenuItem";
            this.vérouillerLesControlesToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.vérouillerLesControlesToolStripMenuItem.Text = "Vérouiller les controles";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.couper;
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.testToolStripMenuItem.Text = "Couper";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Image = global::OSMaker.My.Resources.Resources.Copy_16x;
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(231, 24);
            this.testToolStripMenuItem1.Text = "Copier";
            this.testToolStripMenuItem1.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
            // 
            // testToolStripMenuItem2
            // 
            this.testToolStripMenuItem2.Image = global::OSMaker.My.Resources.Resources.coller;
            this.testToolStripMenuItem2.Name = "testToolStripMenuItem2";
            this.testToolStripMenuItem2.Size = new System.Drawing.Size(231, 24);
            this.testToolStripMenuItem2.Text = "Coller";
            this.testToolStripMenuItem2.Click += new System.EventHandler(this.testToolStripMenuItem2_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.undoo;
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Image = global::OSMaker.My.Resources.Resources.redoo;
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.rétablirToolStripMenuItem.Text = "Rétablir";
            this.rétablirToolStripMenuItem.Click += new System.EventHandler(this.rétablirToolStripMenuItem_Click);
            // 
            // IUGConceptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1053, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IUGConceptor";
            this.Load += new System.EventHandler(this.EditeurCCplus_Load);
            this._Panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroContextMenu1.ResumeLayout(false);
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

     

       
        internal ToolStripMenuItem ToolStripMenuItem1;

   

    

     

       
        public MetroFramework.Controls.MetroTextBox metroFichierCCPlus;
        public MetroFramework.Controls.MetroTextBox metroFichierXml;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
     
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
        private Panel panel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton17;
        private MetroFramework.Controls.MetroButton metroButton18;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton13;
        private MetroFramework.Controls.MetroButton metroButton14;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem copierCtrlCToolStripMenuItem;
        private ToolStripMenuItem collerCtrlVToolStripMenuItem;
        public MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private ToolStripMenuItem affichierLeCodeToolStripMenuItem;
        private ToolStripMenuItem cpcdosCToolStripMenuItem;
        private ToolStripMenuItem oSMToolStripMenuItem;
        private ToolStripMenuItem lierÀUnÉvènementToolStripMenuItem1;
        private ToolStripMenuItem mouseClickToolStripMenuItem1;
        private ToolStripMenuItem mouseMoveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem mettreEnAvantToolStripMenuItem;
        private ToolStripMenuItem mettreEnArrièrePlanToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem vérouillerLesContrôlesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem annulerToolStripMenuItem1;
        private ToolStripMenuItem rétablirToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem alignerToolStripMenuItem;
        private ToolStripMenuItem horizontalementToolStripMenuItem;
        private ToolStripMenuItem verticalementToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem sélectionnerToutToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton15;
        private MetroFramework.Controls.MetroButton metroButton16;
        private Panel panel3;
        private MetroFramework.Controls.MetroButton metroButton20;
    }
}