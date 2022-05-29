using System;
using System.Runtime.InteropServices;

namespace Browser
{
    public static class ExternalMethods
    {

        [DllImport("user32.dll")] 
	    public static extern bool LockWindowUpdate(IntPtr hWnd); 

        [ DllImport( "Comdlg32.dll", CharSet=CharSet.Auto )]                
        public static extern bool GetOpenFileName([ In, Out ] OpenFileName ofn );

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
        
        [DllImport("DisplaySettings.dll", CharSet=CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern void ChangeScreenResolutionW(int height, int width, out string output);

        [DllImport("DisplaySettings.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EnumScreenResolution(out IntPtr unmanagedStringsArray, out int size); 
    }
}
