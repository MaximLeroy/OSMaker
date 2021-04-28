using cwc.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VM_Viewer;

namespace cwc
{
    class Data
    {

        internal static bool bUpdateMode = false;
        internal static string sUpdateModeSrc = "";
        internal static string sUpdateVer;
        public static bool bNothingToBuild = false;


        public static string sVersion = "0.0.95";

        public static string sTRUE = "1";
        public static string sFALSE = "0";
        public static string fGetStrBool(bool _bCond)
        {
            if (_bCond)
            {
                return sTRUE;
            }
            else
            {
                return sFALSE;
            }
        }
        public static bool fIsDataTrue(string _sName)
        {
            if (aVarGlobal.ContainsKey(_sName))
            {
                return aVarGlobal[_sName] == Data.sTRUE;
            }
            if (aOption.ContainsKey(_sName))
            {
                return aOption[_sName] == Data.sTRUE;
            }
            return false;
        }


        public static bool bModeIDE = false;

        public static string[] CmdArgs;


        public static List<string> aAllInclude = new List<string>();



        public static string sArg = "";
        public static string sArgExpand = "";

        public static string sCmd = "";

        public static int nDontKillId = 0;


        public static Dictionary<string, string> aVarGlobal = new Dictionary<string, string>();
        public static Dictionary<string, string> aOption = new Dictionary<string, string>(); //Same as varGlobal but its saved settings



        public static List<String> aBrowser = new List<String>();
        public static List<String> aBrowserVersion = new List<String>();

        public static bool bNowBuilding = false;
        public static bool bDontExecute = false;

        public static Process MainProcess = Process.GetCurrentProcess();
        public static bool bConsoleMode = false;
        public static ConfigMng oConfigMng = null;

        

        public static bool bInGUI = false;


        public static Form oMsgBox = null;
        public static Form oMainUpdateForm = null;


        public static bool bWaitGUI = false;
        internal static bool bStartWithMessage;
        internal static bool bNonBuildCommand = false;

        public static bool bShowLibRT { get; internal set; }

        public static string sShowModule = "";

        //	public static  List<ModuleData> aModuleUsed  = new List<ModuleData>();

        public static List<string> aRequiredModule = new List<string>();
        public static List<string> aModuleList = new List<string>();
        public static bool bGUI = true;
        internal static bool bColor = true;

        public static int nCloseOnId = 0;
        public static bool bModuleIsRequired = false;
        public static bool bCheckLibRTRequired = true;

      


        public static string sToLauch = "";
        internal static bool bForceTestNextCmd;
        internal static bool bIWantGoToEnd = false;

        public static VM_GUI oGui = null;



        internal static void fGetMainArg()
        {
            Data.sArg = Environment.CommandLine.Trim();
            //     sArg = String.Join(" ", CmdArgs); //Fail to parse quotes

            //   fDebug("Environment.CommandLine: "+Environment.CommandLine);


            if (sArg[0] == '\"')
            { //Remove current file arg when loaded from file
                int _nFindEndQuote = sArg.IndexOf("\"", 1) + 1;
                //fDebug("_nFindEndQuote:"+_nFindEndQuote);
                sArg = sArg.Substring(_nFindEndQuote, sArg.Length - _nFindEndQuote).Trim();
            }
            //    Console.WriteLine(sArg);
            //Remove current name exe cwc
            if (sArg.Length >= 3 && sArg[0] == 'c' && sArg[1] == 'w' && sArg[2] == 'c')
            {
                sArg = sArg.Substring(3).Trim();

                //   Data.fSetWorkingDir(_sFullValue);
            }

            /*
            //First arg is current file
            if (Sys.oParentProcess.ProcessName == "cmd")
            { //Remove escape sequence
                Data.sArg = Data.sArg.Replace("\"|\"", "|");
            }
            */

        }



        public static string fGetGlobalVar(string _sVar, bool _bWeak = false)
        {
            //Output.TraceWarning("fGetGlobalVar " + _sVar);
            /*
            if(_sVar == "lPThread") {
            Output.TraceWarning("fGetGlobalVar " + _sVar);
             }*/
            if (Data.aVarGlobal.ContainsKey(_sVar))
            {
                return Data.aVarGlobal[_sVar];
            }
            if (_bWeak)
            {
                return "{" + _sVar + "}";//Keep original
            }
            return "";
        }
        public static void fSetGlobalVar(string _sVar, string _sValue)
        {

            _sValue = _sValue.Replace("\'", "").Replace("\"", "").Trim();
            if (!Data.aVarGlobal.ContainsKey(_sVar))
            {
                Data.aVarGlobal.Add(_sVar, _sValue);
                return;
            }
            aVarGlobal[_sVar] = _sValue;
            //			Output.TraceGood("Set_" + _sVar + ":" + _sValue);
        }



        public static void fSetDefaultVar(string[] _sArgs)
        {
            Data.CmdArgs = _sArgs;
            fSetDefaultVar();
        }

        public static void fSetDefaultVar()
        {

            Data.fSetGlobalVar("_sOpt", "Debug");
            Data.fSetGlobalVar("wBuildAnd", "Run");
        }






    }
}
