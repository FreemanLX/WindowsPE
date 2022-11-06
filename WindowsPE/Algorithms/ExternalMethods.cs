using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsPE
{
    public unsafe static class ExternalMethods
    {

        [DllImport("user32.dll")] 
	    public static extern bool LockWindowUpdate(IntPtr hWnd);
        
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Description, int ReservedValue);


        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
        
        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ChangeScreenResolutionU(int height, int width);

        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetFileSharing(out IntPtr netShares, out IntPtr netPaths, out int size);

        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool AddFileSharing([In] Settings.ShareWizard.ShareData.SHARE_INFO_2 data);

        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool DeleteFileSharing([In] string[] netshare);

        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EnumScreenResolutionU(int display, out IntPtr unmanagedStringsArray, out int size); 

        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void OpenFileDialog(out IntPtr path); 
        
        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool GetAvailableScreenResolutionIndex(out IntPtr IndexList, out int size);

        [DllImport("kernel32.dll")]
        public static extern bool GlobalFree(IntPtr hModule);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        public static extern bool MoveWindow(IntPtr hWndChild, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        public extern static int SetWindowLong(IntPtr hWndChild, int index, int value);

        [DllImport("user32.dll")]
        public extern static int GetWindowLong(IntPtr hWndChild, int index);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern void RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);

        [DllImport("user32.dll")]
        public static extern void SetWindowPos(IntPtr hwnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("shell32.dll")]
        public static extern int ExtractIconEx(string File, int index, IntPtr[] IconLargeList, IntPtr[] IconSmallList, int countIcons);
        
        [StructLayout(LayoutKind.Sequential)]
        public struct UnmanagedFirewallData
        {
	       public IntPtr program;
           public IntPtr name;
		   public IntPtr localAddress;
		   public IntPtr remoteAddress; 
		   public IntPtr profile;
		   public IntPtr localPort;
		   public IntPtr remotePort;
           public IntPtr action;
		   public IntPtr protocol;
           public bool enabled;
           public bool outbound;
        }

        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFirewallData(out IntPtr UnmanagedFirewallData, out int size, out int memsize);

        [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetFirewallData(UnmanagedFirewallData** UnmanagedFirewallData, out int size, out int memsize);
    }
}
