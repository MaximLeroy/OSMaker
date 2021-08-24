using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace OSMaker.Formulaires
{
    public partial class New_OS : MetroFramework.Forms.MetroForm
    {
        public New_OS()
        {
            InitializeComponent();
        }

        private void New_OS_Load(object sender, EventArgs e)
        {

        }

        private void metroButton15_Click(object sender, EventArgs e)
        {

            try
            {
                var dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Text = dlg.FileName;
                   
                }
            }
            catch
            {

            }
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            try
            {
                var dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    path = dlg.SelectedPath;
                    textBox1.Text = dlg.SelectedPath + "\\" + textBox2.Text;

                }
            }
            catch
            {

            }
        }
        public string path = "";
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = path + "\\" + textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
