using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;


using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;


static class Program {

[DllImport("user32.dll")][return: MarshalAs(UnmanagedType.Bool)]
static extern bool SetForegroundWindow(IntPtr hWnd);

/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
static void Main()
{

    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run(new VM_Viewer.VM_GUI());
  //  return;
        /*

   bool createdNew = true;
   using (Mutex mutex = new Mutex(true, "MyApplicationName", out createdNew))
   {
      if (createdNew)
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new VM_Viewer.VM_GUI());
      }
      else
      {
         Process current = Process.GetCurrentProcess();
         foreach (Process process in Process.GetProcessesByName(current.ProcessName))
         {
            if (process.Id != current.Id)
            {
               SetForegroundWindow(process.MainWindowHandle);
               break;
            }
         }
      }
   }*/
}
}


/*
namespace VM_Viewer {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VM_GUI());
        }
    }
}
*/