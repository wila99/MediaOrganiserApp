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
        string mode;
        string selectedCategory;
        UserDirectory userDirectory;
        Category category = new Category();
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
            RefreshDataGridView();
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

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCategory = dataGridViewCategory.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            txtBoxCategory.Text = selectedCategory;

        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                if (string.IsNullOrEmpty(selectedCategory) || string.IsNullOrEmpty(txtBoxCategory.Text) == true)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    category.EditCategory(txtBoxCategory.Text, selectedCategory);

                }
            }
            else if (mode == "delete")
            {
                category.DeleteCategory(txtBoxCategory.Text);
            }
            else if (mode == "add")
            {
                if (string.IsNullOrEmpty(txtBoxCategory.Text) == true)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    if (category.AddCategory(txtBoxCategory.Text) == false)
                    {
                        MessageBox.Show("Error category already exists");

                    }
                    else if (category.AddCategory(txtBoxCategory.Text) == true)
                    {
                        MessageBox.Show("Category added.");
                    }
                }
            }


            btnAddCat.Enabled = true;
            btnEditCat.Enabled = true;
            btnDelete.Enabled = true;
            RefreshDataGridView();

        }
        private void RefreshDataGridView()
        {
            dataGridViewCategory.DataSource = ConvertListToDataTable(category.GetCategories());

        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnDelete.Enabled = false;
            btnEditCat.Enabled = false;
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            mode = "edit";
            btnAddCat.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mode = "delete";
            btnAddCat.Enabled = false;
            btnEditCat.Enabled = false;
        }

        private void dataGridViewCategory_SelectionChanged(object sender, EventArgs e)
        {

        }

        private DataTable ConvertListToDataTable(List<string> stringList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Category Name");
            foreach (var item in stringList)
            {
                table.Rows.Add(item);
            }
            return table;
        }
    }
}
