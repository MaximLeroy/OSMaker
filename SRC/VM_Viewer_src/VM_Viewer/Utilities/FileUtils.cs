
using cwc.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace cwc
{
    public class FileUtils
    {
        public static bool IsEmpty(string _sText)
        {
            return String.IsNullOrEmpty(_sText) || _sText.Trim().Length == 0;
        }

        private string sTab = "";
        public string sFile = "";
        StreamWriter oWriter = null;
        FileStream oFileStream = null;
        public bool bSettingLoaded;

        public string[] aRead = null;

        XmlDocument oXml = null;

        public Boolean fIniFile(string _sFile, bool _bEmpty = true, bool _bIni = true)
        {
            Debug.fTrace(_sFile);
            // Console.WriteLine("aaaa"+_sFile);


            sFile = _sFile;
            bSettingLoaded = true;
            if (!File.Exists(sFile))
            {
         
                return false;
            }else
            {
                return true;
            }


            try
            {     
                /*
                if (oFileStream != null)
                {
                    oFileStream.Close();
                }

                sFile = _sFile;

                fCreateDirectoryRecursively(Path.GetDirectoryName(_sFile));
         
                if (_bEmpty && File.Exists(_sFile))
                { //Stupid c# can't create empty file
                    File.Delete(_sFile);
                }

                if (_bIni)
                {
                    oFileStream = new FileStream(_sFile, FileMode.OpenOrCreate, FileAccess.Write);
                    oWriter = new StreamWriter(oFileStream);
                }*/
                bSettingLoaded = true;
                return true;
            }
            catch (Exception e)
            {
                Debug.fTrace("Ini File error: " + _sFile + " : " + e.Message);
                return false;
            }
        }
        /*
        public string[] fReadFile()
        {
            byte[] buffer;
            // FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)oFileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read

                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = oFileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
            }
            finally
            {
                oFileStream.Close();
            }

            //Convert byte[] to string[]
            aRead = (Encoding.Default.GetString(buffer, 0, buffer.Length - 1)).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            return aRead;
        }
        */

        public XmlDocument fReadXmlFile()
        {

            try
            {
                // MessageBox.Show("Lo "+sFile);
                //  oFileStream.Close();
                oXml = new XmlDocument();
                if (File.Exists(sFile))
                {
                    oXml.Load(sFile);
                }

            }
            catch (Exception e)
            {
                Debug.fTrace("Read Xml error: " + sFile + " : " + e.Message);
            }

            return oXml;
        }

        public void fSaveXmlFile(XmlDocument _oSaveXML)
        {
            if (sFile == "")
            {
                return;
            }
            try
            {
                //   oFileStream = new FileStream(sFile, FileMode.OpenOrCreate, FileAccess.Write);
                //   oFileStream.Close(); //Jsut to be sure

                _oSaveXML.Save(sFile);
            }
            catch (Exception e)
            {
                Debug.fTrace("Save Xml error: " + sFile + " : " + e.Message);
            }

        }



        public void fSubTab()
        {
            sTab = sTab.Substring(0, sTab.Length - 1);
        }
        public void fAddTab()
        {
            sTab += '\t';
        }

        public void fAdd(string _sLine)
        {
            oWriter.WriteLine(sTab + _sLine);
        }

        public void fClose()
        {
            oWriter.Close();
        }

        public static void fCreateDirectoryRecursively(string path)
        {
            if (!IsEmpty(path) && !Directory.Exists(path))
            {

                path.Replace('\\', '/');
                string[] pathParts = path.Split('/');

                for (int i = 0; i < pathParts.Length; i++)
                {

                    try
                    {
                        if (i > 0)
                            pathParts[i] = Path.Combine(pathParts[i - 1], pathParts[i]);


                        if (!Directory.Exists(pathParts[i]))
                            Directory.CreateDirectory(pathParts[i]);
                    }
                    catch (Exception ex) { }

                }

            }
        }

        public static bool fIsNewer(string _sSrcFile, string _sToFile)
        {

            try
            {

                if (!File.Exists(_sToFile))
                {
                    return true;
                }

                DateTime dtSrc = File.GetLastWriteTime(_sSrcFile);
                DateTime dtTo = File.GetLastWriteTime(_sToFile);

                if (dtSrc > dtTo)
                {
                    return true;
                }
            }
            catch
            {
                return true;
            }
            //   Debug.fTrace("--Skip Asm ------" + _sSrcFile);
            return false;
        }



        public static string fMakeRelativePath(string workingDirectory, string fullPath)
        {
            string result = string.Empty;
            int offset;

            workingDirectory = workingDirectory.Replace('\\', '/');
            fullPath = fullPath.Replace('\\', '/');
            if (workingDirectory[workingDirectory.Length - 1] == '/')
            {
                workingDirectory = workingDirectory.Substring(0, workingDirectory.Length - 1);
            }
            if (fullPath[fullPath.Length - 1] == '/')
            {
                fullPath = fullPath.Substring(0, fullPath.Length - 1);
            }

            // this is the easy case.  The file is inside of the working directory.
            if (fullPath.StartsWith(workingDirectory))
            {
                return fullPath.Substring(workingDirectory.Length + 1);
            }

            // the hard case has to back out of the working directory
            string[] baseDirs = workingDirectory.Split(new char[] { ':', '/' });
            string[] fileDirs = fullPath.Split(new char[] { ':', '/' });

            // if we failed to split (empty strings?) or the drive letter does not match
            if (baseDirs.Length <= 0 || fileDirs.Length <= 0 || baseDirs[0] != fileDirs[0])
            {
                // can't create a relative path between separate harddrives/partitions.
                return fullPath;
            }

            // skip all leading directories that match
            for (offset = 1; offset < baseDirs.Length; offset++)
            {
                if (baseDirs[offset] != fileDirs[offset])
                    break;
            }

            // back out of the working directory
            for (int i = 0; i < (baseDirs.Length - offset); i++)
            {
                result += "../";
            }

            // step into the file path
            for (int i = offset; i < fileDirs.Length - 1; i++)
            {
                result += fileDirs[i] + "/";
            }

            // append the file
            result += fileDirs[fileDirs.Length - 1];

            return result;
        }




        public static void DeleteDirectory(string path, bool recursive = true)
        {
            try
            {
                // Delete all files and sub-folders?
                if (recursive)
                {
                    // Yep... Let's do this
                    var subfolders = Directory.GetDirectories(path);
                    foreach (var s in subfolders)
                    {
                        DeleteDirectory(s, recursive);
                    }
                }

                // Get all files of the folder
                var files = Directory.GetFiles(path);
                foreach (var f in files)
                {
                    // Get the attributes of the file
                    var attr = File.GetAttributes(f);

                    // Is this file marked as 'read-only'?
                    if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        // Yes... Remove the 'read-only' attribute, then
                        File.SetAttributes(f, attr ^ FileAttributes.ReadOnly);
                    }

                    // Delete the file
                    File.Delete(f);
                }

                // When we get here, all the files of the folder were
                // already deleted, so we just delete the empty folder

                Directory.Delete(path);
            }
            catch (Exception Ex) { }

        }


        public static List<String> GetAllFiles(String directory)
        {
            return Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories).ToList();
        }

        /*
                    public static List<String> GetAllFiles(String directory){
                        return Directory.GetFiles(directory, "*", SearchOption.AllDirectories).ToList();
                    }*/


        ///////////////////////////// Copy Directory //////////////////////
        public static void CopyFolderContents(string sourceFolder, string destinationFolder)
        {
            CopyFolderContents(sourceFolder, destinationFolder, "*.*", "", true, true);
        }
        public static void CopyFolderContents(string sourceFolder, string destinationFolder, string mask)
        {
            CopyFolderContents(sourceFolder, destinationFolder, mask, "", true, true);
        }
        public static void CopyFolderContents(string sourceFolder, string destinationFolder, string mask = "*.*", string _sExept = "", Boolean createFolders = true, Boolean recurseFolders = true)
        {

            //Output.TraceAction("Copy: " + sourceFolder + " to " + destinationFolder);

            try
            {

                if (!(sourceFolder.EndsWith(@"\") || sourceFolder.EndsWith(@"/")))
                {
                    sourceFolder += @"\";
                }

                sourceFolder = Path.GetFullPath(sourceFolder);
                string _sSingleFile = "";
                bool _bSourceIsFile = false;
                if (!Directory.Exists(sourceFolder))
                {
                    if (File.Exists(sourceFolder))
                    { //It's a file from source
                        _sSingleFile = sourceFolder.Substring(0, sourceFolder.Length - 1);
                        sourceFolder = new FileInfo(_sSingleFile).Directory.FullName + "\\";
                        _bSourceIsFile = true;
                    }
                    else
                    {
                        return; //No source
                    }
                }

                string _sDestFileName = "";
                if (!_bSourceIsFile)
                {
                    if (!(destinationFolder.EndsWith(@"\") || destinationFolder.EndsWith(@"/")))
                    {
                        destinationFolder += @"\";
                    }
                }
                else
                { //Source is a file
                    if ((destinationFolder.EndsWith(@"\") || destinationFolder.EndsWith(@"/")))
                    {
                        destinationFolder += Path.GetFileName(sourceFolder);
                    }
                    else
                    {
                        //Debug.fTrace("destinationFolder " + destinationFolder);
                        FileInfo _oFile = new FileInfo(destinationFolder);
                        destinationFolder = _oFile.Directory.FullName + "\\";
                        //Debug.fTrace("----destinationFolder " + destinationFolder);
                        _sDestFileName = _oFile.Name;
                    }
                }

                destinationFolder = Path.GetFullPath(destinationFolder);

                var exDir = sourceFolder;
                var dir = new DirectoryInfo(exDir);

                string[] _aSourceFile;

                if (_bSourceIsFile)
                {
                    _aSourceFile = new string[] { _sSingleFile };
                }
                else
                {
                    SearchOption so = (recurseFolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                    string _sDir = dir.ToString();
                    if (_sExept == "")
                    {
                        _aSourceFile = Directory.GetFiles(_sDir, mask, so);
                    }
                    else
                    {
                        _aSourceFile = Directory.GetFiles(_sDir, mask, so).Except(Directory.GetFiles(_sDir, _sExept, so)).ToArray();

                    }
                }

                //  foreach (string sourceFile in Directory.GetFiles(dir.ToString(), mask, so).Where(file => Regex.IsMatch(file, @"^.+\.(cpp|hpp|hxx|gcpp|icpp|c|h)$"))             )
                foreach (string sourceFile in _aSourceFile)
                {


                    FileInfo srcFile = new FileInfo(sourceFile);
                    string srcFileName = srcFile.Name;

                    // Create a destination that matches the source structure
                    string _sFileRelPath = _sDestFileName;
                    if (_sDestFileName == "")
                    {
                        _sFileRelPath = srcFile.FullName.Replace(sourceFolder, "");
                    }


                    FileInfo destFile = new FileInfo(destinationFolder + _sFileRelPath);

                    if (!Directory.Exists(destFile.DirectoryName) && createFolders)
                    {
                        Directory.CreateDirectory(destFile.DirectoryName);
                    }

                    if (!destFile.Exists || srcFile.LastWriteTime > destFile.LastWriteTime)
                    {
                        File.Copy(srcFile.FullName, destFile.FullName, true);
                        //Output.Trace("\f3FCopy: \f37 " + _sFileRelPath);
                    }
                }
            }
            catch (Exception ex)
            {
                //   System.Diagnostics.Debug.WriteLine(ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace);
                //Debug.fTrace("Error copy: " + ex.Message + " "  + ex.StackTrace);
                //Output.TraceError("Error copy: " + ex.Message + " " + ex.StackTrace);
            }
        }




        public static void DirectoryDeleteAll(string path)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(path, true);
            }
            catch (IOException)
            {
                Directory.Delete(path, true);
            }
            catch (UnauthorizedAccessException)
            {
                Directory.Delete(path, true);
            }
        }










        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);

        public static Process exeProcess = null;
        public static Process firstProcess = null;
       


        public static void fFindExistantExe(string _sFullPath)
        {
            Process[] localByName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(_sFullPath));
            _sFullPath = PathHelper.fNormalizePath(_sFullPath);
            foreach (Process _oProc in localByName)
            {
                string _sNormPath = PathHelper.fNormalizePath(_oProc.MainModule.FileName);
                if (_sNormPath.IndexOf(_sFullPath) != -1)
                {
                    firstProcess = _oProc;
                }
            }
        }



      
         public static string fDialogExeFile( string _sRoot, string _sCurrentVal, string _sFilter = "", bool _bRelative = false) {

            OpenFileDialog fbd = new OpenFileDialog();
            if(_sRoot.Length <= 1) {
                _sRoot = "C:/";
             }
            _sRoot = _sRoot.Replace('\\', '/');
            if(_sRoot[_sRoot.Length - 1] != '/' ) {
                _sRoot += '/';
            }
           

            fbd.InitialDirectory  =  Path.GetDirectoryName(_sRoot + _sCurrentVal);
			if(_sFilter == ""){
				 fbd.Filter = "VM (*.vmx/*.ova/*.ovf)|*.vmx;*.ova;*.ovf|All files (*.*)|*.*";
			}else{
				 fbd.Filter = _sFilter;
			}
            if(fbd.ShowDialog() == DialogResult.OK) {
               //return Path.GetFileName( fbd.FileName);
              // Debug.fTrace(_sRoot);
              // Debug.fTrace( fbd.FileName);
              // return FileUtils.fMakeRelativePath(_sRoot, fbd.FileName);
                  if(_bRelative) {
                        return FileUtils.fMakeRelativePath(_sRoot, fbd.FileName);
                }else
                {
                        return  fbd.FileName;
                }
            }
            return _sCurrentVal;
        }


        public static string fOpenFolderBrowsing(string _sCurrentVal)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (FileUtils.IsEmpty(_sCurrentVal) || !Directory.Exists(_sCurrentVal))
            {
                fbd.SelectedPath = "C:\\";
            }
            else
            {
                _sCurrentVal = Path.GetDirectoryName(_sCurrentVal.Replace('/', '\\'));
                if (_sCurrentVal[_sCurrentVal.Length - 1] != '\\')
                {
                    _sCurrentVal += "\\";
                }



                fbd.SelectedPath = _sCurrentVal;

            }

            fbd.Description = "Select the compiler binaries folder";
            fbd.ShowNewFolderButton = false;

            //SendKeys.Send("{TAB}{TAB}{RIGHT}");  // <<-- Workaround
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fCorrectPath(fbd.SelectedPath);
            }
            return _sCurrentVal.Replace('\\', '/');
        }


        public static string fCorrectPath(string _sPath)
        {
            _sPath = _sPath.Replace('\\', '/');
            if (_sPath[_sPath.Length - 1] != '/')
            {
                _sPath = _sPath + "/";
            }
            return _sPath;
        }




    }
}


