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
    public partial class AdminForm : Form
    {

        private int userID;

        public AdminForm(int userId)
        {
            InitializeComponent();
            userID = userId;
        }

        // Opens the user form
        private void btnProdSave_Click(object sender, EventArgs e)
        {
            ShowForm(new UserForm());
        }

        // Opens the category form
        private void btnCatInsert_Click(object sender, EventArgs e)
        {
            ShowForm(new CategoryForm());
        }

     
        // Opens the product form
        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            ShowForm(new ProductForm());
        }

        
        // Opens the order form (with user ID)
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowForm(new OrderForm(userID));
        }

        // Exits the application
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        // Common method to show forms
        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }
    }
}
