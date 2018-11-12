using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaOrganiser.Logic
{
    public class Viewer
    {
       
        public static ListViewItem[] DisplayDirectory(string path)
        {
            var directoryItems = new List<ListViewItem>();
            if (!(string.IsNullOrEmpty(path)))
            {
                foreach (var file in Directory.GetFiles(@path))
                {
                    //Gets file name without returning the full path.
                    string fileName = Path.GetFileName(file);
                    ListViewItem fileItem = new ListViewItem(fileName);
                    directoryItems.Add(fileItem);
                }
                foreach (string folder in Directory.GetDirectories(@path))
                {
                    //Gets folder name without returning the full path.
                    string folderName = Path.GetFileName(folder);

                    ListViewItem folderItem = new ListViewItem(folderName);
                    directoryItems.Add(folderItem);
                }
                return directoryItems.ToArray();
            }
            else
            {
                return directoryItems.ToArray();
            }
           
        }
        //public static void FilterItems()
        //{
        //}
    }
}
