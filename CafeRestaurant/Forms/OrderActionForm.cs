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
        // Events to notify parent form about user actions
        public event Action OnCancelClicked;
        public event Action OnDeliveredClicked;

        public OrderActionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles form load event. Currently unused but kept for future initialization.
        /// </summary>
        private void OrderActionForm_Load(object sender, EventArgs e)
        {
            // You can initialize form controls here if needed
        }

        /// <summary>
        /// Handles Delivered button click.
        /// Invokes the OnDeliveredClicked event and closes the form.
        /// </summary>
        private void btnDelivered_Click(object sender, EventArgs e)
        {
            OnDeliveredClicked?.Invoke();
            this.Close();
        }

        /// <summary>
        /// Handles Order Cancel button click.
        /// Invokes the OnCancelClicked event and closes the form.
        /// </summary>
        private void btnOrderCancel_Click(object sender, EventArgs e)
        {
            OnCancelClicked?.Invoke();
            this.Close();
        }

        /// <summary>
        /// Handles Cancel button click.
        /// Hides the form instead of closing it.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
