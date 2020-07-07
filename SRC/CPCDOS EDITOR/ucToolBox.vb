Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Design
Imports System.ComponentModel.Design
Namespace MyDesignerSurface
  ''' <summary>
  ''' Réprésente la boite à outils (ne gère pas de catégories)
  ''' </summary>
  Public Class ucToolBox
    Inherits UserControl
    Implements IToolboxService
    Implements IToolboxUser
    Public Sub New()
      InitializeComponent()

      'Ajoute un item par défaut pour le pointeur
      Dim pointer As New ToolboxItem()
      pointer.DisplayName = "Pointer"
      AddToolboxItem(pointer)
    End Sub

    Private designHost As IDesignerHost

    Public Property DesignerHost() As IDesignerHost
      Get
        Return designHost
      End Get
      Set
        designHost = value
      End Set
    End Property

#Region "IToolboxService Members"

        Public Sub AddCreator(ByVal creator As ToolboxItemCreatorCallback, ByVal format As String, ByVal host As System.ComponentModel.Design.IDesignerHost) Implements IToolboxService.AddCreator
        End Sub

        Public Sub AddCreator(ByVal creator As ToolboxItemCreatorCallback, ByVal format As String) Implements IToolboxService.AddCreator
        End Sub

        Public Sub AddLinkedToolboxItem(ByVal toolboxItem As ToolboxItem, ByVal category As String, ByVal host As System.ComponentModel.Design.IDesignerHost) Implements IToolboxService.AddLinkedToolboxItem
        End Sub

        Public Sub AddLinkedToolboxItem(ByVal toolboxItem As ToolboxItem, ByVal host As System.ComponentModel.Design.IDesignerHost) Implements IToolboxService.AddLinkedToolboxItem
        End Sub

    ''' <summary>
    ''' ajoute un type dans la boite à outils
    ''' </summary>
    ''' <param name="type"></param>
        Public Sub AddToolboxItem(ByVal type As Type)
            Me.AddToolboxItem(New ToolboxItem(type))
        End Sub

    ''' <summary>
    ''' ajoute un item dans la boite à outils
    ''' </summary>
    ''' <param name="toolboxItem"></param>
    ''' <param name="category"></param>
        Public Sub AddToolboxItem(ByVal toolboxItem As ToolboxItem, ByVal category As String) Implements IToolboxService.AddToolboxItem
            lstToolBox.Items.Add(toolboxItem)
        End Sub

    ''' <summary>
    ''' Ajoute un item dans la boite à outils
    ''' </summary>
    ''' <param name="toolboxItem"></param>
        Public Sub AddToolboxItem(ByVal toolboxItem As ToolboxItem) Implements IToolboxService.AddToolboxItem
            lstToolBox.Items.Add(toolboxItem)
        End Sub

    ''' <summary>
    ''' ne gère pas les catégories
    ''' </summary>
        Public ReadOnly Property CategoryNames() As CategoryNameCollection Implements IToolboxService.CategoryNames
            Get
                Return Nothing
            End Get
        End Property

    ''' <summary>
    ''' Appelé quand la surface de Design effectue le drop de l'item sur sa surface
    ''' </summary>
    ''' <param name="serializedObject"></param>
    ''' <param name="host"></param>
    ''' <returns></returns>
        Public Function DeserializeToolboxItem(ByVal serializedObject As Object, ByVal host As System.ComponentModel.Design.IDesignerHost) As ToolboxItem Implements IToolboxService.DeserializeToolboxItem
            'récupère le ToolBoxItem
            Return DirectCast((DirectCast(serializedObject, DataObject)).GetData(GetType(ToolboxItem)), ToolboxItem)
        End Function

    ''' <summary>
    ''' Appelé quand la surface de Design effectue le drop de l'item sur sa surface
    ''' </summary>
    ''' <param name="serializedObject"></param>
    ''' <returns></returns>
        Public Function DeserializeToolboxItem(ByVal serializedObject As Object) As ToolboxItem Implements IToolboxService.DeserializeToolboxItem
            Return Me.DeserializeToolboxItem(serializedObject, Me.designHost)
        End Function

    ''' <summary>
    ''' Renvoie l'item sélectionné
    ''' </summary>
    ''' <param name="host"></param>
    ''' <returns></returns>
        Public Function GetSelectedToolboxItem(ByVal host As System.ComponentModel.Design.IDesignerHost) As ToolboxItem Implements IToolboxService.GetSelectedToolboxItem
            If lstToolBox.SelectedIndex > 0 Then
                Return DirectCast(lstToolBox.SelectedItem, ToolboxItem)
            Else
                Return Nothing
            End If
        End Function

    ''' <summary>
    ''' Renvoie l'item sélectionné
    ''' </summary>
    ''' <returns></returns>
        Public Function GetSelectedToolboxItem() As ToolboxItem Implements IToolboxService.GetSelectedToolboxItem
            Return Me.GetSelectedToolboxItem(Me.designHost)
        End Function

        Public Function GetToolboxItems(ByVal category As String, ByVal host As System.ComponentModel.Design.IDesignerHost) As ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Function GetToolboxItems(ByVal category As String) As ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Function GetToolboxItems(ByVal host As System.ComponentModel.Design.IDesignerHost) As ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Function GetToolboxItems() As ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Function IsSupported(ByVal serializedObject As Object, ByVal filterAttributes As System.Collections.ICollection) As Boolean Implements IToolboxService.IsSupported
            Return False
        End Function

        Public Function IsSupported(ByVal serializedObject As Object, ByVal host As System.ComponentModel.Design.IDesignerHost) As Boolean Implements IToolboxService.IsSupported
            Return False
        End Function

    ''' <summary>
    ''' indique si un objet est un item de boite à outils
    ''' </summary>
    ''' <param name="serializedObject"></param>
    ''' <param name="host"></param>
    ''' <returns></returns>
        Public Function IsToolboxItem(ByVal serializedObject As Object, ByVal host As System.ComponentModel.Design.IDesignerHost) As Boolean Implements IToolboxService.IsToolboxItem
            Return (DirectCast(serializedObject, DataObject)).GetDataPresent(GetType(ToolboxItem))
        End Function

    ''' <summary>
    ''' indique si un objet est un item de boite à outils
    ''' </summary>
    ''' <param name="serializedObject"></param>
    ''' <returns></returns>
        Public Function IsToolboxItem(ByVal serializedObject As Object) As Boolean Implements IToolboxService.IsToolboxItem
            Return Me.IsToolboxItem(serializedObject)
        End Function

        Public Overrides Sub Refresh() Implements IToolboxService.Refresh
            MyBase.Refresh()
        End Sub

        Public Sub RemoveCreator(ByVal format As String, ByVal host As System.ComponentModel.Design.IDesignerHost) Implements IToolboxService.RemoveCreator
        End Sub

        Public Sub RemoveCreator(ByVal format As String) Implements IToolboxService.RemoveCreator
        End Sub

    ''' <summary>
    ''' retire un item de la boite à outils
    ''' </summary>
    ''' <param name="toolboxItem"></param>
    ''' <param name="category"></param>
        Public Sub RemoveToolboxItem(ByVal toolboxItem As ToolboxItem, ByVal category As String) Implements IToolboxService.RemoveToolboxItem
            lstToolBox.Items.Remove(toolboxItem)
        End Sub

    ''' <summary>
    ''' retire un item de la boite à outils
    ''' </summary>
    ''' <param name="toolboxItem"></param>
        Public Sub RemoveToolboxItem(ByVal toolboxItem As ToolboxItem) Implements IToolboxService.RemoveToolboxItem
            Me.RemoveToolboxItem(toolboxItem)
        End Sub

    ''' <summary>
    ''' ne gère pas les catégories
    ''' </summary>
        Public Property SelectedCategory() As String Implements IToolboxService.SelectedCategory
            Get
                Return Nothing
            End Get
            Set(ByVal value As String)
            End Set
        End Property

    ''' <summary>
    ''' indique que l'item a été droppé sur la surface de Design
    ''' </summary>
        Public Sub SelectedToolboxItemUsed() Implements IToolboxService.SelectedToolboxItemUsed
            'sélectionne le pointeur
            lstToolBox.SelectedIndex = 0
        End Sub

    ''' <summary>
    ''' Appeler pour sérialiser un toolbox item pour initier le drag and drop
    ''' </summary>
    ''' <param name="toolboxItem"></param>
    ''' <returns></returns>
        Public Function SerializeToolboxItem(ByVal toolboxItem As ToolboxItem) As Object Implements IToolboxService.SerializeToolboxItem
            'renvoie le ToolBoxItem wrapper dans un dataobject pour le drag and drop
            Return New DataObject(toolboxItem)
        End Function

        Public Function SetCursor() As Boolean Implements IToolboxService.SetCursor
            Return False
        End Function

    ''' <summary>
    ''' Définit l'item sélectionné
    ''' </summary>
    ''' <param name="toolboxItem"></param>
        Public Sub SetSelectedToolboxItem(ByVal toolboxItem As ToolboxItem) Implements IToolboxService.SetSelectedToolboxItem
            lstToolBox.SelectedItem = toolboxItem
        End Sub

#End Region

        Private Sub lstToolBox_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lstToolBox.MouseDown
            'on ne drag pas le pointeur
            If lstToolBox.SelectedIndex > 0 Then
                'on commence le drag and drop de l'item sélectionné de la toolbox
                'le drag and drop en fait une copie
                lstToolBox.DoDragDrop(DirectCast(Me.SerializeToolboxItem(DirectCast(lstToolBox.SelectedItem, ToolboxItem)), DataObject), DragDropEffects.Copy)
            End If
        End Sub

#Region "IToolboxUser Members"

    ''' <summary>
    ''' on supporte tous nos items
    ''' </summary>
    ''' <param name="tool"></param>
    ''' <returns></returns>
        Public Function GetToolSupported(ByVal tool As ToolboxItem) As Boolean Implements IToolboxUser.GetToolSupported
            Return True
        End Function

    ''' <summary>
    ''' appelé pour indiquer que notre item de toolbox a été utilisé
    ''' </summary>
    ''' <param name="tool"></param>
        Public Sub ToolPicked(ByVal tool As ToolboxItem) Implements IToolboxUser.ToolPicked
            'on crée sur la surface de design (designHost)
            'le type de contrôle associé à l'item de toolbox
            Dim c As IComponent = Me.GetSelectedToolboxItem().CreateComponents(Me.designHost)(0)
        End Sub

#End Region

    ''' <summary>
    ''' gère l'affichage des cases de la toolbox
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="bounds"></param>
    ''' <param name="bg"></param>
    ''' <param name="fg"></param>
    Private Sub DrawBackground(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal bg As Color, ByVal fg As Color)
      Using bgBrush As Brush = New SolidBrush(bg)
        g.FillRectangle(bgBrush, bounds)
      End Using
      Using fgPen As New Pen(fg, 1F)
        g.DrawRectangle(fgPen, bounds)
      End Using
    End Sub

        Private Sub lstToolBox_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles lstToolBox.DrawItem
            'on dessine le fond en fonction de l'état
            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                'item sélectionné avec le focus
                If (e.State And DrawItemState.Focus) = DrawItemState.Focus Then
                    Me.DrawBackground(e.Graphics, e.Bounds, SystemColors.ControlDark, SystemColors.ControlDarkDark)
                Else
                    Me.DrawBackground(e.Graphics, e.Bounds, SystemColors.InactiveCaption, SystemColors.InactiveCaptionText)
                End If
            Else
                Me.DrawBackground(e.Graphics, e.Bounds, SystemColors.Control, SystemColors.Control)
            End If

            'on récupère l'item à dessiner
            Dim ti As ToolboxItem = DirectCast(lstToolBox.Items(e.Index), ToolboxItem)
            'si ce n'est pas le pointeur, on met l'icône juste à côté
            If ti.DisplayName <> "Pointer" Then
                e.Graphics.DrawImage(ti.Bitmap, New Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, e.Bounds.Height - 4, e.Bounds.Height - 4))
            End If

            'on dessine le nom du type de contrôle à côté
            e.Graphics.DrawString(ti.DisplayName, e.Font, Brushes.Black, e.Bounds.Left + e.Bounds.Height, e.Bounds.Top + 2)
        End Sub
  End Class
End Namespace

