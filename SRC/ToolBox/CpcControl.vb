Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Public Class CpcControl

End Class



Public Class FormatStringConverter
    Inherits StringConverter

    Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As TypeConverter.StandardValuesCollection
        Dim list As Collections.Generic.List(Of String) = New Collections.Generic.List(Of String)()
        list.Add("")
        list.Add("Currency")
        list.Add("Scientific Notation")
        list.Add("General Number")
        list.Add("Number")
        list.Add("Percent")
        list.Add("Time")
        list.Add("Date")
        Return New StandardValuesCollection(list)
    End Function
End Class
Public Class BitmapLocationEditor : Inherits UITypeEditor
    Public Overrides Function GetEditStyle(ByVal context As ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function



    Public Overrides Function GetPaintValueSupported(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function

    Public Overrides Sub PaintValue(ByVal e As PaintValueEventArgs)
        If e.Value IsNot Nothing Then
            Dim bmp As Bitmap = CType(e.Value, Bitmap)
            Dim destRect As Rectangle = e.Bounds
            bmp.MakeTransparent()
            e.Graphics.DrawImage(bmp, destRect)
        End If
    End Sub
End Class

Public Class Window : Inherits Panel
    Private ImgTitre1 As Image
    Private Ctn1 As Boolean
    Private Siz1 As Boolean
    Private SizBtn1 As Boolean
    Private Reduct1 As Boolean
    Private Move1 As Boolean
    Private Bord1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurtitre1 As Color
    Private couleurfenetre1 As Color
    Private Close1 As Boolean
    Private TaskBar1 As Boolean
    Private Parametres1 As Boolean
    Private Ombre1 As String
    Private _Type As String
    Private Opacite1 As String

    Public Enum SummaryOptions
      
        Normale
        Sans_conteneur_visible
        Sans_bitmap_de_titre
        Sans_bitmap_de_titre_et_sans_conteneur_visible
        Sans_barre_de_titre
        Sans_barre_de_titre_et_sans_conteneur_visible

    End Enum
    Private _Type1 As SummaryOptions

    <Category("Propriétés CPCDOS")>
    <DisplayName("Type")>
    <Description("Type de fenêtre graphique")>
    Public Property Type As SummaryOptions
        Get
            Return _Type1
        End Get
        Set(ByVal value As SummaryOptions)
            _Type1 = value
        End Set
    End Property


    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Utiliser les paramètres")>
    Public Property Parameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle Fenetre")>
    <Description("Handle")>
    Public Overloads Property HANDLEFENETRE() As String
        Get
            Return handle1
        End Get
        Set(value As String)
            handle1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Shadow")>
    <Description("Opacité de l'ombre derrière la fenêtre d'une valeur personnalisable entre 0 → 255.")>
    Public Overloads Property OMBRE() As String
        Get
            Return ombre1
        End Get
        Set(value As String)
            ombre1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité de la fenêtre (0 → 255 Opaque)")>
    Public Overloads Property OPACITE() As String
        Get
            Return Opacite1
        End Get
        Set(value As String)
            Opacite1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Conteneur")>
    <Description("Afficher le conteneur au complet (sans la barre de titre cliquable)")>
    Public Property CTN As Boolean
        Get
            Return Ctn1
        End Get
        Set(value As Boolean)
            Ctn1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Move")>
    <Description("Fenêtre déplaçable avec la souris.")>
    Public Property MOVE As Boolean
        Get
            Return Move1
        End Get
        Set(value As Boolean)
            Move1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Bord")>
    <Description("Afficher le contour graphique d'une fenêtre.")>
    Public Property BORD As Boolean
        Get
            Return Bord1
        End Get
        Set(value As Boolean)
            Bord1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Siz")>
    <Description("Taille de la fenêtre modifiable")>
    Public Property SIZ As Boolean
        Get
            Return Siz1
        End Get
        Set(value As Boolean)
            Siz1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("SizeButton")>
    <Description("Bouton rétrécissement fenêtre présent ou non")>
    Public Property SIZBTN As Boolean
        Get
            Return SizBtn1
        End Get
        Set(value As Boolean)
            SizBtn1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Reduct")>
    <Description("Fenêtre réductale dans la barre des tâches")>
    Public Property REDUCT As Boolean
        Get
            Return Reduct1
        End Get
        Set(value As Boolean)
            Reduct1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Close")>
    <Description("Fenêtre fermable ou non")>
    Public Property CLOSE As Boolean
        Get
            Return Close1
        End Get
        Set(value As Boolean)
            Close1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("TaskBar")>
    <Description("Fenêtre héberge une taskbar d’application")>
    Public Property TASKBAR As Boolean
        Get
            Return Close1
        End Get
        Set(value As Boolean)
            Close1 = value

        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Events")>
    <Description("→Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property EVENT_PATH() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property


    <Category("Propriétés CPCDOS")>
    <Description("Couleur des caractères du titre")>
    Public Property TitleColor As System.Drawing.Color
        Get
            Return couleurtitre1
        End Get
        Set(ByVal Value As System.Drawing.Color)
            couleurtitre1 = Value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <Description("Couleur générale de la fenêtre")>
    Public Property WindowColor As System.Drawing.Color
        Get
            Return couleurfenetre1
        End Get
        Set(ByVal Value As System.Drawing.Color)
            couleurfenetre1 = Value
        End Set
    End Property
    Sub New()

        Ctn1 = System.Boolean.FalseString
        Imgauto1 = "0"
        UPD1 = Boolean.TrueString
        handle1 = "MonHandle"
        EVENT_PATH = ""
        _Type1 = SummaryOptions.Normale
        Bord1 = Boolean.TrueString
        Move1 = Boolean.TrueString
        Parametres1 = Boolean.FalseString
        Siz1 = Boolean.TrueString
        SizBtn1 = Boolean.TrueString
        Reduct1 = Boolean.TrueString
        Close1 = Boolean.TrueString
        TaskBar1 = Boolean.FalseString
        Opacite1 = "255"
        Ombre1 = "0"
    End Sub

End Class
Public Class TextBox : Inherits System.Windows.Forms.TextBox

    Private Col1 As Boolean
    Private Move1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private Parametres1 As String
    Private Opacite1 As Integer
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)
            value = Handle
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

        EVENT_PATH = ""
        CouleurFond = ""
        CouleurTexte = ""
        handle1 = "MonHandle"
    End Sub
End Class

Public Class TextBlock : Inherits System.Windows.Forms.Label

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private MULTILINES1 As Boolean
    Private Opacite1 As Integer
    Private Parametres1 As String
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
    Public Overloads Property Handle() As String
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
        Handle = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = "200,255,240"
        CouleurTexte = "250,100,100"
        MULTILINES = System.Boolean.FalseString
        Parameters = ""
    End Sub

End Class
Public Class CheckBox : Inherits System.Windows.Forms.CheckBox

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private Opacite1 As Integer


    Private Parametres1 As String
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property
    Public Overloads Property Handle() As String
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
        Handle = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = "255,255,240"
        CouleurTexte = "000,000,000"
        Parameters = ""
    End Sub

End Class

Public Class ProgressBar : Inherits System.Windows.Forms.ProgressBar


    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private couleurfond1 As String
    Private couleurtexte1 As String
    Private valeur1 As String
    Private Parametres1 As String
    Private Opacite1 As Integer
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    Public Property Parameters As String
        Get
            Return Parametres1
        End Get
        Set(value As String)
            Parametres1 = value
        End Set
    End Property

    Public Overloads Property Handle() As String
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
        Handle = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = "200,255,240"
        CouleurTexte = "250,100,100"
        VALEUR = "0"
        Parameters = ""
    End Sub

End Class
Public Class PictureBox : Inherits System.Windows.Forms.PictureBox

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
    Public Overloads Property Handle() As String
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
        Handle = "MonHandle"
        EVENT_PATH = ""
        CouleurFond = ""
        CouleurTexte = ""
        IMAGE = ""
        OPACITE = 255
        Parameters = ""
    End Sub
End Class
Public Class Button : Inherits System.Windows.Forms.Button

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
            Dim rgb = BackColor.ToString
            value = rgb
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


