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
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Show();
        }

        private void lstMediaViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshDirectory_Click(object sender, EventArgs e)
        {
            lstMediaViewer.Clear();
            lstMediaViewer.Items.AddRange(Viewer.DisplayDirectory(userDirectory.GetPath()));
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            FileDetails form = new FileDetails();
            form.Show();
        }
    }
}
