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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditeurCCplus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._tb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DocumentMap2 = new FastColoredTextBoxNS.DocumentMap();
            this.FastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DocumentMap1 = new FastColoredTextBoxNS.DocumentMap();
            this._Panel1 = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroFichierCCPlus = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroFichierXml = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroFichierEvent = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroGridEvent = new MetroFramework.Controls.MetroGrid();
            this.metroEventCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLier = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.txtboxselection = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionnerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastColoredTextBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // _tb
            // 
            this._tb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this._tb.AutoScrollMinSize = new System.Drawing.Size(52, 17);
            this._tb.BackBrush = null;
            this._tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._tb.CharHeight = 17;
            this._tb.CharWidth = 8;
            this._tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._tb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this._tb.Font = new System.Drawing.Font("Consolas", 9F);
            this._tb.ForeColor = System.Drawing.Color.Gainsboro;
            this._tb.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._tb.IsReplaceMode = false;
            this._tb.LeftPadding = 25;
            this._tb.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this._tb.Location = new System.Drawing.Point(9, 83);
            this._tb.Margin = new System.Windows.Forms.Padding(4);
            this._tb.Name = "_tb";
            this._tb.Paddings = new System.Windows.Forms.Padding(0);
            this._tb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._tb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_tb.ServiceColors")));
            this._tb.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this._tb.ShowScrollBars = false;
            this._tb.Size = new System.Drawing.Size(478, 58);
            this._tb.TabIndex = 7;
            this._tb.Zoom = 100;
            this._tb.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tb_TextChangedDelayed);
            // 
            // DocumentMap2
            // 
            this.DocumentMap2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DocumentMap2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentMap2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.DocumentMap2.Location = new System.Drawing.Point(494, 10);
            this.DocumentMap2.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentMap2.Name = "DocumentMap2";
            this.DocumentMap2.Size = new System.Drawing.Size(542, 153);
            this.DocumentMap2.TabIndex = 7;
            this.DocumentMap2.Target = this._tb;
            this.DocumentMap2.Text = "DocumentMap2";
            // 
            // FastColoredTextBox1
            // 
            this.FastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FastColoredTextBox1.AutoIndentCharsPatterns = "";
            this.FastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 17);
            this.FastColoredTextBox1.BackBrush = null;
            this.FastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastColoredTextBox1.CharHeight = 17;
            this.FastColoredTextBox1.CharWidth = 8;
            this.FastColoredTextBox1.CommentPrefix = null;
            this.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastColoredTextBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.FastColoredTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.FastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FastColoredTextBox1.IsReplaceMode = false;
            this.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML;
            this.FastColoredTextBox1.LeftBracket = '<';
            this.FastColoredTextBox1.LeftBracket2 = '(';
            this.FastColoredTextBox1.LeftPadding = 25;
            this.FastColoredTextBox1.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.FastColoredTextBox1.Location = new System.Drawing.Point(-4, 84);
            this.FastColoredTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.FastColoredTextBox1.Name = "FastColoredTextBox1";
            this.FastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.FastColoredTextBox1.RightBracket = '>';
            this.FastColoredTextBox1.RightBracket2 = ')';
            this.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastColoredTextBox1.ServiceColors")));
            this.FastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.FastColoredTextBox1.Size = new System.Drawing.Size(488, 34);
            this.FastColoredTextBox1.TabIndex = 13;
            this.FastColoredTextBox1.Visible = false;
            this.FastColoredTextBox1.Zoom = 100;
            // 
            // DocumentMap1
            // 
            this.DocumentMap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DocumentMap1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentMap1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.DocumentMap1.Location = new System.Drawing.Point(496, 12);
            this.DocumentMap1.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentMap1.Name = "DocumentMap1";
            this.DocumentMap1.Size = new System.Drawing.Size(540, 151);
            this.DocumentMap1.TabIndex = 6;
            this.DocumentMap1.Target = this.FastColoredTextBox1;
            this.DocumentMap1.Text = "DocumentMap1";
            // 
            // _Panel1
            // 
            this._Panel1.AutoScroll = true;
            this._Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Panel1.ForeColor = System.Drawing.Color.Black;
            this._Panel1.Location = new System.Drawing.Point(0, 28);
            this._Panel1.Margin = new System.Windows.Forms.Padding(4);
            this._Panel1.Name = "_Panel1";
            this._Panel1.Size = new System.Drawing.Size(1053, 614);
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
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 430);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1053, 212);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.DocumentMap2);
            this.metroTabPage1.Controls.Add(this.metroButton4);
            this.metroTabPage1.Controls.Add(this.metroFichierCCPlus);
            this.metroTabPage1.Controls.Add(this.pictureBox2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this._tb);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1045, 167);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "CC+";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(27, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 89);
            this.panel1.TabIndex = 80;
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton4.Location = new System.Drawing.Point(69, 39);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(418, 37);
            this.metroButton4.TabIndex = 79;
            this.metroButton4.Text = "Voir le code";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseStyleColors = true;
            // 
            // metroFichierCCPlus
            // 
            // 
            // 
            // 
            this.metroFichierCCPlus.CustomButton.Image = null;
            this.metroFichierCCPlus.CustomButton.Location = new System.Drawing.Point(396, 1);
            this.metroFichierCCPlus.CustomButton.Name = "";
            this.metroFichierCCPlus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroFichierCCPlus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierCCPlus.CustomButton.TabIndex = 1;
            this.metroFichierCCPlus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroFichierCCPlus.CustomButton.UseSelectable = true;
            this.metroFichierCCPlus.CustomButton.Visible = false;
            this.metroFichierCCPlus.Lines = new string[0];
            this.metroFichierCCPlus.Location = new System.Drawing.Point(69, 10);
            this.metroFichierCCPlus.MaxLength = 32767;
            this.metroFichierCCPlus.Name = "metroFichierCCPlus";
            this.metroFichierCCPlus.PasswordChar = '\0';
            this.metroFichierCCPlus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroFichierCCPlus.SelectedText = "";
            this.metroFichierCCPlus.SelectionLength = 0;
            this.metroFichierCCPlus.SelectionStart = 0;
            this.metroFichierCCPlus.ShortcutsEnabled = true;
            this.metroFichierCCPlus.Size = new System.Drawing.Size(418, 23);
            this.metroFichierCCPlus.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierCCPlus.TabIndex = 77;
            this.metroFichierCCPlus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroFichierCCPlus.UseSelectable = true;
            this.metroFichierCCPlus.UseStyleColors = true;
            this.metroFichierCCPlus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroFichierCCPlus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::OSMaker.My.Resources.Resources.openfolderpng1;
            this.pictureBox2.Location = new System.Drawing.Point(322, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 25);
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 20);
            this.metroLabel1.TabIndex = 76;
            this.metroLabel1.Text = "Chemin";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroTabPage2.Controls.Add(this.DocumentMap1);
            this.metroTabPage2.Controls.Add(this.FastColoredTextBox1);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.metroFichierXml);
            this.metroTabPage2.Controls.Add(this.pictureBox6);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1045, 167);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = ".OSM";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.UseCustomBackColor = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(71, 40);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(418, 37);
            this.metroButton1.TabIndex = 75;
            this.metroButton1.Text = "Voir le code";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // metroFichierXml
            // 
            // 
            // 
            // 
            this.metroFichierXml.CustomButton.Image = null;
            this.metroFichierXml.CustomButton.Location = new System.Drawing.Point(396, 1);
            this.metroFichierXml.CustomButton.Name = "";
            this.metroFichierXml.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroFichierXml.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierXml.CustomButton.TabIndex = 1;
            this.metroFichierXml.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroFichierXml.CustomButton.UseSelectable = true;
            this.metroFichierXml.CustomButton.Visible = false;
            this.metroFichierXml.Lines = new string[0];
            this.metroFichierXml.Location = new System.Drawing.Point(71, 11);
            this.metroFichierXml.MaxLength = 32767;
            this.metroFichierXml.Name = "metroFichierXml";
            this.metroFichierXml.PasswordChar = '\0';
            this.metroFichierXml.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroFichierXml.SelectedText = "";
            this.metroFichierXml.SelectionLength = 0;
            this.metroFichierXml.SelectionStart = 0;
            this.metroFichierXml.ShortcutsEnabled = true;
            this.metroFichierXml.Size = new System.Drawing.Size(418, 23);
            this.metroFichierXml.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierXml.TabIndex = 71;
            this.metroFichierXml.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroFichierXml.UseSelectable = true;
            this.metroFichierXml.UseStyleColors = true;
            this.metroFichierXml.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroFichierXml.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = global::OSMaker.My.Resources.Resources.openfolderpng1;
            this.pictureBox6.Location = new System.Drawing.Point(324, 9);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 25);
            this.pictureBox6.TabIndex = 72;
            this.pictureBox6.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 20);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Chemin";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroTabPage3.Controls.Add(this.metroFichierEvent);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroGridEvent);
            this.metroTabPage3.Controls.Add(this.metroEventCombo);
            this.metroTabPage3.Controls.Add(this.metroLier);
            this.metroTabPage3.Controls.Add(this.metroButton3);
            this.metroTabPage3.Controls.Add(this.txtboxselection);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.pictureBox4);
            this.metroTabPage3.Controls.Add(this.pictureBox5);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1045, 167);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Evènements";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.UseCustomBackColor = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroFichierEvent
            // 
            // 
            // 
            // 
            this.metroFichierEvent.CustomButton.Image = null;
            this.metroFichierEvent.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.metroFichierEvent.CustomButton.Name = "";
            this.metroFichierEvent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroFichierEvent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierEvent.CustomButton.TabIndex = 1;
            this.metroFichierEvent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroFichierEvent.CustomButton.UseSelectable = true;
            this.metroFichierEvent.CustomButton.Visible = false;
            this.metroFichierEvent.Lines = new string[0];
            this.metroFichierEvent.Location = new System.Drawing.Point(135, 89);
            this.metroFichierEvent.MaxLength = 32767;
            this.metroFichierEvent.Name = "metroFichierEvent";
            this.metroFichierEvent.PasswordChar = '\0';
            this.metroFichierEvent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroFichierEvent.SelectedText = "";
            this.metroFichierEvent.SelectionLength = 0;
            this.metroFichierEvent.SelectionStart = 0;
            this.metroFichierEvent.ShortcutsEnabled = true;
            this.metroFichierEvent.Size = new System.Drawing.Size(121, 23);
            this.metroFichierEvent.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroFichierEvent.TabIndex = 79;
            this.metroFichierEvent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroFichierEvent.UseSelectable = true;
            this.metroFichierEvent.UseStyleColors = true;
            this.metroFichierEvent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroFichierEvent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 20);
            this.metroLabel4.TabIndex = 78;
            this.metroLabel4.Text = "Fichier évènement";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroGridEvent
            // 
            this.metroGridEvent.AllowUserToResizeRows = false;
            this.metroGridEvent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEvent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEvent.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridEvent.EnableHeadersVisualStyles = false;
            this.metroGridEvent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEvent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGridEvent.Location = new System.Drawing.Point(262, 3);
            this.metroGridEvent.Name = "metroGridEvent";
            this.metroGridEvent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEvent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridEvent.RowHeadersWidth = 51;
            this.metroGridEvent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEvent.RowTemplate.Height = 24;
            this.metroGridEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEvent.Size = new System.Drawing.Size(233, 146);
            this.metroGridEvent.TabIndex = 77;
            this.metroGridEvent.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroEventCombo
            // 
            this.metroEventCombo.FormattingEnabled = true;
            this.metroEventCombo.ItemHeight = 24;
            this.metroEventCombo.Location = new System.Drawing.Point(501, 3);
            this.metroEventCombo.Name = "metroEventCombo";
            this.metroEventCombo.Size = new System.Drawing.Size(240, 30);
            this.metroEventCombo.TabIndex = 76;
            this.metroEventCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroEventCombo.UseSelectable = true;
            // 
            // metroLier
            // 
            this.metroLier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroLier.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroLier.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroLier.Location = new System.Drawing.Point(501, 38);
            this.metroLier.Name = "metroLier";
            this.metroLier.Size = new System.Drawing.Size(240, 37);
            this.metroLier.TabIndex = 75;
            this.metroLier.Text = "Lier";
            this.metroLier.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLier.UseSelectable = true;
            this.metroLier.UseStyleColors = true;
            this.metroLier.Click += new System.EventHandler(this.metroLier_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton3.Location = new System.Drawing.Point(16, 38);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(240, 37);
            this.metroButton3.TabIndex = 73;
            this.metroButton3.Text = "Actualiser";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // txtboxselection
            // 
            // 
            // 
            // 
            this.txtboxselection.CustomButton.Image = null;
            this.txtboxselection.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtboxselection.CustomButton.Name = "";
            this.txtboxselection.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxselection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxselection.CustomButton.TabIndex = 1;
            this.txtboxselection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxselection.CustomButton.UseSelectable = true;
            this.txtboxselection.CustomButton.Visible = false;
            this.txtboxselection.ForeColor = System.Drawing.SystemColors.Control;
            this.txtboxselection.Lines = new string[0];
            this.txtboxselection.Location = new System.Drawing.Point(135, 9);
            this.txtboxselection.MaxLength = 32767;
            this.txtboxselection.Name = "txtboxselection";
            this.txtboxselection.PasswordChar = '\0';
            this.txtboxselection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxselection.SelectedText = "";
            this.txtboxselection.SelectionLength = 0;
            this.txtboxselection.SelectionStart = 0;
            this.txtboxselection.ShortcutsEnabled = true;
            this.txtboxselection.Size = new System.Drawing.Size(121, 23);
            this.txtboxselection.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxselection.TabIndex = 71;
            this.txtboxselection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtboxselection.UseSelectable = true;
            this.txtboxselection.UseStyleColors = true;
            this.txtboxselection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxselection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 20);
            this.metroLabel3.TabIndex = 70;
            this.metroLabel3.Text = "Objet sélectionné";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::OSMaker.My.Resources.Resources.cross;
            this.pictureBox4.Location = new System.Drawing.Point(176, 119);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 25);
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::OSMaker.My.Resources.Resources.openfolderpng1;
            this.pictureBox5.Location = new System.Drawing.Point(135, 119);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 25);
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "Fichier";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.saveToolStripMenuItem.Text = "Enregistrer";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.deleteToolStripMenuItem,
            this.centrerToolStripMenuItem,
            this.sélectionnerToutToolStripMenuItem,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.editToolStripMenuItem.Text = "Edition";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem6.Text = "&Cut (non dispo)";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem7.Text = "C&opy (non dispo)";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem8.Text = "&Paste(non dispo)";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // centrerToolStripMenuItem
            // 
            this.centrerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalementToolStripMenuItem,
            this.verticalementToolStripMenuItem});
            this.centrerToolStripMenuItem.Name = "centrerToolStripMenuItem";
            this.centrerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.centrerToolStripMenuItem.Text = "Centrer";
            // 
            // horizontalementToolStripMenuItem
            // 
            this.horizontalementToolStripMenuItem.Name = "horizontalementToolStripMenuItem";
            this.horizontalementToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.horizontalementToolStripMenuItem.Text = "Horizontalement";
            this.horizontalementToolStripMenuItem.Click += new System.EventHandler(this.horizontalementToolStripMenuItem_Click);
            // 
            // verticalementToolStripMenuItem
            // 
            this.verticalementToolStripMenuItem.Name = "verticalementToolStripMenuItem";
            this.verticalementToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.verticalementToolStripMenuItem.Text = "Verticalement";
            this.verticalementToolStripMenuItem.Click += new System.EventHandler(this.verticalementToolStripMenuItem_Click);
            // 
            // sélectionnerToutToolStripMenuItem
            // 
            this.sélectionnerToutToolStripMenuItem.Name = "sélectionnerToutToolStripMenuItem";
            this.sélectionnerToutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sélectionnerToutToolStripMenuItem.Text = "Sélectionner tout";
            this.sélectionnerToutToolStripMenuItem.Click += new System.EventHandler(this.sélectionnerToutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem9.Text = "Undo";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click_1);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem10.Text = "Redo";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // EditeurCCplus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 642);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this._Panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditeurCCplus";
            this.Load += new System.EventHandler(this.EditeurCCplus_Load);
            ((System.ComponentModel.ISupportInitialize)(this._tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastColoredTextBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        internal FastColoredTextBoxNS.FastColoredTextBox tb
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tb;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tb != null)
                {
                    _tb.TextChangedDelayed -= tb_TextChangedDelayed;
                }

                _tb = value;
                if (_tb != null)
                {
                    _tb.TextChangedDelayed += tb_TextChangedDelayed;
                }
            }
        }
        internal ToolStripMenuItem ToolStripMenuItem1;

   

    

     

       

        
        
        public FastColoredTextBoxNS.FastColoredTextBox _tb;
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        public PictureBox pictureBox4;
        public PictureBox pictureBox5;
        public FastColoredTextBoxNS.FastColoredTextBox FastColoredTextBox1;
        public FastColoredTextBoxNS.DocumentMap DocumentMap2;
        public FastColoredTextBoxNS.DocumentMap DocumentMap1;
        public MetroFramework.Controls.MetroButton metroButton4;
        public MetroFramework.Controls.MetroTextBox metroFichierCCPlus;
        public PictureBox pictureBox2;
        public MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroTextBox metroFichierXml;
        public PictureBox pictureBox6;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox metroFichierEvent;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroGrid metroGridEvent;
        public MetroFramework.Controls.MetroComboBox metroEventCombo;
        public MetroFramework.Controls.MetroButton metroLier;
        public MetroFramework.Controls.MetroButton metroButton3;
        public MetroFramework.Controls.MetroTextBox txtboxselection;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private ToolStripMenuItem centrerToolStripMenuItem;
        private ToolStripMenuItem horizontalementToolStripMenuItem;
        private ToolStripMenuItem verticalementToolStripMenuItem;
        private ToolStripMenuItem sélectionnerToutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
    }
}