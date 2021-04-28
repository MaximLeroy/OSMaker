using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cwc.Utilities
{
    public class PathHelper
    {
       
        public static String GetCurrentDirectory()
        {
            //  return Path.GetDirectoryName(Application.StartupPath) + "/";
            return System.IO.Directory.GetCurrentDirectory().Replace('\\', '/') + "/";


            //	return  System.Reflection.Assembly.GetEntryAssembly().Location.Replace('\\', '/') + "/";;



        }


        public static String ExeWorkDir = GetCurrentDirectory();


        public static string sExeIDE = "npp/notepad++.exe";
        public static string sExeIDE_Name = "cwc.notepad++.";

        //    nppProcess.StartInfo.FileName = PathHelper.ToolDir +  "npp/notepad++.exe";


        /// <summary>
        /// Gets the directory of the app.
        /// </summary>
        public static String GetExeDirectory()
        {
            return Path.GetDirectoryName(Application.ExecutablePath).Replace('\\', '/') + "/";
        }

        public static string CwcRootPath()
        {
            return GetExeDirectory();
        }


        public static String ToolDir = GetExeDirectory() + "Utils/";



        public static String WORK_DIR;

        public static string Module = PathHelper.GetExeDirectory() + "Module/";
        public static string Updater = PathHelper.GetExeDirectory() + "Updater/";
        public static string Temp = PathHelper.GetExeDirectory() + "temp/";
        public static string Demos = PathHelper.GetExeDirectory() + "_Demos/";

        public static String WorkDirectory()
        {
            string _sPath = Path.GetDirectoryName(Application.ExecutablePath);
            DirectoryInfo parentDir = Directory.GetParent(_sPath.EndsWith("\\") ? _sPath : string.Concat(_sPath, "\\"));
            return parentDir.Parent.FullName.Replace('\\', '/') + "/";
        }




        public static String fNormalizePath(string _sPath)
        {

            _sPath = _sPath.Replace('\\', '/').Replace('\"', ' ').Trim().Replace("//", "/");

            if (_sPath[0] == '\'')
            {
                _sPath = _sPath.Substring(1);
            }
            return _sPath;


        }

        public static String fNormalizeFolder(string _sPath)
        {

            _sPath = fNormalizePath(_sPath);

            /*
            _sPath = _sPath.Replace('\\', '/').Replace('\"', ' ').Trim().Replace("//","/");

			if(_sPath[0] == '\''){
				_sPath =_sPath.Substring(1);
			}*/


            if (_sPath[_sPath.Length - 1] == '\'')
            {
                _sPath = _sPath.Substring(0, _sPath.Length - 1);
            }

            if (_sPath[_sPath.Length - 1] != '/')
            {
                _sPath += '/';
            }

            return _sPath;
        }
        public static String fNormalizeFolderAndRel(string _sPath)
        {
            _sPath = fNormalizeFolder(_sPath);

            if (_sPath.Length > 0 && _sPath[1] != ':')
            { //Is relative
                _sPath = ExeWorkDir + _sPath;
            }

            return _sPath;
        }


        public static string fFindFolder(string _sPath, string _sFilter, int _nMaxLevel = 9999, int _nLevel = 0)
        {

            try
            {
                foreach (var f in Directory.GetDirectories(_sPath, _sFilter, SearchOption.TopDirectoryOnly))
                {
                    return f;
                }

                if (_nLevel <= _nMaxLevel)
                {
                    foreach (var f in Directory.GetDirectories(_sPath))
                    {
                        string _sFind = fFindFolder(f, _sFilter, _nMaxLevel, _nLevel + 1);
                        if (_sFind != "")
                        {
                            return _sFind;
                        }
                    }
                }


            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path is not accessible: {0}", _sPath);
            }
            return "";
        }




    }

}
