using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace WindowsPE
{
    public static class AdaptiveMethods
    {
        public delegate int WpeutilFunction(IntPtr hInstance, IntPtr hPrevious, string SW_CMDLINE, int SW_SHOW);
        public static int WPEInitialization(string FunctionName, string cmdline)
        {
            int Hrresult = 0;
            Thread thread = new Thread(()=> 
            {
                Thread.Sleep(1000);
                IntPtr hWpeutil = ExternalMethods.LoadLibrary("wpeutil.dll");
                if (hWpeutil == IntPtr.Zero) Hrresult = Marshal.GetLastWin32Error();
                else
                {
                    WpeutilFunction wpeutilFunction = Marshal.GetDelegateForFunctionPointer<WpeutilFunction>(ExternalMethods.GetProcAddress(hWpeutil, FunctionName));
                    if(wpeutilFunction == null) Hrresult = Marshal.GetLastWin32Error();
                    else
                    {
                        if(wpeutilFunction(IntPtr.Zero, IntPtr.Zero, cmdline, 0) == 0x0)
                        {
                            ExternalMethods.FreeLibrary(hWpeutil);
                            Hrresult = 0;
                        }
                        Hrresult = Marshal.GetLastWin32Error();
                        ExternalMethods.FreeLibrary(hWpeutil);
                    }
                }
            });
            thread.Start();
            while(thread.IsAlive) Application.DoEvents();
            return Hrresult;
        }

        static void IntPtr2Array(IntPtr pointer, int size, out string[] stringArray, bool cleanup = true)
        {
              IntPtr[] intptrArray = new IntPtr[size];
              stringArray = new string[size];
              Marshal.Copy(pointer, intptrArray, 0, size);
              for (int i = 0; i < size; i++)
              {
                 stringArray[i] = Marshal.PtrToStringAnsi(intptrArray[i]);
                 if(cleanup)
                   Marshal.FreeCoTaskMem(intptrArray[i]);  
              }
              if(cleanup)
                 Marshal.FreeCoTaskMem(pointer);
        }


        public static void GetFileSharing()
        {
            ExternalMethods.GetFileSharing(out IntPtr netShare, out IntPtr netPaths, out int size);  
            IntPtr2Array(netShare, size, out Data.NetSharesName);
            IntPtr2Array(netPaths, size, out Data.NetPaths);
        }

        public static int CustomCompare(string obj1, string obj2)
        {
            string[] obj1splitted = obj1.Split('x');
            string[] obj2splitted = obj2.Split('x');
            if(int.Parse(obj1splitted[0]) * int.Parse(obj1splitted[1]) > int.Parse(obj2splitted[0]) * int.Parse(obj2splitted[1])) return 1;
            return 0;
        }

        public static void GetScreenResolutions()
        {
            if(ExternalMethods.GetAvailableScreenResolutionIndex(out IntPtr IndexPtr, out int sizePtr))
            {
                     IntPtr[] intptrArray = new IntPtr[sizePtr];
                     int[] indexes = new int[sizePtr];
                     Marshal.Copy(IndexPtr, intptrArray, 0, sizePtr);
                     for (int i = 0; i < sizePtr; i++)
                     {
                        indexes[i] = (int)intptrArray[i];
                     }
                     Data.resolutions = new Dictionary<int, string[]>();
                     Data.DisplayIndex = indexes;
                     foreach(int index in indexes)
                     {
                        string[] array = null;
                        if (ExternalMethods.EnumScreenResolutionU(index, out IntPtr ptr, out int size))
                        {
                             IntPtr2Array(ptr, size, out array);
                             array = array.Distinct().ToArray();
                        }
                        QuickSort<string> qs = new QuickSort<string>(array, CustomCompare);
                        qs.Sort();
                        Data.resolutions[index] = qs.getArrayList();
                     // return qs.getArrayList();  
                    }
            }
            //return null;
        }

        public static ImageList getIcons()
        {
            ImageList imageList = new ImageList();
            int IconsCount = ExternalMethods.ExtractIconEx("shell32.dll", -1, null, null, 0);
            if(IconsCount > 0)
            {
                IntPtr[] ImageLargeList = new IntPtr[IconsCount];
                IntPtr[] ImageSmallList = new IntPtr[IconsCount];
                var result = ExternalMethods.ExtractIconEx("shell32.dll", 0, ImageLargeList, null, IconsCount);
                imageList.ImageSize = SystemInformation.IconSize;
                imageList.Images.AddRange(ImageLargeList.Select(x => Icon.FromHandle(x).ToBitmap()).ToArray());
            }
            return imageList;
        }


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct firewallData
        {
	       public string name;
           public string program;
		   public string localAddress;
		   public string remoteAddress; 
		   public string profile;
		   public string action;
		   public string protocol;
		   public string localPort;
		   public string remotePort;   
           public bool outbound;
           public bool enabled;
        }
        
        /// <summary>
        /// Explicit way to get data from unsafe structure...
        /// </summary>
        /// <returns></returns>
        public static unsafe firewallData[] GetFirewallData()
        {
            ExternalMethods.UnmanagedFirewallData* data;
            if (ExternalMethods.GetFirewallData(&data, out int size, out int memsize) == 1)
            {
                firewallData[] firewallDataArray = new firewallData[size];
                ExternalMethods.UnmanagedFirewallData* ptr = data;
                for(int i = 0; i<size; i++, ptr++)
                {
                    firewallDataArray[i] = new firewallData
                    {
                        action = Marshal.PtrToStringAnsi(ptr->action),
                        name = Marshal.PtrToStringAnsi(ptr->name),
                        localAddress = Marshal.PtrToStringAnsi(ptr->localAddress),
                        localPort = Marshal.PtrToStringAnsi(ptr->localPort),
                        remoteAddress = Marshal.PtrToStringAnsi(ptr->remoteAddress),
                        remotePort = Marshal.PtrToStringAnsi(ptr->remotePort),
                        program = Marshal.PtrToStringAnsi(ptr->program),
                        enabled = ptr->enabled,
                        protocol = Marshal.PtrToStringAnsi(ptr->protocol),
                        profile = "None", //doesnt matter in Windows PE...
                        outbound = ptr->outbound
                    };
                }
                return firewallDataArray;
            }
            return null;
        }
    }
}
