using System;
using System.Drawing;
using System.Windows.Forms;

namespace OSMaker
{
    public partial class Objets
    {
        public Objets()
        {
            InitializeComponent();
            _ButtonX14.Name = "ButtonX14";
            _RibbonControl1.Name = "RibbonControl1";
        }

        private void RibbonControl1_Click(object sender, EventArgs e)
        {
        }

        private void Objets_Load(object sender, EventArgs e)
        {
        }

        private void Objets_MouseMove(object sender, MouseEventArgs e)
        {
            Opacity = 1.0d;
        }

        private void ButtonX14_Click(object sender, EventArgs e)
        {
            var bouton = new Button();
            bouton.Location = new Point(147, 121);
            bouton.Size = new Size(90, 100);
            bouton.Visible = true;
            My.MyProject.Forms.Fenetre.Controls.Add(bouton);
        }
    }
}