using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Exporter
{
  public  class CpcDosCPlusFenetre : CpcDosCPlusObjet
    {
        public CpcDosCPlusFenetre(string[] declaration) : base(declaration)
        {
        }

        public override string TypeObjet { get { return "fenetre"; } }

        public string Title
        {
            get
            {
                Attributes.TryGetValue(".title", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".title"))
                {
                    Attributes.Remove(".title");
                }
                else
                {
                    Attributes[".title"] = value;
                }
            }
        }
        public string Px
        {
            get
            {
                Attributes.TryGetValue(".px", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".px"))
                {
                    Attributes.Remove(".px");
                }
                else
                {
                    Attributes[".px"] = value;
                }
            }
        }
        public string Py
        {
            get
            {
                Attributes.TryGetValue(".py", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".py"))
                {
                    Attributes.Remove(".py");
                }
                else
                {
                    Attributes[".py"] = value;
                }
            }
        }
        public string SizeX
        {
            get
            {
                Attributes.TryGetValue(".sx", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".sx"))
                {
                    Attributes.Remove(".sx");
                }
                else
                {
                    Attributes[".sx"] = value;
                }
            }
        }
        public string SizeY
        {
            get
            {
                Attributes.TryGetValue(".sy", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".sy"))
                {
                    Attributes.Remove(".sy");
                }
                else
                {
                    Attributes[".sy"] = value;
                }
            }
        }
        public string Opacity
        {
            get
            {
                Attributes.TryGetValue(".Opacity", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Opacity"))
                {
                    Attributes.Remove(".Opacity");
                }
                else
                {
                    Attributes[".Opacity"] = value;
                }
            }
        }
        public string Parameters
        {
            get
            {
                Attributes.TryGetValue(".Parameters", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Parameters"))
                {
                    Attributes.Remove(".Parameters");
                }
                else
                {
                    Attributes[".Parameters"] = value;
                }
            }
        }
        public string WindowColor
        {
            get
            {
                Attributes.TryGetValue(".WindowColor", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".WindowColor"))
                {
                    Attributes.Remove(".WindowColor");
                }
                else
                {
                    Attributes[".WindowColor"] = value;
                }
            }
        }
        public string TitleColor
        {
            get
            {
                Attributes.TryGetValue(".TitleColor", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".TitleColor"))
                {
                    Attributes.Remove(".TitleColor");
                }
                else
                {
                    Attributes[".TitleColor"] = value;
                }
            }
        }
        public string BackColor
        {
            get
            {
                Attributes.TryGetValue(".BackColor", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".BackColor"))
                {
                    Attributes.Remove(".BackColor");
                }
                else
                {
                    Attributes[".BackColor"] = value;
                }
            }
        }
        public string Icon
        {
            get
            {
                Attributes.TryGetValue(".Icon", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Icon"))
                {
                    Attributes.Remove(".Icon");
                }
                else
                {
                    Attributes[".Icon"] = value;
                }
            }
        }
        public string TitleImg
        {
            get
            {
                Attributes.TryGetValue(".TitleImg", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".TitleImg"))
                {
                    Attributes.Remove(".TitleImg");
                }
                else
                {
                    Attributes[".TitleImg"] = value;
                }
            }
        }
        public string Event
        {
            get
            {
                Attributes.TryGetValue(".event", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".event"))
                {
                    Attributes.Remove(".event");
                }
                else
                {
                    Attributes[".event"] = value;
                }
            }
        }

        //public override UserControl CreateUC()
       // {
           // return new Controls.UCFenetre(this) as UserControl;
      //  }
    }
}
