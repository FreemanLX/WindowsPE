using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsPE
{
    
    public static class ExternalMethods
    {
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]  
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);  


        [StructLayout(LayoutKind.Sequential)]
		public struct SHFILEINFO {
			public IntPtr handle;
			public IntPtr index;
			public uint attr;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=260)]
			public string display;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=80)]
			public string type;
		};
		public const uint SHGFI_ICON = 0x100;

		[DllImport("shell32.dll")]
		public static extern IntPtr SHGetFileInfo(string path, uint fattrs, ref SHFILEINFO sfi, uint size, uint flags);
		public static Icon GetLargeIcon(string path) {
			SHFILEINFO info = new SHFILEINFO();
			SHGetFileInfo(path, 0, ref info, (uint)Marshal.SizeOf(info), SHGFI_ICON|0x0);
			return Icon.FromHandle(info.handle);
		}

        static public void RegisterAccessBar(IntPtr handle, int height)
        {
             if(!MoveWindow(handle, 0, Screen.PrimaryScreen.Bounds.Height - height, Screen.PrimaryScreen.Bounds.Width, height, true))
             {
                 MessageBox.Show("Error MoveWindow. Hresult: " + Marshal.GetLastWin32Error());
             }
        }

    }
}
