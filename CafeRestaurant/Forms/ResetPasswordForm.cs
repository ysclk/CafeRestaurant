using CafeRestaurant.Services;
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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }
        private AuthService authService = new AuthService();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int userId = authService.userId(txbUsermail.Text);
            if (userId == 0)
            {
                MessageBox.Show("Not User");
            }
            PasswordChangeForm passForm = new PasswordChangeForm(userId,txbUsermail.Text);            
            this.Close();
            passForm.Show();

        }
       
    }
}
