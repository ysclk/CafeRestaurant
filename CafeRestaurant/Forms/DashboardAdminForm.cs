using CafeRestaurant.Services;
using System;
using System.Windows.Forms;
using CafeRestaurant.DTOs;

namespace CafeRestaurant.Forms
{
    public partial class DashboardAdminForm : Form
    {
        private int userId = 0;
        public DashboardAdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            new Dashboards().WelcomeDate(DateTime.Now,lblDate,lblClock);
            lblCustomerCount.Text = userService.UserSameRoleList(3).Count.ToString();
        }

        UserService userService = new UserService();

      
        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Ortalamak için:
            lblWelcome.Left = (pnlWelcome.ClientSize.Width - lblWelcome.Width) / 2;
            lblWelcome.Top = (pnlWelcome.ClientSize.Height - lblWelcome.Height) / 2;
            pnlWelcome.Controls.Add(lblWelcome);
        }
    }
}
