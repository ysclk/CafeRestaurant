using CafeRestaurant.DTOs;
using CafeRestaurant.Enums;
using CafeRestaurant.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeRestaurant.Forms
{
    public partial class OrderForm : Form
    {

        private readonly CategoryService cs = new CategoryService();
        private readonly OrderService os = new OrderService();
        private readonly OrderDetailService ods = new OrderDetailService();
        private readonly ProductService ps = new ProductService();
        private readonly UserService us = new UserService();
        private readonly CafeRestaurantEntities db = new CafeRestaurantEntities();

        private readonly DataTable dtOrder = new DataTable();
        private readonly DataGridViewButtonColumn btnIncrease = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnDecrease = new DataGridViewButtonColumn();

        private decimal subTotal = 0;
        private int userId;
        private string custPhone = string.Empty;
     

        public OrderForm(int _userId)
        {
            InitializeComponent();
            this.userId = _userId;
            //CAST(getdate() AS DATE)
            // Initializes form elements and default settings
            InitializeForm();
        }
        private void InitializeForm()
        {
            SetupCategoryComboBox();
            SetupOrderTypeAndPaymentComboBoxes();
            SetupCustomerComboBox();
            SetupOrderGrid();
        }

        
        //Columns of Datagridview 
        private void SetupOrderGrid()
        {
            dtOrder.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("PRODUCTID", typeof(int)),
                new DataColumn("PRODUCTNAME", typeof(string)),
                new DataColumn("QUANTITY", typeof(int)),
                new DataColumn("PRODUCTPRICE", typeof(decimal)),
                new DataColumn("SUBTOTAL", typeof(decimal)),
                new DataColumn("ORDERNOTE", typeof(string)),
                new DataColumn("CUSTOMERID", typeof(int)),
                new DataColumn("CUSTOMERNAME", typeof(string)),
                new DataColumn("ORDERPAID", typeof(string)),
                new DataColumn("ORDERTYPE", typeof(string))
            });

            dgOrders.DataSource = dtOrder;
            dgOrders.Columns["CustomerId"].Visible = false;
            dgOrders.Columns["ProductID"].Visible = false;

            ConfigureOrderGridButtons();
        }

        //plus minus button adding
        private void ConfigureOrderGridButtons()
        {
            btnIncrease.Name = "Increase";
            btnIncrease.HeaderText = "";
            btnIncrease.Text = "+";
            btnIncrease.UseColumnTextForButtonValue = true;
            btnIncrease.Width = 30;
            btnIncrease.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnDecrease.Name = "Decrease";
            btnDecrease.HeaderText = "";
            btnDecrease.Text = "-";
            btnDecrease.UseColumnTextForButtonValue = true;
            btnDecrease.Width = 30;
            btnDecrease.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgOrders.Columns.Add(btnIncrease);
            dgOrders.Columns.Add(btnDecrease);
        }

        //Customer Combobox fill
        private void SetupCustomerComboBox()
        {
            cmbCustomer.DataSource = us.UserSameRoleList(3);
            cmbCustomer.DisplayMember = "Fullname";
            cmbCustomer.ValueMember = "USERID";
        }

        //Comboboxes OrderType and IsPaid fill
        private void SetupOrderTypeAndPaymentComboBoxes()
        {
            cmbOrdertype.DataSource = Enum.GetValues(typeof(OrderType));
            cmbPaid.DataSource = Enum.GetValues(typeof(PaymentStatus));
        }

        //Category Combobox fill
        private void SetupCategoryComboBox()
        {
            var categories = cs.GetAll();
            categories.Insert(0, new CATEGORY { CATEGORYID = 0, CATEGORYNAME = "-- Select --" });

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "CATEGORYNAME";
            cmbCategories.ValueMember = "CATEGORYID";
            cmbCategories.SelectedIndex = 0;
        }

       
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex > 0)
            {
                int categoryId = Convert.ToInt32(cmbCategories.SelectedValue);
                var products = ps.GetByCategory(categoryId);
                products.Insert(0, new PRODUCT { PRODUCTID = 0, PRODUCTNAME = "--Select--" });

                cmbProducts.DataSource = products;
                cmbProducts.DisplayMember = "PRODUCTNAME";
                cmbProducts.ValueMember = "PRODUCTID";
            }
        }


        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedIndex > 0)
            {
                int productId = (int)cmbProducts.SelectedValue;
                ndPrice.Value = ps.GetPrice(productId);
            }
        }

        private void ndQuantity_ValueChanged(object sender, EventArgs e)
        {
            ndSubtotal.Value = Math.Round(ndQuantity.Value * ndPrice.Value,2);
        }

        //In Order and OrderDetail saving die Inputs
        private void btnCatSave_Click(object sender, EventArgs e)
        {
            cmbCustomer.Enabled = true;
            lblTotalAmount.Text = subTotal.ToString();

            var transaction = db.Database.BeginTransaction();

            try
            {
                var order = new ORDER
                {
                    ORDERDATE = DateTime.Now,
                    CUSTOMERID = (int)cmbCustomer.SelectedValue,
                    TOTALAMOUNT = Convert.ToDecimal(lblTotalAmount.Text)
                };
                os.Insert(order);

                for (int i = 0; i < dgOrders.Rows.Count - 1; i++)
                {
                    var detail = new ORDERDETAIL
                    {
                        ORDERID = order.ORDERID,
                        PRODUCTID = (int)dgOrders.Rows[i].Cells["PRODUCTID"].Value,
                        QUANTITY = (int)dgOrders.Rows[i].Cells["QUANTITY"].Value,
                        UNITPRICE = (decimal)dgOrders.Rows[i].Cells["PRODUCTPRICE"].Value,
                        SUBTOTAL = (decimal)dgOrders.Rows[i].Cells["SUBTOTAL"].Value,
                        ORDERNOTE = dgOrders.Rows[i].Cells["ORDERNOTE"].Value.ToString(),
                        ORDERPAID = dgOrders.Rows[i].Cells["ORDERPAID"].Value.ToString(),
                        ORDERTYPE = dgOrders.Rows[i].Cells["ORDERTYPE"].Value.ToString(),
                        STAFFID = userId
                    };
                    ods.Insert(detail);
                }

                transaction.Commit();
                MessageBox.Show("Order successfully inserted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + (ex.InnerException?.InnerException?.Message ?? ex.Message));
            }

        ((DataTable)dgOrders.DataSource).Rows.Clear();
        }

        //Orderlist fill
        private void btnInsertOrderList_Click(object sender, EventArgs e)
        {

            subTotal += ndSubtotal.Value;
            lblTotalAmount.Text = subTotal.ToString();

            string orderNote = txbOrdernote.Text;
            string customerName = (cmbCustomer.SelectedItem as UserListItem)?.Fullname ?? string.Empty;
            string isPaid = cmbPaid.SelectedValue.ToString();
            string orderType = cmbOrdertype.SelectedValue.ToString();

            cmbCustomer.Enabled = false;

            dtOrder.Rows.Add(
                (int)cmbProducts.SelectedValue,
                cmbProducts.Text,
                (int)ndQuantity.Value,
                ndPrice.Value,
                ndSubtotal.Value,
                orderNote,
                (int)cmbCustomer.SelectedValue,
                customerName,
                isPaid,
                orderType);

            ResetProductSelection();
        }

        // Clears all form input fields
        private void ResetProductSelection()
        {
            cmbCategories.SelectedIndex = 0;
            cmbProducts.SelectedIndex = 0;
            ndQuantity.Value = 0;
            ndPrice.Value = 0;
            ndSubtotal.Value = 0;
            cmbOrdertype.SelectedIndex = 0;
            cmbPaid.SelectedIndex = 0;
            txbOrdernote.Text = string.Empty;
        }

        private void dgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            string columnName = dgOrders.Columns[e.ColumnIndex].Name;
            int currentQty = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value);

            if (columnName == "Increase")
                dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value = currentQty + 1;
            else if (columnName == "Decrease" && currentQty > 1)
                dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value = currentQty - 1;

            decimal unitPrice = Convert.ToDecimal(dgOrders.Rows[e.RowIndex].Cells["PRODUCTPRICE"].Value);
            int quantity = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value);
            dgOrders.Rows[e.RowIndex].Cells["SUBTOTAL"].Value = unitPrice * quantity;
        }

        //Lists the orders taken by the employee on that day.
        private void btnOrderlistForDay_Click(object sender, EventArgs e)
        {

            dgOrders.DataSource = os.UpdateOrderWithDetails(custPhone, DateTime.Parse("2025-07-18"));
        }
      
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectCustomer = cmbCustomer.SelectedItem as UserListItem;
            if (selectCustomer != null)
            {
                custPhone = selectCustomer.Phone;
              
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

    }
}
