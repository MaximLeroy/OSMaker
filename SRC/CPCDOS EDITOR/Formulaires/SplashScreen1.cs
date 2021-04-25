using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OSMaker
{
    public sealed partial class SplashScreen1
    {
        Home _Home;
        public SplashScreen1()
        {
            InitializeComponent();
            

        }

        // TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
        // du Concepteur de projets ("Propriétés" sous le menu "Projet").

        public int timeLeft { get; set; }
        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            timeLeft = 30;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;

            }
            else
            {
                timer1.Stop();
                new Home().Show();
                this.Hide();
            }
        }
    }

        
}