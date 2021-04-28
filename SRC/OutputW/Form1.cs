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
        public static FastColoredTextBoxNS.FastColoredTextBox rtOutput2;
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
            rtOutput2 = new FastColoredTextBoxNS.FastColoredTextBox();
            rtOutput2.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            rtOutput2.AutoScrollMinSize = new System.Drawing.Size(52, 17);
            rtOutput2.BackBrush = null;
            rtOutput2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            rtOutput2.CharHeight = 17;
            rtOutput2.CharWidth = 8;
            rtOutput2.Cursor = System.Windows.Forms.Cursors.IBeam;
            rtOutput2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            rtOutput2.Dock = System.Windows.Forms.DockStyle.Fill;
            rtOutput2.Font = new System.Drawing.Font("Consolas", 9F);
            rtOutput2.ForeColor = System.Drawing.Color.Gainsboro;
            rtOutput2.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            rtOutput2.IsReplaceMode = false;
            rtOutput2.LeftPadding = 25;
            rtOutput2.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            rtOutput2.Location = new System.Drawing.Point(0, 0);
            rtOutput2.Margin = new System.Windows.Forms.Padding(4);
            rtOutput2.Name = "rtOutput";
            rtOutput2.Paddings = new System.Windows.Forms.Padding(0);
            rtOutput2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            rtOutput2.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources2.GetObject("rtOutput2.ServiceColors")));
            rtOutput2.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            rtOutput2.ShowScrollBars = false;
            rtOutput2.Size = new System.Drawing.Size(800, 450);
            rtOutput2.TabIndex = 9;
            rtOutput2.Zoom = 100;
            this.Controls.Add(rtOutput2);

        }
    }
}
