using System;
using System.Windows.Forms;
using WindowsPE.Algorithms;

namespace WindowsPE.Settings
{
    public partial class FilesharingForm : UserControl
    {
        ShareWizard.ShareDataLayout shareDataLayout;
        public FilesharingForm() 
        {
            InitializeComponent();
            shareDataLayout = new ShareWizard.ShareDataLayout() {Dock = DockStyle.Fill};
        }
        
        private void FilesharingForm_Load(object sender, EventArgs e)
        {
            ExternalMethods.FileSharingApi.GetFileSharing(out IntPtr netShare, out IntPtr netPaths, out int size);
            string[] NetShareName = new string[size];
            string[] NetPaths = new string[size];
            AdaptiveMethods.IntPtr2Array(netShare, size, out NetShareName);
            AdaptiveMethods.IntPtr2Array(netPaths, size, out NetPaths);
            for(int i = 0; i<NetShareName.Length; i++){
               shareDataLayout.insertData(NetShareName[i], NetPaths[i], "SMB");
            }
            filesharingContainer.Controls.Add(shareDataLayout, 0, 0);
        }
    }
}
