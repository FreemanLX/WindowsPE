using System.Windows.Forms;

namespace WindowsPE.Settings.ShareWizard
{
    public partial class ShareDataLayout : UserControl
    {
        public ShareDataLayout()
        {
            InitializeComponent();
            shareData.DefaultCellStyle.SelectionBackColor = Data.color;
        }

        public void insertData(string name, string path, string protocol) => shareData.Rows.Add(name, path, protocol);
    }
}
