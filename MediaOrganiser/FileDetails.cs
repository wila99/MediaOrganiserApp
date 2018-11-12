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
        UserDirectory userDirectory = new UserDirectory();
        string mode;
        public FileDetails(string fileName, string filePath, string fileCategory, string fileDesc)
        {
            mode = "edit";
            txtBoxFileName.Text = fileName;
            txtBoxFileDesc.Text = fileDesc;
            cboxCategory.Text = fileCategory;
            openFileDialog.FileName = filePath;

            InitializeComponent();
        }
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
              if (String.IsNullOrEmpty(openFileDialog.FileName))
            {
                MessageBox.Show("Error, unable to save details.");
            }
            else
            {
                FileController fileUploader = new FileController
                {
                    FileName = txtBoxFileName.Text,
                    FilePath = Path.Combine(userDirectory.GetCurrentPath(), txtBoxFileName.Text + Path.GetExtension(openFileDialog.FileName)),
                    Category = cboxCategory.Text,
                    FileType = Path.GetExtension(openFileDialog.FileName)
                };
                if (mode == "edit")
                {

                }
                else
                {
                    fileUploader.CopyFile(openFileDialog.FileName, fileUploader.FilePath);
                    fileUploader.SaveMediaData();
                }   
            }
         
        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }      
    
}
