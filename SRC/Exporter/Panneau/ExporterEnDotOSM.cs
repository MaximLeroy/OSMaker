using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Exporter;
using Host;
using Loader;


namespace Exporter.formulaire
{
    public partial class Form1 : DocumentC
    {
        private readonly CpcDosCPlusListeObjets objets;
        public static Host.HostSurfaceManager _hostSurfaceManager;
        private int _formCount = 0;
        public static Host.HostControl HostC;
        public Form1()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Dpi;
            DockAreas = DockAreas.Document | DockAreas.Float;
            CustomInitialize();
            objets = new CpcDosCPlusListeObjets("fichier1.cpc");
     

            //textBox1.Text = objets.ToCPCDosCPlus();
        }
        private void CustomInitialize()
        {



            //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox

            _hostSurfaceManager = new Host.HostSurfaceManager();
           

        }
        public static ListBox list1 = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                _formCount += 1;
                HostC = _hostSurfaceManager.GetNewHost(typeof(Form), Host.LoaderType.BasicDesignerLoader);
                // AddTabForNewHost("Form" & _formCount.ToString() & " - " & Strings.Design)
                HostC.Parent = panel4;
                HostC.Dock = DockStyle.Fill;
            }
            catch
            {
                MessageBox.Show("Error in creating new host", "Shell Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (CpcDosCPlusObjet objet in objets)
            {
                listBox1.Items.Add(objet);
                //richTextBox1.Text = CpcDosCPlusObjet.mavariable;
            }
            foreach (CpcDosCPlusObjet objetfenetre in objets)
            {
                //comboBox1.Items.Add(objetfenetre);

            }
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.Controls.Clear();

            ComboBox list = sender as ComboBox;

            if (list != null)
            {
                CpcDosCPlusObjet obj = list.SelectedItem as CpcDosCPlusObjet;

                if (list != null)
                {
                    panel4.Controls.Add(obj.CreateUC());
                }
            }
        }
        Preview apercu = new Preview();
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            apercu.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            ListBox list = sender as ListBox;

            if (list != null)
            {
                CpcDosCPlusObjet obj = list.SelectedItem as CpcDosCPlusObjet;

                if (list != null)
                {
                    panel3.Controls.Add(obj.CreateUC());
                }
            }
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
