using System;

namespace OSMaker
{
    public sealed partial class SplashScreen1
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }

        // TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
        // du Concepteur de projets ("Propriétés" sous le menu "Projet").


        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            // Configurez le texte de la boîte de dialogue au moment de l'exécution en fonction des informations d'assembly de l'application.  

            // TODO: personnalisez les informations d'assembly de l'application dans le volet "Application" de la 
            // boîte de dialogue Propriétés du projet (sous le menu "Projet").

            // Titre de l'application
            if (!string.IsNullOrEmpty(My.MyProject.Application.Info.Title))
            {
            }
            else
            {
                // Si le titre de l'application est absent, utilisez le nom de l'application, sans l'extension

            }

            // Mettez en forme les informations de version à l'aide du texte défini dans le contrôle de version au moment du design en tant que
            // chaîne de mise en forme.  Ceci permet une localisation efficace si besoin est.
            // Les informations de génération et de révision peuvent être incluses en utilisant le code suivant et en remplaçant le 
            // texte du contrôle de version par "Version {0}.{1:00}.{2}.{3}" ou un équivalent.  Voir
            // String.Format() dans l'aide pour plus d'informations.
            // 
            // Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)



            // Informations de copyright

        }
    }
}