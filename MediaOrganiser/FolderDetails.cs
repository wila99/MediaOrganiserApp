using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaOrganiser.Logic;
using MetroFramework.Forms;
using System.IO;

namespace MediaOrganiser
{
    public partial class FolderDetails : MetroForm
    {
        private string currentPath;
        public FolderDetails(string currentPath)
        {
            this.currentPath = currentPath;
            InitializeComponent();
        }

        private void FolderDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(currentPath + @"\" + txtBoxFolder.Text))
            {
                MessageBox.Show("Folder already exists");
            }
            else
            {
                Directory.CreateDirectory(currentPath + @"\" + txtBoxFolder.Text);
                MessageBox.Show("Folder created");
            }
        }
    }
}
