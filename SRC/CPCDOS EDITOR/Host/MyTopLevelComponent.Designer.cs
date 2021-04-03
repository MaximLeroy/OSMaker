using System.Diagnostics;

namespace OSMaker.Host
{
    partial class MyTopLevelComponent2 : System.ComponentModel.Component
    {
        [DebuggerNonUserCode()]
        public MyTopLevelComponent2(System.ComponentModel.IContainer container) : this()
        {

            // Requis pour la prise en charge du Concepteur de composition de classes Windows.Forms
            if (container is object)
            {
                container.Add(this);
            }
        }

        [DebuggerNonUserCode()]
        public MyTopLevelComponent2() : base()
        {

            // Cet appel est requis par le Concepteur de composants.
            InitializeComponent();
        }

        // Component remplace la méthode Dispose pour nettoyer la liste des composants.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requise par le Concepteur de composants
        private System.ComponentModel.IContainer components;

        // REMARQUE : la procédure suivante est requise par le Concepteur de composants
        // Elle peut être modifiée à l'aide du Concepteur de composants.
        // Ne la modifiez pas à l'aide de l'éditeur de code.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
    }
}