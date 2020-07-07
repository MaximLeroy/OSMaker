Namespace MyDesignerSurface
  Partial Class ucToolBox
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If Not disposing AndAlso (components Is Nothing) Then
        components.Dispose()
      End If
      MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
            Me.lstToolBox = New System.Windows.Forms.ListBox()
            Me.SuspendLayout()
            '
            'lstToolBox
            '
            Me.lstToolBox.BackColor = System.Drawing.SystemColors.Control
            Me.lstToolBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lstToolBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.lstToolBox.FormattingEnabled = True
            Me.lstToolBox.ItemHeight = 17
            Me.lstToolBox.Location = New System.Drawing.Point(0, 0)
            Me.lstToolBox.Name = "lstToolBox"
            Me.lstToolBox.Size = New System.Drawing.Size(259, 423)
            Me.lstToolBox.TabIndex = 2
            '
            'ucToolBox
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.lstToolBox)
            Me.Name = "ucToolBox"
            Me.Size = New System.Drawing.Size(259, 423)
            Me.ResumeLayout(False)

        End Sub

#End Region

    Private lstToolBox As System.Windows.Forms.ListBox
  End Class
End Namespace

