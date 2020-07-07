Public Class CpcControl

End Class
Class TextBox : Inherits System.Windows.Forms.TextBox

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private Parametres1 As String

    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
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

    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
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
        Parameters = System.Boolean.FalseString
        COL = System.Boolean.TrueString
        IMGAUTO = 0
        UPD1 = System.Boolean.TrueString
        HANDLE = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = "200,255,240"
        CouleurTexte = "250,100,100"
    End Sub
End Class

Class TextBlock : Inherits System.Windows.Forms.Label

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private MULTILINES1 As Boolean

    Private Parametres1 As String

    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
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
    Public Property MULTILINES As Boolean
        Get
            Return MULTILINES1
        End Get
        Set(value As Boolean)
            MULTILINES1 = value
        End Set
    End Property
    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
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
        Imgauto1 = "0"
        UPD1 = System.Boolean.TrueString
        HANDLE = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = "200,255,240"
        CouleurTexte = "250,100,100"
        MULTILINES = System.Boolean.FalseString
        Parameters = ""
    End Sub

End Class
Class CheckBox : Inherits System.Windows.Forms.CheckBox

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String



    Private Parametres1 As String

    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
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

    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
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

        COL = System.Boolean.TrueString
        IMGAUTO = "2"
        UPD1 = System.Boolean.TrueString
        HANDLE = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = "255,255,240"
        CouleurTexte = "000,000,000"
        Parameters = ""
    End Sub

End Class

Class ProgressBar : Inherits System.Windows.Forms.ProgressBar


        Private Imgauto1 As Integer
        Private UPD1 As Boolean
        Private handle1 As String
        Private Evant1 As String
        Private couleurfond1 As String
        Private couleurtexte1 As String
        Private valeur1 As String
    Private Parametres1 As String

    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property

    Public Overloads Property HANDLE() As String
            Get
                Return handle1
            End Get
            Set(value As String)
                handle1 = value

            End Set

        End Property

        Public Overloads Property VALEUR() As String
            Get
                Return valeur1
            End Get
            Set(value As String)
                valeur1 = value

            End Set

        End Property
        Public Property IMGAUTO As Integer
            Get
                Return Imgauto1
            End Get
            Set(value As Integer)
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


        IMGAUTO = "2"
        UPD1 = System.Boolean.TrueString
            HANDLE = "MonHandle"
            EVENT_PATH = ""
            CouleurFond = "200,255,240"
            CouleurTexte = "250,100,100"
        VALEUR = "0"
        Parameters = ""
    End Sub

    End Class
Class PictureBox : Inherits System.Windows.Forms.PictureBox

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private image1 As String
    Private Opacite1 As Integer
    Private Parametres1 As String

    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
    Public Overloads Property HANDLE() As String
        Get
            Return handle1
        End Get
        Set(value As String)
            handle1 = value

        End Set

    End Property
    Public Overloads Property IMAGE() As String
        Get
            Return image1
        End Get
        Set(value As String)
            image1 = value

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

    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
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
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
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

        COL = System.Boolean.TrueString
        IMGAUTO = 0
        UPD1 = System.Boolean.TrueString
        HANDLE = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = ""
        CouleurTexte = ""
        IMAGE = ""
        OPACITE = 255
        Parameters = ""
    End Sub
End Class
Class Button : Inherits System.Windows.Forms.Button

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private opacite1 As Integer
    Private image1 As String
    Private Parametres1 As String

    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
    Public Overloads Property HANDLE() As String
        Get
            Return handle1
        End Get
        Set(value As String)
            handle1 = value

        End Set

    End Property

    Public Overloads Property IMAGE() As String
        Get
            Return image1
        End Get
        Set(value As String)
            image1 = value

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

    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
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
    Public Property OPACITE As Integer
        Get
            Return opacite1
        End Get
        Set(value As Integer)
            opacite1 = value
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

        COL = System.Boolean.TrueString
        IMGAUTO = 0
        UPD1 = System.Boolean.TrueString
        HANDLE = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = ""
        CouleurTexte = ""
        OPACITE = 255
        IMAGE = ""
        Parameters = ""
    End Sub
End Class


