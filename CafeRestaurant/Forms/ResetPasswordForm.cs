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
       
        // Service to handle authentication-related operations
        private readonly AuthService _authService = new AuthService();

        public ResetPasswordForm()
        {
            InitializeComponent();

            // Set the Reset button as the default accept button
            this.AcceptButton = btnReset;
        }

        /// <summary>
        /// Handles the Cancel button click event.
        /// Closes the application.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Reset button click event.
        /// Validates the user email and opens the password change form if valid.
        /// </summary>
        private async void btnReset_Click(object sender, EventArgs e)
        {
            string userEmail = txbUsermail.Text.Trim();

            // Get the user ID for the provided email
            int userId =await _authService.UserIdAsync(userEmail);

            if (userId == 0)
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open the password change form
            PasswordChangeForm passForm = new PasswordChangeForm(userId, userEmail);

            // Close the current form before showing the next form
            this.Close();
            passForm.Show();
        }
    }

}

