using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsPE
{
    public static partial class Data
    {
        /// <summary>
        /// Display personalization
        /// </summary>
        public static Size screenResolution = new Size(0, 0);
        public static Settings.SettingsForm settingsForm;

        /// <summary>
        /// Desktop personalization
        /// </summary>
        public static string WallpaperPath = "";
        public static Dictionary<string, ImageLayout> WinPEImageLayout;
        public static Color color = Color.FromArgb(0, 174, 219);

        public static void Init()
        {
            WinPEImageLayout = new Dictionary<string, ImageLayout>
            {
                {"Fill", ImageLayout.None},
                {"Tile", ImageLayout.Tile},
                {"Center", ImageLayout.Center},
                {"Stretch", ImageLayout.Stretch},
                {"Zoom", ImageLayout.Zoom}
            };
        }

        public static void ExtractDataFromRegistry()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop");
            if(key != null)
            {
                WallpaperPath = key.GetValue("WallPaper") as string; //this is how it named
            }
        }
    }
}
  
