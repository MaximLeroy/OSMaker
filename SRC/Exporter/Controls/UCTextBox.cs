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
    public partial class UCTextBox : UserControl
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
        public UCTextBox(CpcDosCPlusTextBox textBox)
            {
                InitializeComponent();
                objets = new CpcDosCPlusListeObjets("fichier1.cpc");

            //TODO: Gérer proprement le binding bi-directionnel
            TailleX = int.Parse(textBox.SizeX);
            TailleY = int.Parse(textBox.SizeY);
            PositionX = int.Parse(textBox.Px);
            PositionY = int.Parse(textBox.Py);
            textBox.Text = textBox.Text;
            textBox3.Width = TailleX;
            textBox3.Height = TailleY;
            Nom = textBox.ID;
            Btext = textBox.Text;
            Bevent = textBox.Event;
            Bopacite = textBox.Opacity;
            Bparameters = textBox.Parameters;
          

            //on pourra choisir sur quelle forme ajouter en modifiant avec un textbox
            // nbforms["preview"].Controls.Add(monbouton);

          

            CouleurFOND = textBox.BackColor;
            CouleurText = textBox.TextColor;
            textBox1.Text = CouleurFOND;
            // FOND
            if (CouleurFOND == null)
            {

                CouleurFOND = "255,255,255";

            }
            else if (CouleurFOND == "")
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
            else if (CouleurText == "")
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
            textBox3.BackColor = Color.FromArgb(int.Parse(redB), int.Parse(greenB), int.Parse(blueB));
           


            textBox3.ForeColor = Color.FromArgb(int.Parse(redT), int.Parse(greenT), int.Parse(blueT));
         





        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroButton1.Style = MetroFramework.MetroColorStyle.Red;

            ToolBox.TextBox t1 = (ToolBox.TextBox)Exporter.formulaire.Form1.HostC.CreateControl(typeof(ToolBox.TextBox), new Size(TailleX, TailleY), new Point(PositionX, PositionY));
            t1.Text = Nom;
            t1.ForeColor = Color.Black;
            t1.BackColor = Color.FromArgb(int.Parse(redB), int.Parse(greenB), int.Parse(blueB));
            t1.ForeColor = Color.FromArgb(int.Parse(redT), int.Parse(greenT), int.Parse(blueT));
            t1.Name = Nom;
            t1.Text = Btext;
            t1._EVENT = Bevent;
            t1.TextBoxParameters = bool.Parse(Bparameters);
            t1.Multiline = true;
            try { t1.OPACITE = int.Parse(Bopacite); }
            catch (System.ArgumentNullException f)
            {

            }
            Exporter.formulaire.Form1.listBox2.Items.Add("TextBox " + Nom);
        }
    }
}
