using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaOrganiser.Logic
{
    public class FileUploader : Media
    {
        public void CopyFile(string sourcePath, string targetPath)
        {
            File.Copy(sourcePath,targetPath);
        }
    }
}
