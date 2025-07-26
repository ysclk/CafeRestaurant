using CafeRestaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class OrdersViewForm : Form
    {
        public OrdersViewForm()
        {
            InitializeComponent();
            
            var data = ods.GetAll();

            dgOrdersDetails.DataSource = data;

        }
        private OrdersViewService ods = new OrdersViewService();

        private void dgOrdersDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in dgOrdersDetails.Rows)
            {
                var isPaid = row.Cells["ORDERPAID"].Value?.ToString();

                if (isPaid == "NotPaid")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;

                }
                else if (isPaid == "Paid")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }
}
