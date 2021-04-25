Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing

Namespace ToolboxLibrary
    ''' <summary>
    ''' ToolboxUIManagerVS
    ''' </summary>
    Public Class ToolboxUIManagerVS
        Private m_toolbox As Toolbox
        Private pointer As Drawing.Design.ToolboxItem ' a "null" tool
        Private bouton As Drawing.Design.ToolboxItem ' a "null" tool
        Public Sub New(ByVal toolbox As Toolbox)
            m_toolbox = toolbox
            pointer = New Design.ToolboxItem()
            pointer.DisplayName = "<Pointer>"
            pointer.Bitmap = New Bitmap(16, 16)


        End Sub


        Private ReadOnly Property Toolbox As Toolbox
            Get
                Return m_toolbox
            End Get
        End Property

        Public Sub FillToolbox()
            CreateControls()
            ConfigureControls()
            UpdateToolboxItems(Toolbox.Tabs.Count - 1)
        End Sub

        Private Sub CreateControls()
            Toolbox.Controls.Clear()
            Toolbox.ToolsListBox = New ListBox()
            Toolbox.TabPageArray = New Button(Toolbox.Tabs.Count - 1) {}
        End Sub

        Private Sub ConfigureControls()
            Toolbox.SuspendLayout()

            For i = Toolbox.Tabs.Count - 1 To 0 Step -1
                ' 
                ' Tab Button
                ' 
                Dim button As Button = New Button()
                button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
                button.Dock = DockStyle.Top
                button.FlatStyle = FlatStyle.Popup
                button.Location = New Point(0, (i + 1) * 20)
                button.Name = Toolbox.Tabs(i).Name
                button.Size = New Size(Toolbox.Width, 20)
                button.TabIndex = i + 1
                button.Text = Toolbox.Tabs(i).Name
                button.TextAlign = ContentAlignment.MiddleLeft
                button.Tag = i
                AddHandler button.Click, New EventHandler(AddressOf button_Click)
                Toolbox.Controls.Add(button)
                Toolbox.TabPageArray(i) = button
            Next


            ' 
            ' toolboxTitleButton
            ' 
            'Dim toolboxTitleButton As Button = New Button()
            'toolboxTitleButton.BackColor = SystemColors.ActiveCaption
            ' toolboxTitleButton.Dock = DockStyle.Top
            ' toolboxTitleButton.FlatStyle = FlatStyle.Popup
            ' toolboxTitleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            'toolboxTitleButton.Location = New Point(0, 0)
            ' toolboxTitleButton.Name = "toolboxTitleButton"
            ' toolboxTitleButton.Size = New Size(Toolbox.Width, 20)
            ' toolboxTitleButton.TabIndex = 0
            ' toolboxTitleButton.Text = "Toolbox"
            ' toolboxTitleButton.TextAlign = ContentAlignment.MiddleLeft
            ' Toolbox.Controls.Add(toolboxTitleButton)

            ' 
            ' listBox
            ' 
            Dim listBox As ListBox = New ListBox()
            listBox.BorderStyle = BorderStyle.None
            listBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
            listBox.DrawMode = DrawMode.OwnerDrawFixed
            listBox.ItemHeight = 18
            listBox.ResetForeColor()
            listBox.Location = New Point(0, (Toolbox.Tabs.Count + 1) * 20)
            listBox.Name = "ToolsListBox"
            listBox.ForeColor = System.Drawing.Color.White
            listBox.Size = New Size(Toolbox.Width, Toolbox.Height - (Toolbox.Tabs.Count + 1) * 20)
            listBox.TabIndex = Toolbox.Tabs.Count + 1
            listBox.ForeColor = Color.White


            Toolbox.Controls.Add(listBox)
            UpdateToolboxItems(Toolbox.Tabs.Count - 1)
            Toolbox.ResumeLayout()
            Toolbox.ForeColor = System.Drawing.Color.White
            Toolbox.ToolsListBox.ForeColor = System.Drawing.Color.White
            Toolbox.ToolsListBox = listBox
            AddHandler Toolbox.SizeChanged, New EventHandler(AddressOf Toolbox_SizeChanged)
        End Sub

        Private Sub UpdateToolboxItems(ByVal tabIndex As Integer)

            Toolbox.ToolsListBox.Items.Clear()
            Toolbox.ToolsListBox.Items.Add(pointer)
            If Toolbox.Tabs.Count <= 0 Then Return
            Dim toolboxTab = Toolbox.Tabs(tabIndex)
            Dim toolboxItems = toolboxTab.ToolboxItems

            For Each toolboxItem As ToolboxItem In toolboxItems
                Dim type = toolboxItem.Type
                Dim tbi As Design.ToolboxItem = New Design.ToolboxItem(type)
                Dim tba As ToolboxBitmapAttribute = TryCast(TypeDescriptor.GetAttributes(type)(GetType(ToolboxBitmapAttribute)), ToolboxBitmapAttribute)

                If tba IsNot Nothing Then
                    tbi.Bitmap = CType(tba.GetImage(type), Bitmap)
                End If

                Toolbox.ToolsListBox.Items.Add(tbi)
            Next
        End Sub

        Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim button As Button = TryCast(sender, Button)
            If button Is Nothing Then Return
            Dim index As Integer = button.Tag

            If button.Dock = DockStyle.Top Then

                For i = index + 1 To Toolbox.TabPageArray.Length - 1
                    Toolbox.TabPageArray(i).Dock = DockStyle.Bottom
                Next
            Else

                For i = 0 To index
                    Toolbox.TabPageArray(i).Dock = DockStyle.Top
                Next
            End If

            Toolbox.ToolsListBox.Location = New Point(0, (index + 2) * 20)
            UpdateToolboxItems(index)
        End Sub

        Private Sub Toolbox_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Toolbox.ToolsListBox.Size = New Size(Toolbox.Width, Toolbox.Height - (Toolbox.Tabs.Count + 1) * 20)
        End Sub
    End Class ' class
End Namespace ' namespace


