using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace WindowsPE
{
    public static class AdaptiveMethods
    {
       public delegate int WpeutilFunction(IntPtr hInstance, IntPtr hPrevious, string SW_CMDLINE, int SW_SHOW);
        public static int WPEInitialization(string FunctionName, string cmdline)
        {
            var task = Task.Run(()=> {
                IntPtr hWpeutil = Browser.ExternalMethods.LoadLibrary("wpeutil.dll");
                if (hWpeutil == IntPtr.Zero) return Marshal.GetLastWin32Error();
                WpeutilFunction wpeutilFunction = Marshal.GetDelegateForFunctionPointer<WpeutilFunction>(Browser.ExternalMethods.GetProcAddress(hWpeutil, FunctionName));
                if(wpeutilFunction == null) return Marshal.GetLastWin32Error();
                Thread.Sleep(200);
                if(wpeutilFunction(IntPtr.Zero, IntPtr.Zero, cmdline, 0) == 0x0)
                {
                    Browser.ExternalMethods.FreeLibrary(hWpeutil);
                    return 0;
                }
                Thread.Sleep(500);
                int Hrresult = Marshal.GetLastWin32Error();
                Browser.ExternalMethods.FreeLibrary(hWpeutil);
                return Hrresult;
            });
            return task.Result;
        }

        static void IntPtr2Array(IntPtr pointer, int size, out string[] stringArray)
        {
              IntPtr[] intptrArray = new IntPtr[size];
              stringArray = new string[size];
              Marshal.Copy(pointer, intptrArray, 0, size);
              for (int i = 0; i < size; i++)
              {
                 stringArray[i] = Marshal.PtrToStringAnsi(intptrArray[i]);
              }
        }

        public static int CustomCompare(string obj1, string obj2)
        {
            string[] obj1splitted = obj1.Split('x');
            string[] obj2splitted = obj2.Split('x');
            if(int.Parse(obj1splitted[0]) * int.Parse(obj1splitted[1]) > int.Parse(obj2splitted[0]) * int.Parse(obj2splitted[1])) return 1;
            return 0;
        }

        public static string[] GetScreenResolutions()
        {
             string[] array = null;
             int size = 0;
             IntPtr ptr = IntPtr.Zero;
             if(Browser.ExternalMethods.EnumScreenResolution(out ptr, out size))
             {
                IntPtr2Array(ptr, size, out array);
             }
             array = array.Distinct().ToArray();
             Browser.QuickSort<string> qs = new Browser.QuickSort<string>(array, CustomCompare);
             qs.sort();
             return qs.getArrayList();
        }
    }
}
