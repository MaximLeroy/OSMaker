Public Class CpcForm : Inherits System.Windows.Forms.Form

    Private Col1 As Boolean
    Private Imgauto1 As Boolean
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String

    Public Overloads Property HANDLE() As String
        Get
            Return handle1
        End Get
        Set(value As String)
            handle1 = value

        End Set

    End Property
    Public Property COL As Boolean
        Get
            Return Col1
        End Get
        Set(value As Boolean)
            Col1 = value
        End Set
    End Property

    Public Property IMGAUTO As Boolean
        Get
            Return Imgauto1
        End Get
        Set(value As Boolean)
            Imgauto1 = value
        End Set
    End Property
    Public Property UPD As Boolean
        Get
            Return UPD1
        End Get
        Set(value As Boolean)
            UPD1 = value
        End Set
    End Property
    Public Overloads Property EVENT_PATH() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property
    Public Property CouleurFond As String
        Get
            Return couleurfond1
        End Get
        Set(value As String)
            couleurfond1 = value
        End Set
    End Property
    Public Property CouleurTexte As String
        Get
            Return couleurtexte1
        End Get
        Set(value As String)
            couleurtexte1 = value
        End Set
    End Property
    Sub New()

        Col1 = System.Boolean.TrueString
        Imgauto1 = System.Boolean.FalseString
        UPD1 = System.Boolean.TrueString
        HANDLE = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = "200,255,240"
        CouleurTexte = "250,100,100"
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'CpcForm
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Name = "CpcForm"
        Me.ResumeLayout(False)

    End Sub


End Class
