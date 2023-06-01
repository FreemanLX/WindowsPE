using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowsPE
{
    class ExternalMethods
    {
        [DllImport("shell32.dll")]
        public static extern int ExtractIconEx(string File, int index, IntPtr[] IconLargeList, IntPtr[] IconSmallList, int countIcons);
    
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
		public const uint SHGFI_SMALLICON = 0x1;

		[DllImport("shell32.dll")]
		public static extern IntPtr SHGetFileInfo(string path, uint fattrs, ref SHFILEINFO sfi, uint size, uint flags);
		public static Icon GetSmallIcon(string path) {
			SHFILEINFO info = new SHFILEINFO();
			SHGetFileInfo(path, 0, ref info, (uint)Marshal.SizeOf(info), SHGFI_ICON|SHGFI_SMALLICON);
			return Icon.FromHandle(info.handle);
		}
      
    }
}
