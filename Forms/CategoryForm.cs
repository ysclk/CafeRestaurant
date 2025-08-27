using CafeRestaurant.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CafeRestaurant.Models;
using CafeRestaurant.Repositories;


namespace CafeRestaurant.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryService cts;
        private readonly CategoryRepository categoryRepository;

        public CategoryForm(CategoryService cts, CategoryRepository categoryRepository)
        {
            InitializeComponent();
            this.cts = cts;
            this.categoryRepository = categoryRepository;
            // Load category list on form initialization
            LoadCategoryList();
        }

    

        /// <summary>
        /// Loads the category list and sets column headers.
        /// </summary>
        private async void LoadCategoryList()
        {
            var list =(await categoryRepository.GetAllAsync())
           .OrderBy(c => c.CATEGORYNAME)
           .ToList();

            if (list == null || list.Count == 0)
            {
                MessageBox.Show("No categories found.");
            }

            dgCatList.DataSource = list;
            dgCatList.Columns["CATEGORYID"].Visible = false;
            dgCatList.Columns[1].HeaderText = "Name";
            dgCatList.Columns[2].HeaderText = "Description";

            // Optional: consistent cell color
            dgCatList.DefaultCellStyle.BackColor = Color.White;
            dgCatList.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        //Adding new Category to database
        private void btnCatSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            try
                {
                    var newCategory = new CATEGORY
                    {
                        CATEGORYNAME = txbCatName.Text,
                        CATEGORYDESC = txbCatDesc.Text
                    };

                _ = categoryRepository.InsertAsync(newCategory);
                    MessageBox.Show("Category inserted successfully!");

                    LoadCategoryList(); // Refresh list
                    ClearFormInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insertion failed: " + ex.Message);
            }
            
        }

        /// <summary>
        /// Clears all input fields.
        /// </summary>
        private void ClearFormInputs()
        {
            txbCatName.Clear();
            txbCatDesc.Clear();
           
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {        
                int categoryId = Convert.ToInt32(lblSifre.Text);
                var categoryEx = await categoryRepository.GetByIdAsync(categoryId);

                if (categoryEx != null)
                {
                    categoryEx.CATEGORYNAME = txbCatName.Text;
                    categoryEx.CATEGORYDESC = txbCatDesc.Text;

                    try
                    {
                        await  categoryRepository.UpdateAsync(categoryEx);
                        MessageBox.Show("Category updated successfully!");

                        LoadCategoryList(); // Refresh list
                        ClearFormInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update failed: " + ex.Message);
                    }
                }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblSifre.Text != "label1")
            {
                int categoryId = Convert.ToInt32(lblSifre.Text);
                try
                {
                    await categoryRepository.DeleteAsync(categoryId);
                    MessageBox.Show("Category deleted successfully!");

                    LoadCategoryList(); // Refresh list
                    ClearFormInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deletion failed: " + ex.Message);
                }
            }
        }

        private void dgCatList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgCatList.Rows[rowIndex];
                int categoryId = Convert.ToInt32(selectedRow.Cells[0].Value?.ToString());
                string categoryName = selectedRow.Cells[1].Value?.ToString();
                string categoryDesc = selectedRow.Cells[2].Value?.ToString();

                txbCatName.Text = categoryName;
                txbCatDesc.Text = categoryDesc;
                lblSifre.Text = categoryId.ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txbCatName.Text))
            {
                MessageBox.Show("Please enter a category name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbCatDesc.Text))
            {
                MessageBox.Show("Please enter a category description.");
                return false;
            }

            return true;
        }

        private bool sortAscending = true; // Başlangıçta A-Z
        private async void dgCatList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var allCategories = await categoryRepository.GetAllAsync();
            // Sadece kategori adına göre sıralama yapılacaksa, sütun indexi 1'dir
            if (e.ColumnIndex == 1)
            {
                if (sortAscending)
                {
                    allCategories = allCategories.OrderByDescending(c => c.CATEGORYNAME).ToList();
                    dgCatList.Columns[1].HeaderText = "Name ▼";
                }
                else
                {
                    allCategories = allCategories.OrderBy(c => c.CATEGORYNAME).ToList();
                    dgCatList.Columns[1].HeaderText = "Name ▲";
                }

                sortAscending = !sortAscending;
                dgCatList.DataSource = null;
                dgCatList.DataSource = allCategories;

                dgCatList.Columns["CATEGORYID"].Visible = false;
                dgCatList.Columns[1].HeaderText = sortAscending ? "Name ▲" : "Name ▼";
                dgCatList.Columns[2].HeaderText = "Description";
            }

        }
    }
}
