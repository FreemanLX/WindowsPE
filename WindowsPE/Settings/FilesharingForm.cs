using System;
using System.Windows.Forms;

namespace WindowsPE.Settings
{
    public partial class FilesharingForm : UserControl
    {
        public FilesharingForm()
        {
            InitializeComponent();
        }

        private void fileSharingNameLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FilesharingForm_Load(object sender, EventArgs e)
        {
            shareData.DefaultCellStyle.SelectionBackColor = Data.color;
            newShareBtn.BackColor = Data.color;
            for(int i = 0; i<Data.NetSharesName.Length; i++){
               shareData.Rows.Add(Data.NetSharesName[i], Data.NetPaths[i], "SMB");
            }
        }

        private void newShareBtn_Click(object sender, EventArgs e)
        {
            ShareWizard.ShareData.newShareForm = new NewShareForm();
            ShareWizard.ShareData.newShareForm.ShowDialog();
            shareData.Rows.Clear();
            for(int i = 0; i<Data.NetSharesName.Length; i++){
               shareData.Rows.Add(Data.NetSharesName[i], Data.NetPaths[i], "SMB");
            }
        }

        private void shareData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
