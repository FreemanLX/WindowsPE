using System;
using System.Runtime.InteropServices;

namespace WindowsPE.Algorithms
{
    public static unsafe partial class ExternalMethods
    {
        public static unsafe class FirewallApi
        {
            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern int CheckFirewall(ExternalStructures.NET_FW_PROFILE_TYPE2 firewallType);

            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool DisableFirewall(ExternalStructures.NET_FW_PROFILE_TYPE2 firewallType);

            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool EnableFirewall(ExternalStructures.NET_FW_PROFILE_TYPE2 firewallType);

            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern int GetFirewallData(ExternalStructures.UnmanagedFirewallData** UnmanagedFirewallData, out int size);

            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool AddFirewallRule(ref ExternalStructures.UnmanagedFirewallData UnmanagedFirewallData);

            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool FirewallDataClear(IntPtr UnmanagedFirewallData, int size);

            [DllImport("ShellCore.dll", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool deleteFirewallEntry(string firewallName);
        }

    }
}
