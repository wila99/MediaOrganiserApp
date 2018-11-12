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
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxCategory = new MetroFramework.Controls.MetroTextBox();
            this.btnAddCat = new MetroFramework.Controls.MetroButton();
            this.btnEditCat = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSaveCat = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
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
            this.txtBoxDirPath.Click += new System.EventHandler(this.txtBoxDirPath_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Categories";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(371, 110);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 3;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseSelectable = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.AllowUserToDeleteRows = false;
            this.dataGridViewCategory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(20, 256);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.ReadOnly = true;
            this.dataGridViewCategory.RowHeadersVisible = false;
            this.dataGridViewCategory.Size = new System.Drawing.Size(384, 201);
            this.dataGridViewCategory.TabIndex = 4;
            this.dataGridViewCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellContentClick);
            this.dataGridViewCategory.SelectionChanged += new System.EventHandler(this.dataGridViewCategory_SelectionChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Category Name";
            // 
            // txtBoxCategory
            // 
            // 
            // 
            // 
            this.txtBoxCategory.CustomButton.Image = null;
            this.txtBoxCategory.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtBoxCategory.CustomButton.Name = "";
            this.txtBoxCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxCategory.CustomButton.TabIndex = 1;
            this.txtBoxCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxCategory.CustomButton.UseSelectable = true;
            this.txtBoxCategory.CustomButton.Visible = false;
            this.txtBoxCategory.Lines = new string[0];
            this.txtBoxCategory.Location = new System.Drawing.Point(133, 192);
            this.txtBoxCategory.MaxLength = 32767;
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.PasswordChar = '\0';
            this.txtBoxCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxCategory.SelectedText = "";
            this.txtBoxCategory.SelectionLength = 0;
            this.txtBoxCategory.SelectionStart = 0;
            this.txtBoxCategory.ShortcutsEnabled = true;
            this.txtBoxCategory.Size = new System.Drawing.Size(232, 23);
            this.txtBoxCategory.TabIndex = 6;
            this.txtBoxCategory.UseSelectable = true;
            this.txtBoxCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(20, 227);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddCat.TabIndex = 7;
            this.btnAddCat.Text = "Add";
            this.btnAddCat.UseSelectable = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnEditCat
            // 
            this.btnEditCat.Location = new System.Drawing.Point(101, 227);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(75, 23);
            this.btnEditCat.TabIndex = 8;
            this.btnEditCat.Text = "Edit";
            this.btnEditCat.UseSelectable = true;
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(371, 192);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCat.TabIndex = 10;
            this.btnSaveCat.Text = "Save";
            this.btnSaveCat.UseSelectable = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 472);
            this.Controls.Add(this.btnSaveCat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditCat);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.txtBoxCategory);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtBoxDirPath);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SettingsForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBoxDirPath;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnSaveSettings;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtBoxCategory;
        private MetroFramework.Controls.MetroButton btnAddCat;
        private MetroFramework.Controls.MetroButton btnEditCat;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSaveCat;
    }
}