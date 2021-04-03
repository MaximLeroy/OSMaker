using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    [DesignerGenerated()]
    internal partial class OSMCodeBox : UserControl
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(OSMCodeBox));
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            DotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(components);
            DockSite4 = new DevComponents.DotNetBar.DockSite();
            DockSite1 = new DevComponents.DotNetBar.DockSite();
            DockSite2 = new DevComponents.DotNetBar.DockSite();
            Bar1 = new DevComponents.DotNetBar.Bar();
            PanelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
            DocumentMap1 = new FastColoredTextBoxNS.DocumentMap();
            _tb = new FastColoredTextBoxNS.FastColoredTextBox();
            _tb.TextChangedDelayed += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(tb_TextChangedDelayed);
            _tb.Load += new EventHandler(tb_Load);
            PanelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
            _dgvObjectExplorer2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            _dgvObjectExplorer2.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgvObjectExplorer2_CellMouseDoubleClick);
            _dgvObjectExplorer2.CellValueNeeded += new DataGridViewCellValueEventHandler(dgvObjectExplorer2_CellValueNeeded);
            Column2 = new DataGridViewImageColumn();
            Column1 = new DataGridViewTextBoxColumn();
            DockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            DockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
            DockSite8 = new DevComponents.DotNetBar.DockSite();
            DockSite5 = new DevComponents.DotNetBar.DockSite();
            DockSite6 = new DevComponents.DotNetBar.DockSite();
            DockSite7 = new DevComponents.DotNetBar.DockSite();
            Bar2 = new DevComponents.DotNetBar.Bar();
            ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
            LabelItem1 = new DevComponents.DotNetBar.LabelItem();
            DockSite3 = new DevComponents.DotNetBar.DockSite();
            PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            _ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem9.Click += new EventHandler(ButtonItem9_Click);
            CouperItem = new DevComponents.DotNetBar.ButtonItem();
            CopierItem = new DevComponents.DotNetBar.ButtonItem();
            CollerItem = new DevComponents.DotNetBar.ButtonItem();
            ButtonItem10 = new DevComponents.DotNetBar.ButtonItem();
            tmUpdateInterface2 = new Timer(components);
            ilAutocomplete = new ImageList(components);
            DockSite2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Bar1).BeginInit();
            Bar1.SuspendLayout();
            PanelDockContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_tb).BeginInit();
            PanelDockContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvObjectExplorer2).BeginInit();
            DockSite7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Bar2).BeginInit();
            PanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ContextMenuBar1).BeginInit();
            SuspendLayout();
            // 
            // DotNetBarManager1
            // 
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            DotNetBarManager1.BottomDockSite = DockSite4;
            DotNetBarManager1.EnableFullSizeDock = false;
            DotNetBarManager1.LeftDockSite = DockSite1;
            DotNetBarManager1.ParentForm = null;
            DotNetBarManager1.ParentUserControl = this;
            DotNetBarManager1.RightDockSite = DockSite2;
            DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            DotNetBarManager1.ToolbarBottomDockSite = DockSite8;
            DotNetBarManager1.ToolbarLeftDockSite = DockSite5;
            DotNetBarManager1.ToolbarRightDockSite = DockSite6;
            DotNetBarManager1.ToolbarTopDockSite = DockSite7;
            DotNetBarManager1.TopDockSite = DockSite3;
            // 
            // DockSite4
            // 
            DockSite4.AccessibleRole = AccessibleRole.Window;
            DockSite4.Dock = DockStyle.Bottom;
            DockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            DockSite4.Location = new Point(0, 593);
            DockSite4.Margin = new Padding(4, 4, 4, 4);
            DockSite4.Name = "DockSite4";
            DockSite4.Size = new Size(1148, 0);
            DockSite4.TabIndex = 3;
            DockSite4.TabStop = false;
            // 
            // DockSite1
            // 
            DockSite1.AccessibleRole = AccessibleRole.Window;
            DockSite1.Dock = DockStyle.Left;
            DockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            DockSite1.Location = new Point(0, 25);
            DockSite1.Margin = new Padding(4, 4, 4, 4);
            DockSite1.Name = "DockSite1";
            DockSite1.Size = new Size(0, 568);
            DockSite1.TabIndex = 0;
            DockSite1.TabStop = false;
            // 
            // DockSite2
            // 
            DockSite2.AccessibleRole = AccessibleRole.Window;
            DockSite2.Controls.Add(Bar1);
            DockSite2.Dock = DockStyle.Right;
            DockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] { new DevComponents.DotNetBar.DocumentBarContainer(Bar1, 193, 568) }, DevComponents.DotNetBar.eOrientation.Horizontal);
            DockSite2.Location = new Point(952, 25);
            DockSite2.Margin = new Padding(4, 4, 4, 4);
            DockSite2.Name = "DockSite2";
            DockSite2.Size = new Size(196, 568);
            DockSite2.TabIndex = 1;
            DockSite2.TabStop = false;
            // 
            // Bar1
            // 
            Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)";
            Bar1.AccessibleName = "DotNetBar Bar";
            Bar1.AccessibleRole = AccessibleRole.Grouping;
            Bar1.AutoSyncBarCaption = true;
            Bar1.CloseSingleTab = true;
            Bar1.Controls.Add(PanelDockContainer1);
            Bar1.Controls.Add(PanelDockContainer2);
            Bar1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
            Bar1.IsMaximized = false;
            Bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { DockContainerItem1, DockContainerItem2 });
            Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
            Bar1.Location = new Point(3, 0);
            Bar1.Margin = new Padding(4, 4, 4, 4);
            Bar1.Name = "Bar1";
            Bar1.SelectedDockTab = 0;
            Bar1.Size = new Size(193, 568);
            Bar1.Stretch = true;
            Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            Bar1.TabIndex = 0;
            Bar1.TabStop = false;
            Bar1.Text = "View";
            // 
            // PanelDockContainer1
            // 
            PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            PanelDockContainer1.Controls.Add(DocumentMap1);
            PanelDockContainer1.DisabledBackColor = Color.Empty;
            PanelDockContainer1.Location = new Point(3, 23);
            PanelDockContainer1.Margin = new Padding(4, 4, 4, 4);
            PanelDockContainer1.Name = "PanelDockContainer1";
            PanelDockContainer1.Size = new Size(187, 517);
            PanelDockContainer1.Style.Alignment = StringAlignment.Center;
            PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            PanelDockContainer1.Style.GradientAngle = 90;
            PanelDockContainer1.TabIndex = 0;
            // 
            // DocumentMap1
            // 
            DocumentMap1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            DocumentMap1.Dock = DockStyle.Fill;
            DocumentMap1.Font = new Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DocumentMap1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(43)), Conversions.ToInteger(Conversions.ToByte(145)), Conversions.ToInteger(Conversions.ToByte(175)));
            DocumentMap1.Location = new Point(0, 0);
            DocumentMap1.Margin = new Padding(4, 4, 4, 4);
            DocumentMap1.Name = "DocumentMap1";
            DocumentMap1.Size = new Size(187, 517);
            DocumentMap1.TabIndex = 5;
            DocumentMap1.Target = _tb;
            DocumentMap1.Text = "DocumentMap1";
            // 
            // tb
            // 
            _tb.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            _tb.AutoScrollMinSize = new Size(52, 17);
            _tb.BackBrush = null;
            _tb.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            _tb.CharHeight = 17;
            _tb.CharWidth = 8;
            ContextMenuBar1.SetContextMenuEx(_tb, _ButtonItem9);
            _tb.Cursor = Cursors.IBeam;
            _tb.DisabledColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(100)), Conversions.ToInteger(Conversions.ToByte(180)), Conversions.ToInteger(Conversions.ToByte(180)), Conversions.ToInteger(Conversions.ToByte(180)));
            _tb.Dock = DockStyle.Fill;
            _tb.Font = new Font("Consolas", 9.0f);
            _tb.ForeColor = Color.Gainsboro;
            _tb.IndentBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            _tb.IsReplaceMode = false;
            _tb.LeftPadding = 25;
            _tb.LineNumberColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(43)), Conversions.ToInteger(Conversions.ToByte(145)), Conversions.ToInteger(Conversions.ToByte(175)));
            _tb.Location = new Point(0, 0);
            _tb.Margin = new Padding(4, 4, 4, 4);
            _tb.Name = "_tb";
            _tb.Paddings = new Padding(0);
            _tb.SelectionColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(60)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(255)));
            _tb.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("tb.ServiceColors");
            _tb.ServiceLinesColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(165)), Conversions.ToInteger(Conversions.ToByte(165)));
            _tb.ShowScrollBars = false;
            _tb.Size = new Size(952, 568);
            _tb.TabIndex = 4;
            _tb.Zoom = 100;
            // 
            // PanelDockContainer2
            // 
            PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            PanelDockContainer2.Controls.Add(_dgvObjectExplorer2);
            PanelDockContainer2.DisabledBackColor = Color.Empty;
            PanelDockContainer2.Location = new Point(3, 23);
            PanelDockContainer2.Margin = new Padding(4, 4, 4, 4);
            PanelDockContainer2.Name = "PanelDockContainer2";
            PanelDockContainer2.Size = new Size(187, 517);
            PanelDockContainer2.Style.Alignment = StringAlignment.Center;
            PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            PanelDockContainer2.Style.GradientAngle = 90;
            PanelDockContainer2.TabIndex = 5;
            // 
            // dgvObjectExplorer2
            // 
            _dgvObjectExplorer2.AllowUserToAddRows = false;
            _dgvObjectExplorer2.AllowUserToDeleteRows = false;
            _dgvObjectExplorer2.AllowUserToResizeColumns = false;
            _dgvObjectExplorer2.AllowUserToResizeRows = false;
            _dgvObjectExplorer2.BackgroundColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            _dgvObjectExplorer2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = Color.White;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            _dgvObjectExplorer2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            _dgvObjectExplorer2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvObjectExplorer2.ColumnHeadersVisible = false;
            _dgvObjectExplorer2.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1 });
            _dgvObjectExplorer2.Cursor = Cursors.Hand;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            DataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle4.ForeColor = Color.White;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = Color.White;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            _dgvObjectExplorer2.DefaultCellStyle = DataGridViewCellStyle4;
            _dgvObjectExplorer2.Dock = DockStyle.Fill;
            _dgvObjectExplorer2.EnableHeadersVisualStyles = false;
            _dgvObjectExplorer2.GridColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(123)), Conversions.ToInteger(Conversions.ToByte(123)), Conversions.ToInteger(Conversions.ToByte(132)));
            _dgvObjectExplorer2.Location = new Point(0, 0);
            _dgvObjectExplorer2.Margin = new Padding(4, 4, 4, 4);
            _dgvObjectExplorer2.MultiSelect = false;
            _dgvObjectExplorer2.Name = "_dgvObjectExplorer2";
            _dgvObjectExplorer2.ReadOnly = true;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            DataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = Color.White;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            _dgvObjectExplorer2.RowHeadersDefaultCellStyle = DataGridViewCellStyle5;
            _dgvObjectExplorer2.RowHeadersVisible = false;
            _dgvObjectExplorer2.RowHeadersWidth = 51;
            DataGridViewCellStyle6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            DataGridViewCellStyle6.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle6.ForeColor = SystemColors.Control;
            _dgvObjectExplorer2.RowsDefaultCellStyle = DataGridViewCellStyle6;
            _dgvObjectExplorer2.ScrollBars = ScrollBars.Vertical;
            _dgvObjectExplorer2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvObjectExplorer2.Size = new Size(187, 517);
            _dgvObjectExplorer2.TabIndex = 6;
            _dgvObjectExplorer2.VirtualMode = true;
            // 
            // Column2
            // 
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            DataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle2.ForeColor = SystemColors.Control;
            DataGridViewCellStyle2.NullValue = resources.GetObject("DataGridViewCellStyle2.NullValue");
            Column2.DefaultCellStyle = DataGridViewCellStyle2;
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 32;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 32;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewCellStyle3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(45)), Conversions.ToInteger(Conversions.ToByte(48)));
            DataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            DataGridViewCellStyle3.ForeColor = SystemColors.Control;
            Column1.DefaultCellStyle = DataGridViewCellStyle3;
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // DockContainerItem1
            // 
            DockContainerItem1.Control = PanelDockContainer1;
            DockContainerItem1.Name = "DockContainerItem1";
            DockContainerItem1.Text = "View";
            // 
            // DockContainerItem2
            // 
            DockContainerItem2.Control = PanelDockContainer2;
            DockContainerItem2.Name = "DockContainerItem2";
            DockContainerItem2.Text = "Class";
            // 
            // DockSite8
            // 
            DockSite8.AccessibleRole = AccessibleRole.Window;
            DockSite8.Dock = DockStyle.Bottom;
            DockSite8.Location = new Point(0, 593);
            DockSite8.Margin = new Padding(4, 4, 4, 4);
            DockSite8.Name = "DockSite8";
            DockSite8.Size = new Size(1148, 0);
            DockSite8.TabIndex = 7;
            DockSite8.TabStop = false;
            // 
            // DockSite5
            // 
            DockSite5.AccessibleRole = AccessibleRole.Window;
            DockSite5.Dock = DockStyle.Left;
            DockSite5.Location = new Point(0, 25);
            DockSite5.Margin = new Padding(4, 4, 4, 4);
            DockSite5.Name = "DockSite5";
            DockSite5.Size = new Size(0, 568);
            DockSite5.TabIndex = 4;
            DockSite5.TabStop = false;
            // 
            // DockSite6
            // 
            DockSite6.AccessibleRole = AccessibleRole.Window;
            DockSite6.Dock = DockStyle.Right;
            DockSite6.Location = new Point(1148, 25);
            DockSite6.Margin = new Padding(4, 4, 4, 4);
            DockSite6.Name = "DockSite6";
            DockSite6.Size = new Size(0, 568);
            DockSite6.TabIndex = 5;
            DockSite6.TabStop = false;
            // 
            // DockSite7
            // 
            DockSite7.AccessibleRole = AccessibleRole.Window;
            DockSite7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            DockSite7.BackColor2 = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            DockSite7.Controls.Add(Bar2);
            DockSite7.Dock = DockStyle.Top;
            DockSite7.Location = new Point(0, 0);
            DockSite7.Margin = new Padding(4, 4, 4, 4);
            DockSite7.Name = "DockSite7";
            DockSite7.Size = new Size(1148, 25);
            DockSite7.TabIndex = 6;
            DockSite7.TabStop = false;
            // 
            // Bar2
            // 
            Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)";
            Bar2.AccessibleName = "DotNetBar Bar";
            Bar2.AccessibleRole = AccessibleRole.ToolBar;
            Bar2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top;
            Bar2.Font = new Font("Segoe UI", 9.0f);
            Bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
            Bar2.IsMaximized = false;
            Bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { ButtonItem1, ButtonItem2, ButtonItem3, ButtonItem4, ButtonItem5, ButtonItem6, ButtonItem7, ButtonItem8, LabelItem1 });
            Bar2.Location = new Point(0, 0);
            Bar2.Margin = new Padding(4, 4, 4, 4);
            Bar2.Name = "Bar2";
            Bar2.Size = new Size(276, 25);
            Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            Bar2.TabIndex = 0;
            Bar2.TabStop = false;
            Bar2.Text = "Bar2";
            // 
            // ButtonItem1
            // 
            ButtonItem1.Image = My.Resources.Resources.button;
            ButtonItem1.Name = "ButtonItem1";
            ButtonItem1.Text = "ButtonItem1";
            // 
            // ButtonItem2
            // 
            ButtonItem2.Image = My.Resources.Resources.button_1_;
            ButtonItem2.Name = "ButtonItem2";
            ButtonItem2.Text = "ButtonItem2";
            // 
            // ButtonItem3
            // 
            ButtonItem3.Image = My.Resources.Resources.Save_37110__Copier_;
            ButtonItem3.Name = "ButtonItem3";
            ButtonItem3.Text = "ButtonItem3";
            // 
            // ButtonItem4
            // 
            ButtonItem4.Image = My.Resources.Resources.scissors;
            ButtonItem4.Name = "ButtonItem4";
            ButtonItem4.Text = "ButtonItem4";
            // 
            // ButtonItem5
            // 
            ButtonItem5.Image = My.Resources.Resources.copy_paste_documents_1580__Copier_;
            ButtonItem5.Name = "ButtonItem5";
            ButtonItem5.Text = "ButtonItem5";
            // 
            // ButtonItem6
            // 
            ButtonItem6.Image = My.Resources.Resources.clipboard;
            ButtonItem6.Name = "ButtonItem6";
            ButtonItem6.Text = "ButtonItem6";
            // 
            // ButtonItem7
            // 
            ButtonItem7.Image = My.Resources.Resources.arrows___Copie;
            ButtonItem7.Name = "ButtonItem7";
            ButtonItem7.Text = "ButtonItem7";
            // 
            // ButtonItem8
            // 
            ButtonItem8.Image = My.Resources.Resources.arrows;
            ButtonItem8.Name = "ButtonItem8";
            ButtonItem8.Text = "ButtonItem8";
            // 
            // LabelItem1
            // 
            LabelItem1.Name = "LabelItem1";
            LabelItem1.Text = "LabelItem1";
            // 
            // DockSite3
            // 
            DockSite3.AccessibleRole = AccessibleRole.Window;
            DockSite3.Dock = DockStyle.Top;
            DockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
            DockSite3.Location = new Point(0, 25);
            DockSite3.Margin = new Padding(4, 4, 4, 4);
            DockSite3.Name = "DockSite3";
            DockSite3.Size = new Size(1148, 0);
            DockSite3.TabIndex = 2;
            DockSite3.TabStop = false;
            // 
            // PanelEx1
            // 
            PanelEx1.CanvasColor = SystemColors.Control;
            PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            PanelEx1.Controls.Add(ContextMenuBar1);
            PanelEx1.Controls.Add(_tb);
            PanelEx1.DisabledBackColor = Color.Empty;
            PanelEx1.Dock = DockStyle.Fill;
            PanelEx1.Location = new Point(0, 25);
            PanelEx1.Margin = new Padding(4, 4, 4, 4);
            PanelEx1.Name = "PanelEx1";
            PanelEx1.Size = new Size(952, 568);
            PanelEx1.Style.Alignment = StringAlignment.Center;
            PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            PanelEx1.Style.GradientAngle = 90;
            PanelEx1.TabIndex = 8;
            PanelEx1.Text = "PanelEx1";
            // 
            // ContextMenuBar1
            // 
            ContextMenuBar1.AntiAlias = true;
            ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            ContextMenuBar1.Font = new Font("Segoe UI", 9.0f);
            ContextMenuBar1.IsMaximized = false;
            ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem9 });
            ContextMenuBar1.Location = new Point(0, -20);
            ContextMenuBar1.Margin = new Padding(4, 4, 4, 4);
            ContextMenuBar1.Name = "ContextMenuBar1";
            ContextMenuBar1.Size = new Size(101, 29);
            ContextMenuBar1.Stretch = true;
            ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ContextMenuBar1.TabIndex = 5;
            ContextMenuBar1.TabStop = false;
            ContextMenuBar1.Text = "ContextMenuBar1";
            // 
            // ButtonItem9
            // 
            _ButtonItem9.AutoExpandOnClick = true;
            _ButtonItem9.Name = "_ButtonItem9";
            _ButtonItem9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { CouperItem, CopierItem, CollerItem, ButtonItem10 });
            _ButtonItem9.Text = "ButtonItem9";
            // 
            // CouperItem
            // 
            CouperItem.Image = My.Resources.Resources.scissors;
            CouperItem.Name = "CouperItem";
            CouperItem.Text = "Couper          Ctrl+X";
            // 
            // CopierItem
            // 
            CopierItem.Image = My.Resources.Resources.copy_paste_documents_1580__Copier_;
            CopierItem.Name = "CopierItem";
            CopierItem.Text = "Copier           Ctrl+C";
            // 
            // CollerItem
            // 
            CollerItem.Image = My.Resources.Resources.clipboard;
            CollerItem.Name = "CollerItem";
            CollerItem.Text = "Coller             Ctrl+V";
            // 
            // ButtonItem10
            // 
            ButtonItem10.Name = "ButtonItem10";
            ButtonItem10.Symbol = "";
            ButtonItem10.SymbolColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)));
            ButtonItem10.SymbolSize = 12.0f;
            ButtonItem10.Text = "Supprimer";
            // 
            // tmUpdateInterface2
            // 
            tmUpdateInterface2.Enabled = true;
            tmUpdateInterface2.Interval = 400;
            // 
            // ilAutocomplete
            // 
            ilAutocomplete.ImageStream = (ImageListStreamer)resources.GetObject("ilAutocomplete.ImageStream");
            ilAutocomplete.TransparentColor = Color.Transparent;
            ilAutocomplete.Images.SetKeyName(0, "script_16x16.png");
            ilAutocomplete.Images.SetKeyName(1, "app_16x16.png");
            ilAutocomplete.Images.SetKeyName(2, "1302166543_virtualbox.png");
            // 
            // OSMCodeBox
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelEx1);
            Controls.Add(DockSite2);
            Controls.Add(DockSite1);
            Controls.Add(DockSite3);
            Controls.Add(DockSite4);
            Controls.Add(DockSite5);
            Controls.Add(DockSite6);
            Controls.Add(DockSite7);
            Controls.Add(DockSite8);
            Margin = new Padding(4, 4, 4, 4);
            Name = "OSMCodeBox";
            Size = new Size(1148, 593);
            DockSite2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Bar1).EndInit();
            Bar1.ResumeLayout(false);
            PanelDockContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_tb).EndInit();
            PanelDockContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvObjectExplorer2).EndInit();
            DockSite7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Bar2).EndInit();
            PanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ContextMenuBar1).EndInit();
            Load += new EventHandler(OSMCodeBox_Load);
            ResumeLayout(false);
        }

        internal DevComponents.DotNetBar.DotNetBarManager DotNetBarManager1;
        internal DevComponents.DotNetBar.DockSite DockSite4;
        internal DevComponents.DotNetBar.DockSite DockSite1;
        internal DevComponents.DotNetBar.DockSite DockSite2;
        internal DevComponents.DotNetBar.DockSite DockSite3;
        internal DevComponents.DotNetBar.DockSite DockSite5;
        internal DevComponents.DotNetBar.DockSite DockSite6;
        internal DevComponents.DotNetBar.DockSite DockSite7;
        internal DevComponents.DotNetBar.DockSite DockSite8;
        internal DevComponents.DotNetBar.PanelEx PanelEx1;
        internal DevComponents.DotNetBar.Bar Bar1;
        internal DevComponents.DotNetBar.PanelDockContainer PanelDockContainer1;
        internal DevComponents.DotNetBar.DockContainerItem DockContainerItem1;
        private FastColoredTextBoxNS.FastColoredTextBox _tb;

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
                    _tb.Load -= tb_Load;
                }

                _tb = value;
                if (_tb != null)
                {
                    _tb.TextChangedDelayed += tb_TextChangedDelayed;
                    _tb.Load += tb_Load;
                }
            }
        }

        internal DevComponents.DotNetBar.Bar Bar2;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem1;
        internal FastColoredTextBoxNS.DocumentMap DocumentMap1;
        internal DevComponents.DotNetBar.PanelDockContainer PanelDockContainer2;
        internal DevComponents.DotNetBar.DockContainerItem DockContainerItem2;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem2;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem3;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem4;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem5;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem6;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem7;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem8;
        internal DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem _ButtonItem9;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem9 != null)
                {
                    _ButtonItem9.Click -= ButtonItem9_Click;
                }

                _ButtonItem9 = value;
                if (_ButtonItem9 != null)
                {
                    _ButtonItem9.Click += ButtonItem9_Click;
                }
            }
        }

        internal DevComponents.DotNetBar.ButtonItem CouperItem;
        internal DevComponents.DotNetBar.ButtonItem CopierItem;
        internal DevComponents.DotNetBar.ButtonItem CollerItem;
        internal DevComponents.DotNetBar.ButtonItem ButtonItem10;
        private DevComponents.DotNetBar.Controls.DataGridViewX _dgvObjectExplorer2;

        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvObjectExplorer2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dgvObjectExplorer2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgvObjectExplorer2 != null)
                {
                    _dgvObjectExplorer2.CellMouseDoubleClick -= dgvObjectExplorer2_CellMouseDoubleClick;
                    _dgvObjectExplorer2.CellValueNeeded -= dgvObjectExplorer2_CellValueNeeded;
                }

                _dgvObjectExplorer2 = value;
                if (_dgvObjectExplorer2 != null)
                {
                    _dgvObjectExplorer2.CellMouseDoubleClick += dgvObjectExplorer2_CellMouseDoubleClick;
                    _dgvObjectExplorer2.CellValueNeeded += dgvObjectExplorer2_CellValueNeeded;
                }
            }
        }

        private Timer tmUpdateInterface2;
        private ImageList ilAutocomplete;
        internal DataGridViewImageColumn Column2;
        internal DataGridViewTextBoxColumn Column1;
        internal DevComponents.DotNetBar.LabelItem LabelItem1;
    }
}