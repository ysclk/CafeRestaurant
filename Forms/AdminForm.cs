using CafeRestaurant.Models;
using CafeRestaurant.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class AdminForm : Form
    {

        private int userID;
        private readonly UserService _userService;
        private int? userRole;
    

            public AdminForm(UserService userService, int userId)
            {
                InitializeComponent();
                this._userService = userService;
                userID = userId;

                // Async initialization
                _ = InitializeFormAsync(); // Fire-and-forget, Load veya async init metodu
            }

            /// <summary>
            /// Initialize the form asynchronously
            /// </summary>
            private async Task InitializeFormAsync()
            {
                // Get user asynchronously
                USER user = await _userService.GetUserByIDAsync(userID);
                userRole = user.USERROLEID;

                // Adjust UI based on role
                if (userRole == 2) // Staff
                {
                    btnUserInsert.Visible = false;
                    btnCatInsert.Visible = false;
                    btnProductInsert.Visible = false;
                    btnOrder.Location = new Point(0, 61);
                    btnLogout.Location = new Point(0, 122);
                    btnReports.Visible = false;
                    btnOrderList.Visible = false;
                    lblHeaderTittle.Text = "Staff Panel";
                }

                // Open default dashboard
                await OpenDashboardAsync();
            }

            /// <summary>
            /// Opens the dashboard asynchronously
            /// </summary>
            private async Task OpenDashboardAsync()
            {
                // Clear previous controls
                panelContent.Controls.Clear();

            // Create dashboard form instance
            var dashboardFactory = Program.serviceProvider.GetService<Func<int, DashboardAdminForm>>();
            var dashboardForm = dashboardFactory(userID);
            dashboardForm.TopLevel = false;
            dashboardForm.TopMost = true;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(dashboardForm);
                dashboardForm.Show();

                await Task.CompletedTask; // Placeholder if needed for future async logic
            }

            private void btnProdSave_Click(object sender, EventArgs e)
            {
                var userForm = Program.serviceProvider.GetService<UserForm>();
                ShowForm(userForm);
            }

            private void ShowForm(Form form)
            {
                panelContent.Controls.Clear();
                form.TopLevel = false;
                form.TopMost = true;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                panelContent.Controls.Add(form);
                form.Show();
            }

            private void btnCatInsert_Click(object sender, EventArgs e)
            {
                // DI container'dan CategoryForm instance'ını al
                var categoryForm = Program.serviceProvider.GetService<CategoryForm>();
                ShowForm(categoryForm);
            }

            private void btnProductInsert_Click(object sender, EventArgs e)
            {
                var productForm = Program.serviceProvider.GetService<ProductForm>();
            ShowForm(productForm);
            }

            private void btnOrder_Click(object sender, EventArgs e)
            {
                var orderFormFactory = Program.serviceProvider.GetService<Func<int, OrderForm>>();
                var orderForm = orderFormFactory(userID);           
                ShowForm(orderForm);
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnUserInsert_Click(object sender, EventArgs e)
            {
                var userForm = Program.serviceProvider.GetService<UserForm>();
                ShowForm(userForm);
            }

            private void AddControlsToPanel()
            {
                lblHeaderTittle.Left = (pnlHeader.ClientSize.Width - lblHeaderTittle.Width) / 2;
                lblHeaderTittle.Top = (pnlHeader.ClientSize.Height - lblHeaderTittle.Height) / 2;
                pnlHeader.Controls.Add(lblHeaderTittle);
            }

            private void pnlHeader_Paint(object sender, PaintEventArgs e)
            {
                AddControlsToPanel();
            }

            private void btnSmaller_Click(object sender, EventArgs e)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.CenterToScreen();
                }
            }

            private void btnToBottom_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            private void btnDashboard_Click(object sender, EventArgs e)
            {
                
                _= OpenDashboardAsync(); // Fire-and-forget
            }

            private void AdminForm_Load(object sender, EventArgs e)
            {
                _ = OpenDashboardAsync(); // Fire-and-forget
            }

            private void btnLogout_Click(object sender, EventArgs e)
            {
                    DialogResult result = MessageBox.Show(
                                            "Çıkış yapmak istediğinize emin misiniz?",
                                            "Oturum Kapat",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question
                                            );

                if (result == DialogResult.Yes)
                {
                    try
                    {                      
                        userID = 0;
                        Properties.Settings.Default.Save();                    
                        var login = Program.serviceProvider.GetService<LoginForm>();                    
                        login.Show();                        
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Çıkış sırasında bir hata oluştu:\n" + ex.Message,
                                        "Hata",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            
                this.Close();
            }

            private void btnReports_Click(object sender, EventArgs e)
            {
                var report = Program.serviceProvider.GetService<ReportsForm>();
                ShowForm(report);
            }

            private void btnOrderList_Click(object sender, EventArgs e)
            {
                var ordersViewForm = Program.serviceProvider.GetService<OrdersViewForm>();
                ShowForm(ordersViewForm);
            }
        }
}

