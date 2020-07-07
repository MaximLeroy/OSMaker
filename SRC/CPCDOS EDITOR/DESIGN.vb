Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports System.ComponentModel.Design.Serialization
Namespace MyDesignerSurface
    Public Class DESIGN















        Private Sub DESIGN_Load(sender As Object, e As EventArgs)


        End Sub

        Private Sub ButtonX14_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub DESIGN_MouseMove(sender As Object, e As MouseEventArgs)

        End Sub

        Private Sub DESIGN_Closed(sender As Object, e As EventArgs)


        End Sub

        Private WithEvents TableLayoutPanel1 As TableLayoutPanel
        Private WithEvents MenuStrip1 As MenuStrip
        Private WithEvents FichierToolStripMenuItem As ToolStripMenuItem
        Private WithEvents ChargerToolStripMenuItem As ToolStripMenuItem
        Private WithEvents SaveToolStripMenuItem As ToolStripMenuItem
        Private WithEvents PropEditor As PropertyGrid

        Private Sub InitializeComponent()
            TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            MenuStrip1 = New System.Windows.Forms.MenuStrip()
            FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            ChargerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            PropEditor = New System.Windows.Forms.PropertyGrid()
            TableLayoutPanel1.SuspendLayout()
            MenuStrip1.SuspendLayout()

            '
            'tableLayoutPanel1
            '
            TableLayoutPanel1.ColumnCount = 3
            TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
            TableLayoutPanel1.Controls.Add(MenuStrip1, 0, 0)
            TableLayoutPanel1.Controls.Add(PropEditor, 2, 1)
            TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            TableLayoutPanel1.Name = "tableLayoutPanel1"
            TableLayoutPanel1.RowCount = 2
            TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            TableLayoutPanel1.Size = New System.Drawing.Size(792, 517)
            TableLayoutPanel1.TabIndex = 3
            '
            'menuStrip1
            '
            TableLayoutPanel1.SetColumnSpan(MenuStrip1, 3)
            MenuStrip1.Location = New System.Drawing.Point(0, 0)
            MenuStrip1.Name = "menuStrip1"
            MenuStrip1.Size = New System.Drawing.Size(792, 20)
            MenuStrip1.TabIndex = 2
            MenuStrip1.Text = "menuStrip1"
            '
            'fichierToolStripMenuItem
            '
            FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {ChargerToolStripMenuItem, SaveToolStripMenuItem})
            FichierToolStripMenuItem.Name = "fichierToolStripMenuItem"
            FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 16)
            FichierToolStripMenuItem.Text = "Fichier"
            '
            'chargerToolStripMenuItem
            '
            ChargerToolStripMenuItem.Name = "chargerToolStripMenuItem"
            ChargerToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
            ChargerToolStripMenuItem.Text = "Charger"
            '
            'saveToolStripMenuItem
            '
            SaveToolStripMenuItem.Name = "saveToolStripMenuItem"
            SaveToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
            SaveToolStripMenuItem.Text = "Save"
            '
            'propEditor
            '
            PropEditor.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText
            PropEditor.Dock = System.Windows.Forms.DockStyle.Fill
            PropEditor.Location = New System.Drawing.Point(597, 23)
            PropEditor.Name = "propEditor"
            PropEditor.Size = New System.Drawing.Size(192, 491)
            PropEditor.TabIndex = 0
            '
            'DESIGN
            '

            TableLayoutPanel1.ResumeLayout(False)
            TableLayoutPanel1.PerformLayout()
            MenuStrip1.ResumeLayout(False)
            MenuStrip1.PerformLayout()


        End Sub
    End Class
End Namespace