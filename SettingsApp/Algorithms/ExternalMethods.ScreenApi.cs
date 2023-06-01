using System;
using System.Runtime.InteropServices;

namespace WindowsPE.Algorithms
{
    public unsafe static partial class ExternalMethods
    {
         public static class ScreenApi
         {
             [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
             public static extern int ChangeScreenResolutionU(int height, int width);

             [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
             public static extern bool EnumScreenResolutionU(int display, out IntPtr unmanagedStringsArray, out int size);    
            
             [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
             public static extern bool GetAvailableScreenResolutionIndex(int** IndexList, out int size);
         }

    }
}
