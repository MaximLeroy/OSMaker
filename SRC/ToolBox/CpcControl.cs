using Microsoft.VisualBasic.CompilerServices;

namespace ToolBox
{
    public class CpcControl
    {
    }

    class TextBox : System.Windows.Forms.TextBox
    {
        private bool Col1;
        private int Imgauto1;
        private bool UPD1;
        private string handle1;
        private string Evant1;
        private string couleurfond1;
        private string couleurtexte1;
        private string Parametres1;

        public string Parameters
        {
            get
            {
                return Parametres1;
            }

            set
            {
                Parametres1 = value;
            }
        }

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

        public int IMGAUTO
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

        public TextBox()
        {
            Parameters = bool.FalseString;
            COL = Conversions.ToBoolean(bool.TrueString);
            IMGAUTO = 0;
            UPD1 = Conversions.ToBoolean(bool.TrueString);
            HANDLE = "MonHandle";
            EVENT_PATH = "";
            CouleurFond = "200,255,240";
            CouleurTexte = "250,100,100";
        }
    }

    class TextBlock : System.Windows.Forms.Label
    {
        private bool Col1;
        private int Imgauto1;
        private bool UPD1;
        private string handle1;
        private string Evant1;
        private string couleurfond1;
        private string couleurtexte1;
        private bool MULTILINES1;
        private string Parametres1;

        public string Parameters
        {
            get
            {
                return Parametres1;
            }

            set
            {
                Parametres1 = value;
            }
        }

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

        public bool MULTILINES
        {
            get
            {
                return MULTILINES1;
            }

            set
            {
                MULTILINES1 = value;
            }
        }

        public int IMGAUTO
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

        public TextBlock()
        {
            Col1 = Conversions.ToBoolean(bool.TrueString);
            Imgauto1 = Conversions.ToInteger("0");
            UPD1 = Conversions.ToBoolean(bool.TrueString);
            HANDLE = "MonHandle";
            EVENT_PATH = "";
            CouleurFond = "200,255,240";
            CouleurTexte = "250,100,100";
            MULTILINES = Conversions.ToBoolean(bool.FalseString);
            Parameters = "";
        }
    }

    class CheckBox : System.Windows.Forms.CheckBox
    {
        private bool Col1;
        private int Imgauto1;
        private bool UPD1;
        private string handle1;
        private string Evant1;
        private string couleurfond1;
        private string couleurtexte1;
        private string Parametres1;

        public string Parameters
        {
            get
            {
                return Parametres1;
            }

            set
            {
                Parametres1 = value;
            }
        }

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

        public int IMGAUTO
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

        public CheckBox()
        {
            COL = Conversions.ToBoolean(bool.TrueString);
            IMGAUTO = Conversions.ToInteger("2");
            UPD1 = Conversions.ToBoolean(bool.TrueString);
            HANDLE = "MonHandle";
            EVENT_PATH = "";
            CouleurFond = "255,255,240";
            CouleurTexte = "000,000,000";
            Parameters = "";
        }
    }

    class ProgressBar : System.Windows.Forms.ProgressBar
    {
        private int Imgauto1;
        private bool UPD1;
        private string handle1;
        private string Evant1;
        private string couleurfond1;
        private string couleurtexte1;
        private string valeur1;
        private string Parametres1;

        public string Parameters
        {
            get
            {
                return Parametres1;
            }

            set
            {
                Parametres1 = value;
            }
        }

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

        public new string VALEUR
        {
            get
            {
                return valeur1;
            }

            set
            {
                valeur1 = value;
            }
        }

        public int IMGAUTO
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

        public ProgressBar()
        {
            IMGAUTO = Conversions.ToInteger("2");
            UPD1 = Conversions.ToBoolean(bool.TrueString);
            HANDLE = "MonHandle";
            EVENT_PATH = "";
            CouleurFond = "200,255,240";
            CouleurTexte = "250,100,100";
            VALEUR = "0";
            Parameters = "";
        }
    }

    class PictureBox : System.Windows.Forms.PictureBox
    {
        private bool Col1;
        private int Imgauto1;
        private bool UPD1;
        private string handle1;
        private string Evant1;
        private string couleurfond1;
        private string couleurtexte1;
        private string image1;
        private int Opacite1;
        private string Parametres1;

        public string Parameters
        {
            get
            {
                return Parametres1;
            }

            set
            {
                Parametres1 = value;
            }
        }

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

        public new string IMAGE
        {
            get
            {
                return image1;
            }

            set
            {
                image1 = value;
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

        public int IMGAUTO
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

        public int OPACITE
        {
            get
            {
                return Opacite1;
            }

            set
            {
                Opacite1 = value;
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

        public PictureBox()
        {
            COL = Conversions.ToBoolean(bool.TrueString);
            IMGAUTO = 0;
            UPD1 = Conversions.ToBoolean(bool.TrueString);
            HANDLE = "MonHandle";
            EVENT_PATH = "";
            CouleurFond = "";
            CouleurTexte = "";
            IMAGE = "";
            OPACITE = 255;
            Parameters = "";
        }
    }

    class Button : System.Windows.Forms.Button
    {
        private bool Col1;
        private int Imgauto1;
        private bool UPD1;
        private string handle1;
        private string Evant1;
        private string couleurfond1;
        private string couleurtexte1;
        private int opacite1;
        private string image1;
        private string Parametres1;

        public string Parameters
        {
            get
            {
                return Parametres1;
            }

            set
            {
                Parametres1 = value;
            }
        }

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

        public new string IMAGE
        {
            get
            {
                return image1;
            }

            set
            {
                image1 = value;
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

        public int IMGAUTO
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

        public int OPACITE
        {
            get
            {
                return opacite1;
            }

            set
            {
                opacite1 = value;
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

        public Button()
        {
            COL = Conversions.ToBoolean(bool.TrueString);
            IMGAUTO = 0;
            UPD1 = Conversions.ToBoolean(bool.TrueString);
            HANDLE = "MonHandle";
            EVENT_PATH = "";
            CouleurFond = "";
            CouleurTexte = "";
            OPACITE = 255;
            IMAGE = "";
            Parameters = "";
        }
    }
}