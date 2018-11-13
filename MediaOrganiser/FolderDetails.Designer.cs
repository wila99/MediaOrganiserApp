namespace MediaOrganiser
{
    partial class FolderDetails
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
            this.txtBoxFolder = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtBoxFolder
            // 
            // 
            // 
            // 
            this.txtBoxFolder.CustomButton.Image = null;
            this.txtBoxFolder.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txtBoxFolder.CustomButton.Name = "";
            this.txtBoxFolder.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxFolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxFolder.CustomButton.TabIndex = 1;
            this.txtBoxFolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxFolder.CustomButton.UseSelectable = true;
            this.txtBoxFolder.CustomButton.Visible = false;
            this.txtBoxFolder.Lines = new string[0];
            this.txtBoxFolder.Location = new System.Drawing.Point(115, 80);
            this.txtBoxFolder.MaxLength = 32767;
            this.txtBoxFolder.Name = "txtBoxFolder";
            this.txtBoxFolder.PasswordChar = '\0';
            this.txtBoxFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxFolder.SelectedText = "";
            this.txtBoxFolder.SelectionLength = 0;
            this.txtBoxFolder.SelectionStart = 0;
            this.txtBoxFolder.ShortcutsEnabled = true;
            this.txtBoxFolder.Size = new System.Drawing.Size(262, 23);
            this.txtBoxFolder.TabIndex = 0;
            this.txtBoxFolder.UseSelectable = true;
            this.txtBoxFolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxFolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Folder Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FolderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtBoxFolder);
            this.Name = "FolderDetails";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Folder Details";
            this.Load += new System.EventHandler(this.FolderDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBoxFolder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}