using CafeRestaurant.DTOs;
using CafeRestaurant.Services;
using System;
using CafeRestaurant.Models;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;

namespace CafeRestaurant.Forms
{
    public partial class OrderForm : Form
    {

        private readonly CategoryService cs;
        private readonly OrderService orderService = new OrderService(new CafeRestaurantEntities());
        private readonly OrderDetailService orderDetailService; 
        private readonly ProductService ps;
        private readonly UserService us = new UserService(new CafeRestaurantEntities());
        private readonly StockTransactionService2 stockTransService  = new StockTransactionService2(new CafeRestaurantEntities());
        private readonly CafeRestaurantEntities db = new CafeRestaurantEntities();
        private readonly StockService stockService; 

        private readonly DataTable dtOrder = new DataTable();
        private readonly DataGridViewButtonColumn btnIncrease = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnDecrease = new DataGridViewButtonColumn();

        private decimal subTotal = 0;
        private int userId;
        private string custPhone = string.Empty;      
        private int change = 0;
        
        private int? stockProduct = 0;
        public OrderForm(int _userId)
        {
            InitializeComponent();
            cs = new CategoryService(new CafeRestaurantEntities());
            ps = new ProductService(new CafeRestaurantEntities());
            stockService = new StockService(new CafeRestaurantEntities());
            orderDetailService = new OrderDetailService(new CafeRestaurantEntities()); ;
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
           //     new DataColumn("ORDERPAID", typeof(string)),
                new DataColumn("ORDERTYPE", typeof(string)),
                new DataColumn("STOCK", typeof(int)),
                new DataColumn("ORDERID", typeof(int)),
                new DataColumn("ORDERDETAILID", typeof(int))
            });

            dgOrders.DataSource = dtOrder;
            dgOrders.Columns["CUSTOMERID"].Visible = false;
            dgOrders.Columns["PRODUCTID"].Visible = false;
            dgOrders.Columns["ORDERID"].Visible = false;
            dgOrders.Columns["ORDERDETAILID"].Visible = false;
      

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
        private async void SetupCustomerComboBox()
        {
            cmbCustomer.DataSource = await us.UserSameRoleListAsync(3);
            cmbCustomer.DisplayMember = "Fullname";
            cmbCustomer.ValueMember = "USERID";
        }

        //Comboboxes OrderType and IsPaid fill
        private void SetupOrderTypeAndPaymentComboBoxes()
        {
            cmbOrdertype.DataSource = Enum.GetValues(typeof(Models.Enums.OrderType));
            //cmbPaid.DataSource = Enum.GetValues(typeof(PaymentStatus));
        }

        //Category Combobox fill
        private async void SetupCategoryComboBox()
        {
            var categories =await cs.GetAllAsync();
            categories.Insert(0, new CATEGORY { CATEGORYID = 0, CATEGORYNAME = "-- Select --" });

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "CATEGORYNAME";
            cmbCategories.ValueMember = "CATEGORYID";
            cmbCategories.SelectedIndex = 0;
        }

       
        private async void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex > 0)
            {
                int categoryId = Convert.ToInt32(cmbCategories.SelectedValue);
                var products = await ps.GetByCategoryAsync(categoryId);
           //     products.InsertAsync(0, new PRODUCT { PRODUCTID = 0, PRODUCTNAME = "--Select--" });

                cmbProducts.DataSource = products;
                cmbProducts.DisplayMember = "PRODUCTNAME";
                cmbProducts.ValueMember = "PRODUCTID";
            }
        }


        private async void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedIndex > 0)
            {
                int productId = (int)cmbProducts.SelectedValue;
                ndPrice.Value = Convert.ToDecimal(await ps.GetPriceAsync(productId));
                ndCurrent.Value = Convert.ToDecimal(stockService.GetStockAsync(productId));   
            }
        }

        private void ndQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (ndPrice.Value != 0 && ndQuantity.Value != 0)
            {
                 ndSubtotal.Value = Math.Round(ndQuantity.Value * ndPrice.Value,2);
            }
           
        }

        //In Order and OrderDetail saving die Inputs
        private async Task btnCatSave_Click(object sender, EventArgs e)
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
                await orderService.InsertAsync(order);

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
                        ORDERTYPE = dgOrders.Rows[i].Cells["ORDERTYPE"].Value.ToString(),
              //          ORDERPAID = dgOrders.Rows[i].Cells["ORDERPAID"].Value.ToString(),
                        STAFFID = userId,
                        ORDERSTATUS = 1
                    };
                    await orderDetailService.InsertAsync(detail);
                    
                    
                    var productStockEx = await stockService.ProductStockByProductIdAsync((int)dgOrders.Rows[i].Cells["PRODUCTID"].Value);
                    
                    if (productStockEx != null) 
                    {
                        stockProduct = productStockEx.STOCK;
                        productStockEx.STOCK = stockProduct - (int)dgOrders.Rows[i].Cells["QUANTITY"].Value;

                    }
                    await stockService.UpdateAsync(productStockEx);
                    ndCurrent.Value = ndCurrent.Value - (int)dgOrders.Rows[i].Cells["QUANTITY"].Value;
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
       //     string isPaid = cmbPaid.SelectedValue.ToString();
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
    //            isPaid,
                orderType,
                ndCurrent.Value
                );

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
            //cmbPaid.SelectedIndex = 0;
            txbOrdernote.Text = string.Empty;
        }

        private void dgOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               int changePlus = 0;
               int changeMinus = 0;

            if (e.RowIndex < 0) return;

            string columnName = dgOrders.Columns[e.ColumnIndex].Name;
            int currentQty = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value);

            if (columnName == "Increase")
            {
                dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value = currentQty + 1;
                changePlus++;
                if (currentQty == Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells["STOCK"].Value) - 1)
                {
                    MessageBox.Show("Yeterli stock yok");

                }
                if (changePlus != 0)
                {
                    change = changePlus;
                }
            }
                
            else if (columnName == "Decrease" && currentQty > 0)
            {
                dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value = currentQty - 1;
                changeMinus--;
                if (currentQty == 1)
                {
                    MessageBox.Show("Iptal edilsin mi?");
                    
                }
                if (changeMinus != 0)
                {
                    change = -changeMinus;
                }

            }

            decimal unitPrice = Convert.ToDecimal(dgOrders.Rows[e.RowIndex].Cells["PRODUCTPRICE"].Value);
            int quantity = Convert.ToInt32(dgOrders.Rows[e.RowIndex].Cells["QUANTITY"].Value);
            dgOrders.Rows[e.RowIndex].Cells["SUBTOTAL"].Value = unitPrice * quantity;
        }

        //Lists the orders taken by the employee on that day.
        private void btnOrderlistForDay_Click(object sender, EventArgs e)
        {

            dgOrders.DataSource = orderService.UpdateOrderWithDetailsAsync(custPhone, DateTime.Parse("2025-07-18"));
        }
      
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectCustomer = cmbCustomer.SelectedItem as UserListItem;
            if (selectCustomer != null)
            {
                custPhone = selectCustomer.Phone;
              
            }
        }


        private int tiklama = 0;
        private async void btnUpdate_Click(object sender, EventArgs e)
        {

            var transaction = db.Database.BeginTransaction();
            try
            {
                if (tiklama == 0)
                {
                    if (txbCustomerPhone.Text.Trim() != string.Empty)
                    {
                        var orderdetails = orderService.UpdateOrderAsync(txbCustomerPhone.Text, 3, DateTime.Now); //Convert.ToDateTime("2025-07-30"));
                        dgOrders.AutoGenerateColumns = false;
                        if (orderdetails != null)
                        {
                            dgOrders.DataSource = orderdetails;
                        }
                    }
                    // Datagridview clear
                    if (dgOrders.Columns.Contains("Increase"))
                        dgOrders.Columns.Remove("Increase");

                    if (dgOrders.Columns.Contains("Decrease"))
                        dgOrders.Columns.Remove("Decrease");

                    ConfigureOrderGridButtons();
                    dgOrders.Columns["Increase"].DisplayIndex = dgOrders.Columns.Count - 2;
                    dgOrders.Columns["Decrease"].DisplayIndex = dgOrders.Columns.Count - 1;
                }

                if (tiklama == 1)
                {
                    if (dgOrders.Rows.Count != 0)
                    {
                        int orderId = Convert.ToInt32(dgOrders.Rows[0].Cells["ORDERID"].Value);
                        var orderEx =await orderService.GetByIdAsync(orderId);

                        if (orderEx != null)
                        {
                            orderEx.TOTALAMOUNT = Convert.ToDecimal(lblTotalAmount.Text);
                        }
                        await orderService.UpdateAsync(orderEx);

                        for (int i = 0; i < dgOrders.Rows.Count; i++)
                        {
                            int orderDetailId = Convert.ToInt32(dgOrders.Rows[i].Cells["ORDERDETAILID"].Value);
                            var orderDetailEx = await orderDetailService.GetByIdAsync(orderDetailId);
                            if (orderDetailEx != null)
                            {
                                orderDetailEx.QUANTITY = Convert.ToInt32(dgOrders.Rows[i].Cells["QUANTITY"].Value);
                            }
                            await orderDetailService.UpdateAsync(orderDetailEx);

                            var stockTransaction = new STOCKTRANSACTION
                            {
                                PRODUCTID = (int)dgOrders.Rows[i].Cells["PRODUCTID"].Value,
                                QUANTITY = change,
                                TRANSACTIONDATE = DateTime.Now,                              
                                REASON = "Artma veya azalma",
                                PERFORMEDBY = "Ali Veli"

                            };
                            await stockTransService.InsertAsync(stockTransaction);

                        }
                    }
                }
                
                transaction.Commit();
                ((DataTable)dgOrders.DataSource).Rows.Clear();
                tiklama = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Transaction failed:" + ex.Message);
            }
            tiklama++;           
        }

        private void ndPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
