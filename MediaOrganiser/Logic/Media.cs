﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml;

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
           
            XElement fileParentPathElement = new XElement("FilePath" +FileName);
            XElement filePathElement = new XElement("FilePath", FilePath);
            XElement fileNameElement = new XElement("FileName", FileName);
            XElement fileTypeElement = new XElement("FileType", FileType);
            XElement catElement = new XElement("Category", Category);

            fileParentPathElement.Add(filePathElement, fileNameElement, fileTypeElement, catElement);

            root.Add(rootElement, fileParentPathElement);
            
            root.Save(@"Data\Data.XML");
        }
        public void DeleteData(string file)
        {
            root = XElement.Load(@"Data\Data.xml");
            root.Descendants("FilePath"+file).Descendants().Remove();
            root.Save("Data/Data.xml");
        }
        public List<string> GetData()
        {
            List<string> list = new List<string>();

            root = XElement.Load(@"Data\Data.xml");
            foreach (XElement xe in root.Descendants("category"))
            {
                list.Add(xe.Value);
            }
            return list;
        }
    }
}
