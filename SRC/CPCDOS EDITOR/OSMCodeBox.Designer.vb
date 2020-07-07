<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OSMCodeBox
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OSMCodeBox))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.DocumentMap1 = New FastColoredTextBoxNS.DocumentMap()
        Me.tb = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.dgvObjectExplorer2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.tmUpdateInterface2 = New System.Windows.Forms.Timer(Me.components)
        Me.ilAutocomplete = New System.Windows.Forms.ImageList(Me.components)
        Me.CouperItem = New DevComponents.DotNetBar.ButtonItem()
        Me.CopierItem = New DevComponents.DotNetBar.ButtonItem()
        Me.CollerItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.DockSite2.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        CType(Me.tb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer2.SuspendLayout()
        CType(Me.dgvObjectExplorer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite7.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Nothing
        Me.DotNetBarManager1.ParentUserControl = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 482)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(861, 0)
        Me.DockSite4.TabIndex = 3
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 25)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 457)
        Me.DockSite1.TabIndex = 0
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Controls.Add(Me.Bar1)
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {CType(New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 144, 457), DevComponents.DotNetBar.DocumentBaseContainer)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite2.Location = New System.Drawing.Point(714, 25)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(147, 457)
        Me.DockSite2.TabIndex = 1
        Me.DockSite2.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.Bar1.AutoSyncBarCaption = True
        Me.Bar1.CloseSingleTab = True
        Me.Bar1.Controls.Add(Me.PanelDockContainer1)
        Me.Bar1.Controls.Add(Me.PanelDockContainer2)
        Me.Bar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar1.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem2})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Location = New System.Drawing.Point(3, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 0
        Me.Bar1.Size = New System.Drawing.Size(144, 457)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "View"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer1.Controls.Add(Me.DocumentMap1)
        Me.PanelDockContainer1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(138, 406)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'DocumentMap1
        '
        Me.DocumentMap1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DocumentMap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentMap1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentMap1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.DocumentMap1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentMap1.Name = "DocumentMap1"
        Me.DocumentMap1.Size = New System.Drawing.Size(138, 406)
        Me.DocumentMap1.TabIndex = 5
        Me.DocumentMap1.Target = Me.tb
        Me.DocumentMap1.Text = "DocumentMap1"
        '
        'tb
        '
        Me.tb.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.tb.AutoScrollMinSize = New System.Drawing.Size(50, 14)
        Me.tb.BackBrush = Nothing
        Me.tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tb.CharHeight = 14
        Me.tb.CharWidth = 7
        Me.ContextMenuBar1.SetContextMenuEx(Me.tb, Me.ButtonItem9)
        Me.tb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.tb.ForeColor = System.Drawing.Color.Gainsboro
        Me.tb.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tb.IsReplaceMode = False
        Me.tb.LeftPadding = 25
        Me.tb.LineNumberColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.tb.Location = New System.Drawing.Point(0, 0)
        Me.tb.Name = "tb"
        Me.tb.Paddings = New System.Windows.Forms.Padding(0)
        Me.tb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb.ServiceColors = CType(resources.GetObject("tb.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.tb.ServiceLinesColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.tb.ShowScrollBars = False
        Me.tb.Size = New System.Drawing.Size(714, 457)
        Me.tb.TabIndex = 4
        Me.tb.Zoom = 100
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelDockContainer2.Controls.Add(Me.dgvObjectExplorer2)
        Me.PanelDockContainer2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(138, 406)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 5
        '
        'dgvObjectExplorer2
        '
        Me.dgvObjectExplorer2.AllowUserToAddRows = False
        Me.dgvObjectExplorer2.AllowUserToDeleteRows = False
        Me.dgvObjectExplorer2.AllowUserToResizeColumns = False
        Me.dgvObjectExplorer2.AllowUserToResizeRows = False
        Me.dgvObjectExplorer2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvObjectExplorer2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObjectExplorer2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvObjectExplorer2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObjectExplorer2.ColumnHeadersVisible = False
        Me.dgvObjectExplorer2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1})
        Me.dgvObjectExplorer2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvObjectExplorer2.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvObjectExplorer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvObjectExplorer2.EnableHeadersVisualStyles = False
        Me.dgvObjectExplorer2.GridColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.dgvObjectExplorer2.Location = New System.Drawing.Point(0, 0)
        Me.dgvObjectExplorer2.MultiSelect = False
        Me.dgvObjectExplorer2.Name = "dgvObjectExplorer2"
        Me.dgvObjectExplorer2.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObjectExplorer2.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvObjectExplorer2.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control
        Me.dgvObjectExplorer2.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvObjectExplorer2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvObjectExplorer2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvObjectExplorer2.Size = New System.Drawing.Size(138, 406)
        Me.dgvObjectExplorer2.TabIndex = 6
        Me.dgvObjectExplorer2.VirtualMode = True
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Column2"
        Me.Column2.MinimumWidth = 32
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 32
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "View"
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.Text = "Class"
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 482)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(861, 0)
        Me.DockSite8.TabIndex = 7
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 25)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 457)
        Me.DockSite5.TabIndex = 4
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(861, 25)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 457)
        Me.DockSite6.TabIndex = 5
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DockSite7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DockSite7.Controls.Add(Me.Bar2)
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(861, 25)
        Me.DockSite7.TabIndex = 6
        Me.DockSite7.TabStop = False
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.Bar2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.Bar2.IsMaximized = False
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5, Me.ButtonItem6, Me.ButtonItem7, Me.ButtonItem8, Me.LabelItem1})
        Me.Bar2.Location = New System.Drawing.Point(0, 0)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.Size = New System.Drawing.Size(262, 25)
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar2.TabIndex = 0
        Me.Bar2.TabStop = False
        Me.Bar2.Text = "Bar2"
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 25)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(861, 0)
        Me.DockSite3.TabIndex = 2
        Me.DockSite3.TabStop = False
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ContextMenuBar1)
        Me.PanelEx1.Controls.Add(Me.tb)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 25)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(714, 457)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 8
        Me.PanelEx1.Text = "PanelEx1"
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.AntiAlias = True
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuBar1.IsMaximized = False
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem9})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(0, -16)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(76, 25)
        Me.ContextMenuBar1.Stretch = True
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar1.TabIndex = 5
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.AutoExpandOnClick = True
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CouperItem, Me.CopierItem, Me.CollerItem, Me.ButtonItem10})
        Me.ButtonItem9.Text = "ButtonItem9"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Symbol = ""
        Me.ButtonItem10.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonItem10.SymbolSize = 12.0!
        Me.ButtonItem10.Text = "Supprimer"
        '
        'tmUpdateInterface2
        '
        Me.tmUpdateInterface2.Enabled = True
        Me.tmUpdateInterface2.Interval = 400
        '
        'ilAutocomplete
        '
        Me.ilAutocomplete.ImageStream = CType(resources.GetObject("ilAutocomplete.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilAutocomplete.TransparentColor = System.Drawing.Color.Transparent
        Me.ilAutocomplete.Images.SetKeyName(0, "script_16x16.png")
        Me.ilAutocomplete.Images.SetKeyName(1, "app_16x16.png")
        Me.ilAutocomplete.Images.SetKeyName(2, "1302166543_virtualbox.png")
        '
        'CouperItem
        '
        Me.CouperItem.Image = Global.OSMaker.My.Resources.Resources.scissors
        Me.CouperItem.Name = "CouperItem"
        Me.CouperItem.Text = "Couper          Ctrl+X"
        '
        'CopierItem
        '
        Me.CopierItem.Image = Global.OSMaker.My.Resources.Resources.copy_paste_documents_1580__Copier_
        Me.CopierItem.Name = "CopierItem"
        Me.CopierItem.Text = "Copier           Ctrl+C"
        '
        'CollerItem
        '
        Me.CollerItem.Image = Global.OSMaker.My.Resources.Resources.clipboard
        Me.CollerItem.Name = "CollerItem"
        Me.CollerItem.Text = "Coller             Ctrl+V"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Image = Global.OSMaker.My.Resources.Resources.button
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "ButtonItem1"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Image = Global.OSMaker.My.Resources.Resources.button_1_
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "ButtonItem2"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Image = Global.OSMaker.My.Resources.Resources.Save_37110__Copier_
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "ButtonItem3"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.Image = Global.OSMaker.My.Resources.Resources.scissors
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "ButtonItem4"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.Image = Global.OSMaker.My.Resources.Resources.copy_paste_documents_1580__Copier_
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "ButtonItem5"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.Image = Global.OSMaker.My.Resources.Resources.clipboard
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "ButtonItem6"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Image = Global.OSMaker.My.Resources.Resources.arrows___Copie
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "ButtonItem7"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.Image = Global.OSMaker.My.Resources.Resources.arrows
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "ButtonItem8"
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "LabelItem1"
        '
        'OSMCodeBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Name = "OSMCodeBox"
        Me.Size = New System.Drawing.Size(861, 482)
        Me.DockSite2.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        CType(Me.tb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer2.ResumeLayout(False)
        CType(Me.dgvObjectExplorer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite7.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents tb As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DocumentMap1 As FastColoredTextBoxNS.DocumentMap
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CouperItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CopierItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CollerItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents dgvObjectExplorer2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents tmUpdateInterface2 As Timer
    Private WithEvents ilAutocomplete As ImageList
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
End Class
