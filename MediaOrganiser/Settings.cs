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
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtBoxDirPath.Text)))
            {               
                UserDirectory userDirectory = new UserDirectory(txtBoxDirPath.Text);
                userDirectory.SetPath();
                MessageBox.Show(userDirectory.CreateDirectory());
            }
        }
    }
}
