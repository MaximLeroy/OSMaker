Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics

Namespace Host
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

        Public Sub New(ByVal hostSurface As HostSurface)
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
            Me.SuspendLayout()
            '
            'HostControl
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
            Me.Name = "HostControl"
            Me.Size = New System.Drawing.Size(268, 224)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Friend Sub InitializeHost(ByVal hostSurface As HostSurface)
            Try
                If hostSurface Is Nothing Then Return
                _hostSurface = hostSurface
                Dim control As Control = TryCast(_hostSurface.View, Control)
                control.Parent = Me
                control.Dock = DockStyle.Fill
                control.Visible = True
            Catch ex As Exception
                Trace.WriteLine(ex.ToString())
            End Try
        End Sub

        Public ReadOnly Property HostSurface As HostSurface
            Get
                Return _hostSurface
            End Get
        End Property

        Public ReadOnly Property DesignerHost As IDesignerHost
            Get
                Return CType(_hostSurface.GetService(GetType(IDesignerHost)), IDesignerHost)
            End Get
        End Property

        Private Sub HostControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class ' class
End Namespace ' namespace