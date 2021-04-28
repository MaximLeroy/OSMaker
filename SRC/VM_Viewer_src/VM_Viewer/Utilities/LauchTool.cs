using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

using System.Management;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VM_Viewer;
using CwcGUI;
using System.Drawing;

namespace cwc {
    public class LauchTool {

        /*
Usage: vmplayer.exe [OPTION...][--][configuration file]
where OPTIONS are:
    -v        Show program version
    -X        Enter full screen mode whern a virtual machine is powered on
    -U        Enter Unity when a virtual machine is powered on
    -s NAME=VALUE    Set preference variable NAME to VALUE
         */


       //  public MainForm oForm = null; //Delegate?

        public bool bRunAsAdmin = false;


        public bool bReturnError = false;
        public bool bReturnBoth = false;

        public bool bExeLauch = false;
        public bool bExeLauched = false;
     //   public bool bExited = false;
        public bool bStopAll = false;
        public bool bHasError = false;
        public bool bStartMinimised = false;
        public bool bStartHidden = false;
        
        public string sExePath = "";
        public string sExeName = "";
        public string sArg = "";
        public string sWorkPath = "";
        public bool bOutput  = true;
        public string sSourceFile  = "";
        public string sTarget  = "";

        public bool bExterneLauch = false;
        public bool bRedirectOutput = true;

public string sResult ="";
		public	string sError ="";

      public   delegate void dIExit(LauchTool _oTool);
      public   delegate void dIOut(LauchTool _oTool, string _sOut);
      public   delegate void dIError(LauchTool _oTool, string _sOut);

       public   dIExit dExit = null; 
       public   dIOut dOut = null; 
       public   dIError dError = null; 


		public bool bDontKill;
		public bool UseShellExecute = false;
		 public  Process ExeProcess = null;
      //  public ModuleLink oModule = null;

        public Object oCustom = null;

        public bool bRunInThread = true;
        public ProcessStartInfo processStartInfo = null;
		
        public bool bWaitEndForOutput  = false;

         public VM_GUI oFromWindow = null;


          [DllImport("user32.dll")]
    static extern int MapVirtualKey(int uCode, uint uMapType);

        [DllImport("User32.Dll")]
        public static extern Int32 PostMessage(IntPtr hWnd, int msg, int wParam, int lParam);


        [DllImport("user32.dll")] private static extern int GetWindowText(IntPtr hWnd, StringBuilder title, int size);




        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        public const Int32 WM_SYSCOMMAND = 0x112;
        public const Int32 SC_MINIMIZE = 0xF020;


        [DllImport("user32.dll")]
public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

public struct Rect {
   public int Left { get; set; }
   public int Top { get; set; }
   public int Right { get; set; }
   public int Bottom { get; set; }
}
        private static  int MAKELPARAM(int p, int p_2)
        {
            return ((p_2 << 16) | (p & 0xFFFF));
        }


        const int WM_KEYDOWN = 0x0100;
        const int VK_TAB = 0x09;
        const int CTRL_KEY = 0x11;


        [DllImport("user32.dll", SetLastError = true)]
static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
public const int VK_LCONTROL = 0xA2; //Left Control key code
public const int A = 0x41; //A key code
public const int C = 0x43; //C key code

  public const int VK_G = 0x47;
        public const int VK_CONTROL = 0x11;
        public const int VK_MENU = 0x12;
        
           [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        
        [DllImport( "user32.dll" )]
        public static extern int ShowWindow( IntPtr hWnd, uint Msg );

        public const UInt32 SW_HIDE = 0;
        public const UInt32 SW_SHOWNORMAL = 1;
        public const UInt32 SW_NORMAL = 1;
        public const UInt32 SW_SHOWMINIMIZED = 2;
        public const UInt32 SW_SHOWMAXIMIZED = 3;
        public const UInt32 SW_MAXIMIZE = 3;
        public const UInt32 SW_SHOWNOACTIVATE = 4;
        public const UInt32 SW_SHOW = 5;
        public const UInt32 SW_MINIMIZE = 6;
        public const UInt32 SW_SHOWMINNOACTIVE = 7;
        public const UInt32 SW_SHOWNA = 8;
        public const UInt32 SW_RESTORE = 9;

        const Int32 SC_RESTORE = 0xF120;



        public string fLauchExe(string _sExePath, string _sArg, string _sSourceFile = "", string _sTarget= "", bool _bDontKill = false) {
			  sTarget =  _sTarget;
                sSourceFile = _sSourceFile;
				sArg = _sArg;
				bDontKill = _bDontKill;

             //   string _sArg = "";
                bExeLauch = true;
	
                    sExePath = _sExePath;
					if(sWorkPath == "") {
						sWorkPath = _sExePath;
					}
                    sExeName =Path.GetFileName( Path.GetDirectoryName(sExePath));

			if(bRunInThread) {
						BackgroundWorker bw = new BackgroundWorker();

						bw.DoWork += new DoWorkEventHandler(
						delegate(object o, DoWorkEventArgs args) {
							fLauch();
						});
						bw.RunWorkerAsync();
			}else {
				return fLauch();
			}
			return "";
				
        }

		
       private  string fLauch() {
				
				string _sResult ="";
				string _sError ="";
                 /*
				if(!File.Exists(sExePath)){
					Output.TraceError("Unable to lauch: " + sExePath);
				}*/
				
                     processStartInfo = new ProcessStartInfo(sExePath, sArg);
                    processStartInfo.UseShellExecute = UseShellExecute;


                   ExeProcess = new Process();




            if (bStartMinimised){

                processStartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            }
            if (bStartHidden)
            {
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }

            if (bOutput && !bExterneLauch) {
         
							//processStartInfo.UseShellExecute = false;
							processStartInfo.UseShellExecute = false;
                              processStartInfo.CreateNoWindow = bHidden;
                 
  

						//		processStartInfo.CreateNoWindow = true;
							processStartInfo.RedirectStandardOutput = bRedirectOutput;
							processStartInfo.RedirectStandardError = true;
							processStartInfo.RedirectStandardInput = true;

                    }else {

               //   processStartInfo.CreateNoWindow = true;
                      //    processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        //    ExeProcess.StartInfo.CreateNoWindow = true;
                        processStartInfo.UseShellExecute = true;
                        processStartInfo.RedirectStandardOutput = false;
                        processStartInfo.RedirectStandardError = false;
                        processStartInfo.RedirectStandardInput = false;

                  }

                     
                    if(bRunAsAdmin) {
                //bRedirectOutput = false;
                 //processStartInfo.UseShellExecute = true;
                         processStartInfo.Verb = "runas"; //Run as admin
                    }

                   


                    ExeProcess.StartInfo = processStartInfo;
					 processStartInfo.WorkingDirectory = Path.GetDirectoryName(sWorkPath); 

                    bool processStarted = false;

                    if (bStopAll) {
                		bExeLauched = true;
                        bExeLauch = false;
                        return "";
                    }

         try {
                    if (bHasError){
                        return "";
                    }

                Debug.fTrace("--------Lauch: " +   sExePath + "  " + processStartInfo.Arguments  );

                if(!File.Exists( sExePath)) {
                   // Output.TraceError("No executable file found to lauch: \"" +  sExePath + "\" " + processStartInfo.Arguments);
                    Debug.TraceError("No executable file found to lauch: \"" +  sExePath + "\" " + processStartInfo.Arguments);
                     return "";
                }

                   //ExeProcess.StartInfo.CreateNoWindow = true;
          

                try{
                        processStarted = ExeProcess.Start();
                } catch (Exception e) {
                    Debug.TraceError("Unable to lauch: " + sExePath + " : " + e.Message);
                }



                ////////////////// OUTPUT /////////////////////////////
                
                if (bOutput && !bExterneLauch && !bWaitEndForOutput)
                {
                    ProcessOutputHandler outputHandler = new ProcessOutputHandler(this);
                    if (bRedirectOutput)
                    {
                        Thread stdOutReader = new Thread(new ThreadStart(outputHandler.ReadStdOut));
                        stdOutReader.Start();
                    }

                    Thread stdErrReader = new Thread(new ThreadStart(outputHandler.ReadStdErr));
                    stdErrReader.Start();
                    //stdOutReader.Priority = ThreadPriority.AboveNormal;
                    ExeProcess.WaitForExit(); //Stop here
                }
                if (bOutput && bRedirectOutput)
                {
                    _sResult += ExeProcess.StandardOutput.ReadToEnd();
                }
                if (bOutput)
                {
                    _sError += ExeProcess.StandardError.ReadToEnd();
                }
                if (bWaitEndForOutput) { ExeProcess.WaitForExit(); }

                if (bRedirectOutput && dOut != null && _sResult != "")
                {
                    dOut(this, _sResult);
                }
                if (dError != null && _sError != "")
                {
                    dError(this, _sError);
                }
                ///////////////////////////////////////////////////////////





                if (bDontKill) {
                       //     Data.nDontKillId = ExeProcess.Id;
                        }



                bExeLauched = true;
                if (oFromWindow != null) {


                    Console.Write("\n ExeProcess.MainWindowHandle: " +  ExeProcess.MainWindowHandle);
            
                    while (ExeProcess.MainWindowHandle == IntPtr.Zero) {
                        Thread.Sleep(1);
                        ExeProcess.Refresh();
                    }
                  
                     // ShowWindow(ExeProcess.MainWindowHandle, SW_HIDE);

                   //   ShowWindow(ExeProcess.MainWindowHandle, SW_RESTORE);
                    //    ShowWindow(ExeProcess.MainWindowHandle, SW_HIDE);

                    if(sArg != "") {
                        string _sTitle = ExeProcess.MainWindowTitle;
                        while (bExeLauched && !ExeProcess.HasExited) {
                            if (oFromWindow != null) {

                                // WinApi.GetWindowInfo
                              //  Console.WriteLine("Title: " + ExeProcess.MainWindowTitle);
                                ExeProcess.Refresh();
                                  //  break;
                                if (_sTitle != ExeProcess.MainWindowTitle) {
                                    break;
                                }

                                /*
                                Rect r = new Rect();
                                GetWindowRect(ExeProcess.MainWindowHandle, ref r);
                                if ((r.Left != t.Left || r.Top != t.Top || r.Right != t.Right || r.Bottom != t.Bottom))
                                {
                                    t = r;
                                    _nCountRes++;
                                    Console.WriteLine(r.Left + ":" + r.Right + ":" + r.Top + ":" + r.Bottom);
                                    if (_nCountRes == 2) {
                                //        break;
                                    }
                              
                                }*/
                            }
                            Thread.Sleep(10);//4 frames
                        }
                  

                    Thread.Sleep(1);
                    Thread.Sleep(1000); //Remove Popup

                    }
                    oFromWindow.fSetParent(ExeProcess.MainWindowHandle);

                     ShowWindow(ExeProcess.MainWindowHandle, SW_SHOW);
                }


                sResult = _sResult;
		    	sError = _sError;




                    while (bExeLauched && !ExeProcess.HasExited  ) {
                        Thread.Sleep(1);                     
                    }
                if (dExit != null)
                {

                    dExit(this);
                }
                        
                    }  catch (Exception ex){
							Debug.fTrace(ex.Message);
					 }

                    bExeLauch = false;


                      //           Debug.fTrace("--------------------------- 7z finish -------------------------");
	
			if(bReturnBoth){
				return _sResult + "\n" + _sError;
			}else{
				if(!bReturnError){
					return _sResult;
				}else{
					return _sError;
				}
			}
		}









public bool bSanitize = false;
        public bool bHidden = false;

        internal void fEnd() {
		  //  Output.Trace("\f18--Try to Close--");
			bStopAll = true;

            if(dExit != null){ dExit(this);};
            //SysAPI.KillProcessAndChildren( 0); //TODO more gentle with -- SEND WM_CLOSE -- ?
           // SysAPI.KillProcessAndChildren( Data.MainProcess.Id ); //TODO more gentle with -- SEND WM_CLOSE -- ?


            while(!ExeProcess.HasExited ) {
            //while(!ExeProcess.HasExited  && Base.bAlive) {
                Thread.Sleep(1);
                }
     

            return;


///////////////////////////////////////////////

             if(bSanitize) {
                List<Process>  children = GetChildProcesses(ExeProcess);
                foreach(Process _procChild in children) {
                  // Debug.fTrace("---------------ID: " + _procChild.Id.ToString());
             
                  //      Debug.fTrace("sExePath: " +sExePath);

                    
                    /* //Try to nurge, (not the besst way)
                     ProcessStartInfo processStartInfo = new ProcessStartInfo(sExePath, " -nudge " + _procChild.Id.ToString());
                    processStartInfo.UseShellExecute = false;

                    ExeProcess.StartInfo = processStartInfo;
                    processStartInfo.WorkingDirectory = Path.GetDirectoryName(sWorkPath); //_sExePath PathHelper.ModulesDir + "/Emscripten_x64/python/2.7.5.3_64bit/"; //TODO
                    ExeProcess.Start();
                    */

                    try{
                         if(_procChild.CloseMainWindow()) { //Todo another process  // SEND WM_CLOSE 
							//	Debug.fTrace("");
							 Debug.fTrace("\f4C-- SEND WM_CLOSE --");
                             //   _procChild.WaitForExit(1000); //if hang
                          }else {
							 if(!_procChild.HasExited) {
								 Debug.fTrace("\f4C-- KILL --");
								_procChild.Kill();
                                if(dExit != null){ dExit(this);};
							}
						}
                       // _procChild.Close();
                     }catch(Exception Ex) { }

           
                   // .CloseMainWindow();


                 //   _procChild.WaitForExit(1000); //if hang


                 //      _procChild.WaitForExit(1000); //if hang
                 //    _procChild.Kill();
                   //  _procChild.CloseMainWindow();
                  //   _procChild.Close();
                   //  ExeProcess.Clos();
                  //  _procChild.Kill();
                }

            }else { 

           List<Process>  children = GetChildProcesses(ExeProcess);
                foreach(Process _procChild in children) { //TODO recursive of child process?

                try{

                    //Output.TraceError("Try to kill");
                    
                    /*
                     if (ExeProcess.MainWindowHandle == IntPtr.Zero) {

                       // ExeProcess.CloseMainWindow();
                           ExeProcess.Kill();
                           ExeProcess.Close();
                     }else {
                     */
                    if(!_procChild.HasExited) {
                           //  Output.TraceError("not HasExited");

                            try{if(_procChild.CloseMainWindow()) { //Todo another process  // SEND WM_CLOSE 
                                _procChild.WaitForExit(1000); //if hang
                            } }catch(Exception Ex) { }


                            if(!_procChild.HasExited) {
                               // Output.TraceError("alwaus not HasExited");
                               //  Output.Trace("\f4C-- KILL --");
                                _procChild.Kill();
                                if(dExit != null){ dExit(this);};


                            }
                    }



                            //ExeProcess.Close();
                     // }
               }catch(Exception Ex) { }

            

             }
            }

              //  while(!ExeProcess.HasExited  && Base.bAlive) {
                while(!ExeProcess.HasExited ) {
                 Thread.Sleep(1);
                 }
               //             Output.Trace("\f18-Finish-");
           }
        


          public static   List<Process>  GetChildProcesses(Process process) {
            /*
                List<Process> children = new List<Process>();
                ManagementObjectSearcher mos = new ManagementObjectSearcher(String.Format("Select * From Win32_Process Where ParentProcessID={0}", process.Id));
                foreach (ManagementObject mo in mos.Get())  {
                    children.Add(Process.GetProcessById(Convert.ToInt32(mo["ProcessID"])));
                }
             
                return children;
                   */
                   return null;
            }





















        public static void fAppOutput(LauchTool _oThis,string _sOut) {

      //       lock(Data.oLockOutPut) {
				
				     if(_oThis.dOut != null) {
                             _oThis.dOut(_oThis, _sOut);
                    }else {
							  /*
							if(_sOut.Length > 3 && _sOut[3] == '%') {
							  Console.Write( "\r\r" + _sOut.Substring(4,_sOut.Length-4) );
							}else { */
							lock(Debug.oLockOutPut) {//???
							 Debug.fTrace(_sOut );
								}
						   // }
					}
             
           // }
        }

		 public static void fAppError(LauchTool _oThis,string _sOut) {
				// lock(Data.oLockError) {
						 if(_oThis.dError != null) {
								 _oThis.dError(_oThis, _sOut);
						}else {
								  /*
								if(_sOut.Length > 3 && _sOut[3] == '%') {
								  Console.Write( "\r\r" + _sOut.Substring(4,_sOut.Length-4) );
								}else { */
								Debug.fTrace(_sOut );
							   // }
						}
             
				//}
			}




      private void fExited(object sender, System.EventArgs e) {
			
         //  lock(Data.oLockOutPut) {
               // Debug.fTrace(" -- Finish --" );
             //   Debug.fTrace("Exit time:    {0}\r\n" +  "Exit code:    {1}\r\nElapsed time: {2}", ExeProcess.ExitTime, ExeProcess.ExitCode);
         // }
	   }


		   public  void fSend(string _sMsg) {
                while (bExeLauch && !bExeLauched) { //Wait for starting
                    Thread.Sleep(1);
                }
                if(bExeLauch){
			     ExeProcess.StandardInput.WriteLine(_sMsg ); ///bug
                }
			   // ExeProcess.StandardInput.WriteLine(_sMsg + "\n"); ///!!GDB dont like "\n" 
			}
/*
		public bool fProcessIsRunning(){
			  bool isRunning;
			  try {
				isRunning = !ExeProcess.HasExited && ExeProcess.Threads.Count > 0;
			  }
			  catch(SystemException sEx)
			  {
				isRunning = false;
			  }
			  
			  return isRunning;
		  } */






    }




public class ProcessOutputHandler
{
    public Process proc { get; set; }
    public string StdOut { get; set; }
    public string StdErr { get; set; }

		public LauchTool oTool;

    /// <summary>  
    /// The constructor requires a reference to the process that will be read.  
    /// The process should have .RedirectStandardOutput and .RedirectStandardError set to true.  
    /// </summary>  
    /// <param name="process">The process that will have its output read by this class.</param>  
    public ProcessOutputHandler(LauchTool _oTool )
    {
		oTool = _oTool;
        proc = _oTool.ExeProcess;

        StdErr = "";
        StdOut = "";
   //     Debug.Assert(proc.StartInfo.RedirectStandardError, "RedirectStandardError must be true to use ProcessOutputHandler.");
  //      Debug.Assert(proc.StartInfo.RedirectStandardOutput, "RedirectStandardOut must be true to use ProcessOutputHandler.");
    }

 
    public void ReadStdErr() {
        string _sLine;
		if(oTool.dError != null){
			while (!proc.HasExited){
				_sLine = proc.StandardError.ReadLine();
				if (_sLine != ""){
						oTool.dError(oTool, _sLine);
				}else{
					Thread.Sleep(1);
				}
			}
		}
    }
    public void ReadStdOut() {
        string _sLine;
		if(oTool.dOut != null){
			while (!proc.HasExited){

				_sLine = proc.StandardOutput.ReadLine();
		
				if (_sLine != ""){
						oTool.dOut(oTool, _sLine);
				}else{
					Thread.Sleep(1);
				}
			}
		}
    }

/*
    public void ReadStdOut() {
        string line;
		  while (!proc.HasExited){
			Thread.Sleep(1);

				line = proc.StandardOutput.ReadLine();
			if (line != ""){
            StdOut += line;
 			Console.WriteLine("OO:" + line);
        }}
    }*/

}




















}
