using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using System.IO;
using System.Linq; // ref

namespace OSMaker.WinToCpc
{
    public static class ModuleCpc
    {
        private static XmlDocument doc;
        private static Dictionary<string, string> WinToCpcControls;
        private static Dictionary<string, string> CpcDebutToFins;
        private static StringBuilder sb;
        public static void GenTextCpc(string stringXML)
        {

            LoadWinToCpcControls();
            sb = new StringBuilder();
            doc = new XmlDocument();

            //le code qui suit remets en place le noeud xml "RACINE" xml 
            // comme  deja car la prop GetCode dans BasicHostLoader la suprime
            string cleandown = stringXML;
            cleandown = "<DOCUMENT_ELEMENT>" + stringXML + "</DOCUMENT_ELEMENT>";

            doc.LoadXml(cleandown);

            XmlNode root = doc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                WriteNodeObject(node, sb);
            }
            string cpcFileName = GetFileNameToSave(); //obtient le nom de fichier CPC à sauvegarder
            if (cpcFileName != null)
                File.WriteAllText(cpcFileName, sb.ToString());


        }
       
        private static void WriteNodeObject(XmlNode currentNode, StringBuilder sbuilder)
        {
            string[] nameTypes = { };
            string[] names = { };
            EditeurCCplus editeurC;
            editeurC = new EditeurCCplus();

            if (currentNode.Name == "Object") // c'est un node Object i.e. un Control
                nameTypes = currentNode.Attributes.GetNamedItem("type").Value.Split(new Char[] { ',' });

            names = currentNode.Attributes.GetNamedItem("name").Value.Split(new Char[] { ',' });

             if (nameTypes[0] == WinToCpcControls.ElementAt(0).Key) // probleme index 
        
            {

                sbuilder.Append(@"
'REMARQUE : Cpcdosiennes, Cpcdosiens ce code est généré par
' _____   _____       ___  ___       ___   _   _    _____   _____   
'/  _  \ /  ___/     /   |/   |     /   | | | / /  | ____| |  _  \  
'| | | | | |___     / /|   /| |    / /| | | |/ /   | |__   | |_| |  
'| | | | \___  \   / / |__/ | |   / / | | | |\ \   |  __|  |  _  /  
'| |_| |  ___| |  / /       | |  / /  | | | | \ \  | |___  | | \ \  
'\_____/ /_____/ /_/        |_| /_/   |_| |_|  \_\ |_____| |_|  \_\ v 1.0
' La procédure suivante est requise par le Concepteur Windows Form
' Elle peut être modifiée à l'aide du Concepteur Windows Form  
' Ne la modifiez pas à l'aide de l'éditeur de code.                        " + '\n');
                sbuilder.Append(WinToCpcControls.Values.ElementAtOrDefault(0));
                sbuilder.Append(" " + names[0]);
                sbuilder.AppendLine();
                // XPATH  un autre operateut  XML fait des miracles 
                // lit tou les nodes "Property" sous le currentNode
                var childrops = currentNode.SelectNodes("Property");
                foreach (XmlNode item in childrops)
                    WriteNodeProperty(item, sbuilder);
                if (editeurC.parametrescheck.Checked)
                {
                    sbuilder.AppendLine(".Parameters" + "   " + " = \"" + editeurC.bordtext.Text + editeurC.ctntext.Text + editeurC.typetext.Text + "OMBRE:" + editeurC.ombretext.Text + "\"");
                }

                if (string.IsNullOrEmpty(editeurC.Opacitetext.Text))
                {
                }
                else
                {
                    sbuilder.AppendLine(".Opacite" + "      " + " = \"" + editeurC.Opacitetext.Text + "\"");
                }

                if (string.IsNullOrEmpty(editeurC.Couleurfenetretext.Text))
                {
                }
                else
                {
                    sbuilder.AppendLine(".WindowColor" + "  " + " = \"" + editeurC.Couleurfenetretext.Text + "\"");
                }

                if (string.IsNullOrEmpty(editeurC.couleurtitretext.Text))
                {
                }
                else
                {
                    sbuilder.AppendLine(".TitleColor" + "   " + " = \"" + editeurC.couleurtitretext.Text + "\"");
                }

                if (string.IsNullOrEmpty(editeurC.couleurfondtext.Text))
                {
                }
                else
                {
                    sbuilder.AppendLine(".BackColor" + "    " + " = \"" + editeurC.couleurfondtext.Text + "\"");
                }

                if (string.IsNullOrEmpty(editeurC.iconetext.Text))
                {
                }
                else
                {
                    sbuilder.AppendLine(".Icone" + "        " + " = \"" + editeurC.iconetext.Text + "\"");
                }

                if (string.IsNullOrEmpty(editeurC.imgtitretext.Text))
                {
                }
                else
                {
                    sbuilder.AppendLine(".ImgTitre" + "     " + " = \"" + editeurC.imgtitretext.Text + "\"");
                }

                sbuilder.AppendLine("Create/ @#" + editeurC.Handletext.Text);
                sbuilder.AppendLine(CpcDebutToFins.Values.ElementAtOrDefault(0));
               
            }
            else if (nameTypes[0] == WinToCpcControls.ElementAt(1).Key)
            {
                sbuilder.Append(WinToCpcControls.ElementAt(1).Value);
                sbuilder.Append(" " + names[0]);
                sbuilder.AppendLine();
                XmlNodeList childrops = currentNode.SelectNodes("Property");
                foreach (XmlNode item in childrops)
                {
                    WriteNodeProperty(item, sbuilder);
                }
                sbuilder.AppendLine(CpcDebutToFins.ElementAt(1).Value);

            }
            else if (nameTypes[0] == WinToCpcControls.ElementAt(2).Key)
            {
                sbuilder.Append(WinToCpcControls.ElementAt(2).Value);
                sbuilder.Append(" " + names[0]);
                sbuilder.AppendLine();
                XmlNodeList childrops = currentNode.SelectNodes("Property");
                foreach (XmlNode item in childrops)
                {
                    WriteNodeProperty(item, sbuilder);
                }
                sbuilder.AppendLine(CpcDebutToFins.ElementAt(2).Value);

            }
            else if (nameTypes[0] == WinToCpcControls.ElementAt(3).Key)
            {
                sbuilder.Append(WinToCpcControls.ElementAt(3).Value);
                sbuilder.Append(" " + names[0]);
                sbuilder.AppendLine();
                XmlNodeList childrops = currentNode.SelectNodes("Property");
                foreach (XmlNode item in childrops)
                {
                    WriteNodeProperty(item, sbuilder);
                }
                sbuilder.AppendLine(CpcDebutToFins.ElementAt(3).Value);
            }
            else if (nameTypes[0] == WinToCpcControls.ElementAt(4).Key)
            {
                sbuilder.Append(WinToCpcControls.ElementAt(4).Value);
                sbuilder.Append(" " + names[0]);
                sbuilder.AppendLine();
                XmlNodeList childrops = currentNode.SelectNodes("Property");
                foreach (XmlNode item in childrops)
                {
                    WriteNodeProperty(item, sbuilder);
                }
                sbuilder.AppendLine(CpcDebutToFins.ElementAt(4).Value);

            }
            else if (nameTypes[0] == WinToCpcControls.ElementAt(5).Key)
            {
                sbuilder.Append(WinToCpcControls.ElementAt(5).Value);
                sbuilder.Append(" " + names[0]);
                sbuilder.AppendLine();
                XmlNodeList childrops = currentNode.SelectNodes("Property");
                foreach (XmlNode item in childrops)
                {
                    WriteNodeProperty(item, sbuilder);
                }
                sbuilder.AppendLine(CpcDebutToFins.ElementAt(5).Value);


            }
            else if (nameTypes[0] == WinToCpcControls.ElementAt(6).Key)
            {
                sbuilder.Append(WinToCpcControls.ElementAt(6).Value);
                sbuilder.Append(" " + names[0]);
                sbuilder.AppendLine();
                XmlNodeList childrops = currentNode.SelectNodes("Property");
                foreach (XmlNode item in childrops)
                {
                    WriteNodeProperty(item, sbuilder);
                }
                sbuilder.AppendLine(CpcDebutToFins.ElementAt(6).Value);


            }

            sbuilder.AppendLine();
            foreach (XmlNode itemNode in currentNode.ChildNodes)
            {
                WriteNodeObject(itemNode, sbuilder);  //appel recurif car XML genere en fait un tree
            }
        }
        private static void WriteNodeProperty(XmlNode currentNode, StringBuilder sbuilder)
        {
            string name;
            string[] propertyValues;
            string[] propertyValues2;
            propertyValues = currentNode.InnerText.Split(new Char[] { ',' });
         //   propertyValues2 = currentNode.InnerText;
            name = currentNode.Attributes.GetNamedItem("name").Value;


            if (name == "Text")
                sbuilder.AppendLine(".titre" + "    " + " = \" " + propertyValues[0] + " \" ");
            else if (name == "Location")
            {
                sbuilder.Append(".px" + "    " + " = \" " + propertyValues[0] + " \" ");
                sbuilder.AppendLine();
                sbuilder.AppendLine(".py" + "    " + " = \" " + propertyValues[1] + " \" ");
            }
            else if (name == "ClientSize" || name == "Size")
            {
                sbuilder.Append(".tx" + "    " + " = \" " + propertyValues[0] + " \" ");
                sbuilder.AppendLine();
                sbuilder.AppendLine(".ty" + "    " + " = \" " + propertyValues[0] + " \" ");
            }
            else if (name == "BackColor")
            {
                Color color = Color.FromName(propertyValues[0]);
                sbuilder.AppendLine(".CouleurFond" + "    " + " \" " + color.R.ToString() + "," + color.G.ToString() + "," + color.B.ToString() + " \" ");
            }
            else if (name == "ForeColor")
            {
                Color color = Color.FromName(propertyValues[0]);
                string[] rgbcolors = color.Name.Split(new Char[] { ',' });
                sbuilder.AppendLine(".CouleurTexte" + "    " + " \" " + color.R.ToString() + "," + color.G.ToString() + "," + color.B.ToString() + " \" ");
            }
            else if (name == "Checked")
            {
                string valeur = propertyValues[0] == "Checked" ? "1" : "0";
                sbuilder.AppendLine(".valeur" + "    " + " \" " + valeur + " \" ");
            }
            else if (name == "Opacite")
            {
                sbuilder.AppendLine(".opacite" + "    " + " = \" " + propertyValues[0] + " \" ");
            }
        }
        private static void LoadWinToCpcControls()
        {
            WinToCpcControls = new Dictionary<String, String>();
            WinToCpcControls.Add("System.Windows.Forms.Form", "Window/");
            WinToCpcControls.Add("ToolBox.PictureBox", "PictureBox/");
            WinToCpcControls.Add("ToolBox.CheckBox", "CheckBox/");
            WinToCpcControls.Add("ToolBox.Button", "Button/");
            WinToCpcControls.Add("ToolBox.TextBox", "TextBox/");
            WinToCpcControls.Add("ToolBox.TextBlock", "TextBlock/");
            WinToCpcControls.Add("ToolBox.ProgressBar", "ProgressBar/");

            CpcDebutToFins = new Dictionary<String, String>();
            CpcDebutToFins.Add("Window/", "End/ Window");
            CpcDebutToFins.Add("PictureBox/", "End/ PictureBox");
            CpcDebutToFins.Add("CheckBox/", "End/ CheckBox");
            CpcDebutToFins.Add("Button/", "End/ Button");
            CpcDebutToFins.Add("TextBox/", "End/ TextBox");
            CpcDebutToFins.Add("TextBlock/", "End/ TextBlock");
            CpcDebutToFins.Add("ProgressBar/", "End/ ProgressBar");

        }
        // AJOUT => UN SAVEDIALOG
        private static string GetFileNameToSave()
        {
            EditeurCCplus  editeurC;
            editeurC = new EditeurCCplus();
            string fileName = null;
            if (string.IsNullOrEmpty(editeurC.TextBoxX1.Text))
            {
                var dlgSaveFile = new SaveFileDialog();
                dlgSaveFile.Filter = "Files(.*cpc)|*.cpc";
                if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlgSaveFile.FileName;
                    editeurC.TextBoxX1.Text = fileName;
                    if (fileName.Length != 0)
                    {
                        return fileName;
                    }
                }
            }
            else
            {
                fileName = editeurC.TextBoxX1.Text;
            }

            return fileName;
        }

    }
}
