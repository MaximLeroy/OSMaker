<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Toolbox
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.toolboxTitleButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'toolboxTitleButton
        '
        Me.toolboxTitleButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.toolboxTitleButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolboxTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.toolboxTitleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.toolboxTitleButton.Location = New System.Drawing.Point(0, 0)
        Me.toolboxTitleButton.Name = "toolboxTitleButton"
        Me.toolboxTitleButton.Size = New System.Drawing.Size(150, 20)
        Me.toolboxTitleButton.TabIndex = 2
        Me.toolboxTitleButton.Text = "Boîte à outils"
        Me.toolboxTitleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolboxTitleButton.UseVisualStyleBackColor = False
        '
        'Toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.toolboxTitleButton)
        Me.Name = "Toolbox"
        Me.Size = New System.Drawing.Size(150, 306)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents toolboxTitleButton As Windows.Forms.Button
End Class
