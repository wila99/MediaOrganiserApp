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
using MediaOrganiser.Logic;

namespace MediaOrganiser
{
    public partial class SettingsForm : MetroForm
    {
        UserDirectory userDirectory;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            userDirectory = new UserDirectory();
            if (!(string.IsNullOrEmpty(userDirectory.GetPath())))
            {
                txtBoxDirPath.Text = userDirectory.GetPath();
            }

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtBoxDirPath.Text)))
            {               
                userDirectory = new UserDirectory(txtBoxDirPath.Text);
                userDirectory.SetPath();
                MessageBox.Show(userDirectory.CreateDirectory());
            }
        }

        private void txtBoxDirPath_Click(object sender, EventArgs e)
        {
        }
    }
}
