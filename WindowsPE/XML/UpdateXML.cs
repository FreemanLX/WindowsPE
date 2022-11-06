using System;
using System.Xml;

namespace WindowsPE
{
    class UpdateXML : IDisposable
    {
        XmlDocument xMLDocument;
        readonly string path;

        public UpdateXML(string path)
        {
            xMLDocument = new XmlDocument();
            this.path = path;
        }

        public void Set(string Node, string Data)
        {
            if (System.IO.File.Exists(path))
            {
                xMLDocument.Load(path);
                xMLDocument.SelectSingleNode("/root/" + Node).InnerText = Data;
                xMLDocument.Save(path);
            }
        }
        public void Dispose()
        {
            
        }
    }
}
