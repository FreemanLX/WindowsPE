using System;
using System.Windows.Forms;
using System.Drawing;
using WindowsPE.Algorithms;

namespace WindowsPE
{
    public partial class PersonalizationForm : UserControl
    {
        public PersonalizationForm()
        {
            InitializeComponent();
            BackgroundFitComboBox.Text = "Stretch"; //needs to be extractred from registry..
        }

        private void PersonalizationForm_Load(object sender, EventArgs e)
        {
              using (Image image = new Bitmap(Data.WallpaperPath)) 
              {
                  BackgroundPreview.BackgroundImage = new Bitmap(image, BackgroundPreview.Size.Height, BackgroundPreview.Size.Width); 
              }
        }

        private void SelectedFit_IndexChanged(object sender, EventArgs e)
        {
            //work with registries
            string layoutType = (BackgroundFitComboBox.SelectedItem).ToString();
            ExternalMethods.PersonalizationApi.SetBackgroundLayout(layoutType);
        }

        private void ChangeBackgroundButton_Click(object sender, EventArgs e)
        {
            if (ExternalMethods.PersonalizationApi.ChangeBackgroundWallpaper())
            {
                Data.ExtractDataFromRegistry();
                using (Image image = new Bitmap(Data.WallpaperPath)) 
                {
                      BackgroundPreview.BackgroundImage = new Bitmap(image, BackgroundPreview.Size.Height, BackgroundPreview.Size.Width); 
                }
            }
            
        }
    }
}
