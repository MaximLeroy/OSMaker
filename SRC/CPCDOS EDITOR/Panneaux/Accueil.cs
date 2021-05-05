using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OSMaker.Formulaires;
namespace OSMaker.Panneaux
{
    public partial class Accueil : DocumentC
    {
        const int MRUnumber = 6;
        System.Collections.Generic.Queue<string> MRUlist = new Queue<string>();
        public Accueil()
        {
            InitializeComponent();
        }
        /// <summary>
        /// load recent file list from file
        /// </summary>
        private void LoadRecentList()
        {//try to load file. If file isn't found, do nothing
            MRUlist.Clear();
            try
            {
                StreamReader listToRead = new StreamReader(System.Environment.CurrentDirectory + "\\Recent.txt"); //read file stream
                string line;
                while ((line = listToRead.ReadLine()) != null) //read each line until end of file
                    MRUlist.Enqueue(line); //insert to list
                listToRead.Close(); //close the stream
            }
            catch (Exception)
            {

                //throw;
            }

        }
        //private void SaveRecentFile(string path)
        //{
        //    metroComboBox1.Items.Clear(); //clear all recent list from menu
        //    LoadRecentList(); //load list from file
        //    if (!(MRUlist.Contains(path))) //prevent duplication on recent list
        //        MRUlist.Enqueue(path); //insert given path into list
        //    while (MRUlist.Count > MRUnumber) //keep list number not exceeded given value
        //    {
        //        MRUlist.Dequeue();
        //    }
        //    foreach (string item in MRUlist)
        //    {
                
        //       ComboBox.ObjectCollection fileRecent = new MetroComboBoxItem(item, null, RecentFile_click);  //create new menu for each item in list
        //        metroComboBox1.Items.Add(fileRecent); //add the menu to "recent" menu
        //    }
        //    //writing menu list to file
        //    StreamWriter stringToWrite = new StreamWriter(System.Environment.CurrentDirectory + "\\Recent.txt"); //create file called "Recent.txt" located on app folder
        //    foreach (string item in MRUlist)
        //    {
        //        stringToWrite.WriteLine(item); //write list to stream
        //    }
        //    stringToWrite.Flush(); //write stream to file
        //    stringToWrite.Close(); //close the stream and reclaim memory
        //}

        private void metroLink1_Click(object sender, EventArgs e)
        {

            try
            {
                var dlg = new   FileFolderDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Home.m_solutionExplorer.txtDirectory.Text = dlg.SelectedPath + "\\";
                    Home.m_solutionExplorer._tv.Nodes.Clear();
                    Home.m_solutionExplorer.LoadDirectory(Home.m_solutionExplorer.txtDirectory.Text);
                    Home.m_solutionExplorer.txtDirectory.Style = MetroFramework.MetroColorStyle.Green;
                }
            }
            catch
            {

            }
        }
        
        private void metroLink2_Click(object sender, EventArgs e)
        {
            New_OS new_OS = new New_OS();
            new_OS.Show();
           
        }
    }
}
