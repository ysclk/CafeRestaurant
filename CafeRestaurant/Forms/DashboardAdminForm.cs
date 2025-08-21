using CafeRestaurant.Services;
using System;
using System.Windows.Forms;
using CafeRestaurant.DTOs;
using CafeRestaurant.Models;

namespace CafeRestaurant.Forms
{
    public partial class DashboardAdminForm : Form
    {
        private int userId = 0;
      

        UserService userService = new UserService(new CafeRestaurantEntities() );

        public DashboardAdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            new Dashboards().WelcomeDate(DateTime.Now, lblDate, lblClock);

            // Async işi Load eventinde halledelim
            this.Load += DashboardAdminForm_LoadAsync;
        }

        private async void DashboardAdminForm_LoadAsync(object sender, EventArgs e)
        {
            var list = await userService.UserSameRoleListAsync(3);
            lblCustomerCount.Text = list.Count.ToString();
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
