using System;
using System.Runtime.InteropServices;

namespace WindowsPE.Algorithms
{
    public unsafe static partial class ExternalMethods
    {
        public static class FileSharingApi
        {
             [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
             public static extern void GetFileSharing(out IntPtr netShares, out IntPtr netPaths, out int size);

             [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
             public static extern bool AddFileSharing([In] ExternalStructures.SHARE_INFO_2 data);

             [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
             public static extern bool DeleteFileSharing([In] string[] netshare);
        }

    }
}
