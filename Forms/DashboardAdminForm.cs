using CafeRestaurant.Services;
using System;
using System.Windows.Forms;
using CafeRestaurant.DTOs;
using CafeRestaurant.Models;
using System.Threading.Tasks;

namespace CafeRestaurant.Forms
{
    public partial class DashboardAdminForm : Form
    {
        private int userId = 0;
        private readonly UserService _userService;

        public DashboardAdminForm(UserService userService, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this._userService = userService;
            new Dashboards().WelcomeDate(DateTime.Now, lblDate, lblClock);

          //  this.Load += DashboardAdminForm_LoadAsync;
        }

        public async Task<string> GetNameFromUser()
        {
            
            var user = await _userService.GetUserByIDAsync(userId);            
            return user?.USERNAME ?? "Bilinmeyen Kullanıcı"; ;
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
           
            lblWelcome.Left = (pnlWelcome.ClientSize.Width - lblWelcome.Width) / 2;
            lblWelcome.Top = (pnlWelcome.ClientSize.Height - lblWelcome.Height) / 2;
            pnlWelcome.Controls.Add(lblWelcome);
        }

        private async Task LoadAsync()
        {
            var list = await _userService.UserSameRoleListAsync(3);
            lblCustomerCount.Text = list.Count.ToString();
            try
            {
                lblWelcome.Text = "Welcome, " + await GetNameFromUser(); // Label’a kullanıcı adını yaz
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private  async Task DashboardAdminForm_LoadAsync(object sender, EventArgs e)
        {
            await LoadAsync();
        }
    }
}
