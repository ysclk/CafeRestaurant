using CafeRestaurant.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class LoginForm : Form
    {
        // The AuthService instance is used for handling authentication operations
        private readonly LoginService loginService; 

        public LoginForm(LoginService loginService)
        {          
            InitializeComponent();
            this.loginService = loginService;
            this.AcceptButton = btnLogin;
        }
   
       
        // simple email validation method (with regex)
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //Close app
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPasswordForget_Click(object sender, EventArgs e)
        {
            var resetPassForm = Program.serviceProvider.GetService<ResetPasswordForm>();

            resetPassForm.Show();
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Simple validation: Check email and password fields.
            if (!IsValidEmail(txbUsermail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.");
                txbUsermail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUserpass.Text))
            {
                MessageBox.Show("Please enter your password.");
                txtUserpass.Focus();
                return;
            }

            // Prevent multiple clicks on the login button during login process
            //btnLogin.Enabled = false;

            try
            {
                //Login on the Authservice
                var result = await loginService.LoginAsync(txbUsermail.Text.Trim(), txtUserpass.Text);

                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                //If login is successful
                switch (result.Action)
                {
                    case "ShowAdminForm":
                        
                        // DI container'dan instance al, userId'yi manuel geçirmek için factory kullan
                        var adminFormFactory = Program.serviceProvider.GetService<Func<int, AdminForm>>();
                        var adminForm = adminFormFactory(result.UserId);
                        adminForm.Show();
                        this.Hide();
                        break;
                    //   case "ShowOrderForm":
                    //     var orderForm = new OrderForm(result.UserId);
                    //   orderForm.Show();
                    // this.Hide();
                    //break;
                    case "ShowPasswordResetForm":
                        var changeFormFactory = Program.serviceProvider.GetService<Func<int, string, PasswordChangeForm>>();
                        var changeForm = changeFormFactory(result.UserId, result.UserMail);
                        changeForm.Show();                       
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Unexpected action returned.");
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed:" + ex.Message);
            }

        }
    }
    
}
