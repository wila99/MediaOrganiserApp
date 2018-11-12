using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediaOrganiser.Logic
{
    public class Media
    {
        XElement root;
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string Category { get; set; }

        public void SaveMediaData()
        {
            root = XElement.Load(@"Data\Data.xml");
            XElement rootElement = new XElement("FileStore");
           
            XElement filePathElement = new XElement("FilePath", new XAttribute("name", FilePath));
            XElement fileNameElement = new XElement("FileName", new XAttribute("name", FileName));
            XElement fileTypeElement = new XElement("FileType", new XAttribute("name", FileType));
            XElement catElement = new XElement("Category", new XAttribute("name", Category));

            filePathElement.Add(fileNameElement, fileTypeElement, catElement);

            root.Add(rootElement,filePathElement);
            
            root.Save(@"Data\Data.XML");
        }
    }
}
