using System;
using System.Runtime.InteropServices;

namespace WindowsPE.Algorithms
{
    public class ExternalStructures
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct UnmanagedFirewallData
        {
	       public int protocol; //6 - tcp, 17 - udp, 0 - icmpv4
           public int enabled; 
           public int outbound; //true - out, false - in
           public int action; //block - 0, allow - 1
           public long profile; //just implement masks..
	       public IntPtr program;
           public IntPtr name;
		   public IntPtr localAddress;
		   public IntPtr remoteAddress; 
		   public IntPtr localPort;
		   public IntPtr remotePort;
        }

        public enum NET_FW_PROFILE_TYPE2
        {
             NET_FW_PROFILE2_DOMAIN	= 0x1,
             NET_FW_PROFILE2_PRIVATE = 0x2,
             NET_FW_PROFILE2_PUBLIC	= 0x4,
             NET_FW_PROFILE2_ALL = 0x7fffffff
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct SHARE_INFO_2
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            public string shi2_netname;
            public uint shi2_type;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string shi2_remark;
            public uint shi2_permissions;
            public uint shi2_max_uses;
            public uint shi2_current_uses;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string shi2_path;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string shi2_passwd;
        }

    }
}
