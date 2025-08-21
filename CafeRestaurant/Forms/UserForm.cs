using CafeRestaurant.Services;
using System;
using CafeRestaurant.Models;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class UserForm : Form
    {
        private readonly UserService _userService = new UserService(new CafeRestaurantEntities());
        private readonly UserroleService _userroleService; 

        public UserForm()
        {
            _userroleService = new UserroleService(new CafeRestaurantEntities());
            InitializeComponent();
            InitializeRoleComboBox();
            LoadUserList();
        }

        /// <summary>
        /// Initializes the role ComboBox with role data.
        /// </summary>
        private async void InitializeRoleComboBox()
        {
            cbRole.DataSource = await _userroleService.GetAllAsync();
            cbRole.DisplayMember = "ROLENAME";
            cbRole.ValueMember = "ROLEID";
        }

        /// <summary>
        /// Loads user list into the DataGridView.
        /// </summary>
        private async void LoadUserList()
        {
            dgUserList.DataSource = await _userService.GetAllWithRoleNameAsync();
            dgUserList.Columns["USERID"].Visible = false;
            dgUserList.Columns["USERNAME"].HeaderText = "Name";
            dgUserList.Columns["USERSURNAME"].HeaderText = "Surname";
            dgUserList.Columns["USERPHONE"].HeaderText = "Phone";
            dgUserList.Columns["USEREMAIL"].HeaderText = "Email";
            dgUserList.Columns["ROLENAME"].HeaderText = "Role";
            dgUserList.Columns["ROLEID"].Visible = false;
            dgUserList.Columns["USERADDRESS"].Visible = false;
        }

        /// <summary>
        /// Handles the Save button click to insert a new user.
        /// </summary>
        private async void btnProdSave_Click(object sender, EventArgs e)
        {
            var user = new USER
            {
                USERNAME = txbName.Text,
                USERSURNAME = txbSurName.Text,
                USERPHONE = txbPhone.Text,
                USEREMAIL = txbEmail.Text,
                USERADDRESS = txbAddress.Text,
                USERROLEID = (int)cbRole.SelectedValue
            };

            try
            {
                await _userService.InsertAsync(user);
                MessageBox.Show("User inserted!");
                LoadUserList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Update button click to modify an existing user.
        /// </summary>
        private async void btnProdUpdate_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(lblSifre.Text);
            var user = await _userService.GetByIdAsync(userId);
            if (user == null) return;

            user.USERNAME = txbName.Text;
            user.USERSURNAME = txbSurName.Text;
            user.USERPHONE = txbPhone.Text;
            user.USEREMAIL = txbEmail.Text;
            user.USERADDRESS = txbAddress.Text;
            user.USERROLEID = (int)cbRole.SelectedValue;

            try
            {
                await _userService.UpdateAsync(user);
                MessageBox.Show("User updated!");
                LoadUserList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the Delete button click to remove a user.
        /// </summary>
        private async void btnProdDelete_Click(object sender, EventArgs e)
        {
            if (lblSifre.Text == "label1") return;

            int userId = Convert.ToInt32(lblSifre.Text);
            try
            {
                await _userService.DeleteAsync(userId);
                MessageBox.Show("User deleted!");
                LoadUserList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Populates form fields when a user row is selected in the DataGridView.
        /// </summary>
        private void dgUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgUserList.Rows[e.RowIndex];

            lblSifre.Text = row.Cells["USERID"].Value?.ToString();
            txbName.Text = row.Cells["USERNAME"].Value?.ToString();
            txbSurName.Text = row.Cells["USERSURNAME"].Value?.ToString();
            txbPhone.Text = row.Cells["USERPHONE"].Value?.ToString();
            txbEmail.Text = row.Cells["USEREMAIL"].Value?.ToString();
            txbAddress.Text = row.Cells["USERADDRESS"].Value?.ToString();
            cbRole.SelectedValue = Convert.ToInt32(row.Cells["ROLEID"].Value);
        }

        /// <summary>
        /// Clears input fields on the form.
        /// </summary>
        private void ClearInputs()
        {
            txbName.Clear();
            txbSurName.Clear();
            txbPhone.Clear();
            txbEmail.Clear();
            txbAddress.Clear();
            lblSifre.Text = string.Empty;
        }


        //   private void btnCancel_Click(object sender, EventArgs e)
        // {
        //   Application.Exit();
        // }
    }
}

