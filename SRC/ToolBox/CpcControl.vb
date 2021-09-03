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
    Private Imgauto1 As Boolean
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private TitleImg1 As String
    Private Icon1 As String
    Private couleurtitre1 As Color
    Private couleurfenetre1 As Color
    Private Close1 As Boolean
    Private TaskBar1 As Boolean
    Private Parametres1 As Boolean
    Private Ombre1 As Integer
    Private _Type1 As SummaryOptions
    Private Opacite1 As Integer
    Private Param1 As String
    Private collision1 As Boolean
    Private minsizx1 As Integer
    Private minsizy1 As Integer
    Private maxsizx1 As Integer
    Private maxsizy1 As Integer
    Private taskbarhide1 As Boolean
    Private blurry1 As Integer
    Private ctx1 As Integer
    Public Enum SummaryOptions
      
        Normale
        Sans_conteneur_visible
        Sans_bitmap_de_titre
        Sans_bitmap_de_titre_et_sans_conteneur_visible
        Sans_barre_de_titre
        Sans_barre_de_titre_et_sans_conteneur_visible

    End Enum





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
    <Description("Modes et paramètres")>
    Public Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim _type As Integer = 0
                If _Type1 = SummaryOptions.Normale Then
                    _type = 0
                ElseIf _Type1 = SummaryOptions.Sans_conteneur_visible Then
                    _type = 1
                ElseIf _Type1 = SummaryOptions.Sans_bitmap_de_titre Then
                    _type = 2
                ElseIf _Type1 = SummaryOptions.Sans_bitmap_de_titre_et_sans_conteneur_visible Then
                    _type = 3
                ElseIf _Type1 = SummaryOptions.Sans_barre_de_titre Then
                    _type = 4
                ElseIf _Type1 = SummaryOptions.Sans_barre_de_titre_et_sans_conteneur_visible Then
                    _type = 5
                End If
                Dim _ctn As Integer = 0
                If Ctn1 = True Then
                    _ctn = 1
                Else
                    _ctn = 0
                End If
                Dim _collision As Integer = 0
                If collision1 = True Then
                    _collision = 1
                Else
                    _collision = 0
                End If
                Dim _bord As Integer = 0
                If Bord1 = True Then
                    _bord = 1
                Else
                    _bord = 0
                End If
                Dim _move As Integer = 0
                If Move1 = True Then
                    _move = 1
                Else
                    _move = 0
                End If
                Dim _siz As Integer = 0
                If Siz1 = True Then
                    _siz = 1
                Else
                    _siz = 0
                End If
                Dim _sizbtn As Integer = 0
                If SizBtn1 = True Then
                    _sizbtn = 1
                Else
                    _sizbtn = 0
                End If
                Dim _reduct As Integer = 0
                If Reduct1 = True Then
                    _reduct = 1
                Else
                    _reduct = 0
                End If
                Dim _close As Integer = 0
                If Close1 = True Then
                    _close = 1
                Else
                    _close = 0
                End If
                Dim _taskbar As Integer = 0
                If TaskBar1 = True Then
                    _taskbar = 1
                Else
                    _taskbar = 0
                End If
                Dim _taskbarhide As Integer = 0
                If taskbarhide1 = True Then
                    _taskbarhide = 1
                Else
                    _taskbarhide = 0
                End If

                Return "TYPE:" + _type.ToString() + " " + "CTN:" + _ctn.ToString() + " " + "BORD:" + _bord.ToString() + " " + "MOVE:" + _move.ToString() + " " + "SIZ:" + _siz.ToString() + " " + "SHADOW:" + OMBRE.ToString() + " " + "TASKBAR:" + _taskbar.ToString() + " " + "CLOSE:" + _close.ToString() + " " + "REDUCT:" + _reduct.ToString() + " " + "SIZEBTN:" + _sizbtn.ToString() + " " + "COLLISION:" + _collision.ToString() + " " + "MINSIZ_X:" + minsizx1.ToString() + "P" + " " + "MINSIZ_Y:" + minsizy1.ToString() + "P" + " " + "MAXSIZ_X:" + maxsizx1.ToString() + "P" + " " + "MAXSIZ_Y:" + maxsizy1.ToString() + "P" + " " + "TASKBARHIDE:" + _taskbarhide.ToString() + " " + "BLURRY:" + blurry1.ToString() + " " + "CTX:" + ctx1.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Utiliser les paramètres")>
    Public Property ShowParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Taskbar hide")>
    <Description("Masquer de la barre des tâches")>
    Public Property TaskBarHide As Boolean
        Get
            Return taskbarhide1
        End Get
        Set(value As Boolean)
            taskbarhide1 = value
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
    Public Overloads Property OMBRE() As Integer
        Get
            Return Ombre1
        End Get
        Set(value As Integer)
            Ombre1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Blurry")>
    <Description("Effet de flou 0 (aucun) à 5 (max)")>
    Public Overloads Property BLURRY() As Integer
        Get
            Return blurry1
        End Get
        Set(value As Integer)
            blurry1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("ContextMenu")>
    <Description("0 (aucun) 1 (défaut) 2 (personnalisé)")>
    Public Overloads Property CTX() As Integer
        Get
            Return ctx1
        End Get
        Set(value As Integer)
            ctx1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Min size X")>
    <Description("Taille minimale en X d’une fenêtre")>
    Public Overloads Property minsizx() As Integer
        Get
            Return minsizx1
        End Get
        Set(value As Integer)
            minsizx1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Min size Y")>
    <Description("Taille minimale en Y d’une fenêtre")>
    Public Overloads Property minsizy() As Integer
        Get
            Return minsizy1
        End Get
        Set(value As Integer)
            minsizy1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Max size X")>
    <Description("Taille maximale en X d’une fenêtre")>
    Public Overloads Property maxsizx() As Integer
        Get
            Return maxsizx1
        End Get
        Set(value As Integer)
            maxsizx1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Max size Y")>
    <Description("Taille maximale en Y d’une fenêtre")>
    Public Overloads Property maxsizy() As Integer
        Get
            Return maxsizy1
        End Get
        Set(value As Integer)
            maxsizy1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité de la fenêtre (0 → 255 Opaque)")>
    <DefaultValue(255)>
    Public Overloads Property OPACITE() As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
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
    Public Property MOVEE As Boolean
        Get

            Return Move1
        End Get
        Set(value As Boolean)
            Move1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Collision")>
    <Description("Soumettre la fenêtre à une nouvelle bordure d’écran (personnalisable).")>
    Public Property COLLISION As Boolean
        Get

            Return collision1
        End Get
        Set(value As Boolean)
            collision1 = value
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
            Return TaskBar1
        End Get
        Set(value As Boolean)
            TaskBar1 = value

        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Events")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("TitleImg")>
    <Description("Image de la barre de titre.")>
    Public Overloads Property TitleImg() As String

        Get
            Return TitleImg1
        End Get
        Set(value As String)
            TitleImg1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Icon")>
    <Description("Icône de la fenêtre.")>
    Public Overloads Property Icon() As String

        Get
            Return Icon1
        End Get
        Set(value As String)
            Icon1 = value

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
        Imgauto1 = System.Boolean.FalseString
        UPD1 = System.Boolean.TrueString
        handle1 = "MyHandle"
        _EVENT = ""
        _Type1 = SummaryOptions.Normale
        Bord1 = System.Boolean.TrueString
        Move1 = System.Boolean.TrueString
        Parametres1 = Boolean.FalseString
        Siz1 = System.Boolean.TrueString
        SizBtn1 = System.Boolean.TrueString
        Reduct1 = System.Boolean.TrueString
        Close1 = System.Boolean.TrueString
        TaskBar1 = System.Boolean.FalseString
        Opacite1 = 255
        Ombre1 = 0
        TitleImg1 = ""
        Icon1 = ""
        collision1 = System.Boolean.TrueString
    End Sub

End Class
Public Class TextBox : Inherits System.Windows.Forms.TextBox

    Private Col1 As Boolean
    Private Imgauto1 As Boolean
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private Parametres1 As Boolean
    Private Opacite1 As Integer
    Private EDIT1 As Boolean
    Private Param1 As String

    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité du textbox")>
    <DefaultValue(255)>
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property TextBoxParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim multiline1 As Integer = 0
                If Multiline = True Then
                    multiline1 = 1
                Else
                    multiline1 = 0
                End If
                Dim _col As Integer = 0
                If Col1 = True Then
                    _col = 1
                Else
                    _col = 0
                End If
                Dim _edit As Integer = 0
                If EDIT1 = True Then
                    _edit = 1
                Else
                    _edit = 0
                End If
                Dim _multilines As Integer = 0
                If multiline1 = True Then
                    _multilines = 1
                Else
                    _multilines = 0
                End If
                Dim _imgauto As Integer = 0
                If Imgauto1 = True Then
                    _imgauto = 1
                Else
                    _imgauto = 0
                End If
                Dim _upd As Integer = 0
                If UPD1 = True Then
                    _upd = 1
                Else
                    _upd = 0
                End If

                Return "COL:" + _col.ToString + " " + "EDIT:" + _edit.ToString() + " " + "MULTILINES:" + _multilines.ToString() + " " + "IMGAUTO:" + _imgauto.ToString() + " " + "UPD:" + _upd.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)

            handle1 = value


        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Col")>
    <Description("Afficher la couleur de fond")>
    Public Property COL As Boolean
        Get
            Return Col1
        End Get
        Set(value As Boolean)
            Col1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("ImgAuto")>
    <Description("Affichage adapté aux dimensions de l'imagebox")>
    Public Property IMGAUTO As Boolean
        Get
            Return Imgauto1
        End Get
        Set(value As Boolean)
            Imgauto1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Upd")>
    <Description("Utiliser un thread d’actualisation graphique de la propriété .Text")>
    Public Property UPD As Boolean
        Get
            Return UPD1
        End Get
        Set(value As Boolean)
            UPD1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Edit")>
    <Description("Utiliser un thread d’actualisation graphique de la propriété .Text")>
    Public Property EDIT As Boolean
        Get
            Return EDIT1
        End Get
        Set(value As Boolean)
            EDIT1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property

    Sub New()

        TextBoxParameters = System.Boolean.FalseString
        COL = System.Boolean.TrueString
        IMGAUTO = System.Boolean.FalseString
        UPD1 = System.Boolean.TrueString
        EDIT1 = System.Boolean.TrueString
        _EVENT = ""
        handle1 = "MyHandle"

        Opacite1 = 255
    End Sub
End Class

Public Class ListBox : Inherits System.Windows.Forms.ListBox

    Private handle1 As String
    Private Evant1 As String
    Private Parametres1 As Boolean
    Private Opacite1 As Integer

    Private Param1 As String
    Private image1 As String
    Private ExploreMode As Boolean

    <Category("Propriétés CPCDOS")>
    <DisplayName("Explore mode")>
    <Description("True : icones | False : liste")>
    Public Property _EXPLOREMODE As Boolean
        Get
            Return ExploreMode
        End Get
        Set(value As Boolean)
            ExploreMode = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité du listbox")>
    <DefaultValue(255)>
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property TextBoxParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim explore1 As Integer = 0
                If ExploreMode = True Then
                    explore1 = 1
                Else
                    explore1 = 0
                End If


                Return "EXPLOREMODE:" + explore1.ToString
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)

            handle1 = value


        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Image(s)")>
    <Description("Path des icônes séparés par un « ; »")>
    Public Overloads Property _IMAGE() As String
        Get
            Return image1
        End Get
        Set(value As String)

            image1 = value


        End Set

    End Property


    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property

    Sub New()

        TextBoxParameters = System.Boolean.FalseString

        ExploreMode = System.Boolean.FalseString

        _EVENT = ""
        handle1 = "MyHandle"

        Opacite1 = 255
    End Sub
End Class

Public Class TextBlock : Inherits System.Windows.Forms.Label

    Private Col1 As Boolean
    Private Imgauto1 As Boolean
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private MULTILINES1 As Boolean
    Private Opacite1 As Integer
    Private Parametres1 As Boolean
    Private Param1 As String
    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité du textblock")>
    <DefaultValue(255)>
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property TextBlockParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim multiline1 As Integer = 0
                If MULTILINES1 = True Then
                    multiline1 = 1
                Else
                    multiline1 = 0
                End If
                Dim _col As Integer = 0
                If Col1 = True Then
                    _col = 1
                Else
                    _col = 0
                End If
                Dim _multilines As Integer = 0
                If multiline1 = True Then
                    _multilines = 1
                Else
                    _multilines = 0
                End If
                Dim _imgauto As Integer = 0
                If Imgauto1 = True Then
                    _imgauto = 1
                Else
                    _imgauto = 0
                End If
                Dim _upd As Integer = 0
                If UPD1 = True Then
                    _upd = 1
                Else
                    _upd = 0
                End If

                Return "COL:" + _col.ToString + " " + "MULTILINES:" + _multilines.ToString() + " " + "IMGAUTO:" + _imgauto.ToString() + " " + "UPD:" + _upd.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)

            handle1 = value


        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Col")>
    <Description("Afficher la couleur de fond")>
    Public Property COL As Boolean
        Get
            Return Col1
        End Get
        Set(value As Boolean)
            Col1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("ImgAuto")>
    <Description("Affichage adapté aux dimensions du texblock")>
    Public Property IMGAUTO As Boolean
        Get
            Return Imgauto1
        End Get
        Set(value As Boolean)
            Imgauto1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Upd")>
    <Description("Utiliser un thread d’actualisation graphique de la propriété .Text")>
    Public Property UPD As Boolean
        Get
            Return UPD1
        End Get
        Set(value As Boolean)
            UPD1 = value
        End Set
    End Property


    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property

    Sub New()

        TextBlockParameters = System.Boolean.FalseString
        COL = System.Boolean.TrueString
        IMGAUTO = System.Boolean.FalseString
        UPD1 = System.Boolean.TrueString
        MULTILINES1 = System.Boolean.FalseString
        _EVENT = ""
        handle1 = "MyHandle"

        OPACITE = 255
    End Sub

End Class
Public Class CheckBox : Inherits System.Windows.Forms.CheckBox

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private Opacite1 As Integer
    Private Param1 As String

    Private Parametres1 As Boolean
    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité de la checkbox")>
    <DefaultValue(255)>
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property CheckBoxParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim _col As Integer = 0
                If Col1 = True Then
                    _col = 1
                Else
                    _col = 0
                End If
                Dim _upd As Integer = 0
                If UPD1 = True Then
                    _upd = 1
                Else
                    _upd = 0
                End If

                Return "COL:" + _col.ToString + " " + "UPD:" + _upd.ToString() + " " + "IMGAUTO:" + Imgauto1.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)
            handle1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Col")>
    <Description("Affiche la couleur de fond")>
    Public Property COL As Boolean
        Get
            Return Col1
        End Get
        Set(value As Boolean)
            Col1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("ImgAuto")>
    <Description("Objet adapté aux dimensions du texte")>
    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
            Imgauto1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Upd")>
    <Description("Utiliser un thread d’actualisation graphique de la propriété .Text")>
    Public Property UPD As Boolean
        Get
            Return UPD1
        End Get
        Set(value As Boolean)
            UPD1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property

    Sub New()

        COL = System.Boolean.TrueString
        IMGAUTO = 2
        UPD1 = System.Boolean.TrueString
        Handle = "MyHandle"
        _EVENT = ""
        CheckBoxParameters = System.Boolean.FalseString
        Me.FlatStyle = FlatStyle.Flat
        Opacite1 = 255

    End Sub

End Class

Public Class ProgressBar : Inherits System.Windows.Forms.ProgressBar


    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private image1 As String
    Private Opacite1 As Integer
    Private Parametres1 As Boolean
    Private Param1 As String

    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité de la progressbar")>
    <DefaultValue(255)>
    Public Property OPACITE As Integer
        Get
            Return Opacite1
        End Get
        Set(value As Integer)
            Opacite1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property ProgressBarParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Overloads Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim _upd As Integer = 0
                If UPD1 = True Then
                    _upd = 1
                Else
                    _upd = 0
                End If


                Return "UPD:" + _upd.ToString() + " " + "IMGAUTO:" + Imgauto1.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)
            handle1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Image")>
    <Description("Image")>
    Public Overloads Property _IMAGE As String
        Get
            Return image1
        End Get
        Set(value As String)
            image1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("ImgAuto")>
    <Description("Objet adapté aux dimensions du texte")>
    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
            Imgauto1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Upd")>
    <Description("Utiliser un thread d’actualisation graphique de la propriété .Text")>
    Public Property UPD As Boolean
        Get
            Return UPD1
        End Get
        Set(value As Boolean)
            UPD1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property



    Sub New()


        IMGAUTO = 2
        UPD1 = System.Boolean.TrueString
        Handle = "MyHandle"
        _EVENT = ""
        Opacite1 = 255
        ProgressBarParameters = System.Boolean.FalseString
        image1 = ""
    End Sub

End Class
Public Class PictureBox : Inherits System.Windows.Forms.PictureBox

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private image1 As String
    Private Opacite1 As Integer
    Private Parametres1 As Boolean
    Private Param1 As String

    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité du picturebox")>
    Public Property OPACITE As String
        Get
            Return Opacite1
        End Get
        Set(value As String)
            Opacite1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property PictureBoxParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim _col As Integer = 0
                If Col1 = True Then
                    _col = 1
                Else
                    _col = 0
                End If
                Dim _upd As Integer = 0
                If UPD1 = True Then
                    _upd = 1
                Else
                    _upd = 0
                End If

                Return "COL:" + _col.ToString + " " + "UPD:" + _upd.ToString() + " " + "IMGAUTO:" + Imgauto1.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)

            handle1 = value


        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Image")>
    <Description("Image")>
    Public Overloads Property _IMAGE As String
        Get
            Return image1
        End Get
        Set(value As String)

            image1 = value


        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Col")>
    <Description("Afficher la couleur de fond")>
    Public Property COL As Boolean
        Get
            Return Col1
        End Get
        Set(value As Boolean)
            Col1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("ImgAuto")>
    <Description("Affichage adapté aux dimensions de l'imagebox")>
    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
            Imgauto1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Upd")>
    <Description("Utiliser un thread d’actualisation graphique de la propriété .Text")>
    Public Property UPD As Boolean
        Get
            Return UPD1
        End Get
        Set(value As Boolean)
            UPD1 = value
        End Set
    End Property


    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property
    Sub New()

        COL = System.Boolean.TrueString
        IMGAUTO = 0
        UPD1 = System.Boolean.TrueString
        Handle = "MyHandle"
        _EVENT = ""
        _IMAGE = ""
        Opacite1 = 255
        PictureBoxParameters = System.Boolean.FalseString
    End Sub
End Class
Public Class Button : Inherits System.Windows.Forms.Button

    Private Col1 As Boolean
    Private Imgauto1 As Integer
    Private UPD1 As Boolean
    Private handle1 As String
    Private Evant1 As String
    Private opacite1 As Integer
    Private image1 As String
    Private Parametres1 As Boolean
    Private bord1 As Boolean
    Private Param1 As String

    <Category("Propriétés CPCDOS")>
    <DisplayName("Opacity")>
    <Description("Opacité du bouton")>
    <DefaultValue(255)>
    Public Property OPACITE As Integer
        Get
            Return opacite1
        End Get
        Set(value As Integer)
            opacite1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property ButtonParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Bord")>
    <Description("Activer les paramètres")>
    Public Property BORD As Boolean
        Get
            Return bord1
        End Get
        Set(value As Boolean)
            bord1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property HANDLE As String
        Get
            Return handle1
        End Get
        Set(value As String)

            handle1 = value


        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Image")>
    <Description("Image de fond")>
    Public Overloads Property _IMAGE As String
        Get
            Return image1
        End Get
        Set(value As String)

            image1 = value


        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Col")>
    <Description("Afficher la couleur de fond")>
    Public Property COL As Boolean
        Get
            Return Col1
        End Get
        Set(value As Boolean)
            Col1 = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("ImgAuto")>
    <Description("Affichage adapté aux dimensions de l'imagebox")>
    Public Property IMGAUTO As Integer
        Get
            Return Imgauto1
        End Get
        Set(value As Integer)
            Imgauto1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Upd")>
    <Description("Utiliser un thread d’actualisation graphique de la propriété .Text")>
    Public Property UPD As Boolean
        Get
            Return UPD1
        End Get
        Set(value As Boolean)
            UPD1 = value
        End Set
    End Property


    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)

            Evant1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Overloads Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim _col As Integer = 0
                If Col1 = True Then
                    _col = 1
                Else
                    _col = 0
                End If
                Dim _upd As Integer = 0
                If UPD1 = True Then
                    _upd = 1
                Else
                    _upd = 0
                End If
                Dim _bord As Integer = 0
                If bord1 = True Then
                    _bord = 1
                Else
                    _bord = 0
                End If

                Return "COL:" + _col.ToString + " " + "UPD:" + _upd.ToString() + " " + "IMGAUTO:" + Imgauto1.ToString() + " " + "BORD:" + _bord.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property
    Sub New()

        Col1 = System.Boolean.TrueString
        Imgauto1 = 0
        UPD1 = System.Boolean.TrueString
        HANDLE = "MyHandle"
        _EVENT = ""
        opacite1 = 255
        _IMAGE = ""
        ButtonParameters = System.Boolean.FalseString
        bord1 = System.Boolean.TrueString
        Me.FlatStyle = FlatStyle.Flat

    End Sub
End Class

Public Class Explorer : Inherits _Explorer


    Private handle1 As String
    Private Evant1 As String
    Private DeskMode As Boolean
    Private ExploreMode As Boolean

    Private Parametres1 As Boolean
    Private Param1 As String

    <Category("Propriétés CPCDOS")>
    <DisplayName("Show Parameters")>
    <Description("Activer les paramètres")>
    Public Property TextBlockParameters As Boolean
        Get
            Return Parametres1
        End Get
        Set(value As Boolean)
            Parametres1 = value
        End Set
    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Parameters")>
    <Description("Modes et paramètres")>
    Public Property Parameters() As String

        Get
            If Parametres1 = True Then
                Dim explore1 As Integer = 0
                If ExploreMode = True Then
                    explore1 = 1
                Else
                    explore1 = 0
                End If
                Dim desk1 As Integer = 0
                If DeskMode = True Then
                    desk1 = 1
                Else
                    desk1 = 0
                End If




                Return "EXPLOREMODE:" + explore1.ToString + " " + "DESKTOPMODE:" + desk1.ToString()
            Else
                Return ""
            End If
        End Get
        Set(value As String)

            Param1 = value

        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Handle")>
    <Description("Numéro de handle parent. (Fenêtre)")>
    Public Overloads Property Handle() As String
        Get
            Return handle1
        End Get
        Set(value As String)

            handle1 = value


        End Set

    End Property
    <Category("Propriétés CPCDOS")>
    <DisplayName("Explore mode")>
    <Description("True : icones | False : liste")>
    Public Property _EXPLOREMODE As Boolean
        Get
            Return ExploreMode
        End Get
        Set(value As Boolean)
            ExploreMode = value
        End Set
    End Property

    <Category("Propriétés CPCDOS")>
    <DisplayName("Desk mode")>
    <Description("True : arrière plan | False : simple")>
    Public Property _DESKMODE As Boolean
        Get
            Return DeskMode
        End Get
        Set(value As Boolean)
            DeskMode = value
        End Set
    End Property



    <Category("Propriétés CPCDOS")>
    <DisplayName("Event")>
    <Description("Fichier évènementiel des interactions graphiques.")>
    Public Overloads Property _EVENT() As String

        Get
            Return Evant1
        End Get
        Set(value As String)
            Evant1 = value

        End Set

    End Property

    Sub New()

        TextBlockParameters = System.Boolean.FalseString
        DeskMode = System.Boolean.FalseString
        ExploreMode = System.Boolean.FalseString

        _EVENT = "%_exe_path_%"
        handle1 = "MyHandle"


    End Sub

End Class


