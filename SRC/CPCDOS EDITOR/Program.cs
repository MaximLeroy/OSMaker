using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OSMaker
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start();
        }


        public static void Start()   // <-- must be marked public!
        {
            
            Application.Run(new SplashScreen1());
        }
    }
}