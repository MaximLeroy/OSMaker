using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace OSMaker.Host
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    partial class HostControl2 : UserControl
    {
        public HostControl2()
        {
            InitializeComponent();
        }

        // UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
        [DebuggerNonUserCode()]
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
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // HostControl
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "HostControl";
            Size = new Size(230, 254);
            ResumeLayout(false);
        }
    }
}