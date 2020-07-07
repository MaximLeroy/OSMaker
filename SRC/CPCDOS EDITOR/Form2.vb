Imports System
Imports System.Drawing
Imports System.Drawing.Design
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Windows.Forms
Imports System.IO
Imports ToolWindows
Imports DevComponents.DotNetBar
Public Class Form2
    Private path = "E:/"

    Private Sub LoadDirectory(ByVal dir As String)
        ProgressBarX1.Value = 25
        ButtonItem16.Text = "Load Directory étape 1/4"
        Dim di As DirectoryInfo = New DirectoryInfo(dir)
        Dim newNode = tv.Nodes.Add(di.Name)
        newNode.Tag = di.FullName
        newNode.StateImageIndex = 0
        ProgressBarX1.Value = 50
        ButtonItem16.Text = "Load Directory étape 2/4"
        LoadFiles(dir, newNode)
        ButtonItem16.Text = "Load Directory étape 3/4"
        ProgressBarX1.Value = 75
        LoadSubDirectories(dir, newNode)
        ButtonItem16.Text = "Load Directory étape 4/4"
        ProgressBarX1.Value = 100
        ButtonItem16.Text = "Prêt"
    End Sub

    Private Sub LoadSubDirectories(ByVal dir As String, ByVal node As TreeNode)
        Dim subdirectoryEntries = Directory.GetDirectories(dir)
        ' Loop through them to see if they have any other subdirectories  
        For Each subdirectory In subdirectoryEntries
            Dim di As DirectoryInfo = New DirectoryInfo(subdirectory)
            Dim newNnode = node.Nodes.Add(di.Name)
            newNnode.StateImageIndex = 0

            newNnode.Tag = di.FullName
            LoadFiles(subdirectory, newNnode)
            LoadSubDirectories(subdirectory, newNnode)
        Next
    End Sub

    Private Sub LoadFiles(ByVal dir As String, ByVal td As TreeNode)
        Dim CPCfiles = Directory.GetFiles(dir, "*.cpc")
        Dim TXTfiles = Directory.GetFiles(dir, "*.xml")

        ' Loop through them to see files  
        For Each CPCfile In CPCfiles
            Dim fi As FileInfo = New FileInfo(CPCfile)
            Dim tnode = td.Nodes.Add(fi.Name)
            tnode.Tag = fi.FullName
            tnode.StateImageIndex = 1
        Next
        For Each TXTfile In TXTfiles
            Dim fi As FileInfo = New FileInfo(TXTfile)
            Dim tnode = td.Nodes.Add(fi.Name)
            tnode.Tag = fi.FullName
            tnode.StateImageIndex = 4

        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tv.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))

        '  If Not Equals(path, "") AndAlso Directory.Exists(path.ToString) Then LoadDirectory(path.ToString)



    End Sub




    Private mySelectedNode As TreeNode = Nothing
    Private Sub tv_MouseDown(sender As Object, e As MouseEventArgs)
        mySelectedNode = tv.GetNodeAt(e.X, e.Y)
    End Sub

    Private Sub tv_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tv.BeforeExpand
        e.Node.StateImageIndex = 3
    End Sub

    Private Sub tv_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles tv.AfterExpand

    End Sub

    Private Sub tv_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs) Handles tv.BeforeCollapse
        e.Node.StateImageIndex = 0
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim dlg As FolderBrowserDialog = New FolderBrowserDialog()

        If dlg.ShowDialog() = DialogResult.OK Then
            txtDirectory.Text = dlg.SelectedPath
            tv.Nodes.Clear()
            LoadDirectory(txtDirectory.Text)
        End If
    End Sub
    Private Sub RenameItem(ByVal node As TreeNode, ByVal newLabel As String)
        Dim oldPathDir = CStr(node.Tag)

        If oldPathDir.Contains("txt") OrElse oldPathDir.Contains("xml") OrElse oldPathDir.Contains("cpc") Then ' it is a fileInfo
            Dim srcFi As FileInfo = New FileInfo(oldPathDir)
            Dim srcDircName = srcFi.FullName
            Dim index = srcDircName.LastIndexOf("\"c)
            Dim partDirName = srcDircName.Remove(index)
            Dim dstDirName = partDirName & "\\" & newLabel

            If Not srcDircName.Equals(dstDirName) Then
                Directory.Move(srcDircName, dstDirName) ' move source to destination 
                tv.Nodes.Clear()
                LoadDirectory(txtDirectory.Text)

                'CODE A VIRER
                'srcFi.MoveTo(dstFileName);

                'srcFi.Delete();

            End If ' it is a directorinfo
        Else
            Dim srcDir As DirectoryInfo = New DirectoryInfo(oldPathDir)
            Dim srcDirName = srcDir.FullName
            Dim index = srcDirName.LastIndexOf("\"c)
            Dim partDirName = srcDirName.Remove(index)
            Dim dstDirName = partDirName & "\\" & newLabel

            If Not srcDirName.Equals(dstDirName) Then
                Directory.Move(srcDirName, dstDirName) ' move source to destination 
                tv.Nodes.Clear()
                LoadDirectory(txtDirectory.Text)

                'CODE A VIRER

                'srcDir.MoveTo(dstDirName);

                'srcDir.Delete(true);
            End If
        End If
    End Sub

    Private Sub tv_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles tv.AfterLabelEdit
        If Not Equals(e.Label, Nothing) Then
            If e.Label.Length > 0 Then
                If e.Label.IndexOfAny(New Char() {"@"c, "\"c, ","c, "!"c}) = -1 Then
                    ' Stop editing without canceling the label change.
                    RenameItem(e.Node, e.Label)
                    e.Node.EndEdit(False)
                Else
                    ' Cancel the label edit action, inform the user, and 
                    ' place the node in edit mode again. 
                    e.CancelEdit = True
                    MessageBox.Show("Invalid tree node label." & Microsoft.VisualBasic.Constants.vbLf & "The invalid characters are: '@','.', ',', '!'", "Node Label Edit")
                    e.Node.BeginEdit()
                End If
            Else
                ' Cancel the label edit action, inform the user, and 
                ' place the node in edit mode again. 
                e.CancelEdit = True
                MessageBox.Show("Invalid tree node label." & Microsoft.VisualBasic.Constants.vbLf & "The label cannot be blank", "Node Label Edit")
                e.Node.BeginEdit()
            End If

            tv.LabelEdit = False
        End If
    End Sub

    Private Sub ButtonItem19_Click(sender As Object, e As EventArgs) Handles ButtonItem19.Click
        If mySelectedNode IsNot Nothing AndAlso mySelectedNode.Parent IsNot Nothing Then
            tv.SelectedNode = mySelectedNode
            tv.LabelEdit = True

            If Not mySelectedNode.IsEditing Then
                mySelectedNode.BeginEdit()
            End If
        Else
            MessageBox.Show("No tree node selected or selected node is a root node." & Microsoft.VisualBasic.Constants.vbLf & "Editing of root nodes is not allowed.", "Invalid selection")
        End If
    End Sub

    Private Function GetNewFolderName(ByVal di As DirectoryInfo) As String



        ' it is a fileInfo
        Dim newFolder = "Nouveau Dossier"
            Dim subdirs = Directory.GetDirectories(di.FullName, newFolder & "*")
            Dim dirName = di.FullName & "\\" & newFolder
            Dim countDir = 0

            If subdirs.Length = 0 Then
                countDir = 1
            Else
                countDir = subdirs.Length + 1
            End If

            dirName += countDir.ToString()
            Dim newDir As DirectoryInfo = New DirectoryInfo(dirName)

            'Create a  directory
            newDir.Create()
            newFolder += countDir.ToString()
            Return newFolder

    End Function

    Private Sub ButtonItem23_Click(sender As Object, e As EventArgs) Handles ButtonItem23.Click
        Dim node As TreeNode = tv.SelectedNode
        Dim oldPathDir = node.Text
        If oldPathDir.ToLower.Contains(".txt") OrElse oldPathDir.ToLower.Contains(".xml") OrElse oldPathDir.ToLower.Contains(".cpc") Then
            MessageBox.Show("Veuillez sélectionner un dossier et non un fichier")
        Else
            If tv.SelectedNode Is Nothing Then Return
            Dim selNode = tv.SelectedNode
            Dim pathDir = CStr(selNode.Tag)
            Dim di As DirectoryInfo = New DirectoryInfo(pathDir)

            ' add subdirectory to  di
            Dim newDirectoryName = GetNewFolderName(di)

            ' Adds new node as a child node of the currently selected node.
            Dim newNode As TreeNode = New TreeNode(newDirectoryName)
            newNode.Tag = di.FullName & "\\" & newDirectoryName
            newNode.ImageKey = "NewFolder"
            newNode.StateImageIndex = 0
            selNode.Nodes.Add(newNode)
        End If
    End Sub

    Private Sub tv_MouseDown_1(sender As Object, e As MouseEventArgs) Handles tv.MouseDown
        mySelectedNode = tv.GetNodeAt(e.X, e.Y)
    End Sub

    Private Sub ButtonItem21_Click(sender As Object, e As EventArgs) Handles ButtonItem21.Click
        Dim node As TreeNode = tv.SelectedNode
        Dim oldPathDir = node.Text
        If oldPathDir.ToLower.Contains(".txt") OrElse oldPathDir.ToLower.Contains(".xml") OrElse oldPathDir.ToLower.Contains(".cpc") Then
            MessageBox.Show("Veuillez sélectionner un dossier et non un fichier")
        Else
            If tv.SelectedNode Is Nothing Then Return
            Dim pathDir = CStr(tv.SelectedNode.Tag)
            Dim di As DirectoryInfo = New DirectoryInfo(pathDir)

            ' add file to  di
            Dim newFileName = GetNewFileNameCPC(di)

            ' Adds new node as a child node of the currently selected node.
            Dim newNode As TreeNode = New TreeNode(newFileName)
            newNode.Tag = di.FullName & "\\" & newFileName
            newNode.ImageKey = "NewFile"
            tv.SelectedNode.Nodes.Add(newNode)
            tv.SelectedNode = newNode
            Dim nouveaunoeud As TreeNode = tv.SelectedNode
            ' Create new document and add it to existing bar
            Dim dockItem As DevComponents.DotNetBar.DockContainerItem = New DevComponents.DotNetBar.DockContainerItem()
            dockItem.Text = nouveaunoeud.Text

            ' Add control to it
            Dim t As OSMCodeBox = New OSMCodeBox()


            ' PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
            ' document tab appears bold
            Dim panel As New DevComponents.DotNetBar.PanelDockContainer()
            panel.Controls.Add(t)
            t.Dock = DockStyle.Fill
            dockItem.Control = panel
            t.LabelItem1.Text = pathDir & "\" & newFileName
            Bar6.Items.Add(dockItem)
            Bar6.SelectedDockContainerItem = dockItem
        End If
    End Sub
    Private Function GetNewFileNameCPC(ByVal di As DirectoryInfo) As String
        Dim newItem = "Class"
        Dim files = Directory.GetFiles(di.FullName, "*.cpc")
        Dim fileName = di.FullName & "\" & newItem
        Dim countFile = 0

        If files.Length = 0 Then
            countFile = 1
        Else
            countFile = files.Length + 1
        End If

        fileName += countFile.ToString() & ".cpc"
        Dim fi As FileInfo = New FileInfo(fileName)

        'Create a file .
        Using sw As StreamWriter = fi.CreateText()
            sw.WriteLine(newItem)
            sw.WriteLine("Hello")
            sw.WriteLine("And")
            sw.WriteLine("Welcome")
        End Using

        newItem += countFile.ToString() & ".cpc"
        Return newItem
    End Function
    Private Function GetNewFileNameXML(ByVal di As DirectoryInfo) As String
        Dim newItem = "IUG"
        ' Dim files = Directory.GetFiles(di.FullName, "*.xml")
        ' Dim fileName = di.FullName & "\" & newItem
        ' Dim countFile = 0

        ' If files.Length = 0 Then
        ' 'countFile = 1
        ' Else
        '     countFile = files.Length + 1
        '  End If

        ' fileName += countFile.ToString() & ".xml"
        'Dim fi As FileInfo = New FileInfo(fileName)

        'Create a file .
        '  Using sw As StreamWriter = fi.CreateText()
        'sw.WriteLine(newItem)
        'sw.WriteLine("Save please")

        ' End Using

        ' newItem += countFile.ToString() & ".xml"
        Return newItem
    End Function
    Private Sub ButtonItem24_Click(sender As Object, e As EventArgs) Handles ButtonItem24.Click
        If tv.SelectedNode Is Nothing Then Return
        Dim selNode = tv.SelectedNode
        Dim pathDir = CStr(selNode.Tag)

        If pathDir.ToLower.Contains("cpc") OrElse pathDir.ToLower.Contains("xml") Then


            Dim fi As FileInfo = New FileInfo(pathDir)
            fi.Delete()
        Else
            Dim di As DirectoryInfo = New DirectoryInfo(pathDir)
            di.Delete(True)
        End If

        ' Removes currently selected node
        tv.Nodes.Remove(selNode)
    End Sub

    Private Sub ButtonItem18_Click(sender As Object, e As EventArgs) Handles ButtonItem18.Click
        If tv.SelectedNode Is Nothing Then Return
        Dim selNode = tv.SelectedNode

        If selNode.Text.EndsWith("cpc") OrElse selNode.Text.EndsWith("CPC") Then
            Dim pathDir = CStr(selNode.Tag)
            Dim fi As FileInfo = New FileInfo(pathDir)

            ' edit file
            Using sr As StreamReader = New StreamReader(fi.FullName)
                Dim dockItem As DevComponents.DotNetBar.DockContainerItem = New DevComponents.DotNetBar.DockContainerItem()
                dockItem.Text = selNode.Text

                ' Add control to it
                Dim t As OSMCodeBox = New OSMCodeBox()


                ' PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                ' document tab appears bold
                Dim panel As New DevComponents.DotNetBar.PanelDockContainer()
                panel.Controls.Add(t)
                t.Dock = DockStyle.Fill
                dockItem.Control = panel

                Bar6.Items.Add(dockItem)
                t.tb.Text = sr.ReadToEnd()
                t.LabelItem1.Text = fi.FullName
                Bar6.SelectedDockContainerItem = dockItem



            End Using
        End If

        If selNode.Text.EndsWith("xml") OrElse selNode.Text.EndsWith("XML") Then
            Dim pathDir = CStr(selNode.Tag)
            Dim fi As FileInfo = New FileInfo(pathDir)

            ' edit file
            Using sr As StreamReader = New StreamReader(fi.FullName)
                Dim dockItem As DevComponents.DotNetBar.DockContainerItem = New DevComponents.DotNetBar.DockContainerItem()
                dockItem.Text = selNode.Text

                ' Add control to it
                Dim t As EditeurCCplus = New EditeurCCplus()


                ' PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
                ' document tab appears bold
                Dim panel As New DevComponents.DotNetBar.PanelDockContainer()
                panel.Controls.Add(t)
                t.Dock = DockStyle.Fill
                dockItem.Control = panel

                Bar6.Items.Add(dockItem)
                t.tb.Text = sr.ReadToEnd()
                t.TextBoxX2.Text = fi.FullName
                Bar6.SelectedDockContainerItem = dockItem



            End Using
        End If
    End Sub

    Private Sub Bar2_ItemClick(sender As Object, e As EventArgs) Handles Bar2.ItemClick

    End Sub

    Private Sub ButtonItem22_Click(sender As Object, e As EventArgs) Handles ButtonItem22.Click
        Dim node As TreeNode = tv.SelectedNode
        Dim oldPathDir = node.Text
        If oldPathDir.ToLower.Contains(".txt") OrElse oldPathDir.ToLower.Contains(".xml") OrElse oldPathDir.ToLower.Contains(".cpc") Then
            MessageBox.Show("Veuillez sélectionner un dossier et non un fichier")
        Else
            If tv.SelectedNode Is Nothing Then Return
            Dim pathDir = CStr(tv.SelectedNode.Tag)
            Dim di As DirectoryInfo = New DirectoryInfo(pathDir)

            ' add file to  di
            Dim newFileName = GetNewFileNameXML(di)

            ' Adds new node as a child node of the currently selected node.
            Dim newNode As TreeNode = New TreeNode(newFileName)
            newNode.Tag = di.FullName & "\\" & newFileName
            newNode.ImageKey = "NewFile"
            tv.SelectedNode.Nodes.Add(newNode)
            tv.SelectedNode = newNode
            Dim nouveaunoeud As TreeNode = tv.SelectedNode
            ' Create new document and add it to existing bar
            Dim dockItem As DevComponents.DotNetBar.DockContainerItem = New DevComponents.DotNetBar.DockContainerItem()
            dockItem.Text = nouveaunoeud.Text

            ' Add control to it
            Dim t As EditeurCCplus = New EditeurCCplus()


            ' PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
            ' document tab appears bold
            Dim panel As New DevComponents.DotNetBar.PanelDockContainer()
            panel.Controls.Add(t)
            t.Dock = DockStyle.Fill
            dockItem.Control = panel
            t.TextBoxX2.Text = pathDir & "\" & newFileName
            Bar6.Items.Add(dockItem)
            Bar6.SelectedDockContainerItem = dockItem
        End If
    End Sub


End Class