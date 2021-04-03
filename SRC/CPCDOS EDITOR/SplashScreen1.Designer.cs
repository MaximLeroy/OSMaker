using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace OSMaker
{
    [DesignerGenerated()]
    public partial class SplashScreen1 : Form
    {

        // Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
            Label4 = new Label();
            Label1 = new Label();
            Label2 = new Label();
            SuspendLayout();
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = SystemColors.ActiveCaption;
            Label4.Location = new Point(296, 208);
            Label4.Name = "Label4";
            Label4.Size = new Size(0, 24);
            Label4.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 48.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.Control;
            Label1.Location = new Point(29, 124);
            Label1.Name = "Label1";
            Label1.Size = new Size(541, 86);
            Label1.TabIndex = 9;
            Label1.Text = "OSMaker Beta 0.1";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 12.0f, FontStyle.Italic, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = SystemColors.Control;
            Label2.Location = new Point(235, 207);
            Label2.Name = "Label2";
            Label2.Size = new Size(128, 21);
            Label2.TabIndex = 10;
            Label2.Text = "For CPCDOS OSx";
            // 
            // SplashScreen1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(30)));
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(598, 335);
            ControlBox = false;
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SplashScreen1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += new EventHandler(SplashScreen1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label4;
        internal Label Label1;
        internal Label Label2;
    }
}