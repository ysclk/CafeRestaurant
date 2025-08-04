using CafeRestaurant.Services;
using System;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class LoginForm : Form
    {
        // The AuthService instance is used for handling authentication operations
        private AuthService authService = new AuthService();

        public LoginForm()
        {          
            InitializeComponent();
        }
   
        
        private void btnLogin_Click_1(object sender, EventArgs e)
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
                    var result = authService.Login(txbUsermail.Text.Trim(), txtUserpass.Text);

                    if (!result.IsSuccess)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }
                    //If login is successful
                    switch (result.Action)
                    {
                        case "ShowAdminForm":
                            var adminForm = new AdminForm(result.UserId);
                            adminForm.Show();
                            this.Hide();
                            break;
                        case "ShowOrderForm":
                            var orderForm = new OrderForm(result.UserId);
                            orderForm.Show();
                            this.Hide();
                            break;
                        case "ShowPasswordResetForm":
                            var resetForm = new PasswordChangeForm(result.UserId, result.UserMail);
                            resetForm.Show();
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
            ResetPasswordForm form = new ResetPasswordForm();
          
            form.Show();
            
        }
    }
    
}
