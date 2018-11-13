using System;
using MetroFramework.Forms;
using System.IO;
using MediaOrganiser.Logic;
using System.Windows.Forms;

namespace MediaOrganiser
{
    public partial class MainScreen : MetroForm
    {
        string mode;
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
            if (!Directory.Exists(Path.Combine(userDirectory.GetCurrentPath(), lstMediaViewer.SelectedItems[0].Text)))
            {
                FileController controller = new FileController();
                if (mode == "edit")
                {
                    System.Collections.Generic.List<string> list = controller.GetData(Path.Combine(userDirectory.currentPath, lstMediaViewer.SelectedItems[0].Text));
                    FileDetails form = new FileDetails(lstMediaViewer.SelectedItems[0].Text, Path.Combine(userDirectory.currentPath,lstMediaViewer.SelectedItems[0].Text),list[3],list[2]);
                    form.Show();
                }
                else if (mode == "delete") 
                {
                    
                    controller.DeleteData(lstMediaViewer.SelectedItems[0].Text);
                    controller.DeleteFile(Path.Combine(userDirectory.currentPath, lstMediaViewer.SelectedItems[0].Text));
                    btnUploadFile.Enabled = true;
                    btnEditFile.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Unable to open file.");
                }
            }
            else
            {
                userDirectory.currentPath = Path.Combine(userDirectory.GetPath(), lstMediaViewer.SelectedItems[0].Text);
                userDirectory.SetCurrentPath();
                lstMediaViewer.Clear();
                lstMediaViewer.Items.AddRange(Viewer.DisplayDirectory(userDirectory.currentPath));

            }

        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            mode = "edit";
            btnDeleteFile.Enabled = false;
            btnUploadFile.Enabled = false;
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            mode = "delete";
            btnUploadFile.Enabled = false;
            btnEditFile.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] fileList = Directory.GetFiles(userDirectory.currentPath);
            lstMediaViewer.Clear();
            foreach (var item in fileList)
            {
                if (item.Contains(txtBoxSearch.Text))
                {
                    lstMediaViewer.Items.Add(item);
                }
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            FolderDetails folderForm = new FolderDetails(userDirectory.currentPath);
            folderForm.Show();
        }
    }
}
