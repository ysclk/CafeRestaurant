using CafeRestaurant.Services;
using System;
using System.Windows.Forms;
using CafeRestaurant.Models;

namespace CafeRestaurant.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ProductService ps = new ProductService(new CafeRestaurantEntities());
        private readonly CategoryService cts = new CategoryService(new CafeRestaurantEntities());
        private readonly StockTransactionService sts = new StockTransactionService();
        private readonly CafeRestaurantEntities db = new CafeRestaurantEntities();

        public ProductForm()
        {
            InitializeComponent();
            InitializeFormData();
        }

        private async void InitializeFormData()
        {
            // Populate ComboBox with category data
            cbCategories.DataSource = await cts.GetAllAsync();
            cbCategories.DisplayMember = "CATEGORYNAME";
            cbCategories.ValueMember = "CATEGORYID";

            // Populate DataGridView with product list (including category info)
            dgProdList.DataSource = await ps.GetAllWithCategoryAsync();

            // Hide internal ID columns
            dgProdList.Columns["CATEGORYID"].Visible = false;
            dgProdList.Columns["PRODUCTID"].Visible = false;

            // Rename column headers for user clarity
            dgProdList.Columns[1].HeaderText = "Product";
            dgProdList.Columns[2].HeaderText = "Category";
            dgProdList.Columns[3].HeaderText = "Price";
            dgProdList.Columns[4].HeaderText = "Stock";
        }

        private async void btnProdSave_Click(object sender, EventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    // Create new product object from form inputs
                    var newProduct = new PRODUCT
                    {
                        CATEGORYID = Convert.ToInt32(cbCategories.SelectedValue),
                        PRODUCTNAME = txbProName.Text,
                        PRODUCTPRICE = Convert.ToDecimal(txbProPrice.Text),
                        STOCK = Convert.ToInt32(txbProStock.Text)
                    };

                    await ps.InsertAsync(newProduct);
                    MessageBox.Show("Product inserted successfully!");

                    // Log stock transaction (starting quantity)
                    var stockTrans = new STOCKTRANSACTION
                    {
                        PRODUCTID = newProduct.PRODUCTID,
                        QUANTITY = newProduct.STOCK,
                        TRANSACTIONDATE = DateTime.Now,
                        REASON = "Start Quantity",
                        PERFORMEDBY = "hasan can"
                    };

                    sts.AddStock(stockTrans.PRODUCTID, stockTrans.QUANTITY, stockTrans.REASON);

                    RefreshForm();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed: " + ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private async void btnProdUpt_Click(object sender, EventArgs e)
        {
            var prodId = Convert.ToInt32(lblSifre.Text);
            var prodEx = await ps.GetByIdAsync(prodId);

            if (prodEx != null)
            {
                // Update product fields with current form inputs
                prodEx.PRODUCTNAME = txbProName.Text;
                prodEx.CATEGORYID = Convert.ToInt32(cbCategories.SelectedValue);
                prodEx.PRODUCTPRICE = Convert.ToDecimal(txbProPrice.Text);
                prodEx.STOCK = Convert.ToInt32(txbProStock.Text);

                try
                {
                    await ps.UpdateAsync(prodEx);
                    MessageBox.Show("Product updated!");
                    RefreshForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed: " + ex.Message);
                }
            }
        }

        private async void btnProdDelete_Click(object sender, EventArgs e)
        {
            var prodId = Convert.ToInt32(lblSifre.Text);

            try
            {
                await ps.DeleteAsync(prodId);
                MessageBox.Show("Product deleted!");
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        private void dgProdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var row = dgProdList.Rows[rowIndex];

                // Get values from selected row
                int prodId = Convert.ToInt32(row.Cells[0].Value);
                string prodName = row.Cells[1].Value?.ToString();
                string prodPrice = row.Cells[3].Value?.ToString();
                string prodStock = row.Cells[4].Value?.ToString();
                int categoryId = Convert.ToInt32(row.Cells[5].Value);

                // Populate form fields
                txbProName.Text = prodName;
                txbProPrice.Text = prodPrice;
                txbProStock.Text = prodStock;
                cbCategories.SelectedValue = categoryId;
                lblSifre.Text = prodId.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Refresh DataGridView and clear input fields
        private void RefreshForm()
        {
            dgProdList.DataSource = ps.GetAllWithCategoryAsync();
            txbProName.Clear();
            txbProPrice.Clear();
            txbProStock.Clear();
            lblSifre.Text = string.Empty;
        }

    }
}

