using System;
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
            if (!string.IsNullOrEmpty(userDirectory.GetPath()))
            {
                userDirectory.currentPath = userDirectory.GetPath();                    
                userDirectory.SetCurrentPath();
                lstMediaViewer.Clear();
                lstMediaViewer.Items.AddRange(Viewer.DisplayDirectory(userDirectory.currentPath));
            }           
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.Show();
        }
        private void btnRefreshDirectory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userDirectory.GetPath()))
            {
                userDirectory.currentPath = userDirectory.GetPath();
                lstMediaViewer.Clear();  
                lstMediaViewer.Items.AddRange(Viewer.DisplayDirectory(userDirectory.currentPath));
            }

        }
        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            FileDetails form = new FileDetails();
            form.Show();
        }

        private void lstMediaViewer_Click(object sender, EventArgs e)
        {
            userDirectory.currentPath = Path.Combine(userDirectory.GetPath(), lstMediaViewer.SelectedItems[0].Text);
            userDirectory.SetCurrentPath();
            lstMediaViewer.Clear();
            lstMediaViewer.Items.AddRange(Viewer.DisplayDirectory(userDirectory.currentPath));
        }
    }
}
