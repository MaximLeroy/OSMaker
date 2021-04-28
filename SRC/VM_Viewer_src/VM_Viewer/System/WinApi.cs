using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CwcGUI
{


    [StructLayout(LayoutKind.Sequential)]
    struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct WINDOWINFO
    {
        public uint cbSize;
        public RECT rcWindow;
        public RECT rcClient;
        public uint dwStyle;
        public uint dwExStyle;
        public uint dwWindowStatus;
        public uint cxWindowBorders;
        public uint cyWindowBorders;
        public ushort atomWindowType;
        public ushort wCreatorVersion;

        public WINDOWINFO(Boolean? filler) : this()   // Allows automatic initialization of "cbSize" with "new WINDOWINFO(null/true/false)".
        {
            cbSize = (UInt32)(Marshal.SizeOf(typeof(WINDOWINFO)));
        }
    }

    class WinApi
    {

 /// <summary>
/// Gets the full path of the given executable filename as if the user had entered this
/// executable in a shell. So, for example, the Windows PATH environment variable will
/// be examined. If the filename can't be found by Windows, null is returned.</summary>
/// <param name="exeName"></param>
/// <returns>The full path if successful, or null otherwise.</returns>
public static string GetFullPathFromWindows(string exeName)
{
    if (exeName.Length >= MAX_PATH)
        throw new ArgumentException($"The executable name '{exeName}' must have less than {MAX_PATH} characters.",
            nameof(exeName));

    StringBuilder sb = new StringBuilder(exeName, MAX_PATH);
    return PathFindOnPath(sb, null) ? sb.ToString() : null;
}

// https://docs.microsoft.com/en-us/windows/desktop/api/shlwapi/nf-shlwapi-pathfindonpathw
// https://www.pinvoke.net/default.aspx/shlwapi.PathFindOnPath
[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = false)]
static extern bool PathFindOnPath([In, Out] StringBuilder pszFile, [In] string[] ppszOtherDirs);

// from MAPIWIN.h :
private const int MAX_PATH = 260;










        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;



        public const Int32 VK_P = 0x0050; 
        public const Int32 VK_G = 0x0047; 

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

        public const Int32 SC_RESTORE = 0xF120;



        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern int MapVirtualKey(int uCode, uint uMapType);
        public  const int WM_KEYDOWN = 0x0100;
        public  const int WM_LBUTTONDBLCLK = 0x0203;
        public const int VK_TAB = 0x09;
        public const int CTRL_KEY = 0x11;


        [DllImport("user32.dll")]
        //  static extern bool RedrawWindow(IntPtr hWnd, [In] ref RECT lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);
        public static extern bool RedrawWindow(IntPtr hWnd, [In] ref RECT lprcUpdate, IntPtr hrgnUpdate, uint flags);

        [DllImport("user32.dll")]
        public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);


        // public const int GWL_STYLE = -16;
      //  public const int SW_SHOWMAXIMIZED = 3;

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern bool GetWindowInfo(IntPtr hwnd, out WINDOWINFO wi);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

         [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT rectangle);

        [DllImport("user32.dll")]
        public static extern bool AdjustWindowRect(ref RECT lpRect, int dwStyle, bool bMenu);

        public static Rectangle GetClientRect(IntPtr hWnd)
        {
            RECT rc;
            GetClientRect(hWnd, out rc);

            return new Rectangle(rc.Left, rc.Top, rc.Right - rc.Left, rc.Bottom - rc.Top);
        }
        
        public static Rectangle GetWindowRect(IntPtr hWnd)
        {
            RECT rc;
            GetWindowRect(hWnd, out rc);

            return new Rectangle(rc.Left, rc.Top, rc.Right - rc.Left, rc.Bottom - rc.Top);
        }


        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        //assorted constants needed
        public static int GWL_STYLE = -16;
        public static int WS_CHILD = 0x40000000; //child window
        public static int WS_BORDER = 0x00800000; //window with border
        public static int WS_DLGFRAME = 0x00400000; //window with double border but no title
        public static int WS_CAPTION = WS_BORDER | WS_DLGFRAME; //window with a title bar

        //Sets window attributes
        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);


        



        public static void ResizeClientRectTo(IntPtr hWnd, Rectangle desired)
        {
            RECT size;
            size.Top = desired.Top;
            size.Left = desired.Left;
            size.Bottom = desired.Bottom;
            size.Right = desired.Right;

            var style = GetWindowLong(hWnd, GWL_STYLE);
            AdjustWindowRect(ref size, style, false);
            MoveWindow(hWnd, size.Left, size.Top, size.Right - size.Left, size.Bottom - size.Top, true);
        }



        [DllImport("kernel32.dll", SetLastError=true)]
       public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("user32.dll")]
       public  static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

#pragma warning restore 649


        public static void ClickOnPoint(IntPtr wndHandle, Point clientPoint)
        {
            var oldPos = Cursor.Position;

            /// get screen coordinates
            ClientToScreen(wndHandle, ref clientPoint);

            /// set cursor on coords, and press mouse
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);

            var inputMouseDown = new INPUT();
            inputMouseDown.Type = 0; /// input type mouse
            inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

            var inputMouseUp = new INPUT();
            inputMouseUp.Type = 0; /// input type mouse
            inputMouseUp.Data.Mouse.Flags = 0x0004; /// left button up

            var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            /// return mouse 
            Cursor.Position = oldPos;
        }





    }
}
