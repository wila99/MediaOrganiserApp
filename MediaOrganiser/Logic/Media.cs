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
        public string FileDescription { get; set; }

        public void SaveMediaData()
        {
            // This part is creation of RootNode, however you want
            root = XElement.Load(@"Data\Data.xml");
            XElement rootElement = new XElement("FileStore");

            XElement fileParentPathElement = new XElement("FilePath" + FileName);
            XElement filePathElement = new XElement("FilePath", FilePath);
            XElement fileNameElement = new XElement("FileName", FileName);
            XElement fileTypeElement = new XElement("FileType", FileType);
            XElement fileDescriptionElement = new XElement("FileDescription", FileDescription);

            XElement catElement = new XElement("Category", Category);

            fileParentPathElement.Add(filePathElement, fileNameElement, fileTypeElement, fileDescriptionElement, catElement);

            root.Add(rootElement, fileParentPathElement);

            root.Save(@"Data\Data.XML");
        }
        public void DeleteData(string file)
        {
            root = XElement.Load(@"Data\Data.xml");
            root.Descendants("FilePath" + file).Descendants().Remove();
            root.Save("Data/Data.xml");
        }
        public List<string> GetData(string filePath)
        {
            List<string> list = new List<string>();
            root = XElement.Load(@"Data\Data.xml");
            
            return list;
        }
    }
}

//var query = from xml in root.Descendants("FilePath" + FileName)
//            where (string)xml.Element("FilePath")
//                                         == filePath
//            select new
//            {
//                filePath = (string)xml.Element("FilePath"),
//                fileName = (string)xml.Element("FileName"),
//                fileType = (string)xml.Element("FileType"),
//                category = (string)xml.Element("Category")
//            };
//            foreach (var item in query)
//                list.Add(item.ToString());
