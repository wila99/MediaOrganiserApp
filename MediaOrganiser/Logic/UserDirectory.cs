using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace MediaOrganiser.Logic
{
    public class UserDirectory
    {
        private string DirectoryPath { get; set; }
        XDocument xDocument = XDocument.Load("Data/Data.xml");

        public UserDirectory(string directoryPath)
        {
            DirectoryPath = directoryPath;
        }
        //Blank constructor to allow retrieval of directory path.
        public UserDirectory() {       }

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
