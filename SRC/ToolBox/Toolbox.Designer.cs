
namespace ToolBox
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    partial class Toolbox : System.Windows.Forms.UserControl
    {
        public Toolbox()
        {
            InitializeComponent();
        }

        // UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requise par le Concepteur Windows Form
        private System.ComponentModel.IContainer components;

        // REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        // Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        // Ne la modifiez pas à l'aide de l'éditeur de code.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            toolboxTitleButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // toolboxTitleButton
            // 
            toolboxTitleButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            toolboxTitleButton.Dock = System.Windows.Forms.DockStyle.Top;
            toolboxTitleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            toolboxTitleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            toolboxTitleButton.Location = new System.Drawing.Point(0, 0);
            toolboxTitleButton.Name = "toolboxTitleButton";
            toolboxTitleButton.Size = new System.Drawing.Size(150, 20);
            toolboxTitleButton.TabIndex = 2;
            toolboxTitleButton.Text = "Boîte à outils";
            toolboxTitleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            toolboxTitleButton.UseVisualStyleBackColor = false;
            // 
            // Toolbox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(toolboxTitleButton);
            Name = "Toolbox";
            Size = new System.Drawing.Size(150, 306);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button toolboxTitleButton;
    }
}