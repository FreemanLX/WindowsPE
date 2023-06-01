using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Collections.Generic;
using WindowsPE.Algorithms;

namespace WindowsPE
{
    public static class AdaptiveMethods
    {
        public static void IntPtr2Array(IntPtr pointer, int size, out string[] stringArray)
        {
              IntPtr[] intptrArray = new IntPtr[size];
              stringArray = new string[size];
              Marshal.Copy(pointer, intptrArray, 0, size);
              for (int i = 0; i < size; i++)
              {
                 stringArray[i] = Marshal.PtrToStringAnsi(intptrArray[i]);
                 Marshal.FreeCoTaskMem(intptrArray[i]);  
              }
              Marshal.FreeCoTaskMem(pointer);
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
            unsafe 
            {
                int* indexes = null;

                if(ExternalMethods.ScreenApi.GetAvailableScreenResolutionIndex(&indexes, out int sizePtr))
                {
                         int[] displayIndex = new int[sizePtr];
                         Data.resolutions = new Dictionary<int, string[]>();
                         for(int i = 0; i<sizePtr; i++, indexes++){
                              displayIndex[i] = *indexes;
                         }
                         Data.DisplayIndex = displayIndex;
                         foreach(int index in displayIndex)
                         {
                            string[] array = null;
                            if (ExternalMethods.ScreenApi.EnumScreenResolutionU(index, out IntPtr ptr, out int size))
                            {
                                 IntPtr2Array(ptr, size, out array);
                                 array = array.Distinct().ToArray();
                            }
                            QuickSort<string> qs = new QuickSort<string>(array, CustomCompare);
                            qs.Sort();
                            Data.resolutions[index] = qs.getArrayList();
                        }
                        
                }
            }
        }


        public struct firewallData
        {
           public long profile;
	       public int protocol; //6 - tcp, 17 - udp, 0 - icmpv4
           public int enabled;
	       public int outbound; //true - out, false - in
	       public int action; 
	       public string name;
           public string program;
		   public string localAddress;
		   public string remoteAddress;
		   public string localPort;
		   public string remotePort;   
        }

        public static unsafe bool addANewRuleFun(firewallData rule)
        {
            ExternalStructures.UnmanagedFirewallData ptr = new ExternalStructures.UnmanagedFirewallData
            {
                action = rule.action,
                name = Marshal.StringToCoTaskMemAnsi(rule.name),
                localAddress = Marshal.StringToCoTaskMemAnsi(rule.localAddress),
                localPort = Marshal.StringToCoTaskMemAnsi(rule.localPort),
                remoteAddress = Marshal.StringToCoTaskMemAnsi(rule.remoteAddress),
                remotePort = Marshal.StringToCoTaskMemAnsi(rule.remotePort),
                program = Marshal.StringToCoTaskMemAnsi(rule.program),
                enabled = rule.enabled,
                protocol = rule.protocol,
                profile = rule.profile,
                outbound = rule.outbound
            };
            return ExternalMethods.FirewallApi.AddFirewallRule(ref ptr);
        }
    }
}
