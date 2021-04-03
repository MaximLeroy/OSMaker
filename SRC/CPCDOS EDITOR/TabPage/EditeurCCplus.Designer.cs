using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    [DesignerGenerated()]
    public partial class EditeurCCplus : UserControl
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
            this.DotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
            this.DockSite4 = new DevComponents.DotNetBar.DockSite();
            this.Bar1 = new DevComponents.DotNetBar.Bar();
            this.PanelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            this.PanelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this._tb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DocumentMap2 = new FastColoredTextBoxNS.DocumentMap();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this._PictureBox4 = new System.Windows.Forms.PictureBox();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PanelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            this.PanelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.DocumentMap1 = new FastColoredTextBoxNS.DocumentMap();
            this.PanelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.LabelX2 = new DevComponents.DotNetBar.LabelX();
            this.TextBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PanelDockContainer3 = new DevComponents.DotNetBar.PanelDockContainer();
            this.Panel2 = new System.Windows.Forms.Panel();
            this._PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX5 = new DevComponents.DotNetBar.LabelX();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.ButtonX15 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX14 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX13 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX12 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX11 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX10 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX6 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX7 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX8 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX9 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
            this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            this._ButtonX2 = new DevComponents.DotNetBar.ButtonX();
            this.TextBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX3 = new DevComponents.DotNetBar.LabelX();
            this._ButtonX1 = new DevComponents.DotNetBar.ButtonX();
            this.TextBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PanelDockContainer4 = new DevComponents.DotNetBar.PanelDockContainer();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.parametrescheck = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.Handletext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX14 = new DevComponents.DotNetBar.LabelX();
            this.ombretext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX13 = new DevComponents.DotNetBar.LabelX();
            this.bordtext = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem7 = new DevComponents.Editors.ComboItem();
            this.ComboItem8 = new DevComponents.Editors.ComboItem();
            this.ComboItem11 = new DevComponents.Editors.ComboItem();
            this.ctntext = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem13 = new DevComponents.Editors.ComboItem();
            this.ComboItem14 = new DevComponents.Editors.ComboItem();
            this.ComboItem10 = new DevComponents.Editors.ComboItem();
            this.Opacitetext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.couleurfondtext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX10 = new DevComponents.DotNetBar.LabelX();
            this.Couleurfenetretext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.couleurtitretext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX11 = new DevComponents.DotNetBar.LabelX();
            this.LabelX12 = new DevComponents.DotNetBar.LabelX();
            this.iconetext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX9 = new DevComponents.DotNetBar.LabelX();
            this.evenementtext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.imgtitretext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LabelX6 = new DevComponents.DotNetBar.LabelX();
            this.typetext = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem1 = new DevComponents.Editors.ComboItem();
            this.ComboItem2 = new DevComponents.Editors.ComboItem();
            this.ComboItem3 = new DevComponents.Editors.ComboItem();
            this.ComboItem4 = new DevComponents.Editors.ComboItem();
            this.ComboItem5 = new DevComponents.Editors.ComboItem();
            this.ComboItem6 = new DevComponents.Editors.ComboItem();
            this.ComboItem9 = new DevComponents.Editors.ComboItem();
            this.LabelX7 = new DevComponents.DotNetBar.LabelX();
            this.LabelX8 = new DevComponents.DotNetBar.LabelX();
            this.DockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.DockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            this.DockContainerItem3 = new DevComponents.DotNetBar.DockContainerItem();
            this.DockContainerItem4 = new DevComponents.DotNetBar.DockContainerItem();
            this.DockSite1 = new DevComponents.DotNetBar.DockSite();
            this.DockSite2 = new DevComponents.DotNetBar.DockSite();
            this.DockSite8 = new DevComponents.DotNetBar.DockSite();
            this.DockSite5 = new DevComponents.DotNetBar.DockSite();
            this.DockSite6 = new DevComponents.DotNetBar.DockSite();
            this.DockSite7 = new DevComponents.DotNetBar.DockSite();
            this.Bar2 = new DevComponents.DotNetBar.Bar();
            this._ButtonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this._ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this._Aligner = new DevComponents.DotNetBar.ButtonItem();
            this._Copy = new DevComponents.DotNetBar.ButtonItem();
            this._ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.DockSite3 = new DevComponents.DotNetBar.DockSite();
            this._Panel1 = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CoucouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DockSite4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).BeginInit();
            this.Bar1.SuspendLayout();
            this.PanelDockContainer1.SuspendLayout();
            this.PanelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tb)).BeginInit();
            this.PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox4)).BeginInit();
            this.PanelDockContainer2.SuspendLayout();
            this.PanelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FastColoredTextBox1)).BeginInit();
            this.PanelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.PanelDockContainer3.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.PanelDockContainer4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.DockSite7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bar2)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DotNetBarManager1
            // 
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.DotNetBarManager1.BottomDockSite = this.DockSite4;
            this.DotNetBarManager1.EnableFullSizeDock = false;
            this.DotNetBarManager1.LeftDockSite = this.DockSite1;
            this.DotNetBarManager1.ParentForm = null;
            this.DotNetBarManager1.ParentUserControl = this;
            this.DotNetBarManager1.RightDockSite = this.DockSite2;
            this.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DotNetBarManager1.ToolbarBottomDockSite = this.DockSite8;
            this.DotNetBarManager1.ToolbarLeftDockSite = this.DockSite5;
            this.DotNetBarManager1.ToolbarRightDockSite = this.DockSite6;
            this.DotNetBarManager1.ToolbarTopDockSite = this.DockSite7;
            this.DotNetBarManager1.TopDockSite = this.DockSite3;
            // 
            // DockSite4
            // 
            this.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite4.Controls.Add(this.Bar1);
            this.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
            ((DevComponents.DotNetBar.DocumentBaseContainer)(new DevComponents.DotNetBar.DocumentBarContainer(this.Bar1, 852, 300)))}, DevComponents.DotNetBar.eOrientation.Vertical);
            this.DockSite4.Location = new System.Drawing.Point(0, 170);
            this.DockSite4.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite4.Name = "DockSite4";
            this.DockSite4.Size = new System.Drawing.Size(852, 303);
            this.DockSite4.TabIndex = 4;
            this.DockSite4.TabStop = false;
            // 
            // Bar1
            // 
            this.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)";
            this.Bar1.AccessibleName = "DotNetBar Bar";
            this.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.Bar1.AutoSyncBarCaption = true;
            this.Bar1.CloseSingleTab = true;
            this.Bar1.Controls.Add(this.PanelDockContainer1);
            this.Bar1.Controls.Add(this.PanelDockContainer4);
            this.Bar1.Controls.Add(this.PanelDockContainer3);
            this.Bar1.Controls.Add(this.PanelDockContainer2);
            this.Bar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            this.Bar1.IsMaximized = false;
            this.Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.DockContainerItem1,
            this.DockContainerItem2,
            this.DockContainerItem3,
            this.DockContainerItem4});
            this.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            this.Bar1.Location = new System.Drawing.Point(0, 3);
            this.Bar1.Margin = new System.Windows.Forms.Padding(4);
            this.Bar1.Name = "Bar1";
            this.Bar1.SelectedDockTab = 0;
            this.Bar1.Size = new System.Drawing.Size(852, 300);
            this.Bar1.Stretch = true;
            this.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar1.TabIndex = 0;
            this.Bar1.TabStop = false;
            this.Bar1.Text = "CC+";
            // 
            // PanelDockContainer1
            // 
            this.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelDockContainer1.Controls.Add(this.PanelEx2);
            this.PanelDockContainer1.Controls.Add(this.PanelEx1);
            this.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelDockContainer1.Location = new System.Drawing.Point(3, 23);
            this.PanelDockContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDockContainer1.Name = "PanelDockContainer1";
            this.PanelDockContainer1.Size = new System.Drawing.Size(846, 249);
            this.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.PanelDockContainer1.Style.GradientAngle = 90;
            this.PanelDockContainer1.TabIndex = 0;
            // 
            // PanelEx2
            // 
            this.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx2.Controls.Add(this.SplitContainer2);
            this.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEx2.Location = new System.Drawing.Point(0, 33);
            this.PanelEx2.Margin = new System.Windows.Forms.Padding(4);
            this.PanelEx2.Name = "PanelEx2";
            this.PanelEx2.Size = new System.Drawing.Size(846, 216);
            this.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx2.Style.GradientAngle = 90;
            this.PanelEx2.TabIndex = 10;
            this.PanelEx2.Text = "PanelEx2";
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this._tb);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.DocumentMap2);
            this.SplitContainer2.Size = new System.Drawing.Size(846, 216);
            this.SplitContainer2.SplitterDistance = 729;
            this.SplitContainer2.SplitterWidth = 5;
            this.SplitContainer2.TabIndex = 0;
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
            this._tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tb.Font = new System.Drawing.Font("Consolas", 9F);
            this._tb.ForeColor = System.Drawing.Color.Gainsboro;
            this._tb.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._tb.IsReplaceMode = false;
            this._tb.LeftPadding = 25;
            this._tb.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this._tb.Location = new System.Drawing.Point(0, 0);
            this._tb.Margin = new System.Windows.Forms.Padding(4);
            this._tb.Name = "_tb";
            this._tb.Paddings = new System.Windows.Forms.Padding(0);
            this._tb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._tb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("_tb.ServiceColors")));
            this._tb.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this._tb.ShowScrollBars = false;
            this._tb.Size = new System.Drawing.Size(729, 216);
            this._tb.TabIndex = 7;
            this._tb.Zoom = 100;
            this._tb.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tb_TextChangedDelayed);
            // 
            // DocumentMap2
            // 
            this.DocumentMap2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DocumentMap2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentMap2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentMap2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.DocumentMap2.Location = new System.Drawing.Point(0, 0);
            this.DocumentMap2.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentMap2.Name = "DocumentMap2";
            this.DocumentMap2.Size = new System.Drawing.Size(112, 216);
            this.DocumentMap2.TabIndex = 7;
            this.DocumentMap2.Target = this._tb;
            this.DocumentMap2.Text = "DocumentMap2";
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx1.Controls.Add(this._PictureBox4);
            this.PanelEx1.Controls.Add(this.LabelX1);
            this.PanelEx1.Controls.Add(this.TextBoxX1);
            this.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 0);
            this.PanelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(846, 33);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 6;
            // 
            // _PictureBox4
            // 
            this._PictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._PictureBox4.Image = global::OSMaker.My.Resources.Resources.openfolderpng1;
            this._PictureBox4.Location = new System.Drawing.Point(807, 4);
            this._PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this._PictureBox4.Name = "_PictureBox4";
            this._PictureBox4.Size = new System.Drawing.Size(33, 25);
            this._PictureBox4.TabIndex = 56;
            this._PictureBox4.TabStop = false;
            this._PictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // LabelX1
            // 
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.Location = new System.Drawing.Point(7, 2);
            this.LabelX1.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(59, 28);
            this.LabelX1.TabIndex = 1;
            this.LabelX1.Text = "Chemin :";
            // 
            // TextBoxX1
            // 
            this.TextBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX1.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.TextBoxX1.Border.Class = "TextBoxBorder";
            this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX1.DisabledBackColor = System.Drawing.Color.Black;
            this.TextBoxX1.ForeColor = System.Drawing.Color.White;
            this.TextBoxX1.Location = new System.Drawing.Point(69, 4);
            this.TextBoxX1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.PreventEnterBeep = true;
            this.TextBoxX1.ReadOnly = true;
            this.TextBoxX1.Size = new System.Drawing.Size(730, 22);
            this.TextBoxX1.TabIndex = 0;
            // 
            // PanelDockContainer2
            // 
            this.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelDockContainer2.Controls.Add(this.PanelEx4);
            this.PanelDockContainer2.Controls.Add(this.PanelEx3);
            this.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelDockContainer2.Location = new System.Drawing.Point(3, 23);
            this.PanelDockContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDockContainer2.Name = "PanelDockContainer2";
            this.PanelDockContainer2.Size = new System.Drawing.Size(846, 249);
            this.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.PanelDockContainer2.Style.GradientAngle = 90;
            this.PanelDockContainer2.TabIndex = 5;
            // 
            // PanelEx4
            // 
            this.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx4.Controls.Add(this.SplitContainer1);
            this.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEx4.Location = new System.Drawing.Point(0, 33);
            this.PanelEx4.Margin = new System.Windows.Forms.Padding(4);
            this.PanelEx4.Name = "PanelEx4";
            this.PanelEx4.Size = new System.Drawing.Size(846, 216);
            this.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx4.Style.GradientAngle = 90;
            this.PanelEx4.TabIndex = 11;
            this.PanelEx4.Text = "PanelEx4";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.FastColoredTextBox1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.DocumentMap1);
            this.SplitContainer1.Size = new System.Drawing.Size(846, 216);
            this.SplitContainer1.SplitterDistance = 731;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 0;
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
            this.FastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(52, 17);
            this.FastColoredTextBox1.BackBrush = null;
            this.FastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastColoredTextBox1.CharHeight = 17;
            this.FastColoredTextBox1.CharWidth = 8;
            this.FastColoredTextBox1.CommentPrefix = null;
            this.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FastColoredTextBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.FastColoredTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.FastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FastColoredTextBox1.IsReplaceMode = false;
            this.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML;
            this.FastColoredTextBox1.LeftBracket = '<';
            this.FastColoredTextBox1.LeftBracket2 = '(';
            this.FastColoredTextBox1.LeftPadding = 25;
            this.FastColoredTextBox1.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.FastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.FastColoredTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.FastColoredTextBox1.Name = "FastColoredTextBox1";
            this.FastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.FastColoredTextBox1.RightBracket = '>';
            this.FastColoredTextBox1.RightBracket2 = ')';
            this.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastColoredTextBox1.ServiceColors")));
            this.FastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.FastColoredTextBox1.ShowScrollBars = false;
            this.FastColoredTextBox1.Size = new System.Drawing.Size(731, 216);
            this.FastColoredTextBox1.TabIndex = 13;
            this.FastColoredTextBox1.Zoom = 100;
            // 
            // DocumentMap1
            // 
            this.DocumentMap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DocumentMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentMap1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentMap1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.DocumentMap1.Location = new System.Drawing.Point(0, 0);
            this.DocumentMap1.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentMap1.Name = "DocumentMap1";
            this.DocumentMap1.Size = new System.Drawing.Size(110, 216);
            this.DocumentMap1.TabIndex = 6;
            this.DocumentMap1.Target = this.FastColoredTextBox1;
            this.DocumentMap1.Text = "DocumentMap1";
            // 
            // PanelEx3
            // 
            this.PanelEx3.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx3.Controls.Add(this.PictureBox3);
            this.PanelEx3.Controls.Add(this.LabelX2);
            this.PanelEx3.Controls.Add(this.TextBoxX2);
            this.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx3.Location = new System.Drawing.Point(0, 0);
            this.PanelEx3.Margin = new System.Windows.Forms.Padding(4);
            this.PanelEx3.Name = "PanelEx3";
            this.PanelEx3.Size = new System.Drawing.Size(846, 33);
            this.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx3.Style.GradientAngle = 90;
            this.PanelEx3.TabIndex = 10;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox3.Image = global::OSMaker.My.Resources.Resources.openfolderpng1;
            this.PictureBox3.Location = new System.Drawing.Point(807, 2);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(33, 25);
            this.PictureBox3.TabIndex = 56;
            this.PictureBox3.TabStop = false;
            // 
            // LabelX2
            // 
            // 
            // 
            // 
            this.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX2.Location = new System.Drawing.Point(7, 2);
            this.LabelX2.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX2.Name = "LabelX2";
            this.LabelX2.Size = new System.Drawing.Size(59, 28);
            this.LabelX2.TabIndex = 1;
            this.LabelX2.Text = "Chemin :";
            // 
            // TextBoxX2
            // 
            this.TextBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxX2.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.TextBoxX2.Border.Class = "TextBoxBorder";
            this.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX2.DisabledBackColor = System.Drawing.Color.Black;
            this.TextBoxX2.ForeColor = System.Drawing.Color.White;
            this.TextBoxX2.Location = new System.Drawing.Point(69, 4);
            this.TextBoxX2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxX2.Name = "TextBoxX2";
            this.TextBoxX2.PreventEnterBeep = true;
            this.TextBoxX2.ReadOnly = true;
            this.TextBoxX2.Size = new System.Drawing.Size(730, 22);
            this.TextBoxX2.TabIndex = 0;
            // 
            // PanelDockContainer3
            // 
            this.PanelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelDockContainer3.Controls.Add(this.Panel2);
            this.PanelDockContainer3.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelDockContainer3.Location = new System.Drawing.Point(3, 23);
            this.PanelDockContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDockContainer3.Name = "PanelDockContainer3";
            this.PanelDockContainer3.Size = new System.Drawing.Size(846, 249);
            this.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.PanelDockContainer3.Style.GradientAngle = 90;
            this.PanelDockContainer3.TabIndex = 10;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel2.Controls.Add(this._PictureBox2);
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Controls.Add(this.TextBoxX5);
            this.Panel2.Controls.Add(this.LabelX5);
            this.Panel2.Controls.Add(this.LabelX4);
            this.Panel2.Controls.Add(this.ButtonX15);
            this.Panel2.Controls.Add(this.ButtonX14);
            this.Panel2.Controls.Add(this.ButtonX13);
            this.Panel2.Controls.Add(this.ButtonX12);
            this.Panel2.Controls.Add(this.ButtonX11);
            this.Panel2.Controls.Add(this.ButtonX10);
            this.Panel2.Controls.Add(this.ButtonX6);
            this.Panel2.Controls.Add(this.ButtonX7);
            this.Panel2.Controls.Add(this.ButtonX8);
            this.Panel2.Controls.Add(this.ButtonX9);
            this.Panel2.Controls.Add(this.ButtonX5);
            this.Panel2.Controls.Add(this.ButtonX4);
            this.Panel2.Controls.Add(this.ButtonX3);
            this.Panel2.Controls.Add(this._ButtonX2);
            this.Panel2.Controls.Add(this.TextBoxX4);
            this.Panel2.Controls.Add(this.LabelX3);
            this.Panel2.Controls.Add(this._ButtonX1);
            this.Panel2.Controls.Add(this.TextBoxX3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(846, 249);
            this.Panel2.TabIndex = 0;
            // 
            // _PictureBox2
            // 
            this._PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this._PictureBox2.Image = global::OSMaker.My.Resources.Resources.cross;
            this._PictureBox2.Location = new System.Drawing.Point(800, 33);
            this._PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this._PictureBox2.Name = "_PictureBox2";
            this._PictureBox2.Size = new System.Drawing.Size(33, 25);
            this._PictureBox2.TabIndex = 56;
            this._PictureBox2.TabStop = false;
            this._PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Image = global::OSMaker.My.Resources.Resources.openfolderpng1;
            this.PictureBox1.Location = new System.Drawing.Point(764, 33);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(33, 25);
            this.PictureBox1.TabIndex = 55;
            this.PictureBox1.TabStop = false;
            // 
            // TextBoxX5
            // 
            this.TextBoxX5.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.TextBoxX5.Border.Class = "TextBoxBorder";
            this.TextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX5.DisabledBackColor = System.Drawing.Color.Black;
            this.TextBoxX5.ForeColor = System.Drawing.Color.White;
            this.TextBoxX5.Location = new System.Drawing.Point(560, 196);
            this.TextBoxX5.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxX5.Name = "TextBoxX5";
            this.TextBoxX5.PreventEnterBeep = true;
            this.TextBoxX5.Size = new System.Drawing.Size(120, 22);
            this.TextBoxX5.TabIndex = 50;
            // 
            // LabelX5
            // 
            this.LabelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX5.Location = new System.Drawing.Point(560, 169);
            this.LabelX5.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX5.Name = "LabelX5";
            this.LabelX5.Size = new System.Drawing.Size(45, 28);
            this.LabelX5.TabIndex = 54;
            this.LabelX5.Text = "Key :";
            // 
            // LabelX4
            // 
            this.LabelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX4.Location = new System.Drawing.Point(7, 4);
            this.LabelX4.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Size = new System.Drawing.Size(168, 28);
            this.LabelX4.TabIndex = 53;
            this.LabelX4.Text = "Objet graphique :";
            // 
            // ButtonX15
            // 
            this.ButtonX15.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX15.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX15.Location = new System.Drawing.Point(560, 101);
            this.ButtonX15.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX15.Name = "ButtonX15";
            this.ButtonX15.Size = new System.Drawing.Size(120, 28);
            this.ButtonX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX15.TabIndex = 52;
            this.ButtonX15.Text = "WindowClosed()";
            // 
            // ButtonX14
            // 
            this.ButtonX14.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX14.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX14.Location = new System.Drawing.Point(560, 65);
            this.ButtonX14.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX14.Name = "ButtonX14";
            this.ButtonX14.Size = new System.Drawing.Size(120, 28);
            this.ButtonX14.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX14.TabIndex = 51;
            this.ButtonX14.Text = "WindowClosing()";
            // 
            // ButtonX13
            // 
            this.ButtonX13.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX13.Location = new System.Drawing.Point(405, 172);
            this.ButtonX13.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX13.Name = "ButtonX13";
            this.ButtonX13.Size = new System.Drawing.Size(147, 48);
            this.ButtonX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX13.TabIndex = 49;
            this.ButtonX13.Text = "Keypress()";
            // 
            // ButtonX12
            // 
            this.ButtonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX12.Location = new System.Drawing.Point(405, 137);
            this.ButtonX12.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX12.Name = "ButtonX12";
            this.ButtonX12.Size = new System.Drawing.Size(147, 28);
            this.ButtonX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX12.TabIndex = 48;
            this.ButtonX12.Text = "MouseLeave()";
            // 
            // ButtonX11
            // 
            this.ButtonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX11.Location = new System.Drawing.Point(405, 101);
            this.ButtonX11.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX11.Name = "ButtonX11";
            this.ButtonX11.Size = new System.Drawing.Size(147, 28);
            this.ButtonX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX11.TabIndex = 47;
            this.ButtonX11.Text = "MouseMove()";
            // 
            // ButtonX10
            // 
            this.ButtonX10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX10.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX10.Location = new System.Drawing.Point(405, 65);
            this.ButtonX10.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX10.Name = "ButtonX10";
            this.ButtonX10.Size = new System.Drawing.Size(147, 28);
            this.ButtonX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX10.TabIndex = 46;
            this.ButtonX10.Text = "MouseEnter()";
            // 
            // ButtonX6
            // 
            this.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX6.Location = new System.Drawing.Point(251, 172);
            this.ButtonX6.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX6.Name = "ButtonX6";
            this.ButtonX6.Size = new System.Drawing.Size(147, 48);
            this.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX6.TabIndex = 45;
            this.ButtonX6.Text = "MouseClick droit/gauche";
            // 
            // ButtonX7
            // 
            this.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX7.Location = new System.Drawing.Point(251, 137);
            this.ButtonX7.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX7.Name = "ButtonX7";
            this.ButtonX7.Size = new System.Drawing.Size(147, 28);
            this.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX7.TabIndex = 44;
            this.ButtonX7.Text = "MouseClick droit";
            // 
            // ButtonX8
            // 
            this.ButtonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX8.Location = new System.Drawing.Point(251, 101);
            this.ButtonX8.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX8.Name = "ButtonX8";
            this.ButtonX8.Size = new System.Drawing.Size(147, 28);
            this.ButtonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX8.TabIndex = 43;
            this.ButtonX8.Text = "MouseClick gauche";
            // 
            // ButtonX9
            // 
            this.ButtonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX9.Location = new System.Drawing.Point(251, 65);
            this.ButtonX9.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX9.Name = "ButtonX9";
            this.ButtonX9.Size = new System.Drawing.Size(147, 28);
            this.ButtonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX9.TabIndex = 42;
            this.ButtonX9.Text = "MouseClick()";
            // 
            // ButtonX5
            // 
            this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX5.Location = new System.Drawing.Point(143, 172);
            this.ButtonX5.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX5.Name = "ButtonX5";
            this.ButtonX5.Size = new System.Drawing.Size(100, 48);
            this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX5.TabIndex = 41;
            this.ButtonX5.Text = "Click droit/gauche";
            // 
            // ButtonX4
            // 
            this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX4.Location = new System.Drawing.Point(143, 137);
            this.ButtonX4.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX4.Name = "ButtonX4";
            this.ButtonX4.Size = new System.Drawing.Size(100, 28);
            this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX4.TabIndex = 40;
            this.ButtonX4.Text = "Click droit";
            // 
            // ButtonX3
            // 
            this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonX3.Location = new System.Drawing.Point(143, 101);
            this.ButtonX3.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Size = new System.Drawing.Size(100, 28);
            this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonX3.TabIndex = 39;
            this.ButtonX3.Text = "Click gauche";
            // 
            // _ButtonX2
            // 
            this._ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ButtonX2.Image = global::OSMaker.My.Resources.Resources.diamond161;
            this._ButtonX2.Location = new System.Drawing.Point(143, 65);
            this._ButtonX2.Margin = new System.Windows.Forms.Padding(4);
            this._ButtonX2.Name = "_ButtonX2";
            this._ButtonX2.Size = new System.Drawing.Size(100, 28);
            this._ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX2.TabIndex = 38;
            this._ButtonX2.Text = "Click()";
            this._ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // TextBoxX4
            // 
            this.TextBoxX4.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.TextBoxX4.Border.Class = "TextBoxBorder";
            this.TextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX4.DisabledBackColor = System.Drawing.Color.Black;
            this.TextBoxX4.ForeColor = System.Drawing.Color.White;
            this.TextBoxX4.Location = new System.Drawing.Point(317, 33);
            this.TextBoxX4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxX4.Name = "TextBoxX4";
            this.TextBoxX4.PreventEnterBeep = true;
            this.TextBoxX4.ReadOnly = true;
            this.TextBoxX4.Size = new System.Drawing.Size(439, 22);
            this.TextBoxX4.TabIndex = 21;
            // 
            // LabelX3
            // 
            this.LabelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX3.Location = new System.Drawing.Point(317, 5);
            this.LabelX3.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX3.Name = "LabelX3";
            this.LabelX3.Size = new System.Drawing.Size(168, 28);
            this.LabelX3.TabIndex = 22;
            this.LabelX3.Text = "Fichier évènement :";
            // 
            // _ButtonX1
            // 
            this._ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._ButtonX1.Location = new System.Drawing.Point(7, 65);
            this._ButtonX1.Margin = new System.Windows.Forms.Padding(4);
            this._ButtonX1.Name = "_ButtonX1";
            this._ButtonX1.Size = new System.Drawing.Size(128, 43);
            this._ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._ButtonX1.Symbol = "";
            this._ButtonX1.SymbolColor = System.Drawing.Color.Teal;
            this._ButtonX1.TabIndex = 20;
            this._ButtonX1.Text = "Actualiser";
            this._ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click_1);
            // 
            // TextBoxX3
            // 
            this.TextBoxX3.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.TextBoxX3.Border.Class = "TextBoxBorder";
            this.TextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TextBoxX3.DisabledBackColor = System.Drawing.Color.Black;
            this.TextBoxX3.ForeColor = System.Drawing.Color.White;
            this.TextBoxX3.Location = new System.Drawing.Point(7, 33);
            this.TextBoxX3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxX3.Name = "TextBoxX3";
            this.TextBoxX3.PreventEnterBeep = true;
            this.TextBoxX3.Size = new System.Drawing.Size(303, 22);
            this.TextBoxX3.TabIndex = 19;
            // 
            // PanelDockContainer4
            // 
            this.PanelDockContainer4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelDockContainer4.Controls.Add(this.Panel3);
            this.PanelDockContainer4.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelDockContainer4.Location = new System.Drawing.Point(3, 23);
            this.PanelDockContainer4.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDockContainer4.Name = "PanelDockContainer4";
            this.PanelDockContainer4.Size = new System.Drawing.Size(846, 249);
            this.PanelDockContainer4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelDockContainer4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelDockContainer4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.PanelDockContainer4.Style.GradientAngle = 90;
            this.PanelDockContainer4.TabIndex = 21;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel3.Controls.Add(this.parametrescheck);
            this.Panel3.Controls.Add(this.Handletext);
            this.Panel3.Controls.Add(this.LabelX14);
            this.Panel3.Controls.Add(this.ombretext);
            this.Panel3.Controls.Add(this.LabelX13);
            this.Panel3.Controls.Add(this.bordtext);
            this.Panel3.Controls.Add(this.ctntext);
            this.Panel3.Controls.Add(this.Opacitetext);
            this.Panel3.Controls.Add(this.couleurfondtext);
            this.Panel3.Controls.Add(this.LabelX10);
            this.Panel3.Controls.Add(this.Couleurfenetretext);
            this.Panel3.Controls.Add(this.couleurtitretext);
            this.Panel3.Controls.Add(this.LabelX11);
            this.Panel3.Controls.Add(this.LabelX12);
            this.Panel3.Controls.Add(this.iconetext);
            this.Panel3.Controls.Add(this.LabelX9);
            this.Panel3.Controls.Add(this.evenementtext);
            this.Panel3.Controls.Add(this.imgtitretext);
            this.Panel3.Controls.Add(this.LabelX6);
            this.Panel3.Controls.Add(this.typetext);
            this.Panel3.Controls.Add(this.LabelX7);
            this.Panel3.Controls.Add(this.LabelX8);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(846, 249);
            this.Panel3.TabIndex = 1;
            // 
            // parametrescheck
            // 
            // 
            // 
            // 
            this.parametrescheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.parametrescheck.Location = new System.Drawing.Point(548, 41);
            this.parametrescheck.Margin = new System.Windows.Forms.Padding(4);
            this.parametrescheck.Name = "parametrescheck";
            this.parametrescheck.Size = new System.Drawing.Size(208, 28);
            this.parametrescheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.parametrescheck.TabIndex = 73;
            this.parametrescheck.Text = "Appliquer les paramètres";
            // 
            // Handletext
            // 
            this.Handletext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.Handletext.Border.Class = "TextBoxBorder";
            this.Handletext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Handletext.DisabledBackColor = System.Drawing.Color.Black;
            this.Handletext.ForeColor = System.Drawing.Color.White;
            this.Handletext.Location = new System.Drawing.Point(588, 7);
            this.Handletext.Margin = new System.Windows.Forms.Padding(4);
            this.Handletext.Name = "Handletext";
            this.Handletext.PreventEnterBeep = true;
            this.Handletext.Size = new System.Drawing.Size(168, 22);
            this.Handletext.TabIndex = 71;
            this.Handletext.Text = "MonHandle";
            // 
            // LabelX14
            // 
            this.LabelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX14.Location = new System.Drawing.Point(521, 5);
            this.LabelX14.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX14.Name = "LabelX14";
            this.LabelX14.Size = new System.Drawing.Size(168, 28);
            this.LabelX14.TabIndex = 72;
            this.LabelX14.Text = "Handle :";
            // 
            // ombretext
            // 
            this.ombretext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.ombretext.Border.Class = "TextBoxBorder";
            this.ombretext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ombretext.DisabledBackColor = System.Drawing.Color.Black;
            this.ombretext.ForeColor = System.Drawing.Color.White;
            this.ombretext.Location = new System.Drawing.Point(359, 144);
            this.ombretext.Margin = new System.Windows.Forms.Padding(4);
            this.ombretext.Name = "ombretext";
            this.ombretext.PreventEnterBeep = true;
            this.ombretext.Size = new System.Drawing.Size(59, 22);
            this.ombretext.TabIndex = 69;
            this.ombretext.Text = "0";
            // 
            // LabelX13
            // 
            this.LabelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX13.Location = new System.Drawing.Point(359, 116);
            this.LabelX13.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX13.Name = "LabelX13";
            this.LabelX13.Size = new System.Drawing.Size(155, 28);
            this.LabelX13.TabIndex = 70;
            this.LabelX13.Text = "Opacité de l\'ombre :";
            // 
            // bordtext
            // 
            this.bordtext.DisplayMember = "Text";
            this.bordtext.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bordtext.ForeColor = System.Drawing.Color.White;
            this.bordtext.FormattingEnabled = true;
            this.bordtext.ItemHeight = 17;
            this.bordtext.Items.AddRange(new object[] {
            this.ComboItem7,
            this.ComboItem8,
            this.ComboItem11});
            this.bordtext.Location = new System.Drawing.Point(352, 9);
            this.bordtext.Margin = new System.Windows.Forms.Padding(4);
            this.bordtext.Name = "bordtext";
            this.bordtext.Size = new System.Drawing.Size(160, 23);
            this.bordtext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bordtext.TabIndex = 68;
            this.bordtext.Text = "BORD:1";
            // 
            // ComboItem7
            // 
            this.ComboItem7.Text = "BORD:0";
            // 
            // ComboItem8
            // 
            this.ComboItem8.Text = "BORD:1";
            // 
            // ctntext
            // 
            this.ctntext.DisplayMember = "Text";
            this.ctntext.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctntext.ForeColor = System.Drawing.Color.White;
            this.ctntext.FormattingEnabled = true;
            this.ctntext.ItemHeight = 17;
            this.ctntext.Items.AddRange(new object[] {
            this.ComboItem13,
            this.ComboItem14,
            this.ComboItem10});
            this.ctntext.Location = new System.Drawing.Point(183, 9);
            this.ctntext.Margin = new System.Windows.Forms.Padding(4);
            this.ctntext.Name = "ctntext";
            this.ctntext.Size = new System.Drawing.Size(160, 23);
            this.ctntext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ctntext.TabIndex = 67;
            this.ctntext.Text = "CTN:0";
            // 
            // ComboItem13
            // 
            this.ComboItem13.Text = "CTN:0";
            // 
            // ComboItem14
            // 
            this.ComboItem14.Text = "CTN:1";
            // 
            // Opacitetext
            // 
            this.Opacitetext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.Opacitetext.Border.Class = "TextBoxBorder";
            this.Opacitetext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Opacitetext.DisabledBackColor = System.Drawing.Color.Black;
            this.Opacitetext.ForeColor = System.Drawing.Color.White;
            this.Opacitetext.Location = new System.Drawing.Point(359, 90);
            this.Opacitetext.Margin = new System.Windows.Forms.Padding(4);
            this.Opacitetext.Name = "Opacitetext";
            this.Opacitetext.PreventEnterBeep = true;
            this.Opacitetext.Size = new System.Drawing.Size(59, 22);
            this.Opacitetext.TabIndex = 19;
            this.Opacitetext.Text = "255";
            // 
            // couleurfondtext
            // 
            this.couleurfondtext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.couleurfondtext.Border.Class = "TextBoxBorder";
            this.couleurfondtext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.couleurfondtext.DisabledBackColor = System.Drawing.Color.Black;
            this.couleurfondtext.ForeColor = System.Drawing.Color.White;
            this.couleurfondtext.Location = new System.Drawing.Point(183, 176);
            this.couleurfondtext.Margin = new System.Windows.Forms.Padding(4);
            this.couleurfondtext.Name = "couleurfondtext";
            this.couleurfondtext.PreventEnterBeep = true;
            this.couleurfondtext.Size = new System.Drawing.Size(168, 22);
            this.couleurfondtext.TabIndex = 65;
            this.couleurfondtext.Text = "255,255,255";
            // 
            // LabelX10
            // 
            this.LabelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX10.Location = new System.Drawing.Point(183, 149);
            this.LabelX10.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX10.Name = "LabelX10";
            this.LabelX10.Size = new System.Drawing.Size(168, 28);
            this.LabelX10.TabIndex = 66;
            this.LabelX10.Text = "CouleurFond :";
            // 
            // Couleurfenetretext
            // 
            this.Couleurfenetretext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.Couleurfenetretext.Border.Class = "TextBoxBorder";
            this.Couleurfenetretext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Couleurfenetretext.DisabledBackColor = System.Drawing.Color.Black;
            this.Couleurfenetretext.ForeColor = System.Drawing.Color.White;
            this.Couleurfenetretext.Location = new System.Drawing.Point(183, 65);
            this.Couleurfenetretext.Margin = new System.Windows.Forms.Padding(4);
            this.Couleurfenetretext.Name = "Couleurfenetretext";
            this.Couleurfenetretext.PreventEnterBeep = true;
            this.Couleurfenetretext.Size = new System.Drawing.Size(168, 22);
            this.Couleurfenetretext.TabIndex = 61;
            this.Couleurfenetretext.Text = "255,255,255";
            // 
            // couleurtitretext
            // 
            this.couleurtitretext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.couleurtitretext.Border.Class = "TextBoxBorder";
            this.couleurtitretext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.couleurtitretext.DisabledBackColor = System.Drawing.Color.Black;
            this.couleurtitretext.ForeColor = System.Drawing.Color.White;
            this.couleurtitretext.Location = new System.Drawing.Point(183, 119);
            this.couleurtitretext.Margin = new System.Windows.Forms.Padding(4);
            this.couleurtitretext.Name = "couleurtitretext";
            this.couleurtitretext.PreventEnterBeep = true;
            this.couleurtitretext.Size = new System.Drawing.Size(168, 22);
            this.couleurtitretext.TabIndex = 63;
            this.couleurtitretext.Text = "255,255,255";
            // 
            // LabelX11
            // 
            this.LabelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX11.Location = new System.Drawing.Point(183, 92);
            this.LabelX11.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX11.Name = "LabelX11";
            this.LabelX11.Size = new System.Drawing.Size(168, 28);
            this.LabelX11.TabIndex = 64;
            this.LabelX11.Text = "CouleurTitre :";
            // 
            // LabelX12
            // 
            this.LabelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX12.Location = new System.Drawing.Point(183, 37);
            this.LabelX12.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX12.Name = "LabelX12";
            this.LabelX12.Size = new System.Drawing.Size(168, 28);
            this.LabelX12.TabIndex = 62;
            this.LabelX12.Text = "CouleurFenetre :";
            // 
            // iconetext
            // 
            this.iconetext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.iconetext.Border.Class = "TextBoxBorder";
            this.iconetext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.iconetext.DisabledBackColor = System.Drawing.Color.Black;
            this.iconetext.ForeColor = System.Drawing.Color.White;
            this.iconetext.Location = new System.Drawing.Point(7, 176);
            this.iconetext.Margin = new System.Windows.Forms.Padding(4);
            this.iconetext.Name = "iconetext";
            this.iconetext.PreventEnterBeep = true;
            this.iconetext.Size = new System.Drawing.Size(168, 22);
            this.iconetext.TabIndex = 59;
            // 
            // LabelX9
            // 
            this.LabelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX9.Location = new System.Drawing.Point(7, 149);
            this.LabelX9.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX9.Name = "LabelX9";
            this.LabelX9.Size = new System.Drawing.Size(168, 28);
            this.LabelX9.TabIndex = 60;
            this.LabelX9.Text = "Icone :";
            // 
            // evenementtext
            // 
            this.evenementtext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.evenementtext.Border.Class = "TextBoxBorder";
            this.evenementtext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.evenementtext.DisabledBackColor = System.Drawing.Color.Black;
            this.evenementtext.ForeColor = System.Drawing.Color.White;
            this.evenementtext.Location = new System.Drawing.Point(7, 65);
            this.evenementtext.Margin = new System.Windows.Forms.Padding(4);
            this.evenementtext.Name = "evenementtext";
            this.evenementtext.PreventEnterBeep = true;
            this.evenementtext.Size = new System.Drawing.Size(168, 22);
            this.evenementtext.TabIndex = 21;
            // 
            // imgtitretext
            // 
            this.imgtitretext.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.imgtitretext.Border.Class = "TextBoxBorder";
            this.imgtitretext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.imgtitretext.DisabledBackColor = System.Drawing.Color.Black;
            this.imgtitretext.ForeColor = System.Drawing.Color.White;
            this.imgtitretext.Location = new System.Drawing.Point(7, 119);
            this.imgtitretext.Margin = new System.Windows.Forms.Padding(4);
            this.imgtitretext.Name = "imgtitretext";
            this.imgtitretext.PreventEnterBeep = true;
            this.imgtitretext.Size = new System.Drawing.Size(168, 22);
            this.imgtitretext.TabIndex = 57;
            // 
            // LabelX6
            // 
            this.LabelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX6.Location = new System.Drawing.Point(7, 92);
            this.LabelX6.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX6.Name = "LabelX6";
            this.LabelX6.Size = new System.Drawing.Size(168, 28);
            this.LabelX6.TabIndex = 58;
            this.LabelX6.Text = "ImgTitre :";
            // 
            // typetext
            // 
            this.typetext.DisplayMember = "Text";
            this.typetext.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typetext.ForeColor = System.Drawing.Color.White;
            this.typetext.FormattingEnabled = true;
            this.typetext.ItemHeight = 17;
            this.typetext.Items.AddRange(new object[] {
            this.ComboItem1,
            this.ComboItem2,
            this.ComboItem3,
            this.ComboItem4,
            this.ComboItem5,
            this.ComboItem6,
            this.ComboItem9});
            this.typetext.Location = new System.Drawing.Point(7, 9);
            this.typetext.Margin = new System.Windows.Forms.Padding(4);
            this.typetext.Name = "typetext";
            this.typetext.Size = new System.Drawing.Size(160, 23);
            this.typetext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.typetext.TabIndex = 56;
            this.typetext.Text = "TYPE:0";
            // 
            // ComboItem1
            // 
            this.ComboItem1.Text = "TYPE:0";
            // 
            // ComboItem2
            // 
            this.ComboItem2.Text = "TYPE:1";
            // 
            // ComboItem3
            // 
            this.ComboItem3.Text = "TYPE:2";
            // 
            // ComboItem4
            // 
            this.ComboItem4.Text = "TYPE:3";
            // 
            // ComboItem5
            // 
            this.ComboItem5.Text = "TYPE:4";
            // 
            // ComboItem6
            // 
            this.ComboItem6.Text = "TYPE:5";
            // 
            // LabelX7
            // 
            this.LabelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX7.Location = new System.Drawing.Point(359, 62);
            this.LabelX7.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX7.Name = "LabelX7";
            this.LabelX7.Size = new System.Drawing.Size(79, 28);
            this.LabelX7.TabIndex = 53;
            this.LabelX7.Text = "Opacité :";
            // 
            // LabelX8
            // 
            this.LabelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX8.Location = new System.Drawing.Point(7, 37);
            this.LabelX8.Margin = new System.Windows.Forms.Padding(4);
            this.LabelX8.Name = "LabelX8";
            this.LabelX8.Size = new System.Drawing.Size(168, 28);
            this.LabelX8.TabIndex = 22;
            this.LabelX8.Text = "Fichier évènement :";
            // 
            // DockContainerItem1
            // 
            this.DockContainerItem1.Control = this.PanelDockContainer1;
            this.DockContainerItem1.Name = "DockContainerItem1";
            this.DockContainerItem1.Text = "CC+";
            // 
            // DockContainerItem2
            // 
            this.DockContainerItem2.Control = this.PanelDockContainer2;
            this.DockContainerItem2.Name = "DockContainerItem2";
            this.DockContainerItem2.Text = "XML";
            // 
            // DockContainerItem3
            // 
            this.DockContainerItem3.Control = this.PanelDockContainer3;
            this.DockContainerItem3.Name = "DockContainerItem3";
            this.DockContainerItem3.Text = "Evènements";
            // 
            // DockContainerItem4
            // 
            this.DockContainerItem4.Control = this.PanelDockContainer4;
            this.DockContainerItem4.Name = "DockContainerItem4";
            this.DockContainerItem4.Text = "Propriétés fenêtre";
            // 
            // DockSite1
            // 
            this.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.DockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.DockSite1.Location = new System.Drawing.Point(0, 29);
            this.DockSite1.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite1.Name = "DockSite1";
            this.DockSite1.Size = new System.Drawing.Size(0, 141);
            this.DockSite1.TabIndex = 1;
            this.DockSite1.TabStop = false;
            // 
            // DockSite2
            // 
            this.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite2.Dock = System.Windows.Forms.DockStyle.Right;
            this.DockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.DockSite2.Location = new System.Drawing.Point(852, 29);
            this.DockSite2.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite2.Name = "DockSite2";
            this.DockSite2.Size = new System.Drawing.Size(0, 141);
            this.DockSite2.TabIndex = 2;
            this.DockSite2.TabStop = false;
            // 
            // DockSite8
            // 
            this.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DockSite8.Location = new System.Drawing.Point(0, 473);
            this.DockSite8.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite8.Name = "DockSite8";
            this.DockSite8.Size = new System.Drawing.Size(852, 0);
            this.DockSite8.TabIndex = 8;
            this.DockSite8.TabStop = false;
            // 
            // DockSite5
            // 
            this.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.DockSite5.Location = new System.Drawing.Point(0, 29);
            this.DockSite5.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite5.Name = "DockSite5";
            this.DockSite5.Size = new System.Drawing.Size(0, 444);
            this.DockSite5.TabIndex = 5;
            this.DockSite5.TabStop = false;
            // 
            // DockSite6
            // 
            this.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite6.Dock = System.Windows.Forms.DockStyle.Right;
            this.DockSite6.Location = new System.Drawing.Point(852, 29);
            this.DockSite6.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite6.Name = "DockSite6";
            this.DockSite6.Size = new System.Drawing.Size(0, 444);
            this.DockSite6.TabIndex = 6;
            this.DockSite6.TabStop = false;
            // 
            // DockSite7
            // 
            this.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DockSite7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DockSite7.Controls.Add(this.Bar2);
            this.DockSite7.Dock = System.Windows.Forms.DockStyle.Top;
            this.DockSite7.Location = new System.Drawing.Point(0, 0);
            this.DockSite7.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite7.Name = "DockSite7";
            this.DockSite7.Size = new System.Drawing.Size(852, 29);
            this.DockSite7.TabIndex = 7;
            this.DockSite7.TabStop = false;
            // 
            // Bar2
            // 
            this.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)";
            this.Bar2.AccessibleName = "DotNetBar Bar";
            this.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.Bar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            this.Bar2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            this.Bar2.IsMaximized = false;
            this.Bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this._ButtonItem11,
            this._ButtonItem1,
            this._Aligner});
            this.Bar2.Location = new System.Drawing.Point(0, 0);
            this.Bar2.Margin = new System.Windows.Forms.Padding(4);
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(176, 29);
            this.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bar2.TabIndex = 0;
            this.Bar2.TabStop = false;
            this.Bar2.Text = "Bar2";
            // 
            // _ButtonItem11
            // 
            this._ButtonItem11.Image = global::OSMaker.My.Resources.Resources.Save_37110__Copier_;
            this._ButtonItem11.Name = "_ButtonItem11";
            this._ButtonItem11.Text = "ButtonItem11";
            this._ButtonItem11.Click += new System.EventHandler(this.ButtonItem11_Click);
            // 
            // _ButtonItem1
            // 
            this._ButtonItem1.Name = "_ButtonItem1";
            this._ButtonItem1.Text = "Supprimer";
            this._ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click_1);
            // 
            // _Aligner
            // 
            this._Aligner.Name = "_Aligner";
            this._Aligner.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this._Copy,
            this._ButtonItem6});
            this._Aligner.Text = "Centrer";
            this._Aligner.Click += new System.EventHandler(this.ButtonItem1_Click);
            // 
            // _Copy
            // 
            this._Copy.Name = "_Copy";
            this._Copy.Text = "Horizontalement";
            this._Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // _ButtonItem6
            // 
            this._ButtonItem6.Name = "_ButtonItem6";
            this._ButtonItem6.Text = "Verticalement";
            this._ButtonItem6.Click += new System.EventHandler(this.ButtonItem6_Click);
            // 
            // DockSite3
            // 
            this.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.DockSite3.Dock = System.Windows.Forms.DockStyle.Top;
            this.DockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            this.DockSite3.Location = new System.Drawing.Point(0, 29);
            this.DockSite3.Margin = new System.Windows.Forms.Padding(4);
            this.DockSite3.Name = "DockSite3";
            this.DockSite3.Size = new System.Drawing.Size(852, 0);
            this.DockSite3.TabIndex = 3;
            this.DockSite3.TabStop = false;
            // 
            // _Panel1
            // 
            this._Panel1.AutoScroll = true;
            this._Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Panel1.ForeColor = System.Drawing.Color.Black;
            this._Panel1.Location = new System.Drawing.Point(0, 29);
            this._Panel1.Margin = new System.Windows.Forms.Padding(4);
            this._Panel1.Name = "_Panel1";
            this._Panel1.Size = new System.Drawing.Size(852, 141);
            this._Panel1.TabIndex = 13;
            this._Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CoucouToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(127, 28);
            // 
            // CoucouToolStripMenuItem
            // 
            this.CoucouToolStripMenuItem.Name = "CoucouToolStripMenuItem";
            this.CoucouToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.CoucouToolStripMenuItem.Text = "coucou";
            // 
            // EditeurCCplus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._Panel1);
            this.Controls.Add(this.DockSite2);
            this.Controls.Add(this.DockSite1);
            this.Controls.Add(this.DockSite3);
            this.Controls.Add(this.DockSite4);
            this.Controls.Add(this.DockSite5);
            this.Controls.Add(this.DockSite6);
            this.Controls.Add(this.DockSite7);
            this.Controls.Add(this.DockSite8);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditeurCCplus";
            this.Size = new System.Drawing.Size(852, 473);
            this.Load += new System.EventHandler(this.EditeurCCplus_Load);
            this.DockSite4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bar1)).EndInit();
            this.Bar1.ResumeLayout(false);
            this.PanelDockContainer1.ResumeLayout(false);
            this.PanelEx2.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._tb)).EndInit();
            this.PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox4)).EndInit();
            this.PanelDockContainer2.ResumeLayout(false);
            this.PanelEx4.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FastColoredTextBox1)).EndInit();
            this.PanelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.PanelDockContainer3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.PanelDockContainer4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.DockSite7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bar2)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal DevComponents.DotNetBar.DotNetBarManager DotNetBarManager1;
        internal DevComponents.DotNetBar.DockSite DockSite4;
        internal DevComponents.DotNetBar.DockSite DockSite1;
        internal DevComponents.DotNetBar.DockSite DockSite2;
        internal DevComponents.DotNetBar.DockSite DockSite3;
        internal DevComponents.DotNetBar.DockSite DockSite5;
        internal DevComponents.DotNetBar.DockSite DockSite6;
        internal DevComponents.DotNetBar.DockSite DockSite7;
        internal DevComponents.DotNetBar.Bar Bar2;
        private DevComponents.DotNetBar.ButtonItem _ButtonItem11;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem11 != null)
                {
                    _ButtonItem11.Click -= ButtonItem11_Click;
                }

                _ButtonItem11 = value;
                if (_ButtonItem11 != null)
                {
                    _ButtonItem11.Click += ButtonItem11_Click;
                }
            }
        }

        internal DevComponents.DotNetBar.DockSite DockSite8;
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
        internal DevComponents.DotNetBar.PanelDockContainer PanelDockContainer1;
        internal DevComponents.DotNetBar.PanelDockContainer PanelDockContainer2;
        internal DevComponents.DotNetBar.DockContainerItem DockContainerItem1;
        internal DevComponents.DotNetBar.DockContainerItem DockContainerItem2;
        internal DevComponents.DotNetBar.PanelEx PanelEx1;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.PanelEx PanelEx3;
        internal DevComponents.DotNetBar.PanelEx PanelEx4;
        internal DevComponents.DotNetBar.LabelX LabelX2;
        internal DevComponents.DotNetBar.PanelEx PanelEx2;
        private DevComponents.DotNetBar.ButtonItem _Aligner;

        internal DevComponents.DotNetBar.ButtonItem Aligner
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Aligner;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Aligner != null)
                {
                    _Aligner.Click -= ButtonItem1_Click;
                }

                _Aligner = value;
                if (_Aligner != null)
                {
                    _Aligner.Click += ButtonItem1_Click;
                }
            }
        }

        internal Timer Timer1;
        internal SplitContainer SplitContainer1;
        internal FastColoredTextBoxNS.FastColoredTextBox FastColoredTextBox1;
        internal SplitContainer SplitContainer2;

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

        internal FastColoredTextBoxNS.DocumentMap DocumentMap2;
        internal FastColoredTextBoxNS.DocumentMap DocumentMap1;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem CoucouToolStripMenuItem;
        internal ToolStripMenuItem ToolStripMenuItem1;
        private DevComponents.DotNetBar.ButtonItem _Copy;

        internal DevComponents.DotNetBar.ButtonItem Copy
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Copy;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Copy != null)
                {
                    _Copy.Click -= Copy_Click;
                }

                _Copy = value;
                if (_Copy != null)
                {
                    _Copy.Click += Copy_Click;
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem6;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem6 != null)
                {
                    _ButtonItem6.Click -= ButtonItem6_Click;
                }

                _ButtonItem6 = value;
                if (_ButtonItem6 != null)
                {
                    _ButtonItem6.Click += ButtonItem6_Click;
                }
            }
        }

        internal DevComponents.DotNetBar.PanelDockContainer PanelDockContainer3;
        internal DevComponents.DotNetBar.DockContainerItem DockContainerItem3;
        internal Panel Panel2;

        internal DevComponents.DotNetBar.ButtonX ButtonX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX2 != null)
                {
                    _ButtonX2.Click -= ButtonX2_Click;
                }

                _ButtonX2 = value;
                if (_ButtonX2 != null)
                {
                    _ButtonX2.Click += ButtonX2_Click;
                }
            }
        }

        internal DevComponents.DotNetBar.ButtonX ButtonX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click -= ButtonX1_Click_1;
                }

                _ButtonX1 = value;
                if (_ButtonX1 != null)
                {
                    _ButtonX1.Click += ButtonX1_Click_1;
                }
            }
        }

        internal PictureBox PictureBox2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox2 != null)
                {
                    _PictureBox2.Click -= PictureBox2_Click;
                }

                _PictureBox2 = value;
                if (_PictureBox2 != null)
                {
                    _PictureBox2.Click += PictureBox2_Click;
                }
            }
        }

        private PictureBox _PictureBox4;

        internal PictureBox PictureBox4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox4 != null)
                {
                    _PictureBox4.Click -= PictureBox4_Click;
                }

                _PictureBox4 = value;
                if (_PictureBox4 != null)
                {
                    _PictureBox4.Click += PictureBox4_Click;
                }
            }
        }

        internal PictureBox PictureBox3;
        internal DevComponents.DotNetBar.PanelDockContainer PanelDockContainer4;
        internal Panel Panel3;
        internal DevComponents.Editors.ComboItem ComboItem1;
        internal DevComponents.Editors.ComboItem ComboItem2;
        internal DevComponents.Editors.ComboItem ComboItem3;
        internal DevComponents.Editors.ComboItem ComboItem4;
        internal DevComponents.Editors.ComboItem ComboItem5;
        internal DevComponents.Editors.ComboItem ComboItem6;
        internal DevComponents.DotNetBar.DockContainerItem DockContainerItem4;
        internal DevComponents.Editors.ComboItem ComboItem7;
        internal DevComponents.Editors.ComboItem ComboItem8;
        internal DevComponents.Editors.ComboItem ComboItem13;
        internal DevComponents.Editors.ComboItem ComboItem14;
        private DevComponents.DotNetBar.ButtonItem _ButtonItem1;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click -= ButtonItem1_Click_1;
                }

                _ButtonItem1 = value;
                if (_ButtonItem1 != null)
                {
                    _ButtonItem1.Click += ButtonItem1_Click_1;
                }
            }
        }
        internal DevComponents.Editors.ComboItem ComboItem11;
        internal DevComponents.Editors.ComboItem ComboItem10;
        internal DevComponents.Editors.ComboItem ComboItem9;
        public DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;
        public DevComponents.DotNetBar.Bar Bar1;
        public DevComponents.DotNetBar.Controls.TextBoxX TextBoxX2;
        public FastColoredTextBoxNS.FastColoredTextBox _tb;
        public DevComponents.DotNetBar.Controls.TextBoxX TextBoxX5;
        public DevComponents.DotNetBar.LabelX LabelX5;
        public DevComponents.DotNetBar.LabelX LabelX4;
        public DevComponents.DotNetBar.ButtonX ButtonX15;
        public DevComponents.DotNetBar.ButtonX ButtonX14;
        public DevComponents.DotNetBar.ButtonX ButtonX13;
        public DevComponents.DotNetBar.ButtonX ButtonX12;
        public DevComponents.DotNetBar.ButtonX ButtonX11;
        public DevComponents.DotNetBar.ButtonX ButtonX10;
        public DevComponents.DotNetBar.ButtonX ButtonX6;
        public DevComponents.DotNetBar.ButtonX ButtonX7;
        public DevComponents.DotNetBar.ButtonX ButtonX8;
        public DevComponents.DotNetBar.ButtonX ButtonX9;
        public DevComponents.DotNetBar.ButtonX ButtonX5;
        public DevComponents.DotNetBar.ButtonX ButtonX4;
        public DevComponents.DotNetBar.ButtonX ButtonX3;
        public DevComponents.DotNetBar.ButtonX _ButtonX2;
        public DevComponents.DotNetBar.Controls.TextBoxX TextBoxX4;
        public DevComponents.DotNetBar.LabelX LabelX3;
        public DevComponents.DotNetBar.ButtonX _ButtonX1;
        public DevComponents.DotNetBar.Controls.TextBoxX TextBoxX3;
        public PictureBox PictureBox1;
        public PictureBox _PictureBox2;
        public DevComponents.DotNetBar.Controls.TextBoxX Opacitetext;
        public DevComponents.DotNetBar.Controls.TextBoxX couleurfondtext;
        public DevComponents.DotNetBar.LabelX LabelX10;
        public DevComponents.DotNetBar.Controls.TextBoxX Couleurfenetretext;
        public DevComponents.DotNetBar.Controls.TextBoxX couleurtitretext;
        public DevComponents.DotNetBar.LabelX LabelX11;
        public DevComponents.DotNetBar.LabelX LabelX12;
        public DevComponents.DotNetBar.Controls.TextBoxX iconetext;
        public DevComponents.DotNetBar.LabelX LabelX9;
        public DevComponents.DotNetBar.Controls.TextBoxX evenementtext;
        public DevComponents.DotNetBar.Controls.TextBoxX imgtitretext;
        public DevComponents.DotNetBar.LabelX LabelX6;
        public DevComponents.DotNetBar.Controls.ComboBoxEx typetext;
        public DevComponents.DotNetBar.LabelX LabelX7;
        public DevComponents.DotNetBar.LabelX LabelX8;
        public DevComponents.DotNetBar.Controls.TextBoxX ombretext;
        public DevComponents.DotNetBar.LabelX LabelX13;
        public DevComponents.DotNetBar.Controls.ComboBoxEx bordtext;
        public DevComponents.DotNetBar.Controls.ComboBoxEx ctntext;
        public DevComponents.DotNetBar.LabelX LabelX14;
        public DevComponents.DotNetBar.Controls.TextBoxX Handletext;
        public DevComponents.DotNetBar.Controls.CheckBoxX parametrescheck;
    }
}