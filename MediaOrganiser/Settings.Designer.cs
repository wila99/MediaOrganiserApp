namespace MediaOrganiser
{
    partial class SettingsForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxDirPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSaveSettings = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Directory Path";
            // 
            // txtBoxDirPath
            // 
            // 
            // 
            // 
            this.txtBoxDirPath.CustomButton.Image = null;
            this.txtBoxDirPath.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtBoxDirPath.CustomButton.Name = "";
            this.txtBoxDirPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxDirPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxDirPath.CustomButton.TabIndex = 1;
            this.txtBoxDirPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxDirPath.CustomButton.UseSelectable = true;
            this.txtBoxDirPath.CustomButton.Visible = false;
            this.txtBoxDirPath.Lines = new string[0];
            this.txtBoxDirPath.Location = new System.Drawing.Point(121, 110);
            this.txtBoxDirPath.MaxLength = 32767;
            this.txtBoxDirPath.Name = "txtBoxDirPath";
            this.txtBoxDirPath.PasswordChar = '\0';
            this.txtBoxDirPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDirPath.SelectedText = "";
            this.txtBoxDirPath.SelectionLength = 0;
            this.txtBoxDirPath.SelectionStart = 0;
            this.txtBoxDirPath.ShortcutsEnabled = true;
            this.txtBoxDirPath.Size = new System.Drawing.Size(244, 23);
            this.txtBoxDirPath.TabIndex = 1;
            this.txtBoxDirPath.UseSelectable = true;
            this.txtBoxDirPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDirPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Categories";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(23, 392);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseSelectable = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 449);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBoxDirPath);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SettingsForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBoxDirPath;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSaveSettings;
    }
}