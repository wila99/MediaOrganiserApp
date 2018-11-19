namespace MediaOrganiser
{
    partial class FileDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFileName = new MetroFramework.Controls.MetroLabel();
            this.lblFileDescription = new MetroFramework.Controls.MetroLabel();
            this.lblCategory = new MetroFramework.Controls.MetroLabel();
            this.cboxCategory = new MetroFramework.Controls.MetroComboBox();
            this.txtBoxFileName = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxFileDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnUploadFile = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveDetails = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(52, 84);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(69, 19);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            // 
            // lblFileDescription
            // 
            this.lblFileDescription.AutoSize = true;
            this.lblFileDescription.Location = new System.Drawing.Point(23, 188);
            this.lblFileDescription.Name = "lblFileDescription";
            this.lblFileDescription.Size = new System.Drawing.Size(98, 19);
            this.lblFileDescription.TabIndex = 1;
            this.lblFileDescription.Text = "File Description";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(57, 137);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 19);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // cboxCategory
            // 
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.ItemHeight = 23;
            this.cboxCategory.Location = new System.Drawing.Point(127, 137);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(275, 29);
            this.cboxCategory.Style = MetroFramework.MetroColorStyle.Black;
            this.cboxCategory.TabIndex = 3;
            this.cboxCategory.UseSelectable = true;
            this.cboxCategory.SelectedIndexChanged += new System.EventHandler(this.cboxCategory_SelectedIndexChanged);
            // 
            // txtBoxFileName
            // 
            // 
            // 
            // 
            this.txtBoxFileName.CustomButton.Image = null;
            this.txtBoxFileName.CustomButton.Location = new System.Drawing.Point(247, 2);
            this.txtBoxFileName.CustomButton.Name = "";
            this.txtBoxFileName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBoxFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxFileName.CustomButton.TabIndex = 1;
            this.txtBoxFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxFileName.CustomButton.UseSelectable = true;
            this.txtBoxFileName.CustomButton.Visible = false;
            this.txtBoxFileName.Lines = new string[0];
            this.txtBoxFileName.Location = new System.Drawing.Point(127, 83);
            this.txtBoxFileName.MaxLength = 32767;
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.PasswordChar = '\0';
            this.txtBoxFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxFileName.SelectedText = "";
            this.txtBoxFileName.SelectionLength = 0;
            this.txtBoxFileName.SelectionStart = 0;
            this.txtBoxFileName.ShortcutsEnabled = true;
            this.txtBoxFileName.Size = new System.Drawing.Size(275, 30);
            this.txtBoxFileName.TabIndex = 4;
            this.txtBoxFileName.UseSelectable = true;
            this.txtBoxFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxFileDesc
            // 
            // 
            // 
            // 
            this.txtBoxFileDesc.CustomButton.Image = null;
            this.txtBoxFileDesc.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.txtBoxFileDesc.CustomButton.Name = "";
            this.txtBoxFileDesc.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtBoxFileDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxFileDesc.CustomButton.TabIndex = 1;
            this.txtBoxFileDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxFileDesc.CustomButton.UseSelectable = true;
            this.txtBoxFileDesc.CustomButton.Visible = false;
            this.txtBoxFileDesc.Lines = new string[0];
            this.txtBoxFileDesc.Location = new System.Drawing.Point(128, 183);
            this.txtBoxFileDesc.MaxLength = 32767;
            this.txtBoxFileDesc.Name = "txtBoxFileDesc";
            this.txtBoxFileDesc.PasswordChar = '\0';
            this.txtBoxFileDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxFileDesc.SelectedText = "";
            this.txtBoxFileDesc.SelectionLength = 0;
            this.txtBoxFileDesc.SelectionStart = 0;
            this.txtBoxFileDesc.ShortcutsEnabled = true;
            this.txtBoxFileDesc.Size = new System.Drawing.Size(274, 120);
            this.txtBoxFileDesc.TabIndex = 5;
            this.txtBoxFileDesc.UseSelectable = true;
            this.txtBoxFileDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxFileDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(213, 309);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(94, 40);
            this.btnUploadFile.TabIndex = 6;
            this.btnUploadFile.Text = "Upload FIle";
            this.btnUploadFile.UseSelectable = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnSaveDetails
            // 
            this.btnSaveDetails.Location = new System.Drawing.Point(298, 364);
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(94, 40);
            this.btnSaveDetails.TabIndex = 7;
            this.btnSaveDetails.Text = "Save";
            this.btnSaveDetails.UseSelectable = true;
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // FileDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 427);
            this.Controls.Add(this.btnSaveDetails);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.txtBoxFileDesc);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.cboxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblFileDescription);
            this.Controls.Add(this.lblFileName);
            this.Name = "FileDetails";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "File Details";
            this.Load += new System.EventHandler(this.FileDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblFileName;
        private MetroFramework.Controls.MetroLabel lblFileDescription;
        private MetroFramework.Controls.MetroLabel lblCategory;
        private MetroFramework.Controls.MetroComboBox cboxCategory;
        private MetroFramework.Controls.MetroTextBox txtBoxFileName;
        private MetroFramework.Controls.MetroTextBox txtBoxFileDesc;
        private MetroFramework.Controls.MetroButton btnUploadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroButton btnSaveDetails;
    }
}