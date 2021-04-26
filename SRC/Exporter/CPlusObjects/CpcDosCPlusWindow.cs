using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;
namespace Exporter
{
    public class CpcDosCPlusWindow : CpcDosCPlusObjet
    {
        public CpcDosCPlusWindow(string[] declaration) : base(declaration)
        {
        }

        public override string TypeObjet { get { return "window"; } }

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
                Attributes.TryGetValue(".opacity", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".opacity"))
                {
                    Attributes.Remove(".opacity");
                }
                else
                {
                    Attributes[".opacity"] = value;
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
                Attributes.TryGetValue(".windowColor", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".windowColor"))
                {
                    Attributes.Remove(".windowColor");
                }
                else
                {
                    Attributes[".windowColor"] = value;
                }
            }
        }
        public string TitleColor
        {
            get
            {
                Attributes.TryGetValue(".titleColor", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".titleColor"))
                {
                    Attributes.Remove(".titleColor");
                }
                else
                {
                    Attributes[".titleColor"] = value;
                }
            }
        }
        public string BackColor
        {
            get
            {
                Attributes.TryGetValue(".backcolor", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".backcolor"))
                {
                    Attributes.Remove(".backcolor");
                }
                else
                {
                    Attributes[".backcolor"] = value;
                }
            }
        }
        public string Icon
        {
            get
            {
                Attributes.TryGetValue(".icon", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".icon"))
                {
                    Attributes.Remove(".icon");
                }
                else
                {
                    Attributes[".icon"] = value;
                }
            }
        }
        public string TitleImg
        {
            get
            {
                Attributes.TryGetValue(".titleImg", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".titleImg"))
                {
                    Attributes.Remove(".titleImg");
                }
                else
                {
                    Attributes[".titleImg"] = value;
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

        public override UserControl CreateUC()
        {
        return new Controls.UCFenetre(this) as UserControl;
          }
    }
}
