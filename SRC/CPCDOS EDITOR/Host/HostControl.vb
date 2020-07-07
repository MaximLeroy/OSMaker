Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics

Namespace OSMaker
    ''' <summary>
    ''' Hosts the HostSurface which inherits from DesignSurface.
    ''' </summary>
    Public Class HostControl
        Inherits UserControl

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As IContainer = Nothing
        Private _hostSurface As HostSurface
        Private _hostSurfaceManager As HostSurfaceManager

        Friend Sub New(ByVal hostSurface As HostSurface)
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
            InitializeHost(hostSurface)
        End Sub


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub


#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
            Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
            Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
            Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ContextMenuBar1
            '
            Me.ContextMenuBar1.AntiAlias = True
            Me.ContextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.ContextMenuBar1.IsMaximized = False
            Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1})
            Me.ContextMenuBar1.Location = New System.Drawing.Point(331, 211)
            Me.ContextMenuBar1.Name = "ContextMenuBar1"
            Me.ContextMenuBar1.Size = New System.Drawing.Size(75, 25)
            Me.ContextMenuBar1.Stretch = True
            Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ContextMenuBar1.TabIndex = 0
            Me.ContextMenuBar1.TabStop = False
            Me.ContextMenuBar1.Text = "ContextMenuBar1"
            '
            'ButtonItem1
            '
            Me.ButtonItem1.AutoExpandOnClick = True
            Me.ButtonItem1.Name = "ButtonItem1"
            Me.ButtonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem2, Me.ButtonItem3})
            Me.ButtonItem1.Text = "ButtonItem1"
            '
            'ButtonItem2
            '
            Me.ButtonItem2.Name = "ButtonItem2"
            Me.ButtonItem2.Text = "ButtonItem2"
            '
            'ButtonItem3
            '
            Me.ButtonItem3.Name = "ButtonItem3"
            Me.ButtonItem3.Text = "ButtonItem3"
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(97, 26)
            '
            'TestToolStripMenuItem
            '
            Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
            Me.TestToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
            Me.TestToolStripMenuItem.Text = "Test"
            '
            'HostControl
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
            Me.ContextMenuBar1.SetContextMenuEx(Me, Me.ButtonItem1)
            Me.Controls.Add(Me.ContextMenuBar1)
            Me.Name = "HostControl"
            Me.Size = New System.Drawing.Size(484, 346)
            CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStrip1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend Sub InitializeHost(ByVal hostSurface As HostSurface)
            Try
                If hostSurface Is Nothing Then Return
                _hostSurface = hostSurface

                Dim Control As Control = TryCast(_hostSurface.View, Control)

                Control.Parent = Me
                Control.Dock = DockStyle.Fill
                Control.Visible = True
                Control.ContextMenuStrip = ContextMenuStrip1

            Catch ex As Exception
                Trace.WriteLine(ex.ToString())
            End Try
        End Sub

        Friend ReadOnly Property HostSurface As HostSurface
            Get
                Return _hostSurface
            End Get
        End Property
        Public Class codee

        End Class


        Friend ReadOnly Property DesignerHost As IDesignerHost
            Get
                Return CType(_hostSurface.GetService(GetType(IDesignerHost)), IDesignerHost)
            End Get
        End Property

        Private Sub HostControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            Me.Dock = DockStyle.Fill

        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs)


        End Sub

        Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
        Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
        Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    End Class ' class
End Namespace ' namespace