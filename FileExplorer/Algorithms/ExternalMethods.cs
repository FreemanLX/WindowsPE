using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;

namespace WindowsPE
{
    class ExternalMethods
    {
        [DllImport("Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern int ExtractIconEx(string File, int index, IntPtr IconLarge, out IntPtr IconSmallList, int countIcons);
    
        [StructLayout(LayoutKind.Sequential)]
		public struct SHFILEINFO {
			public IntPtr handle;
			public IntPtr index;
			public uint attr;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=260)]
			public string display;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst=80)]
			public string type;
		}

		[DllImport("shell32.dll")]
		public static extern IntPtr SHGetFileInfo(string path, uint fattrs, ref SHFILEINFO sfi, uint size, uint flags);

        [DllImport("User32.dll")]
        static extern int DestroyIcon(IntPtr hIcon);

        [SecuritySafeCritical]
        public static Icon GetSmallIcon(string path)
        {
            SHFILEINFO info = new SHFILEINFO();
            SHGetFileInfo(path, 0, ref info, (uint)Marshal.SizeOf(info), 0x10 | 0x100 | 0x1);
            if(info.handle != IntPtr.Zero)
            {
                Icon icon = (Icon)Icon.FromHandle(info.handle).Clone();
                DestroyIcon(info.handle);
                return icon;
            }
            return null;
		}
    }
}
