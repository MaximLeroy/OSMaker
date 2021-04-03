using Microsoft.VisualBasic.CompilerServices;

namespace ToolBox
{
    public class CpcForm : System.Windows.Forms.Form
    {
        private bool Col1;
        private bool Imgauto1;
        private bool UPD1;
        private string handle1;
        private string Evant1;
        private string couleurfond1;
        private string couleurtexte1;

        public new string HANDLE
        {
            get
            {
                return handle1;
            }

            set
            {
                handle1 = value;
            }
        }

        public bool COL
        {
            get
            {
                return Col1;
            }

            set
            {
                Col1 = value;
            }
        }

        public bool IMGAUTO
        {
            get
            {
                return Imgauto1;
            }

            set
            {
                Imgauto1 = value;
            }
        }

        public bool UPD
        {
            get
            {
                return UPD1;
            }

            set
            {
                UPD1 = value;
            }
        }

        public new string EVENT_PATH
        {
            get
            {
                return Evant1;
            }

            set
            {
                Evant1 = value;
            }
        }

        public string CouleurFond
        {
            get
            {
                return couleurfond1;
            }

            set
            {
                couleurfond1 = value;
            }
        }

        public string CouleurTexte
        {
            get
            {
                return couleurtexte1;
            }

            set
            {
                couleurtexte1 = value;
            }
        }

        public CpcForm()
        {
            Col1 = Conversions.ToBoolean(bool.TrueString);
            Imgauto1 = Conversions.ToBoolean(bool.FalseString);
            UPD1 = Conversions.ToBoolean(bool.TrueString);
            HANDLE = "MonHandle";
            EVENT_PATH = "";
            CouleurFond = "200,255,240";
            CouleurTexte = "250,100,100";
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // CpcForm
            // 
            ClientSize = new System.Drawing.Size(284, 262);
            Name = "CpcForm";
            ResumeLayout(false);
        }
    }
}