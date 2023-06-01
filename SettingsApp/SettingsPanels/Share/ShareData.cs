using WindowsPE.Algorithms;

namespace WindowsPE.Settings.ShareWizard
{
    public static class ShareData
    {  
        public static ExternalStructures.SHARE_INFO_2 pointer = new ExternalStructures.SHARE_INFO_2(){
            shi2_type = 0,
            shi2_passwd = null,
            shi2_permissions = 0,
            shi2_max_uses = 4,
            shi2_current_uses = 0
        };
    }
    

}
