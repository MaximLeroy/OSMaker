Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace ToolWindows
    ''' <summary>
    ''' OutputWindow.
    ''' </summary>
    Public Class OutputWindow
        Inherits UserControl

        Private label1 As Label
        Public RichTextBox As RichTextBox
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Public WithEvents RichTextBox1 As RichTextBox
        Friend WithEvents TabPage3 As TabPage
        Public WithEvents RichTextBox2 As RichTextBox
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As IContainer = Nothing

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            InitializeComponent()
        End Sub


        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then

                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub


#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
            Me.SuspendLayout()
            '
            'RichTextBox3
            '
            Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RichTextBox3.Location = New System.Drawing.Point(0, 0)
            Me.RichTextBox3.Name = "RichTextBox3"
            Me.RichTextBox3.Size = New System.Drawing.Size(726, 296)
            Me.RichTextBox3.TabIndex = 0
            Me.RichTextBox3.Text = ""
            '
            'OutputWindow
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.RichTextBox3)
            Me.Name = "OutputWindow"
            Me.Size = New System.Drawing.Size(726, 296)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private Sub label1_Click(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Friend WithEvents RichTextBox3 As RichTextBox

    End Class
End Namespace

