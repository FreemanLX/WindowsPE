using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsPE
{
    public partial class PersonalizationForm : UserControl
    {

        int ResolutionComboBoxOK = 0; //for initialization
        public PersonalizationForm()
        {
            InitializeComponent();
            try
            {
                BackgroundFitComboBox.Text = Data.fit.ToString();
            }
            catch{}
        }

        private void display_Load(object sender, EventArgs e)
        {
              BackgroundPreview.BackgroundImage = Data.FormContainers.mainContainer.BackgroundImage;
              browseButton.BackColor = Data.color;
              colorsList.Text = Data.WinPEColors.FirstOrDefault(x => x.Value == Data.color).Key;
              colorsList.Items.AddRange(Data.WinPEColors.Keys.ToArray());    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SelectedFit_IndexChanged(object sender, EventArgs e) => new UpdateXML("settings.xml").Set("Fit", (BackgroundFitComboBox.SelectedItem).ToString());

        private void ChangeBackgroundButton_Click(object sender, EventArgs e)
        {
            IntPtr intPtr = IntPtr.Zero;
            ExternalMethods.OpenFileDialog(out intPtr);
            Data.WallpaperPath = Marshal.PtrToStringAnsi(intPtr);
            Marshal.FreeCoTaskMem(intPtr); ///cleaning the character array
            try
            {
                   BackgroundPreview.BackgroundImage = new Bitmap(Data.WallpaperPath);
                   Data.image = BackgroundPreview.BackgroundImage;
                   using(UpdateXML updateXML = new UpdateXML(Path.Combine(Data.applicationLocation, "Settings.xml")))
                   {
                       updateXML.Set("Wallpaper", Data.WallpaperPath);
                   }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ResolutionComboBoxOK == 1)
            {
                    try
                    {
                       //  string[] split = ResolutionComboBox.SelectedItem.ToString().Split('x');
                       //  Data.screenResolution = new Size(int.Parse(split[0]), int.Parse(split[1]));
                         new UpdateXML("settings.xml").Set("Resolution", Data.screenResolution.Width.ToString() + "x" + Data.screenResolution.Height.ToString());
                         ExternalMethods.ChangeScreenResolutionU(Data.screenResolution.Height, Data.screenResolution.Width);                    
                    }
                    catch (Exception)
                    {
                       //
                    }
            }
            else ResolutionComboBoxOK = 1;
        }

        private void ColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.color = Data.WinPEColors[(colorsList.SelectedItem).ToString()];
            new UpdateXML("settings.xml").Set("Color", (colorsList.SelectedItem).ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
