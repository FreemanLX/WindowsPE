using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE
{
    public static partial class Data
    {
        public static Image image;
        public static ImageLayout fit = ImageLayout.Stretch;
        public static Size screenResolution = new Size(0, 0);
        public static Dictionary<int, string[]> resolutions = null;
        public static int[] DisplayIndex = null;
        public static string WallpaperPath = "";
        public static string[] NetPaths = null;
        public static string[] NetSharesName = null;
        public static Dictionary<string, Color> WinPEColors;
        public static Dictionary<string, ImageLayout> WinPEImageLayout;
        public static Color color;
        public static string applicationLocation = System.IO.Directory.GetCurrentDirectory();

        public static void Init()
        {
            WinPEColors = new Dictionary<string, Color>
            {
                { "Silver", Color.FromArgb(85, 85, 85) },
                { "Blue", Color.FromArgb(0, 174, 219) },
                { "Green", Color.FromArgb(0, 177, 89) },
                { "Lime", Color.FromArgb(142, 188, 0) },
                { "Teal", Color.FromArgb(0, 170, 173) },
                { "Orange", Color.FromArgb(243, 119, 53) },
                { "Brown", Color.FromArgb(165, 81, 0) },
                { "Pink", Color.FromArgb(231, 113, 189) },
                { "Magenta", Color.FromArgb(255, 0, 148) },
                { "Red", Color.FromArgb(209, 17, 65) },
                { "Purple", Color.FromArgb(124, 65, 153) },
                { "Yellow", Color.FromArgb(255, 196, 37) }
            };
            WinPEImageLayout = new Dictionary<string, ImageLayout>
            {
                {"Fill", ImageLayout.None},
                {"Tile", ImageLayout.Tile},
                {"Center", ImageLayout.Center},
                {"Stretch", ImageLayout.Stretch},
                {"Zoom", ImageLayout.Zoom}
            };
        }
    }
}
  
