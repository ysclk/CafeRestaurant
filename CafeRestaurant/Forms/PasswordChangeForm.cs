using CafeRestaurant.Services;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class PasswordChangeForm : Form
    {
        private readonly int _userId;
        private readonly string _userEmail;
        private readonly AuthService _authService;

        public PasswordChangeForm(int userId, string userEmail)
        {
            InitializeComponent();

            _userId = userId;
            _userEmail = userEmail;
            _authService = new AuthService();

            lblUserid.Text = _userId.ToString();

            // Optional: Set placeholder or mask for password fields
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            // Check if user ID is valid before attempting password change
            if (_userId == 0)
            {
                MessageBox.Show("User ID is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newPassword = txbPassword.Text.Trim();
            string confirmPassword = txbPassagain.Text.Trim();

            // Validate that both password fields match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the AuthService to change the password
        

            if (_userId != 0)
            {
                _authService.ChangePassword(_userId, newPassword, confirmPassword);
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after success
            }
            else
            {
                MessageBox.Show("Password change failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Exit the application (optional: consider whether this should only close the form)
            Application.Exit();
        }
    }
}
