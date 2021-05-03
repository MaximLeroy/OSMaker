Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Design

Namespace ToolboxLibrary
    ''' <summary>
    ''' Toolbox - it implements the IToolboxService to enable
    ''' dragging toolbox items onto the host
    ''' </summary>

    Public Class Toolbox
        Inherits UserControl
        Implements IToolboxService
        Private m_ToolboxTabCollection As ToolboxTabCollection = Nothing
        Private m_filePath As String = Nothing
        Private m_tabPageArray As Button() = Nothing
        Private selectedIndex As Int32 = 0
        Private m_designerHost As IDesignerHost = Nothing
        Private m_toolsListBox As ListBox = Nothing

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toolbox))
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.SuspendLayout()
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "pointeur.PNG")
            Me.ImageList1.Images.SetKeyName(1, "Button_16xBlack.png")
            Me.ImageList1.Images.SetKeyName(2, "CheckBoxChecked_16xBlack.png")
            Me.ImageList1.Images.SetKeyName(3, "TextBlock_16xBlack.png")
            Me.ImageList1.Images.SetKeyName(4, "TextBox_16xBlack.png")
            Me.ImageList1.Images.SetKeyName(5, "Image_16xBlack.png")
            Me.ImageList1.Images.SetKeyName(6, "ProgressBar_16xBlack.png")
            Me.ImageList1.Images.SetKeyName(7, "WindowsFormBlue_16x.png")
            '
            'Toolbox
            '
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.Name = "Toolbox"
            Me.Size = New System.Drawing.Size(153, 351)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Public Sub InitializeToolbox()
            Dim toolboxXmlManager As ToolboxXmlManager = New ToolboxXmlManager(Me)
            Tabs = toolboxXmlManager.PopulateToolboxInfo()
            Dim toolboxUIManagerVS As ToolboxUIManagerVS = New ToolboxUIManagerVS(Me)
            toolboxUIManagerVS.FillToolbox()
            AddEventHandlers()
            PrintToolbox()
        End Sub

        Public Property DesignerHost As IDesignerHost
            Set(ByVal value As IDesignerHost)
                m_designerHost = value
            End Set
            Get
                Return m_designerHost
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Tabs As ToolboxTabCollection
            Get
                Return m_ToolboxTabCollection
            End Get
            Set(ByVal value As ToolboxTabCollection)
                m_ToolboxTabCollection = value

            End Set
        End Property

        Private Sub PrintToolbox()
            Try

                For i = 0 To Tabs.Count - 1
                    Console.WriteLine(Tabs(i).Name)

                    For j = 0 To Tabs(i).ToolboxItems.Count - 1
                        Console.WriteLine(Microsoft.VisualBasic.Constants.vbTab & Tabs(CInt(i)).ToolboxItems(CInt(j)).Type.ToString())
                    Next

                    Console.WriteLine(" ")
                Next

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub

        Public Property FilePath As String
            Get
                Return m_filePath
            End Get
            Set(ByVal value As String)
                m_filePath = value
                InitializeToolbox()
            End Set
        End Property

        Friend Property TabPageArray As Button()
            Get
                Return m_tabPageArray
            End Get
            Set(ByVal value As Button())
                m_tabPageArray = value
            End Set
        End Property

        Friend Property ToolsListBox As ListBox

            Get
                Return m_toolsListBox

            End Get
            Set(ByVal value As ListBox)
                m_toolsListBox = value

            End Set
        End Property

        Private Sub AddEventHandlers()
            AddHandler ToolsListBox.KeyDown, New KeyEventHandler(AddressOf list_KeyDown)
            AddHandler ToolsListBox.MouseDown, New MouseEventHandler(AddressOf list_MouseDown)
            AddHandler ToolsListBox.DrawItem, New DrawItemEventHandler(AddressOf list_DrawItem)
        End Sub

        Private Sub list_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
            Try
                Dim lbSender As ListBox = TryCast(sender, ListBox)

                If lbSender Is Nothing Then Return


                ' If this tool is the currently selected tool, draw it with a highlight.
                If selectedIndex = e.Index Then
                    e.Graphics.FillRectangle(Brushes.LightSlateGray, e.Bounds)
                End If

                Dim tbi As Design.ToolboxItem = TryCast(lbSender.Items(e.Index), Design.ToolboxItem)
                Dim BitmapBounds As Rectangle = New Rectangle(e.Bounds.Location.X, e.Bounds.Location.Y + e.Bounds.Height / 2 - tbi.Bitmap.Height / 2, tbi.Bitmap.Width, tbi.Bitmap.Height)
                Dim StringBounds As Rectangle = New Rectangle(e.Bounds.Location.X + BitmapBounds.Width + 5, e.Bounds.Location.Y, e.Bounds.Width - BitmapBounds.Width, e.Bounds.Height)
                Dim format As StringFormat = New StringFormat()
                format.LineAlignment = StringAlignment.Center
                format.Alignment = StringAlignment.Near

                e.Graphics.DrawImage(ImageList1.Images(e.Index), BitmapBounds)
                'attention connerie

                e.Graphics.DrawString(tbi.DisplayName, New Font("Segoe UI", 11, FontStyle.Regular, GraphicsUnit.World), Brushes.White, StringBounds, format)
            Catch ex As Exception
                ex.ToString()
            End Try
        End Sub

        Private Sub list_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Try
                Dim lbSender As ListBox = TryCast(sender, ListBox)
                Dim lastSelectedBounds = lbSender.GetItemRectangle(0)

                Try
                    lastSelectedBounds = lbSender.GetItemRectangle(selectedIndex)
                Catch ex As Exception
                    ex.ToString()
                End Try

                selectedIndex = lbSender.IndexFromPoint(e.X, e.Y) ' change our selection
                lbSender.SelectedIndex = selectedIndex
                lbSender.Invalidate(lastSelectedBounds) ' clear highlight from last selection
                lbSender.Invalidate(lbSender.GetItemRectangle(selectedIndex)) ' highlight new one
                If selectedIndex <> 0 Then

                    If e.Clicks = 2 Then
                        Try
                        Catch ex As Exception
                            Dim idh = CType(DesignerHost.GetService(GetType(IDesignerHost)), IDesignerHost)
                            Dim tbu As IToolboxUser = TryCast(idh.GetDesigner(TryCast(idh.RootComponent, IComponent)), IToolboxUser)

                            If tbu IsNot Nothing Then
                                tbu.ToolPicked(CType(lbSender.Items(selectedIndex), Design.ToolboxItem))
                            End If

                        End Try
                    ElseIf e.Clicks < 2 Then
                        Dim tbi As Design.ToolboxItem = TryCast(lbSender.Items(selectedIndex), Design.ToolboxItem)
                        Dim tbs As IToolboxService = Me

                        ' The IToolboxService serializes ToolboxItems by packaging them in DataObjects.
                        Dim d As DataObject = TryCast(tbs.SerializeToolboxItem(tbi), DataObject)

                        Try
                            lbSender.DoDragDrop(d, DragDropEffects.Copy)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If

            Catch ex As Exception
                ex.ToString()
            End Try
        End Sub

        Private Sub list_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Try
                Dim lbSender As ListBox = TryCast(sender, ListBox)
                Dim lastSelectedBounds = lbSender.GetItemRectangle(0)

                Try
                    lastSelectedBounds = lbSender.GetItemRectangle(selectedIndex)
                Catch ex As Exception
                    ex.ToString()
                End Try

                Select Case e.KeyCode
                    Case Keys.Up

                        If selectedIndex > 0 Then
                            selectedIndex -= 1 ' change selection
                            lbSender.SelectedIndex = selectedIndex
                            lbSender.Invalidate(lastSelectedBounds) ' clear old highlight
                            lbSender.Invalidate(lbSender.GetItemRectangle(selectedIndex)) ' add new one
                        End If

                    Case Keys.Down

                        If selectedIndex + 1 < lbSender.Items.Count Then
                            selectedIndex += 1 ' change selection
                            lbSender.SelectedIndex = selectedIndex
                            lbSender.Invalidate(lastSelectedBounds) ' clear old highlight
                            lbSender.Invalidate(lbSender.GetItemRectangle(selectedIndex)) ' add new one
                        End If

                    Case Keys.Enter
                        If DesignerHost Is Nothing Then MessageBox.Show("idh Null")
                        Dim tbu As IToolboxUser = TryCast(DesignerHost.GetDesigner(TryCast(DesignerHost.RootComponent, IComponent)), IToolboxUser)

                        If tbu IsNot Nothing Then
                            ' Enter means place the tool with default location and default size.
                            tbu.ToolPicked(CType(lbSender.Items(selectedIndex), Design.ToolboxItem))
                            lbSender.Invalidate(lastSelectedBounds) ' clear old highlight
                            lbSender.Invalidate(lbSender.GetItemRectangle(selectedIndex)) ' add new one
                        End If

                    Case Else
                        Console.WriteLine("Error: Not able to add")
                        Exit Select
                End Select ' switch
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End Sub


#Region "IToolboxService Members"

        ' We only implement what is really essential for ToolboxService

        Public Function GetSelectedToolboxItem(ByVal host As IDesignerHost) As Drawing.Design.ToolboxItem Implements IToolboxService.GetSelectedToolboxItem
            Dim list = ToolsListBox
            Dim tbi = CType(list.Items(selectedIndex), Design.ToolboxItem)

            If Not Equals(tbi.DisplayName, "<Pointer>") Then
                Return tbi
            Else
                Return Nothing
            End If
        End Function

        Public Function GetSelectedToolboxItem() As Drawing.Design.ToolboxItem Implements IToolboxService.GetSelectedToolboxItem
            Return GetSelectedToolboxItem(Nothing)
        End Function

        Public Sub AddToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem, ByVal category As String) Implements IToolboxService.AddToolboxItem
        End Sub

        Public Sub AddToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem) Implements IToolboxService.AddToolboxItem
        End Sub

        Public Function IsToolboxItem(ByVal serializedObject As Object, ByVal host As IDesignerHost) As Boolean Implements IToolboxService.IsToolboxItem
            Return False
        End Function

        Public Function IsToolboxItem(ByVal serializedObject As Object) As Boolean Implements IToolboxService.IsToolboxItem
            Return False
        End Function

        Public Sub SetSelectedToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem) Implements IToolboxService.SetSelectedToolboxItem
        End Sub

        Public Sub SelectedToolboxItemUsed() Implements IToolboxService.SelectedToolboxItemUsed
            Dim list = ToolsListBox
            list.Invalidate(list.GetItemRectangle(selectedIndex))
            selectedIndex = 0
            list.SelectedIndex = 0

            list.Invalidate(list.GetItemRectangle(selectedIndex))
        End Sub

        Public ReadOnly Property CategoryNames As CategoryNameCollection Implements IToolboxService.CategoryNames
            Get
                Return Nothing
            End Get
        End Property

        Private Overloads Sub Refresh() Implements IToolboxService.Refresh
        End Sub

        Public Sub AddLinkedToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem, ByVal category As String, ByVal host As IDesignerHost) Implements IToolboxService.AddLinkedToolboxItem
        End Sub

        Public Sub AddLinkedToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem, ByVal host As IDesignerHost) Implements IToolboxService.AddLinkedToolboxItem
        End Sub

        Public Function IsSupported(ByVal serializedObject As Object, ByVal filterAttributes As ICollection) As Boolean Implements IToolboxService.IsSupported
            Return False
        End Function

        Public Function IsSupported(ByVal serializedObject As Object, ByVal host As IDesignerHost) As Boolean Implements IToolboxService.IsSupported
            Return False
        End Function

        Public Property SelectedCategory As String Implements IToolboxService.SelectedCategory
            Get
                Return Nothing
            End Get
            Set(ByVal value As String)
            End Set
        End Property

        Public Function DeserializeToolboxItem(ByVal serializedObject As Object, ByVal host As IDesignerHost) As Drawing.Design.ToolboxItem Implements IToolboxService.DeserializeToolboxItem
            Return CType(CType(serializedObject, DataObject).GetData(GetType(Design.ToolboxItem)), Design.ToolboxItem)
        End Function

        Public Function DeserializeToolboxItem(ByVal serializedObject As Object) As Drawing.Design.ToolboxItem Implements IToolboxService.DeserializeToolboxItem
            Return DeserializeToolboxItem(serializedObject, DesignerHost)
        End Function

        Public Function GetToolboxItems(ByVal category As String, ByVal host As IDesignerHost) As Drawing.Design.ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Function GetToolboxItems(ByVal category As String) As Drawing.Design.ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Function GetToolboxItems(ByVal host As IDesignerHost) As Drawing.Design.ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Function GetToolboxItems() As Drawing.Design.ToolboxItemCollection Implements IToolboxService.GetToolboxItems
            Return Nothing
        End Function

        Public Sub AddCreator(ByVal creator As ToolboxItemCreatorCallback, ByVal format As String, ByVal host As IDesignerHost) Implements IToolboxService.AddCreator
        End Sub

        Public Sub AddCreator(ByVal creator As ToolboxItemCreatorCallback, ByVal format As String) Implements IToolboxService.AddCreator
        End Sub

        Public Function SetCursor() As Boolean Implements IToolboxService.SetCursor
            Return False
        End Function

        Public Sub RemoveToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem, ByVal category As String) Implements IToolboxService.RemoveToolboxItem
        End Sub

        Public Sub RemoveToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem) Implements IToolboxService.RemoveToolboxItem
        End Sub

        Public Function SerializeToolboxItem(ByVal toolboxItem As Drawing.Design.ToolboxItem) As Object Implements IToolboxService.SerializeToolboxItem
            Return New DataObject(toolboxItem)
        End Function

        Public Sub RemoveCreator(ByVal format As String, ByVal host As IDesignerHost) Implements IToolboxService.RemoveCreator
        End Sub

        Public Sub RemoveCreator(ByVal format As String) Implements IToolboxService.RemoveCreator
        End Sub


#End Region

        Private Sub Toolbox_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub Toolbox_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private components As IContainer
        Friend WithEvents ImageList1 As ImageList
    End Class ' class
End Namespace ' namespace


