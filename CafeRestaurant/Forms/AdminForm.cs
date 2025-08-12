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
    public partial class AdminForm : Form
    {

        private int userID;
        private readonly UserService userService = new UserService(); 
        private int? userRole;

        public AdminForm(int userId)
        {
            InitializeComponent();
            userID = userId;
            // AddControlsToPanel();
            USER user = userService.GetUserByID(userId);
            userRole = user.USERROLEID;
            if (userRole == 2)
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
        

        }

        // Opens the user form
        private void btnProdSave_Click(object sender, EventArgs e)
        {
            // panelContent içini temizle
            panelContent.Controls.Clear();

            // FormUser instance oluştur
            UserForm userForm = new UserForm();

            // Formu panelContent içine yerleştir
            userForm.TopLevel = false;
            userForm.TopMost = true;// Formu bağımsız pencere yapma
            userForm.FormBorderStyle = FormBorderStyle.None; // Çerçevesiz yap
            userForm.Dock = DockStyle.Fill;          // Paneli doldur
            panelContent.Controls.Add(userForm);     // Panel içerisine ekle
        
            userForm.Show();
            //  ShowForm(new UserForm());
        }
        private void ShowForm(Form form )
        {
            // panelContent içini temizle
            panelContent.Controls.Clear();

            // FormUser instance oluştur
           // UserForm userForm = new UserForm();

            // Formu panelContent içine yerleştir
            form.TopLevel = false;
            form.TopMost = true;// Formu bağımsız pencere yapma
            form.FormBorderStyle = FormBorderStyle.None; // Çerçevesiz yap
            form.Dock = DockStyle.Fill;          // Paneli doldur
            panelContent.Controls.Add(form);     // Panel içerisine ekle

            form.Show();
            //  ShowForm(new UserForm());
        }

        // Opens the category form
        private void btnCatInsert_Click(object sender, EventArgs e)
        {
            ShowForm(new CategoryForm());
        //    ShowForm(new CategoryForm());
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

        private void btnUserInsert_Click(object sender, EventArgs e)
        {
            ShowForm(new UserForm());
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
                this.WindowState = FormWindowState.Maximized; // Tam ekran
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Eski boyut
                this.CenterToScreen(); // Eski boyutta ekran ortasına getir
            }
        }

        private void btnToBottom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
             ShowForm(new DashboardAdminForm(userID));
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(null, null);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
          

            // Giriş formunu aç
            LoginForm login = new LoginForm();
            login.Show();

            // Şu anki formu kapat
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
                ShowForm(new OrdersViewForm());
        }
    }
}
