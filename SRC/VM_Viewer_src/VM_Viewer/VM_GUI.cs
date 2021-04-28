using cwc;
using cwc.Utilities;
using CwcGUI;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static cwc.LauchTool;
using MetroFramework.Forms;

namespace VM_Viewer {
    public partial class VM_GUI : DocumentC {

          LauchTool oConvert = null;
          LauchTool oLauch = null;
          LauchTool oLDrive = null;
         
          LauchTool oLoadedDrive = null;
          LauchTool oInstallDriver = null;
          LauchTool oKvmAction = null;

        string sConvertToFile = "";
        string sVM_Path = "";
        string sLauched_Path = "";

        LauchTool oLFolder = null;
        ConfigMng oConfig;
        string sMountDirectory = "";

       //string sFilePath =  @"D:\Data\autre\_CpcD\[PUBLIC] CpcdosOS2.1 BETA1.1 [JUIL.2019]\VM\PUBLIC Cpcdos OSx.vmx";
        internal bool bCreated =false;

    //    string sFilePath =  @"E:/MyVM/CpcDos/My_Cpcdos OSx.vmx";
        

        public VM_GUI() {
            InitializeComponent();
           // cbPath.Text = sFilePath;
            
        }

        private void fSetBtnLauch(string _sText)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                if (bLauching)
                {
                    btnLauch.Text = _sText;
                }
            });
        }

        public bool bLauching = false;
        public Color oOriColor;
        public string sOriText;
       
        private void fStartLaodingLauch(){
            if(bLauching) {return; }
            btnLauch.Enabled = false;
            btnEdit.Enabled = false;
            oOriColor = btnLauch.BackColor;
            sOriText = btnLauch.Text;
            btnLauch.Text = "";
            btnLauch.BackColor = Color.DarkKhaki;
            int _nDotCount = 0;

            btnLauch.TextAlign = ContentAlignment.MiddleLeft;
            bLauching = true;

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args) {
                while (bLauching)
                    {
                        Thread.Sleep(200);
                        _nDotCount++;
                        if (_nDotCount > 9)
                        {
                            _nDotCount = 1;
                        }
                        string _sDot = "";
                        for(int i = 0; i < _nDotCount; i++) {
                            _sDot += ">";
                        }
                        fSetBtnLauch(_sDot);

                    }

            });
            bw.RunWorkerAsync();

            
            btConfig.Enabled = false;
            btnPause.Enabled =true;
            btnStop.Enabled =true;
            btnReset.Enabled = true;


        }
        private void fStopLaodingLauch()
        {
            this.BeginInvoke((MethodInvoker)delegate {
                bLauching = false;
                btnLauch.Enabled = true;
                btnEdit.Enabled = true;
                btnLauch.BackColor = oOriColor;
                btnLauch.Text = sOriText;

                btConfig.Enabled =true;
                btnPause.Enabled =false;
                btnStop.Enabled =false;
                btnReset.Enabled = false;

            });
        }

        private void fConvertFinish(LauchTool _oTool){

            if(File.Exists(sConvertToFile) ) {
                fLauchVMX(sConvertToFile);
            }else{
                fStopLaodingLauch();
            }
			this.BeginInvoke((MethodInvoker)delegate {
				cbPath_TextChanged(null, null); //update listed drive
			});
        }


        private void fLauchVMX(string _sPath) {

            if(_sPath != "" && !File.Exists(_sPath))
            {
                fOut(null, "Error >> File not exist: "+  _sPath);
            }

              fStartLaodingLauch();
              sLauched_Path = _sPath;
		
            if(_sPath == "" || !cbFullScreen.Checked) { //Normal Mode
                bFullScreenMode = false;
                oLauch = new LauchTool();
           
                //oLauch.dOut = new LauchTool.dIOut(fOut);
           	    oLauch.dExit = new LauchTool.dIExit(fLauchClose);
                oLauch.oFromWindow = this;
                oLauch.bOutput = false;
                oLauch.bStartMinimised  =true;

                if(ckbAdmin.Checked) {
                    // oLauch.bRunAsAdmin = true;
                }
                 fOut(null, "Lauch[vmplayer]: "+  _sPath);
                if(_sPath == "") {
                    oLauch.fLauchExe(sVM_Path + "vmplayer.exe", "");
                }else{
                    oLauch.fLauchExe(sVM_Path + "vmplayer.exe", " " + "\""  +_sPath + "\"");
                }

            }else { //FULLSceen Mode
                bFullScreenMode = true;
                oLauch = new LauchTool();
           
                //oLauch.dOut = new LauchTool.dIOut(fOut);
           	    oLauch.dExit = new LauchTool.dIExit(fLauchClose);
               // oLauch.oFromWindow = this;
                oLauch.bOutput = false;
               // oLauch.bStartMinimised  =true;

                if(ckbAdmin.Checked) {
                    // oLauch.bRunAsAdmin = true;
                }

                fOut(null, "Lauch[vmplayer-kvm]: "+  _sPath);
                oLauch.fLauchExe(sVM_Path + "vmware-kvm.exe", " " + "\""  +_sPath + "\"");
            }
			

            //oLauch.fLauchExe(sVM_Path + "vmplayer-kvm.exe", " " + "\""  +_sPath + "\"");
            //ovftool.exe --lax source.ova destination.vmx

        }




        public string fGetRegKey() {
            try{
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes\Applications\vmplayer.exe\shell\open\command"))
            {
            if (key != null)
            {
                Object o = key.GetValue("");
                if (o != null)
                {
                     return o.ToString();
                   // Version version = new Version(o as String);  //"as" because it's REG_SZ...otherwise ToString() might be safe(r)
                    //do what you like with version
                }
            }
            }
            }
            catch (Exception ex)  //just for demonstration...it's always best to handle specific exceptions
            {
            //react appropriately
                return "";
            }
            return "";
        }


        public void fFound_VM_Ware(bool _bDialog = true) {
            //Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Applications\vmplayer.exe\shell\open\command


             string _sVM_Path = "";
            if(File.Exists(@"C:\Program Files (x86)\VMware\VMware Player\vmplayer.exe")) {
                _sVM_Path= @"C:\Program Files (x86)\VMware\VMware Player\vmplayer.exe";
            }
              if(File.Exists(@"C:\Program Files\VMware\VMware Player\vmplayer.exe")) {
                _sVM_Path=   @"C:\Program Files\VMware\VMware Player\vmplayer.exe";
            }

            if(_sVM_Path == "") {//Try to get regkey
                try { 
                    string _sKey = fGetRegKey();
                    if(_sKey.Length > 12) {///"vmplayer.exe".length
                
                        int _nBegin = _sKey.IndexOf('"')+1;
                        int _nEnd = _sKey.IndexOf('"',_nBegin );
                        if(_nBegin != -1 && _nEnd != -1) {
                    
                            string _sResult = _sKey.Substring(_nBegin,_nEnd- _nBegin);
                            if(File.Exists(_sResult)) {
                                _sVM_Path = _sResult;
                            }else{
                                if(_sKey != "") { fOut(null, "Unable to use RegKey: " +_sVM_Path );}
                            }
                  
                        }
                    }
                }catch(Exception e) { fOut(null, "Error finding VM Registry:" + e.Message); }
            }

            if(_sVM_Path == "" && _bDialog) {
               fOut(null, "Please install VMware Workstation player (free)");

               DialogResult dr = MessageBox.Show("Please install VMware Workstation player (free)",  "Install Player", MessageBoxButtons.YesNo);
                switch(dr)
                {
                    case DialogResult.Yes:
                           System.Diagnostics.Process.Start("https://www.vmware.com/go/downloadworkstationplayer");
                        break;
                    case DialogResult.No:
                         fOut(null, "Error: The vmplayer.exe is not found");
                        break;
                }

                return;
            }

             sVM_Path = Path.GetDirectoryName(_sVM_Path) + "\\";

        }


        public string fGetVMX(string _sSource){
            string _sSrcDir = Path.GetDirectoryName(_sSource);
            string _sName =  Path.GetFileNameWithoutExtension(_sSource);
            return _sSrcDir + "\\" + _sName + ".vmx";

        }

        public void fLauch(string _sPath)
        {

            this.BeginInvoke((MethodInvoker)delegate  {
           
            if(_sPath == ""){
                 fOut(null, "Lauch Library "+  _sPath);
                 fLauchVMX("");
             }


            fOut(null, "Lauch: "+  _sPath);
            if(File.Exists(_sPath)) {
                 ConfigMng.oConfig.fAddRecent(_sPath);
            }
            string _sType = Path.GetFileName(_sPath);
            _sType = _sType.Substring(_sType.LastIndexOf('.')+1);
            Console.WriteLine("_sType :" +  _sType);
            switch (_sType) {
                case "vmx":
                   fLauchVMX(_sPath);
                break;

                case "ova":
                case "ovf":
                    
                    string _sDest =  fGetVMX(_sPath);
                    sConvertToFile = _sDest;

                    if(!File.Exists(_sDest) ) {
                        fStartLaodingLauch();
                        //!!!!Generate .vmx!!!!!

                        oConvert = new LauchTool();
                   	    oConvert.dOut = new LauchTool.dIOut(fOut);
                   	    oConvert.dError = new LauchTool.dIError(fOut);
           	            oConvert.dExit = new LauchTool.dIExit(fConvertFinish);
                        oConvert.bHidden = true;

                        oConvert.bOutput = true;
                        //oConvert.bStartMinimised  =true;
                       // oLauch.UseShellExecute = true;
                        //oLauch.fLauchExe(@"C:\Program Files (x86)\VMware\VMware Player\vmplayer.exe", "-X " + "\"E:/MyVM/CpcDos/My_Cpcdos OSx.vmx\"");

                        if(ckbAdmin.Checked) {
                           // oLauch.bRunAsAdmin = true;
                        }

                        ConfigMng.oConfig.fAddRecent(_sPath);
                        fOut(null, "Convert: "+  _sPath);
                        oConvert.fLauchExe(sVM_Path + @"OVFTool\ovftool.exe", "--lax " + "\""  + _sPath + "\" \"" + _sDest + "\"");	

                    } else{
                       fLauchVMX(_sDest);
                    }
                break;

            }

            });
        }


        public void fConvertOva(string _sPath, string _sDest){
            fFound_VM_Ware();
          oConvert = new LauchTool();
            oConvert.dOut = new LauchTool.dIOut(fOut);
            oConvert.dError = new LauchTool.dIError(fOut);
           	oConvert.dExit = new LauchTool.dIExit(fConvertFinish);
            oConvert.bHidden = true;

            oConvert.bOutput = true;

            fOut(null, "Export: "+   "\""  + _sPath  + "\" \"" + _sDest + "\"");
            oConvert.fLauchExe(sVM_Path + @"OVFTool\ovftool.exe", "\""  + _sPath  + "\" \"" + _sDest + "\"");

        }

      //   "E:\CpcDosAss\MyVM\PUBLIC Cpcdos OSx.vmx" test.ova







        public void fLauchBtn(string _sPath)
        {
            btnLauch.Enabled = false;
           fFound_VM_Ware();

            /*
              Console.WriteLine("Path :  "  +  cbPath.Text);
            Console.WriteLine(WinApi.GetFullPathFromWindows(cbPath.Text));
            Console.WriteLine(WinApi.GetFullPathFromWindows("vmplayer.exe"));
            return;
            */
          // if(WinApi.GetFullPathFromWindows("imdisk.exe") != null) {

           // }


            fUnMount(sMountDirectory);
            //!!!TODO wait to completly unmont!!!!!

             try {
                    /////// Delete directory  ///////////
                    BackgroundWorker bw = new BackgroundWorker();
					bw.DoWork += new DoWorkEventHandler(
					delegate(object o, DoWorkEventArgs args) {

                        int _nTimeOut = 0;
                        while(!bIsUnMount)
                        {
                            _nTimeOut++;
                            Thread.Sleep(1);
                            if(_nTimeOut > 3000)
                            {
                                break;
                            }
                        }

                         if(_nTimeOut > 3000){
                             fOut(null, "TimeOut, Unable to unmount drive!");
                             this.BeginInvoke((MethodInvoker)delegate  { btnLauch.Enabled = true; });
                         }else{
                             fLauch(_sPath);
                        }

                       
                    });
                 bw.RunWorkerAsync();

            }catch(Exception _e){}


        }



     
       public void 	fOut(LauchTool _oTool, string _sOut){
         //   Debug.fTrace("O: " + _sOut);
           this.BeginInvoke((MethodInvoker)delegate  {
               rtOutput.AppendText(_sOut + "\n");
               rtOutput.SelectionStart = rtOutput.Text.Length;
              // rtOutput.ScrollToCaret();
           });
        }

        public  void fLauchClose(LauchTool _oTool){
                /*
             this.BeginInvoke((MethodInvoker)delegate  {
                      Activate();
                    //...
                    TopMost = true;
                    Show();
                    BringToFront();
                    TopMost = false;
           
             });*/
        }


          Point rtStartPos;
          Size rtStartSize;
             int nTtitleHeight=0;
         private void VM_GUI_Load(object sender, EventArgs e) {
             ///////Ini State///
             mnViewer.ForeColor = Color.WhiteSmoke; 
             oOriColor = btnLauch.BackColor;
             sOriText = btnLauch.Text;
             fStopLaodingLauch();
             fUpdateRtState();
            /////////////////////


             Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
           nTtitleHeight = screenRectangle.Top - this.Top;
            nTtitleHeight = 0;
           // fOut(null, "nTitleHeight: " + nTtitleHeight);


            oConfig = new ConfigMng();
            oConfig.LoadConfig(this);
            if (ConfigMng.bLoadFailed)
            {
                    ConfigMng.oConfig.vStartSize = Size;
                    ConfigMng.oConfig.vStartPos = Location;
            }

            if (ConfigMng.oConfig.bMaximize)
            {
                WindowState = FormWindowState.Maximized;
                fMaximizedState();
            }

            fLoadRecent();
            bCreated = true;
            
        }

       public  void fToHide() {
             this.BeginInvoke((MethodInvoker)delegate  {
            Hide();
             });
        }

        internal void fSetPos(LauchTool.Rect vmRect) {
            //Console.WriteLine("fSetPos!!");
            this.BeginInvoke((MethodInvoker)delegate  {
            
                    Left = vmRect.Left;
                    Top = vmRect.Top;
                  //  Width = vmRect.Right - vmRect.Left;
                  //  Height = vmRect.Bottom - vmRect.Top;
             });
        }

        internal void fLoadRecent()
        {
            this.BeginInvoke((MethodInvoker)delegate {


                /*
                List<ToolStripItem> aToRem = new List<ToolStripItem>();

                ///// Clear ///
                foreach (ToolStripItem _oItem in cbPath.Items)
                {
                    //Console.WriteLine("aa" + _oItem.Tag);
                  //  if (!(_oItem is ToolStripSeparator)) {
                        if (_oItem.Tag != null)
                        {
                            aToRem.Add(_oItem);
                        }
                   // }
                }
                foreach (ToolStripItem _oItem in aToRem)
                {
                    lauchToolStripMenuItem.DropDownItems.Remove(_oItem);
                }
                //////
                */
                cbPath.Items.Clear();

                try
                {
                  int _nCount = 0;
                    foreach (string _sRecent in ConfigMng.oConfig.aRecent)
                    {
                        if(File.Exists(_sRecent)) {
                            _nCount++;
                            cbPath.Items.Add(_sRecent);
                        }

                        /*
                            * 
                        ToolStripMenuItem _oNew = new ToolStripMenuItem(_sRecent);
                        _oNew.Tag = _sRecent;

                        string _sName = _sRecent;
                        string _sPath = _sRecent;
                        int _nLastIndex = _sName.LastIndexOf("/");
                        if (_nLastIndex != -1)
                        {
                            _sPath = _sName.Substring(0, _nLastIndex);
                            _sName = _sName.Substring(_nLastIndex);
                        }
                        _nLastIndex = _sPath.LastIndexOf("/");
                        if (_nLastIndex != -1)
                        {
                            _sName = _sPath.Substring(_nLastIndex + 1) + _sName;
                        }

                        _oNew.Text = _sName;
                        lauchToolStripMenuItem.DropDownItems.Add(_oNew);
                        
                        _oNew.Click += fRecentClick;
                        */
                    }
                    if(_nCount != 0) {
                         cbPath.SelectedIndex = 0;
                    }
                    

                }
                catch (Exception e) { Console.WriteLine(e.Message); };


            });


        }

     

        public IntPtr nVM_Handle = IntPtr.Zero;
        internal void fSetParent(IntPtr _nHandle)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                nVM_Handle = _nHandle;
                //WinApi.ShowWindow(nVM_Handle, WinApi.SW_RESTORE);
                ///   Thread.Sleep(1000);
                ///   WinApi.ShowWindow(_nHandle, LauchTool.SW_MAXIMIZE);
                //  Thread.Sleep(1000);
                // ResizeConsole(true);
                //WinApi.SetForegroundWindow(nVM_Handle);
               

                WinApi.SetParent(_nHandle, Handle);
                WinApi.SetForegroundWindow(nVM_Handle);

                int style = WinApi.GetWindowLong(_nHandle, WinApi.GWL_STYLE);
                WinApi.SetWindowLong(_nHandle, WinApi.GWL_STYLE, (style & ~WinApi.WS_CAPTION));



                WinApi.ShowWindow(_nHandle, LauchTool.SW_MAXIMIZE);

                ResizeConsole(Handle,nVM_Handle);

                WinApi.SetForegroundWindow(Handle);
                /*
                                WinApi.keybd_event(VK_CONTROL, VK_CONTROL, 0, 0); // Control Down
                                PostMessage(nVM_Handle, WinApi.WM_KEYDOWN, WinApi.VK_G, 0); // G
                                WinApi.keybd_event(VK_CONTROL, VK_CONTROL, 2, 0); // Control Up

                */

            });

            fStopLaodingLauch();
            return;

            /*

    BackgroundWorker bw2 = new BackgroundWorker();
            bw2.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args) {
                Thread.Sleep(3000);
                this.BeginInvoke((MethodInvoker)delegate {
                    WinApi.SetForegroundWindow(Handle);
                    WinApi.SetForegroundWindow(nVM_Handle);
                    WinApi.keybd_event(VK_CONTROL, (byte)WinApi.MapVirtualKey(VK_CONTROL, 0), 0, 0); // Control Down
                    PostMessage(nVM_Handle, WinApi.WM_KEYDOWN, WinApi.VK_G, 0); // G
                    WinApi.keybd_event(VK_CONTROL, (byte)WinApi.MapVirtualKey(VK_CONTROL, 0), 2, 0); // Control Up
                });

            });
            bw2.RunWorkerAsync();



            //BUG remover
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args) {

                Thread.Sleep(2000);
                int i = 2;
                while (i > 0)
                {
                    i--;
                    this.BeginInvoke((MethodInvoker)delegate {
                        ResizeConsole(true);
                        ResizeConsole();
                    });
                    Thread.Sleep(1000);
                }
            });
            bw.RunWorkerAsync();
            */
        }


        public void ResizeConsole(IntPtr _Handle, IntPtr _CtrlHandle, int _nBorder = 2, Control _oCtrl = null, int _nOffset  = 0)
        {

            this.BeginInvoke((MethodInvoker)delegate {
               // int _nBorder = 2;



      //  Console.WriteLine("----------aaa : " + _nOffset);




            Rectangle clientRect = WinApi.GetClientRect(_Handle);
         

            

            //  this.BeginInvoke((MethodInvoker)delegate {
            //   WinApi.ShowWindow(cmdHandle, WinApi.SW_SHOWMAXIMIZED);
            if (_CtrlHandle != IntPtr.Zero) {
                 
                        WinApi.ResizeClientRectTo(_CtrlHandle , new Rectangle(new Point(clientRect.Left + _nBorder, clientRect.Top - _nOffset), new Size(new Point(clientRect.Right - _nBorder*2, clientRect.Bottom - _nBorder*1+_nOffset))));
                       // WinApi.ResizeClientRectTo(nVM_Handle, clientRect);
                    
                }
          

         

                /*
                Point _ptTest = new Point();
                 WinApi.ClientToScreen(_CtrlHandle, ref _ptTest);
            //Console.WriteLine("aaa "+ rect);


                 Console.WriteLine("bbb "+ _ptTest);
                 WinApi.ClientToScreen(_Handle, ref _ptTest);
                 Console.WriteLine("cccc "+ _ptTest);
                 */


                if(_oCtrl != null) {
                    _oCtrl.Invalidate();
                    _oCtrl.Update();
                    _oCtrl.Refresh();

                }

                 Invalidate();
                Update(); 
                Refresh();
               // Invalidate();
                



            });


        }

        private void VM_GUI_SizeChanged(object sender, EventArgs e)
        {

        }

        private void VM_GUI_Resize(object sender, EventArgs e)
        {
            ResizeConsole(Handle,nVM_Handle);
            if(nFolderHandle != null) {
                 ResizeConsole(tbFolder.Handle, nFolderHandle,0, tbControl, nTtitleHeight);
            }
            if (bCreated)
            {

                if (!fIsMaximizeChange())
                {
                    ConfigMng.oConfig.vStartSize = Size;

                }

            }
        }
        public bool NeedRestore = false;
        FormWindowState LastWindowState = FormWindowState.Minimized;
        private bool bFullScreenMode;

        public bool fIsMaximizeChange()
        {


            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                {
                    fMaximizedState();

                }
                if (WindowState == FormWindowState.Normal)
                {
                    // Restored!

                   // msMenu.Top = nInitialPosTop;
                   // msMenu.Left = Width - nInitialPosLeft;
                    //    Console.WriteLine("Restored " +    ConfigMng.oConfig.vStartPos);

                    Location = new Point(-999999, -999999);//Why??
                    Location = ConfigMng.oConfig.vStartPos; //Restore previous loc

                    return false;
                }
                return true;
            }
            return false;

        }
        public void fMaximizedState()
        {
            // Maximized!
           // msMenu.Top = nInitialPosTop + 9;
           // msMenu.Left = Width - nInitialPosLeft - 10;
        }



        private void VM_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (oLauch != null)
            {
                oLauch.bExeLauched = false;
                if (!oLauch.ExeProcess.HasExited) {
                    if(bFullScreenMode) {
                        fCloseFullScreen();
                    }else{
                        oLauch.ExeProcess.CloseMainWindow();
                    }
                    //  oLauch.ExeProcess.WaitForExit(10);
                    e.Cancel = true;
                }
            }

            ConfigMng.oConfig.bMaximize = (WindowState == FormWindowState.Maximized);
            oConfig.SaveConfig();
            fUnMount(sMountDirectory);
        }

    
        internal void fRefresh()
        {
            /*
            this.BeginInvoke((MethodInvoker)delegate {
              // Focus();
                WinApi.SetForegroundWindow(Handle);
                WinApi.SetForegroundWindow(nVM_Handle);
            WinApi.keybd_event(VK_CONTROL, (byte)WinApi.MapVirtualKey(VK_CONTROL, 0), 0, 0); // Control Down
            PostMessage(nVM_Handle, WinApi.WM_KEYDOWN, VK_G, 0); // G
            WinApi.keybd_event(VK_CONTROL, (byte)WinApi.MapVirtualKey(VK_CONTROL, 0), 2, 0); // Control Up
                                                                                             //Thread.Sleep(2000);
               // WinApi.SetForegroundWindow(Handle);
            });
            */

            /*
            Thread.Sleep(10);
            ResizeConsole(true);
            Thread.Sleep(10);
            ResizeConsole();
            Thread.Sleep(10);

            this.BeginInvoke((MethodInvoker)delegate {
                Invalidate();
                Refresh();
            });
            */

            /*
            this.BeginInvoke((MethodInvoker)delegate {
                // WinApi.SetForegroundWindow(nVM_Handle);

                WinApi.keybd_event(VK_CONTROL, (byte)WinApi.MapVirtualKey(VK_CONTROL, 0), 0, 0); // Control Down
            PostMessage(nVM_Handle, WinApi.WM_KEYDOWN, VK_G, 0); // G
            WinApi.keybd_event(VK_CONTROL, (byte)WinApi.MapVirtualKey(VK_CONTROL, 0), 2, 0); // Control Up

            Thread.Sleep(2000);
                // ResizeConsole(true);
                //   ResizeConsole();

            });*/
        }

        private void VM_GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void VM_GUI_Move(object sender, EventArgs e)
        {
            fRefresh();
        }

        private void VM_GUI_ResizeEnd(object sender, EventArgs e)
        {
            if (bCreated)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    ConfigMng.oConfig.vStartPos = Location;
                }
            }
        }


        private void btnEdit_Click(object sender, EventArgs e) {


        }

        private void fOpenFolder()
        {
         //  System.Diagnostics.Process.Start("explorer.exe", "\"" + sMountDirectory + "\"");
                               
         


                //  oLFolder = new LauchTool();
                //   oLFolder.bOutput = false;
                //   oLFolder.fLauchExe("explorer.exe", "\"" + sMountDirectory + "\"");
        //

            string _sOpenFolder = sMountDirectory;
            if(sCloseLocation != null){
                _sOpenFolder += sCloseLocation;
                //  sCloseLocation
            }

            
            int _nTimeOut = 0;
            while(!Directory.Exists(_sOpenFolder) )  {
                Thread.Sleep(1);
                _nTimeOut++;
                if(_nTimeOut > 1000){
                    break;
                }
            }
            if(!Directory.Exists(_sOpenFolder) ) {
                _sOpenFolder = sMountDirectory;
            }
      
            Console.WriteLine("Get the process handle example.");
            var process = new Process{
                StartInfo = new ProcessStartInfo("explorer.exe", "\"" + _sOpenFolder + "\"")
            };
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            /*
            Console.WriteLine("Process Id: " + process.Id);
            Console.WriteLine("Process Name: " + process.ProcessName);
            Console.WriteLine("Process Handle(IntPtr): " + process.Handle.ToString());
            Console.ReadLine();
            */

           MoveAllExplorerWindows(_sOpenFolder,  Path.GetFileName( sMountDirectory));
   
            //Thread.Sleep(2000);
                  //  process.Refresh();      
            /*       
            while (process.MainWindowHandle == IntPtr.Zero) {
                Thread.Sleep(1);
                process.Refresh();
            }*/
            //fSetParent(process.Handle);
            //process.Kill();
        }

        SHDocVw.InternetExplorer oFolderWindow;
        IntPtr nFolderHandle = (IntPtr)null;
        private void MoveAllExplorerWindows(string _sDir, string _sMountName){
                string _sFolderName =  Path.GetFileName( _sDir);
                bool _bFound = false;

               // Thread.Sleep(1000); //Wait for opening
                nFolderHandle = (IntPtr)null;

                int _nTimeout = 30; //3 sec
                while(!_bFound && _nTimeout > 0) {
                    Thread.Sleep(100);
                    foreach (SHDocVw.InternetExplorer window in new SHDocVw.ShellWindows()){
                        string _sLoc = window.LocationName ;
                    
                        if(window.LocationName == _sFolderName ){ 
                            string _sPath = window.FullName.Replace("%20", " ");
                            if(_sDir == _sMountName || _sPath.IndexOf(_sMountName) != 0) {
                                  oFolderWindow = window;
                                  nFolderHandle =  (IntPtr) window.HWND;
                                  _bFound = true;
                                break;
                             }
                         }
                     }
                    _nTimeout--;
                }
                if(_bFound == false){
                    fOut(null, "Error: Folder not found: " + _sDir);
                 }


                if(nFolderHandle != null) {




              Rectangle _oRectBefore = WinApi.GetClientRect(nFolderHandle);
              WinApi.SetParent(nFolderHandle, tbFolder.Handle);
              Rectangle _oRectAfter = WinApi.GetClientRect(nFolderHandle);

             int _nResultHeight = Math.Abs(_oRectAfter.Height - _oRectBefore.Height);
             nTtitleHeight = _nResultHeight;
                if(nTtitleHeight > 150) {//If somthing wrong
                    nTtitleHeight = 0;
                }

             //  fOut(null,"_oRectBefore " + _oRectBefore.ToString());
             //  fOut(null,"_oRectAfter " + _oRectAfter.ToString());
             //  fOut(null,"nTtitleHeight " +nTtitleHeight);

                //    int style = WinApi.GetWindowLong(nFolderHandle, WinApi.GWL_STYLE);
                  //  WinApi.SetWindowLong(nFolderHandle, WinApi.GWL_STYLE, (style & ~WinApi.WS_CAPTION));

   
                  //  WinApi.ShowWindow(nFolderHandle, LauchTool.SW_MAXIMIZE);
                    WinApi.ShowWindow(nFolderHandle, LauchTool.SW_NORMAL);
                    metroTabControl1.SelectedIndex = 2;
                    ResizeConsole(tbFolder.Handle, nFolderHandle,0, tbControl, nTtitleHeight);
                    Thread.Sleep(100);
                    WinApi.ShowWindow(nFolderHandle, WinApi.SW_SHOW);

                  //  ResizeConsole(tbFolder.Handle, nFolderHandle,0, tbControl, 0);
              }
           }

        private void fDriverFinish(LauchTool _oTool){
          this.BeginInvoke((MethodInvoker)delegate {
              btnEdit.Enabled =  true;
            if(WinApi.GetFullPathFromWindows("imdisk.exe") != null) {
                  fOut(null, "Driver Installation SUCCESS! ");
            }else{
                 fOut(null, "ERROR: Driver Installation FAIL");
            }
          });
        }

        public string sCloseLocation = "";
        public bool bIsUnMount = true;
        private void fUnMount(string _sPath, bool _bForce =false)
        {
            
            Console.WriteLine("Try to unmount: " + _sPath);
            if (btnEdit.Text == "UnMount" || _bForce)
            {
                bIsUnMount = false;
                oLDrive = new LauchTool();
                oLDrive.dOut = new LauchTool.dIOut(fOut);
                oLDrive.bRunAsAdmin = true;
                oLDrive.bOutput = false;
                oLDrive.bStartHidden = true;

                 try {
                     oLDrive.fLauchExe(PathHelper.GetExeDirectory() + @"ImDiskTk/ImDisk-Dlg.exe", "RM \"" + _sPath + "\"");
                }catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                }

                try {
                    /////// Delete directory  ///////////
                    BackgroundWorker bw = new BackgroundWorker();
					bw.DoWork += new DoWorkEventHandler(
					delegate(object o, DoWorkEventArgs args) {
                            
                            int _nTimeOut = 3000;
                            while (oLDrive.bExeLauch || (oLoadedDrive != null && oLoadedDrive.bExeLauch) )
                            {
                                Thread.Sleep(1);
                            }
                            if(_bForce)
                            {
                                Thread.Sleep(500);
                            }
                           // if(File.Exists(_sPath)) { //Not work&! But useless
                            try {
                              Directory.Delete(_sPath);
                             }catch (Exception ex) {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                           // }
                            fFinishUnmount();
					});
					bw.RunWorkerAsync();
                    //////////////////////////////////////
                }catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                }
                if(nFolderHandle != null)
                {
                  
                   sCloseLocation =  oFolderWindow.LocationURL.Replace("%20", " ").Replace("file:///", "").Replace('/', '\\');

                   // if(sCloseLocation.Length > sMountDirectory.Length){
                   int _nIndex = sCloseLocation.IndexOf(sMountDirectory);
                   if(_nIndex != -1 ){
                        sCloseLocation = sCloseLocation.Substring(_nIndex + sMountDirectory.Length);
                    }

                   fOut(null, "Close Location: " +sCloseLocation);
                //   fOut(null, "sMountDirectory: " +sMountDirectory.Replace('\\', '/'));
                    oFolderWindow.Quit();
                    metroTabControl1.SelectedIndex = 1 ;
                }
               
              //  btnEdit.Text = "Edit Drive";
            }


        }



        public void fFinishUnmount() {
            bIsUnMount = true;
             this.BeginInvoke((MethodInvoker)delegate {
               btnEdit.Text = "Edit Drive";
                 btnEdit.Enabled = true;
             });
        }

        private void cbPath_TextChanged(object sender, EventArgs e)
        {
            string _sLastItem = cbDrive.Text;
            cbDrive.Items.Clear();
            cbDrive.Text = "";
            try {
           string _sDir = Path.GetDirectoryName(  cbPath.Text) ;
            if (Directory.Exists(_sDir))
            {
                int _nIndex = 0;
                int _nFoundIndex = 0;
                foreach (string _sFile in Directory.GetFiles(_sDir, "*.*", SearchOption.TopDirectoryOnly))  {
                 
                //string supportedExtensions = "*.vmdk,*.vhd,*.vdi,*.img,*.ima,*.raw,*.vfd";
               // foreach (string _sFile in Directory.GetFiles(_sDir, "*.*", SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower()))) {
                   string _sExtention = Str.fGetExtention(_sFile);
                   switch(_sExtention){
                            case "vmdk":
                            case "vhd":
                            case "vdi":
                            case "img":
                            case "raw":
                            case "vfd":
                                
                            cbDrive.Items.Add(_sFile);
                            if (_sLastItem == _sFile)
                            {
                                _nFoundIndex = _nIndex;
                            }
                            _nIndex++;

                         break;
                    }
                }
                if (cbDrive.Items.Count > 0)
                {
                    cbDrive.SelectedIndex = _nFoundIndex;
                }
            }
            }catch(Exception ex)
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/VLiance");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btStop_Click(object sender, EventArgs e)
        {
           

        }

        private void btPause_Click(object sender, EventArgs e)
        {
           
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          

        }

        private void fCloseFullScreen(){
            btStop_Click(null, null); //Maybe click?
        }

        private void cbFullScreen_CheckedChanged(object sender, EventArgs e) {
           
        }


        void fUpdateRtState() {
            rtStartPos =  tbControl.Location;
            rtStartSize =  tbControl.Size;
            int _nSize = 75;
            if(cbFullScreen.Checked) {
                 gbFullScreen.Visible = true;
                tbControl.Size = new Size( rtStartSize.Width , rtStartSize.Height - _nSize);
                tbControl.Location = new Point(rtStartPos.X, rtStartPos.Y         + _nSize);
            }else{
                gbFullScreen.Visible = false;
                tbControl.Size = new Size( rtStartSize.Width , rtStartSize.Height + _nSize);
                tbControl.Location = new Point(rtStartPos.X, rtStartPos.Y          - _nSize);
            }
        }

        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
              ResizeConsole(tbFolder.Handle, nFolderHandle,0, tbControl, nTtitleHeight);
        }

        private void vmxSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLauchBtn(""); //"" is library
        }

        private void exportToovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          string _sDate  =   System.DateTime.Now.ToString().Replace('/', '-').Replace(':', '-').Replace(' ', '_');


            fConvertOva(fGetVMX(cbPath.Text),  Path.GetDirectoryName( cbPath.Text) + "\\Export" + _sDate+ ".ova"  );
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            fLauchBtn(cbPath.Text); ;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // cbPath.Text = FileUtils.fOpenFolderBrowsing(cbPath.Text);
            cbPath.Text = FileUtils.fDialogExeFile(cbPath.Text, ""); ;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            fUpdateRtState();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {


            if (WinApi.GetFullPathFromWindows("imdisk.exe") != null)
            {

                string _sPath = cbDrive.Text;

                if (File.Exists(_sPath))
                {

                    if (btnEdit.Text != "UnMount")
                    {
                        fOut(null, "Mount[DiscUtilsDevio] ");

                        //  btPause_Click(null,null);
                        string _sDirectory = Path.GetDirectoryName(_sPath) + "\\" + Path.GetFileNameWithoutExtension(_sPath) + "_Mount";
                        if (!Directory.Exists(_sDirectory))
                        {
                            Directory.CreateDirectory(_sDirectory);
                        }
                        else
                        {

                            if (Directory.GetFileSystemEntries(_sDirectory, "*.*").Length != 0)
                            { //Use a new directory if already in use
                                string _sNewPath = _sDirectory;
                                int _nCount = 1;
                                try
                                {

                                    do
                                    {
                                        /*
                                           if( Directory.GetFileSystemEntries(_sNewPath, "*.*").Length != 0 ){

                                               fUnMount(_sNewPath, true); //TODO check if attribute is mounted
                                               if(!Directory.Exists(_sNewPath)){ // Able to unmount
                                                   break;
                                               }

                                           }else{
                                              // break;
                                           }*/
                                        _nCount++;
                                        _sNewPath = _sDirectory + "_" + _nCount.ToString();
                                    } while (Directory.Exists(_sNewPath));

                                }
                                catch (Exception ex)
                                { //If is already mounted and crash
                                    if (File.Exists(_sNewPath))
                                    {
                                        fUnMount(_sNewPath);
                                    }

                                }

                                _sDirectory = _sNewPath;
                                Directory.CreateDirectory(_sDirectory);
                            }
                        }
                        bIsUnMount = false;
                        oLDrive = new LauchTool();
                        oLDrive.dOut = new LauchTool.dIOut(fOut);
                        oLDrive.bRunAsAdmin = true;
                        oLDrive.bOutput = false;
                        oLDrive.bStartHidden = true;


                        sMountDirectory = _sDirectory;
                        oLoadedDrive = oLDrive;
                        fOut(null, "Mount[DiscUtilsDevio]: " + sMountDirectory);
                        // oLauch.bRunInThread = false;
                        // oLDrive.fLauchExe(PathHelper.GetExeDirectory() + @"ImDiskTk/DiscUtilsDevio.exe", "/filename=" + "\"" + _sPath + "\"" + " /mount=Z:");
                        oLDrive.fLauchExe(PathHelper.GetExeDirectory() + @"ImDiskTk/DiscUtilsDevio.exe", "/filename=" + "\"" + _sPath + "\"" + " /mount=\"" + sMountDirectory + "\"");


                        //System.Diagnostics.Process.Start(sMountDirectory);



                        //   oLFolder = new LauchTool();
                        // oLFolder.bOutput = false;
                        //  oLFolder.fLauchExe("explorer.exe", "\"" + sMountDirectory + "\"");

                        if (cbOpen.Checked)
                        {
                            fOpenFolder();

                        }

                        btnEdit.Text = "UnMount";
                    }
                    else
                    {
                        fUnMount(sMountDirectory);
                    }
                }
                else
                {
                    fOut(null, "Error: Drive not exist: \"" + _sPath + "\"");

                }

            }
            else
            {
                fOut(null, "Driver is required to 'Edit Drive'");
                btnEdit.Enabled = false;
                DialogResult dr = MessageBox.Show("Driver 'imdisk' is required to 'Edit Drive', install?", "Install Driver", MessageBoxButtons.YesNo);
                switch (dr)
                {

                    case DialogResult.Yes:

                        oInstallDriver = new LauchTool();
                        oInstallDriver.dOut = new LauchTool.dIOut(fOut);
                        oInstallDriver.dError = new LauchTool.dIError(fOut);
                        oInstallDriver.dExit = new LauchTool.dIExit(fDriverFinish);
                        //  oInstallDriver.bHidden = true;

                        oInstallDriver.bOutput = false;
                        //oConvert.bStartMinimised  =true;
                        // oLauch.UseShellExecute = true;
                        //oLauch.fLauchExe(@"C:\Program Files (x86)\VMware\VMware Player\vmplayer.exe", "-X " + "\"E:/MyVM/CpcDos/My_Cpcdos OSx.vmx\"");

                        if (ckbAdmin.Checked)
                        {
                            oInstallDriver.bRunAsAdmin = true;
                            //    oInstallDriver.bOutput = false;
                        }
                        string _sPath = PathHelper.GetCurrentDirectory() + "ImDiskTk/driver/install.cmd";
                        //  string _sPath = PathHelper.GetCurrentDirectory() + "ImDiskTk/config.exe";

                        fOut(null, "Install Driver: " + _sPath);
                        oInstallDriver.fLauchExe(_sPath, "");

                        break;
                    case DialogResult.No:
                        fOut(null, "Error: Driver not installed!");
                        btnEdit.Enabled = true;
                        break;
                }
            }
        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {
            oKvmAction = new LauchTool();
            oKvmAction.bOutput = false;
            oKvmAction.fLauchExe(sVM_Path + "vmware-kvm.exe", "--reset " + "\"" + sLauched_Path + "\"");
            //--exit can cause problem
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //fFound_VM_Ware(false);
            oKvmAction = new LauchTool();
            oKvmAction.bOutput = false;
            oKvmAction.fLauchExe(sVM_Path + "vmware-kvm.exe", "--suspend " + "\"" + sLauched_Path + "\"");
            fStopLaodingLauch();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            oKvmAction = new LauchTool();
            oKvmAction.bOutput = false;
            oKvmAction.fLauchExe(sVM_Path + "vmware-kvm.exe", "--power-off " + "\"" + sLauched_Path + "\"");
            fStopLaodingLauch();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            fFound_VM_Ware();
            // fStopLaodingLauch();
            oKvmAction = new LauchTool();
            oKvmAction.bOutput = false;
            oKvmAction.fLauchExe(sVM_Path + "vmware-kvm.exe", "--preferences " + "\"" + sLauched_Path + "\"");
            //--detach ??
            //--reset
            //--exit
        }
    }
}
