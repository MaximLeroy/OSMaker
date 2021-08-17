using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exporter.Controls
{
   
    public partial class UCButton : UserControl
        
    {
        private readonly CpcDosCPlusListeObjets objets;
        public static int TailleX = 0;
        public static int TailleY = 0;
        public static int PositionX = 0;
        public static int PositionY = 0;

        public static string Nom = null;
        public static string Btext = null;
        public static string Bevent = null;
        public static string Bopacite = null;
        public static string Bparameters = null;

        public static string CouleurFOND;
        public static string redB = "255";
        public static string greenB = "255";
        public static string blueB = "255";

        public static string CouleurFenetre;
        public static string redW = "255";
        public static string greenW = "255";
        public static string blueW = "255";

        public static string CouleurText;
        public static string redT = "000";
        public static string greenT = "000";
        public static string blueT = "000";
        public UCButton(CpcDosCPlusBouton button)
        {
            InitializeComponent();
            objets = new CpcDosCPlusListeObjets("fichier1.cpc");
            
            //TODO: Gérer proprement le binding bi-directionnel
             TailleX = int.Parse(button.SizeX);
             TailleY = int.Parse(button.SizeY);
            PositionX = int.Parse(button.Px);
            PositionY = int.Parse(button.Py);
            button1.Text = button.Text;
            button1.Width = TailleX;
            button1.Height = TailleY;
            Nom = button.ID;
            Btext = button.Text;
            Bevent = button.Event;
            Bopacite = button.Opacity;
            Bparameters = button.Parameters;
            FormCollection nbforms = Application.OpenForms;
            Button monbouton;
            monbouton = new Button();

         //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox
           // nbforms["preview"].Controls.Add(monbouton);
           
            monbouton.Location = new Point(int.Parse(button.Px), int.Parse(button.Py));
            monbouton.Size = new Size(TailleX, TailleY);
            monbouton.Text = button.Text;
          
            CouleurFOND = button.BackColor;
            CouleurText = button.TextColor;
            textBox1.Text = CouleurFOND;
            // FOND
            if (CouleurFOND == null)
            {

                CouleurFOND = "255,255,255";

            }
            else
            {
               
                
                    redB = CouleurFOND.Substring(0, 3);
                    greenB = CouleurFOND.Substring(4, 3);
                    blueB = CouleurFOND.Substring(8, 3);
                
            
                
            }
            //TEXT
            if (CouleurText == null)
            {

                CouleurText = "000,000,000";

            }
            else
            {
                redT = CouleurText.Substring(0, 3);
                greenT = CouleurText.Substring(4, 3);
                blueT = CouleurText.Substring(8, 3);
            }

            textBox2.Text = CouleurText;
            button1.BackColor = Color.FromArgb(int.Parse(redB), int.Parse(greenB), int.Parse(blueB));
            monbouton.BackColor = Color.FromArgb(int.Parse(redB), int.Parse(greenB), int.Parse(blueB));
            

            button1.ForeColor = Color.FromArgb(int.Parse(redT), int.Parse(greenT), int.Parse(blueT));
            monbouton.ForeColor = Color.FromArgb(int.Parse(redT), int.Parse(greenT), int.Parse(blueT));


        }

        private void UCButton_Load(object sender, EventArgs e)
           
        {
            
            foreach (CpcDosCPlusObjet objet in objets)
            {
                //comboBox1.Items.Add(objet);

            }
            
        }

   

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     

            ComboBox list = sender as ComboBox;

            if (list != null)
            {
                CpcDosCPlusObjet obj = list.SelectedItem as CpcDosCPlusObjet;

                if (list != null)
                {
                   // panel2.Controls.Add(obj.CreateUC());
                }
            }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton1.Style = MetroFramework.MetroColorStyle.Red;

            ToolBox.Button b1 = (ToolBox.Button)Exporter.formulaire.Form1.HostC.CreateControl(typeof(ToolBox.Button), new Size(TailleX, TailleY), new Point(PositionX, PositionY));
            b1.Text = Nom;
            b1.ForeColor = Color.Black;
            b1.BackColor = Color.FromArgb(int.Parse(redB), int.Parse(greenB), int.Parse(blueB));
            b1.ForeColor = Color.FromArgb(int.Parse(redT), int.Parse(greenT), int.Parse(blueT));
            b1.Name = Nom;
            b1.Text = Btext;
            b1._EVENT = Bevent;
            b1.ButtonParameters = bool.Parse(Bparameters);
            try { b1.OPACITE = int.Parse(Bopacite); }
            catch (System.ArgumentNullException f)
            {

            }
            //Exporter.formulaire.Form1.listBox2.Items.Add("Button " + Nom);
        }

      
    }
    }


