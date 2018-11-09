using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using MediaOrganiser.Logic;

namespace MediaOrganiser
{
    public partial class MainScreen : MetroForm
    {
        UserDirectory userDirectory = new UserDirectory();
        string currentPath;
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            Category category = new Category();
            category.AddCategory("test");
            category.AddCategory("test2");
            MessageBox.Show("Done");
            category.EditCategory("test3", "test2");
            //category.GetCategories();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Show();
        }
        private void btnRefreshDirectory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPath))
            {

            }
            lstMediaViewer.Clear();
            lstMediaViewer.Items.AddRange(Viewer.DisplayDirectory(currentPath));
        }
        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            FileDetails form = new FileDetails();
            form.Show();
        }
    }
}
