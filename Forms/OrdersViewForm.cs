using CafeRestaurant.Services;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CafeRestaurant.Models;
using System.Threading.Tasks;
using CafeRestaurant.Repositories;

namespace CafeRestaurant.Forms
{
    public partial class OrdersViewForm : Form
    {
        private readonly OrdersViewService _orderViewService; 
        private readonly OrderStatusRepository _orderStatusRepository; 
        private readonly OrderDetailService _orderDetailService;

        private List<ORDERSVIEW> allOrders = new List<ORDERSVIEW>();
        private List<ORDERSVIEW> filteredOrders = new List<ORDERSVIEW>();

        private int selectedOrderDetailID = 0;
        private bool isFormLoading = true;

        private bool isExpanded = false;
        private readonly int maxHeight = 256;
        private readonly int panelSpeed = 30;

        public OrdersViewForm(OrdersViewService orderViewService,
                              OrderStatusRepository orderStatusRepository,
                              OrderDetailService orderDetailService)
        {
            InitializeComponent();
            this._orderViewService = orderViewService;
            this._orderStatusRepository = orderStatusRepository;    
            this._orderDetailService = orderDetailService;

            HideUnnecessaryColumns();


            //dgOrdersDetails.DataSource = orderViewService.GetAllAsync();

        }     

        private async void OrdersViewForm_Load(object sender, EventArgs e)
        {
            isFormLoading = false;
            await FillOrderStatusComboBox(cmbOrderStatus);
            await FillOrderStatusComboBox(cmbStatusSearch);
            HideUnnecessaryColumns();
            dgOrdersDetails.RowPrePaint += dgOrdersDetails_RowPrePaint;
            await LoadAllOrders();
        }

        /// <summary>
        /// Paint rows based on ORDERSTATUS
        /// </summary>
        private void RowsPaintedByStatus()
        {
            foreach (DataGridViewRow row in dgOrdersDetails.Rows)
            {
                if (row.IsNewRow) continue;

                object statusValue = row.Cells["ORDERSTATUS"].Value;

                if (statusValue != null && int.TryParse(statusValue.ToString(), out int status))
                {
                    switch (status)
                    {
                        case 1: row.DefaultCellStyle.BackColor = Color.Orange; break;      // Hazırlanıyor / Preparing
                        case 2: row.DefaultCellStyle.BackColor = Color.LightGreen; break; // Teslim edildi / Delivered
                        case 3: row.DefaultCellStyle.BackColor = Color.Red; break;        // İptal / Canceled
                    }
                }
            }
        }

        /// <summary>
        /// Fills combobox with order status options.
        /// </summary>

        /// <summary>
        /// Fills combobox with order status options.
        /// </summary>
        private async Task FillOrderStatusComboBox(Guna2ComboBox cmb)
        {
            var statusList = await _orderStatusRepository.GetAllAsync();
            statusList.Insert(0, new ORDERSTATUSTYPES { StatusID = 0, StatusCode = "-- Select --" });

            cmb.DisplayMember = "StatusCode";
            cmb.ValueMember = "StatusID";
            cmb.DataSource = statusList;
            cmb.SelectedIndex = 0;
        }

        private void HideUnnecessaryColumns()
        {
            string[] hiddenColumns = { "ORDERID", "ORDERDETAILID", "PRODUCTID", "USERID", "CUSTOMERID", "ORDERSTATUS" };

            foreach (DataGridViewColumn col in dgOrdersDetails.Columns)
            {
                if (hiddenColumns.Contains(col.HeaderText, StringComparer.OrdinalIgnoreCase))
                {
                    col.Visible = false;
                }
            }
        }

        private async Task LoadAllOrders()
        {
            try
            {
                dgOrdersDetails.DataSource = null; // Eski bağlamı temizle
                var orders = await _orderViewService.GetAllAsync();
                if (orders == null || !orders.Any())
                {
                    MessageBox.Show("No orders found or data is empty!");
                    return;
                }
                Console.WriteLine($"Orders count: {orders.Count()}"); //for debug
                dgOrdersDetails.BeginInvoke((MethodInvoker)delegate
                {
                    dgOrdersDetails.DataSource = orders.ToList();
                    dgOrdersDetails.AutoGenerateColumns = true;
                    dgOrdersDetails.Columns["CUSTOMERNAME"].Visible = true; 
                    dgOrdersDetails.Refresh();
                });
                RowsPaintedByStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        // Filters with Customername
        private void txbCustomerName_TextChanged(object sender, EventArgs e)
        {
            FilterByCustomerName(txbCustomerName.Text.Trim());
        }

        private void txbCustomerNameSearch_TextChanged(object sender, EventArgs e)
        {
            FilterByCustomerName(txbCustomerNameSearch.Text.Trim());
        }

        private async void FilterByCustomerName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgOrdersDetails.DataSource = await _orderViewService.GetAllAsync();
                return;
            }

            var source = filteredOrders?.Count > 0 ? filteredOrders :await _orderViewService.GetAllAsync();
            dgOrdersDetails.DataSource = await _orderViewService.GetOrdersByCustomerNameAsync(source, keyword);
        }

        // Filters with date
        private async void guna2DateTimePicker1_CloseUp(object sender, EventArgs e)
        {
             await FilterByDate(guna2DateTimePicker1.Value.Date);
        }

        private async void dtpDateSearch_CloseUp(object sender, EventArgs e)
        {
            await FilterByDate(dtpDateSearch.Value.Date);
        }

        private async Task FilterByDate(DateTime date)
        {
            var source = filteredOrders?.Count > 0 ? filteredOrders :await _orderViewService.GetAllAsync();
            dgOrdersDetails.DataSource = await _orderViewService.GetOrdersByDateAsync(source, date);
        }

        // Filters with Orderstatus
        private async Task cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbOrderStatus.SelectedValue?.ToString(), out int statusId))
            {
                var source = filteredOrders?.Count > 0 ? filteredOrders :await _orderViewService.GetAllAsync();
                dgOrdersDetails.DataSource = await _orderViewService.GetOrdersByOrderStatusAsync(source, statusId);
            }
        }

        private async void cmbStatuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbStatusSearch.SelectedValue?.ToString(), out int statusId))
            {
                dgOrdersDetails.DataSource =await _orderViewService.GetOrdersByOrderStatusAsync(await _orderViewService.GetAllAsync(), statusId);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFilters();
        }

        /// <summary>
        /// Clears all filter fields.
        /// </summary>
        private async void ClearAllFilters()
        {
            await FillOrderStatusComboBox(cmbOrderStatus);
            await FillOrderStatusComboBox(cmbStatusSearch);
            txbCustomerName.Clear();
            txbCustomerNameSearch.Clear();
            guna2DateTimePicker1.Value = DateTime.Now;
            dtpDateSearch.Value = DateTime.Now;

            filteredOrders = null;
            await LoadAllOrders();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Filter Panel animation
        private void imgFilters_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                pnlFilters.Height -= panelSpeed;

                if (pnlFilters.Height <= 0)
                {
                    pnlFilters.Visible = false;
                    timer1.Stop();
                    isExpanded = false;
                }
            }
            else
            {
                pnlFilters.Visible = true;
                pnlFilters.Height += panelSpeed;

                if (pnlFilters.Height >= maxHeight)
                {
                    pnlFilters.Height = maxHeight;
                    timer1.Stop();
                    isExpanded = true;
                }
            }
        }

        private async Task gdOrdersDetails_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           await LoadAllOrders();
        }

        private void dgOrdersDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedOrderDetailID = (int)dgOrdersDetails.Rows[e.RowIndex].Cells["ORDERDETAILID"].Value;
                ShowOrderActionPopup();
            }
        }

        /// <summary>
        /// Shows popup for order actions (Cancel / Delivered)
        /// </summary>
        private void ShowOrderActionPopup()
        {
            if (selectedOrderDetailID <= 0)
            {
                MessageBox.Show("Lütfen bir sipariş seçin."); // Please select an order.
                return;
            }

            var popup = new OrderActionForm();

            popup.OnCancelClicked += async () =>
            {
                await _orderDetailService.CancelOrderAsync(selectedOrderDetailID);
               await LoadAllOrders();
            };

            popup.OnDeliveredClicked += async () =>
            {
                await _orderDetailService.MarkOrderAsDeliveredAsync(selectedOrderDetailID);
               await LoadAllOrders();  
            };

            popup.ShowDialog(this);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgOrdersDetails_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgOrdersDetails.Rows.Count)
            {
                DataGridViewRow row = dgOrdersDetails.Rows[e.RowIndex];
                if (row.IsNewRow) return;

                object statusValue = row.Cells["ORDERSTATUS"].Value;
                if (statusValue != null && int.TryParse(statusValue.ToString(), out int status))
                {
                    switch (status)
                    {
                        case 1: row.DefaultCellStyle.BackColor = Color.Orange; break;
                        case 2: row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                        case 3: row.DefaultCellStyle.BackColor = Color.Red; break;
                        default: row.DefaultCellStyle.BackColor = Color.White; break;
                    }
                }
            }
        }
    }
}

