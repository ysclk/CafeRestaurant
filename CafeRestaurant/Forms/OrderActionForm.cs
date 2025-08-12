using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class OrderActionForm : Form
    {
        public OrderActionForm()
        {
            InitializeComponent();
        }
        public event Action OnCancelClicked;
        public event Action OnDeliveredClicked;
        private void OrderActionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            OnDeliveredClicked?.Invoke();
            this.Close();
        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            OnCancelClicked?.Invoke();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
