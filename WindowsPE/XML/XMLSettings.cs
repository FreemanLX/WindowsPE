using System;
using System.Xml;

namespace WindowsPE
{
    public class XMLSettings : IDisposable
    {
        private XmlTextReader textReader;

        public XMLSettings(string path) => textReader = new XmlTextReader(path);

        public void Dispose() => textReader.Dispose();

        /// <summary>
        /// Check if the current node has the selected string name
        /// </summary>
        /// <param name="xmlNodeType">node</param>
        /// <param name="name">selected string name</param>
        /// <returns>a bool</returns>
        private bool Check(XmlTextReader xmlNodeType, string name) => 
            (xmlNodeType.NodeType == XmlNodeType.Element && xmlNodeType.Name == name);

        public void OSLoaded()
        {
            while (textReader.Read())
            {
                    if (Check(textReader, "Loaded")) 
                         bool.TryParse(textReader.ReadElementString(), out Data.FormContainers.OSLoaded);
            }
        }
        /// <summary>
        /// Reads XML type format
        /// </summary>
        public void Read()
        {
            while (textReader.Read())
            {
                try
                {
                    if (Check(textReader, "Color")){
                        Data.color = Data.WinPEColors[textReader.ReadElementString()];
                    }
                    if (Check(textReader, "Resolution"))
                    {
                        string[] resolution = textReader.ReadElementString().Split('x');
                        Data.screenResolution = new System.Drawing.Size(int.Parse(resolution[0]), int.Parse(resolution[1]));
                        ExternalMethods.ChangeScreenResolutionU(Data.screenResolution.Height, Data.screenResolution.Width);
                    }
                    if (Check(textReader, "Wallpaper"))
                    {
                        Data.WallpaperPath = textReader.ReadElementString();
                    }
                    if((Check(textReader, "Fit")))
                    {
                        Data.fit = Data.WinPEImageLayout[(textReader.ReadElementString())];
                    }
                }
                catch{}
            }
        }
    }
}
  
