﻿using System.Collections.Generic;
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
                if (!(Directory.GetFiles(@path).Length == 0))
                {
                    foreach (var file in Directory.GetFiles(@path))
                    {
                        //Gets file name without returning the full path.
                        string fileName = Path.GetFileName(file);
                        ListViewItem fileItem = new ListViewItem(fileName);
                        directoryItems.Add(fileItem);
                    }
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
    }
}
