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
            this.txtBoxFIleName = new MetroFramework.Controls.MetroTextBox();
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
            this.cboxCategory.TabIndex = 3;
            this.cboxCategory.UseSelectable = true;
            // 
            // txtBoxFIleName
            // 
            // 
            // 
            // 
            this.txtBoxFIleName.CustomButton.Image = null;
            this.txtBoxFIleName.CustomButton.Location = new System.Drawing.Point(247, 2);
            this.txtBoxFIleName.CustomButton.Name = "";
            this.txtBoxFIleName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBoxFIleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxFIleName.CustomButton.TabIndex = 1;
            this.txtBoxFIleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxFIleName.CustomButton.UseSelectable = true;
            this.txtBoxFIleName.CustomButton.Visible = false;
            this.txtBoxFIleName.Lines = new string[0];
            this.txtBoxFIleName.Location = new System.Drawing.Point(127, 81);
            this.txtBoxFIleName.MaxLength = 32767;
            this.txtBoxFIleName.Name = "txtBoxFIleName";
            this.txtBoxFIleName.PasswordChar = '\0';
            this.txtBoxFIleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxFIleName.SelectedText = "";
            this.txtBoxFIleName.SelectionLength = 0;
            this.txtBoxFIleName.SelectionStart = 0;
            this.txtBoxFIleName.ShortcutsEnabled = true;
            this.txtBoxFIleName.Size = new System.Drawing.Size(275, 30);
            this.txtBoxFIleName.TabIndex = 4;
            this.txtBoxFIleName.UseSelectable = true;
            this.txtBoxFIleName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxFIleName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Controls.Add(this.txtBoxFIleName);
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
        private MetroFramework.Controls.MetroTextBox txtBoxFIleName;
        private MetroFramework.Controls.MetroTextBox txtBoxFileDesc;
        private MetroFramework.Controls.MetroButton btnUploadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroButton btnSaveDetails;
    }
}