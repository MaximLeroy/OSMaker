using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exporter
{
    class CpcDosCPlusTexteBloc : CpcDosCPlusObjet
    {
        public CpcDosCPlusTexteBloc(string[] declaration) : base(declaration)
        {
        }

        public override string TypeObjet { get { return "textebloc"; } }

        public string Handle
        {
            get
            {
                Attributes.TryGetValue(".handle", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".handle"))
                {
                    Attributes.Remove(".handle");
                }
                else
                {
                    Attributes[".handle"] = value;
                }
            }
        }
        public string Parametres
        {
            get
            {
                Attributes.TryGetValue(".Parametres", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".Parametres"))
                {
                    Attributes.Remove(".Parametres");
                }
                else
                {
                    Attributes[".Parametres"] = value;
                }
            }
        }
        public string Texte
        {
            get
            {
                Attributes.TryGetValue(".texte", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".texte"))
                {
                    Attributes.Remove(".texte");
                }
                else
                {
                    Attributes[".texte"] = value;
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
        public string CouleurFond
        {
            get
            {
                Attributes.TryGetValue(".CouleurFond", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".CouleurFond"))
                {
                    Attributes.Remove(".CouleurFond");
                }
                else
                {
                    Attributes[".CouleurFond"] = value;
                }
            }
        }
        public string CouleurTexte
        {
            get
            {
                Attributes.TryGetValue(".CouleurTexte", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".CouleurTexte"))
                {
                    Attributes.Remove(".CouleurTexte");
                }
                else
                {
                    Attributes[".CouleurTexte"] = value;
                }
            }
        }
        public string Tx
        {
            get
            {
                Attributes.TryGetValue(".tx", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".tx"))
                {
                    Attributes.Remove(".tx");
                }
                else
                {
                    Attributes[".tx"] = value;
                }
            }
        }
        public string Ty
        {
            get
            {
                Attributes.TryGetValue(".ty", out string value);
                return value;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && Attributes.ContainsKey(".ty"))
                {
                    Attributes.Remove(".ty");
                }
                else
                {
                    Attributes[".ty"] = value;
                }
            }
        }
    }
}
