using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MediaOrganiser.Logic
{
    public class FileController : Media
    {
        public void CopyFile(string sourcePath, string targetPath)
        {
            if (File.Exists(targetPath))
            {

            }
            else
            {
                File.Copy(sourcePath, targetPath);
            }
        }
        public void DeleteFile(string filePath)
        {
            File.Delete(filePath);
        }
    }
}
