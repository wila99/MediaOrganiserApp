namespace MediaOrganiser
{
    partial class MainScreen
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
            this.btnUploadFile = new MetroFramework.Controls.MetroButton();
            this.btnCreateFolder = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.lstMediaViewer = new System.Windows.Forms.ListView();
            this.btnRefreshDirectory = new MetroFramework.Controls.MetroButton();
            this.btnDeleteFile = new MetroFramework.Controls.MetroButton();
            this.btnEditFile = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(586, 101);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(81, 39);
            this.btnUploadFile.TabIndex = 0;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseSelectable = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(586, 266);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(81, 39);
            this.btnCreateFolder.TabIndex = 1;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseSelectable = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(23, 435);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(81, 39);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(23, 64);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 19);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // txtBoxSearch
            // 
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.CustomButton.Visible = false;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(77, 60);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.ShortcutsEnabled = true;
            this.txtBoxSearch.Size = new System.Drawing.Size(185, 23);
            this.txtBoxSearch.TabIndex = 5;
            this.txtBoxSearch.UseSelectable = true;
            this.txtBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(255, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstMediaViewer
            // 
            this.lstMediaViewer.Location = new System.Drawing.Point(23, 101);
            this.lstMediaViewer.Name = "lstMediaViewer";
            this.lstMediaViewer.Size = new System.Drawing.Size(542, 328);
            this.lstMediaViewer.TabIndex = 7;
            this.lstMediaViewer.UseCompatibleStateImageBehavior = false;
            this.lstMediaViewer.View = System.Windows.Forms.View.SmallIcon;
            this.lstMediaViewer.Click += new System.EventHandler(this.lstMediaViewer_Click);
            // 
            // btnRefreshDirectory
            // 
            this.btnRefreshDirectory.Location = new System.Drawing.Point(586, 320);
            this.btnRefreshDirectory.Name = "btnRefreshDirectory";
            this.btnRefreshDirectory.Size = new System.Drawing.Size(81, 39);
            this.btnRefreshDirectory.TabIndex = 8;
            this.btnRefreshDirectory.Text = "Refresh";
            this.btnRefreshDirectory.UseSelectable = true;
            this.btnRefreshDirectory.Click += new System.EventHandler(this.btnRefreshDirectory_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(586, 211);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(81, 39);
            this.btnDeleteFile.TabIndex = 9;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseSelectable = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnEditFile
            // 
            this.btnEditFile.Location = new System.Drawing.Point(586, 155);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(81, 39);
            this.btnEditFile.TabIndex = 10;
            this.btnEditFile.Text = "Edit File";
            this.btnEditFile.UseSelectable = true;
            this.btnEditFile.Click += new System.EventHandler(this.btnEditFile_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 488);
            this.Controls.Add(this.btnEditFile);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnRefreshDirectory);
            this.Controls.Add(this.lstMediaViewer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnUploadFile);
            this.Name = "MainScreen";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Media Organiser";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnUploadFile;
        private MetroFramework.Controls.MetroButton btnCreateFolder;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.ListView lstMediaViewer;
        private MetroFramework.Controls.MetroButton btnRefreshDirectory;
        private MetroFramework.Controls.MetroButton btnDeleteFile;
        private MetroFramework.Controls.MetroButton btnEditFile;
    }
}

