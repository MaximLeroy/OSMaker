using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Exporter
{
	class CpcDosCPlusListeObjets : List<CpcDosCPlusObjet>
	{
		public CpcDosCPlusListeObjets(string path)
		{
			string[] lignes = File.ReadAllLines(path);

			bool chercheDebut = true;
			int debutObjet = -1;
			string typeObjet = string.Empty;

			for (int i = 0, length = lignes.Length; i < length; i++)
			{
				string ligne = lignes[i].Trim().ToLower();
				if (chercheDebut && ligne.Contains('/') && !ligne.StartsWith("rem/"))
				{
					string[] tmp = ligne.Split('/');
					if (tmp.Length > 2)
					{
						//throw new Exception($"Je n'arrive pas à décoder cette ligne : {i}");

					}
					debutObjet = i;
					typeObjet = tmp[0];
					chercheDebut = false; // Maintenant on va chercher la fin
				}
				else if (!chercheDebut && ligne.StartsWith("end/"))
				{
					switch (typeObjet)
					{

						case "button":
						case "bouton":
							this.Add(new CpcDosCPlusBouton(lignes.SubArray(debutObjet, i)));
							break;

						//case "window":
						//this.Add(new CpcDosCPlusBouton(lignes.SubArray(debutObjet, i)));
						//break;
						case "fonction":
						case "function":
							this.Add(new CpcDosCPlusFonction(lignes.SubArray(debutObjet, i)));
							break;
						case "window":
							this.Add(new CpcDosCPlusWindow(lignes.SubArray(debutObjet, i)));
							break;
						case "picturebox":
							this.Add(new CpcDosCPlusPictureBox(lignes.SubArray(debutObjet, i)));
							break;
						case "textebloc":
							this.Add(new CpcDosCPlusTexteBloc(lignes.SubArray(debutObjet, i)));
							break;
						case "textbox":
						case "textebox":
							this.Add(new CpcDosCPlusTextBox(lignes.SubArray(debutObjet, i)));

							break;
						case "checkbox":
							this.Add(new CpcDosCPlusCheckBox(lignes.SubArray(debutObjet, i)));
							break;
							//default:
							//throw new Exception($"Type d'objet non pris en charge {typeObjet}");

					}
					chercheDebut = true;
				}
			}
		}

		public string ToCPCDosCPlus()
		{
			StringBuilder sb = new StringBuilder();

			foreach (CpcDosCPlusObjet objet in this)
			{
				sb.AppendLine(objet.ToCPCDosCPlus());
			}

			return sb.ToString();
		}
		class CpcDosCPlusListeVariables : List<CpcDosCPlusObjet>
		{
			public CpcDosCPlusListeVariables(string path)
			{
				string[] lignes = File.ReadAllLines(path);

				bool chercheDebut = true;
				int debutObjet = -1;
				string typeObjet = string.Empty;

				for (int i = 0, length = lignes.Length; i < length; i++)
				{
					string ligne = lignes[i].Trim().ToLower();
					if (chercheDebut && ligne.Contains("set/") && !ligne.StartsWith("rem/"))
					{
						string[] tmp = ligne.Split('/');
						if (tmp.Length > 2)
						{
							//throw new Exception($"Je n'arrive pas à décoder cette ligne : {i}");

						}
						debutObjet = i;
						typeObjet = tmp[0];
						//chercheDebut = false; // Maintenant on va chercher la fin
					}
					else if (!chercheDebut && ligne.StartsWith("set/"))
					{
						switch (typeObjet)
						{
							case "variable":
							
								this.Add(new CpcDosCPlusVariables(lignes.SubArray(debutObjet, i)));
								break;
							

						}
						chercheDebut = true;
					}
				}
			}

		}
	}
}
	
