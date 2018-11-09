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
using System.IO;

namespace MediaOrganiser
{
    public partial class FileDetails : MetroForm
    {
        
        public FileDetails()
        {
            InitializeComponent();
        }

        private void FileDetails_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Audio Files|*.mp3; *.mpa; *.wav; *.wma; *.midi" +
                "|Video Files|*.mp4; *.mpg; *.mpeg; *.avi; *.flv; *.wmv; *.mov" +
                "|Image Files|*.ai; *.bmp; *.gif; *.ico; *.jpg; *.jpeg; *.png; *.ps; *.psd; *.svg; *.tif" +
                "|Miscellaneous Files|*.7z; *.rar; *.zip; *.xlsx; *.doc; *.docx; *.pdf; *.txt; *.ppt; *.pptx";
            Category category = new Category();
            foreach (var item in category.GetCategories())
            {
                cboxCategory.Items.Add(item);
            }
            
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            FileUploader uploader = new FileUploader();
            //uploader.
        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }      
    
}
