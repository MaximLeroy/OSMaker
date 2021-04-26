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
    
    public partial class UCFenetre : UserControl
    {
     
        public UCFenetre(CpcDosCPlusWindow mafenetre )
        {
            
            InitializeComponent();
            //TODO: Gérer proprement le binding bi-directionnel
            int TailleX = int.Parse(mafenetre.SizeX);
            int TailleY = int.Parse(mafenetre.SizeY);

            label1.Text = mafenetre.Title;
            panel4.Width = TailleX;
            panel4.Height = TailleY;
            panel2.Width = TailleX;
            Preview apercu = new Preview();
            apercu.Show();
            apercu.Width = TailleX;
            apercu.Height = TailleY;
            apercu.Text = mafenetre.Title;
            apercu.TopMost = true;
            propertyGrid1.SelectedObject = mafenetre;

            string CouleurFOND;
            string red = "255";
            string green = "255";
            string blue = "255";
            CouleurFOND = mafenetre.BackColor;
            
            if (CouleurFOND == null)
            {

                CouleurFOND = "255,255,255";

            }
            else

                red = CouleurFOND.Substring(0, 3);
            green = CouleurFOND.Substring(4, 3);
            blue = CouleurFOND.Substring(8, 3);



            panel4.BackColor = Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue));
            apercu.BackColor = Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue));


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
