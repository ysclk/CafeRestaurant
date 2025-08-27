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
using CafeRestaurant.Repositories;
using System.Linq;

namespace CafeRestaurant.Forms
{
    public partial class OrderForm : Form
    {

        private readonly CategoryService cs;
        private readonly OrderService orderService;
        private readonly OrderRepository _orderRepository;
        private readonly StockRepository _stockRepository;
        private readonly OrderDetailsRepository _orderDetailRepository;
        private readonly OrderDetailService orderDetailService;
        private readonly ProductService ps;
        private readonly UserService us;
        private readonly StockTransactionRepository _stockTrasnactionRepository;
        private readonly CafeRestaurantEntities db;
        private readonly StockService stockService;
        private readonly CategoryRepository categoryRepository;

        private readonly DataTable dtOrder = new DataTable();
        private readonly DataGridViewButtonColumn btnIncrease = new DataGridViewButtonColumn();
        private readonly DataGridViewButtonColumn btnDecrease = new DataGridViewButtonColumn();

        private decimal subTotal = 0;
        private int userId;
        private string custPhone = string.Empty;      
        private int change = 0;
        
        private int? stockProduct = 0;
        public OrderForm(CategoryService cs,
        OrderService orderService,
        OrderRepository orderRepository,
        StockRepository stockRepository,
        OrderDetailsRepository orderDetailRepository,
        OrderDetailService orderDetailService,
        ProductService ps,
        UserService us,
        StockTransactionRepository stockTrasnactionRepository,
        CafeRestaurantEntities db,
        StockService stockService,
        CategoryRepository categoryRepository, 
        int userId)
        {
            InitializeComponent();
            this.cs = cs;
            this.orderService = orderService;
            this._orderRepository = orderRepository;
            this._stockRepository = stockRepository;
            this._orderDetailRepository = orderDetailRepository;
            this.orderDetailService = orderDetailService;
            this.ps = ps;
            this.us = us;
            this._stockTrasnactionRepository = stockTrasnactionRepository;
            this.db = db;
            this.stockService = stockService;
            this.categoryRepository = categoryRepository;
            this.userId = userId; 
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
            var categories =await categoryRepository.GetAllAsync();
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
                products.Insert(0, new PRODUCT { PRODUCTID = 0, PRODUCTNAME = "--Select--" });

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
                txtCurrent.Text = (await stockService.GetStockAsync(productId)).ToString();   
            }
        }
        //Orderlist fill
        private void btnInsertOrderList_Click(object sender, EventArgs e)
        {

            subTotal += ndSubtotal.Value;
            txtTotalAmount.Text = subTotal.ToString();
            string orderNote = txbOrdernote.Text;
            string customerName = (cmbCustomer.SelectedItem as UserListItem)?.Fullname ?? string.Empty;
          //string isPaid = cmbPaid.SelectedValue.ToString();
            string orderType = cmbOrdertype.SelectedValue.ToString();
            int productQuantity = Convert.ToInt32(txtQuantity.Text);
            int productCurrent =Convert.ToInt32(txtCurrent.Text);
            cmbCustomer.Enabled = false;

            if (productCurrent >= productQuantity)
            {
                dtOrder.Rows.Add(
                (int)cmbProducts.SelectedValue,
                cmbProducts.Text,
                productQuantity,
                ndPrice.Value,
                ndSubtotal.Value,
                orderNote,
                (int)cmbCustomer.SelectedValue,
                customerName,
                //            isPaid,
                orderType,
                productCurrent
                );
            }
            else
                MessageBox.Show("There is not enough products!");
                ResetProductSelection();
        }

        // Clears all form input fields
        private void ResetProductSelection()
        {
            cmbCategories.SelectedIndex = 0;
            cmbProducts.SelectedIndex = 0;
            txtQuantity.Text = string.Empty;
            ndPrice.Value = 0;
            ndSubtotal.Value = 0;
            cmbOrdertype.SelectedIndex = 0;
            //cmbPaid.SelectedIndex = 0;
            txbOrdernote.Text = string.Empty;
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
        //In Order and OrderDetail saving die Inputs
        private async void btnCatSave_Click(object sender, EventArgs e)
        {

            cmbCustomer.Enabled = true;
            txtTotalAmount.Text = subTotal.ToString();

            var transaction = db.Database.BeginTransaction();

            try
            {
                var order = new ORDER
                {
                    ORDERDATE = DateTime.Now,
                    CUSTOMERID = (int)cmbCustomer.SelectedValue,
                    TOTALAMOUNT = Convert.ToDecimal(txtTotalAmount.Text),
                    STAFFID = userId
                };
                await _orderRepository.InsertAsync(order);

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
                    await _orderDetailRepository.InsertAsync(detail);


                    var productStockEx = await stockService.ProductStockByProductIdAsync((int)dgOrders.Rows[i].Cells["PRODUCTID"].Value);

                    if (productStockEx != null)
                    {
                        stockProduct = productStockEx.STOCK;
                        productStockEx.STOCK = stockProduct - (int)dgOrders.Rows[i].Cells["QUANTITY"].Value;

                    }
                    await _stockRepository.UpdateAsync(productStockEx);
                    txtCurrent.Text = (Convert.ToInt32(txtCurrent.Text) - (int)dgOrders.Rows[i].Cells["QUANTITY"].Value).ToString();
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

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (ndPrice.Value != 0 && txtQuantity.Text != string.Empty)
            {
                ndSubtotal.Value = Math.Round(Convert.ToInt32(txtQuantity.Text) * ndPrice.Value, 2);
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction()) { // Asenkron transaction başlat

                try
                {
                    if (tiklama == 0)
                    {
                        if (!string.IsNullOrWhiteSpace(txbCustomerPhone.Text))
                        {
                            var orderdetails = await orderService.UpdateOrderAsync(txbCustomerPhone.Text, 3, DateTime.Now);
                            dgOrders.AutoGenerateColumns = false;
                            if (orderdetails != null)
                            {
                                dgOrders.DataSource = orderdetails;
                                var customerId = orderdetails.Select(o => o.CUSTOMERID).FirstOrDefault();
                                cmbCustomer.SelectedValue = customerId;
                                cmbCustomer.Enabled = false;
                            }
                        }

                        if (dgOrders.Columns.Contains("Increase"))
                            dgOrders.Columns.Remove("Increase");
                        if (dgOrders.Columns.Contains("Decrease"))
                            dgOrders.Columns.Remove("Decrease");

                        ConfigureOrderGridButtons();
                        dgOrders.Columns["Increase"].DisplayIndex = dgOrders.Columns.Count - 2;
                        dgOrders.Columns["Decrease"].DisplayIndex = dgOrders.Columns.Count - 1;
                    }

                    if (tiklama == 1 && dgOrders.Rows.Count != 0)
                    {
                        int orderId = Convert.ToInt32(dgOrders.Rows[0].Cells["ORDERID"].Value);
                        var orderEx = await _orderRepository.GetByIdAsync(orderId);

                        if (orderEx != null)
                        {
                            txtTotalAmount.Text = orderEx.TOTALAMOUNT.ToString();
                            await _orderRepository.UpdateAsync(orderEx); // Asenkron güncelle
                        }

                        for (int i = 0; i < dgOrders.Rows.Count; i++)
                        {
                            int orderDetailId = Convert.ToInt32(dgOrders.Rows[i].Cells["ORDERDETAILID"].Value);
                            var orderDetailEx = await _orderDetailRepository.GetByIdAsync(orderDetailId);

                            if (orderDetailEx != null)
                            {
                                orderDetailEx.QUANTITY = Convert.ToInt32(dgOrders.Rows[i].Cells["QUANTITY"].Value);
                                await _orderDetailRepository.UpdateAsync(orderDetailEx); // Asenkron güncelle
                            }
                            else
                            {
                                var newOrderDetail = new ORDERDETAIL
                                {
                                    ORDERID = orderId,
                                    PRODUCTID = (int)dgOrders.Rows[i].Cells["PRODUCTID"].Value,
                                    QUANTITY = Convert.ToInt32(dgOrders.Rows[i].Cells["QUANTITY"].Value),
                                    UNITPRICE = Convert.ToDecimal(dgOrders.Rows[i].Cells["UNITPRICE"].Value)
                                };
                                await _orderDetailRepository.InsertAsync(newOrderDetail);
                            }
                            // change hesapla
                            int previousQuantity = orderDetailEx?.QUANTITY ?? 0;
                            int currentQuantity = Convert.ToInt32(dgOrders.Rows[i].Cells["STOCK"].Value);
                            int change = currentQuantity - previousQuantity;
                            PRODUCTSTOCK productStock = new PRODUCTSTOCK();
                            productStock.PRODUCT_ID = (int)dgOrders.Rows[i].Cells["PRODUCTID"].Value;
                            productStock.STOCK = change;
                            await _stockRepository.UpdateAsync(productStock);

                            var stockTransaction = new STOCKTRANSACTION
                            {
                                PRODUCTID = (int)dgOrders.Rows[i].Cells["PRODUCTID"].Value,
                                QUANTITY = change,
                                TRANSACTIONDATE = DateTime.Now,
                                REASON = "Artma veya azalma",
                                PERFORMEDBY = "Ali Veli"
                            };
                            await _stockTrasnactionRepository.InsertAsync(stockTransaction);
                            
                        }
                        tiklama = 0;

                    }
                    await db.SaveChangesAsync(); // Asenkron kaydet
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Transaction failed: " + ex.Message);
                }
            }
            tiklama++;
        }  

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int changePlus = 0;
            int changeMinus = 0;
            if (e.RowIndex < 0) return;
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }            
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
