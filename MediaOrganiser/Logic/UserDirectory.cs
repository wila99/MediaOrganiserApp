﻿using System.Xml.Linq;
using System.IO;

namespace MediaOrganiser.Logic
{
    public class UserDirectory
    {
        private string DirectoryPath { get; set; }
        public string currentPath { get; set; }
        XDocument xDocument = XDocument.Load("Data/Data.xml");

        public UserDirectory(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }
        //Blank constructor to allow retrieval of directory path.
        public UserDirectory() { }

        public void SetPath()
        {
            xDocument.Root.Element("directory").SetValue(DirectoryPath);
            xDocument.Save("Data/Data.xml");
        }
        public string GetPath()
        {
            xDocument = XDocument.Load("Data/Data.xml");
            return xDocument.Root.Element("directory").Value;
        }
        public void SetCurrentPath()
        {
            xDocument.Root.Element("CurrentDirectory").SetValue(currentPath);
            xDocument.Save("Data/Data.xml");           
        }
        public string GetCurrentPath()
        {
            xDocument = XDocument.Load("Data/Data.xml");
            return xDocument.Root.Element("CurrentDirectory").Value;
        } 
        public string CreateDirectory()
        {
            if (string.IsNullOrEmpty((Path.GetPathRoot(DirectoryPath))))
            {
                return "Invalid path";
            }
            else
            {
                if (!(Directory.Exists(DirectoryPath)))
                {
                    Directory.CreateDirectory(DirectoryPath);
                    return "Folder Created";
                }
                else
                {
                    return "Folder Exists";
                }
            }
            
        }

    }
}
