using System;
using System.Runtime.InteropServices;

namespace WindowsPE.Algorithms
{
    public unsafe static partial class ExternalMethods
    {
        public static class PersonalizationApi
        {
            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool ChangeBackgroundWallpaper(); 

            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool SetBackgroundLayout([In] string layoutData); 
        }
    }
}
