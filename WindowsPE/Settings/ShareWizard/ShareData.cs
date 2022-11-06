using System.Runtime.InteropServices;

namespace WindowsPE.Settings.ShareWizard
{
    public static class ShareData
    {
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
        public static SHARE_INFO_2 pointer = new SHARE_INFO_2(){
            shi2_type = 0,
            shi2_passwd = null,
            shi2_permissions = 0,
            shi2_max_uses = 4,
            shi2_current_uses = 0
        };
        public static NewShareForm newShareForm;
    }
    

}
