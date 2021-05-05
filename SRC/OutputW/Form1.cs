using OutputW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OutputW
{
    public partial class Form1 : ToolWindow
    {
        public static RichTextBox rtOutput;
        System.ComponentModel.ComponentResourceManager resources2 = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
            // rtOutput2
            // 
            rtOutput = new RichTextBox();
            rtOutput.BackColor = System.Drawing.Color.Black;
            rtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            rtOutput.ForeColor = System.Drawing.SystemColors.Info;
            rtOutput.Location = new System.Drawing.Point(0, 0);
            rtOutput.Margin = new System.Windows.Forms.Padding(4);
            rtOutput.Name = "rtOutput";
            rtOutput.ReadOnly = true;
            rtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            rtOutput.Size = new System.Drawing.Size(800, 450);
            rtOutput.TabIndex = 10;
            rtOutput.Text = "";
            this.Controls.Add(rtOutput);

        }
    }
}
