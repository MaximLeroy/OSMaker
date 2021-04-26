using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Exporter
{
    public class CpcDosCPlusObjet
    {
        protected readonly Dictionary<string, string> Attributes;
		public virtual string TypeObjet { get; }
        public string ID { get; set; }
		public static string mavariable = "";
		public CpcDosCPlusObjet() : this(new Dictionary<string, string>())
        {
        }

        public CpcDosCPlusObjet(Dictionary<string, string> attributes)
        {
            Attributes = attributes;
        }

        public CpcDosCPlusObjet(string[] declaration)
        {
            Attributes = new Dictionary<string, string>();
			string typeObjet = declaration[0].Split('/')[0].Trim();
            ID = declaration[0].Split('/')[1].Trim();

			if (typeObjet == "function")
			{
				StringBuilder code = new StringBuilder();
				for (int i = 0, length = declaration.Length; i <length; i++)
				{
					code.Append(string.Concat(declaration[i], "\r\n"));
				}
				Attributes.Add(".code", code.ToString());
			}
			else
			{
				for (int i = 1, length = declaration.Length; i < length; i++)
				{
					string ligne = declaration[i].Trim();
					if (ligne.StartsWith("rem/"))
					{
						// Cette ligne est en commentaire, on l'ignore
						continue;
					}
					else if (ligne.StartsWith("set/"))
                    {
						 mavariable = ligne.Remove(4);
						
						
						
                    }
					else if (ligne.Contains('='))
					{
						// Il s'agit d'une ligne de déclaration d'un attribut
						string[] keyval = ligne.Split('=');
						string key = keyval[0].Trim().ToLower();
						string val = keyval[1].Trim();
						if (val.StartsWith("\"") && val.EndsWith("\""))
						{
							val = val.Substring(1, val.Length - 2);
						}
						Attributes[key] = val;
					}
					else
					{
						// Il s'agit d'un autre type de ligne
						if (ligne.StartsWith("@#"))
						{
							// Ca j'ai pas compris ce que c'était
						}
					}
				}
			}
        }

		public override string ToString()
		{
			return $"{TypeObjet} {ID}";
		}

		public virtual UserControl CreateUC()
		{
			return null;
		}

		public string ToCPCDosCPlus()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{TypeObjet}/ {ID}");

			foreach (KeyValuePair<string, string> kvp in Attributes)
			{
				sb.AppendLine($"\t{kvp.Key} = \"{kvp.Value}\"");
			}

			sb.AppendLine($"End/ {TypeObjet}");
			
			return sb.ToString();
		}
	}
}
