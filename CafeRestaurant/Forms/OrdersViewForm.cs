using CafeRestaurant.Services;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CafeRestaurant.Models;

namespace CafeRestaurant.Forms
{
    public partial class OrdersViewForm : Form
    {
        private readonly OrdersViewService orderViewService = new OrdersViewService();
        private readonly OrderStatusService orderStatusService = new OrderStatusService();
        private readonly OrderDetailService orderDetailService = new OrderDetailService();

        private List<ORDERSVIEW> allOrders = new List<ORDERSVIEW>();
        private List<ORDERSVIEW> filteredOrders = new List<ORDERSVIEW>();

        private int selectedOrderDetailID = 0;
        private bool isFormLoading = true;

        private bool isExpanded = false;
        private readonly int maxHeight = 256;
        private readonly int panelSpeed = 30;

        public OrdersViewForm()
        {
            InitializeComponent();

            FillOrderStatusComboBox(cmbOrderStatus);
            FillOrderStatusComboBox(cmbStatusSearch);

            HideUnnecessaryColumns();


            dgOrdersDetails.DataSource = orderViewService.GetAll();
        }

        private void OrdersViewForm_Load(object sender, EventArgs e)
        {
            isFormLoading = false;
            LoadAllOrders();
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
        private void FillOrderStatusComboBox(Guna2ComboBox cmb)
        {
            var statusList = orderStatusService.GetAll();
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

        private void LoadAllOrders()
        {
            dgOrdersDetails.DataSource = orderViewService.GetAll();
            dgOrdersDetails.ClearSelection();
            RowsPaintedByStatus();
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

        private void FilterByCustomerName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgOrdersDetails.DataSource = orderViewService.GetAll();
                return;
            }

            var source = filteredOrders?.Count > 0 ? filteredOrders : orderViewService.GetAll();
            dgOrdersDetails.DataSource = orderViewService.GetOrdersByCustomerName(source, keyword);
        }

        // Filters with date
        private void guna2DateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            FilterByDate(guna2DateTimePicker1.Value.Date);
        }

        private void dtpDateSearch_CloseUp(object sender, EventArgs e)
        {
            FilterByDate(dtpDateSearch.Value.Date);
        }

        private void FilterByDate(DateTime date)
        {
            var source = filteredOrders?.Count > 0 ? filteredOrders : orderViewService.GetAll();
            dgOrdersDetails.DataSource = orderViewService.GetOrdersByDate(source, date);
        }

        // Filters with Orderstatus
        private void cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbOrderStatus.SelectedValue?.ToString(), out int statusId))
            {
                var source = filteredOrders?.Count > 0 ? filteredOrders : orderViewService.GetAll();
                dgOrdersDetails.DataSource = orderViewService.GetOrdersByOrderStatus(source, statusId);
            }
        }

        private void cmbStatuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbStatusSearch.SelectedValue?.ToString(), out int statusId))
            {
                dgOrdersDetails.DataSource = orderViewService.GetOrdersByOrderStatus(orderViewService.GetAll(), statusId);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFilters();
        }

        /// <summary>
        /// Clears all filter fields.
        /// </summary>
        private void ClearAllFilters()
        {
            FillOrderStatusComboBox(cmbOrderStatus);
            FillOrderStatusComboBox(cmbStatusSearch);
            txbCustomerName.Clear();
            txbCustomerNameSearch.Clear();
            guna2DateTimePicker1.Value = DateTime.Now;
            dtpDateSearch.Value = DateTime.Now;

            filteredOrders = null;
            LoadAllOrders();
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

        private void gdOrdersDetails_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            LoadAllOrders();
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

            popup.OnCancelClicked += () =>
            {
                orderDetailService.CancelOrder(selectedOrderDetailID);
                LoadAllOrders();
            };

            popup.OnDeliveredClicked += () =>
            {
                orderDetailService.MarkOrderAsDelivered(selectedOrderDetailID);
                LoadAllOrders();
            };

            popup.ShowDialog(this);
        }
    }
}

