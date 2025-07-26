using CafeRestaurant.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;

namespace CafeRestaurant.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            cbRole.DataSource = new List<object>
                {
                    new { Text = "Admin", Value = 1 },
                    new { Text = "Staff", Value = 2 }
                };

            cbRole.DisplayMember = "Text";
            cbRole.ValueMember = "Value";
            dgUserList.DataSource = us.GetAllWithRoleName();
            dgUserList.Columns["USERID"].Visible = false;
            dgUserList.Columns["USERNAME"].HeaderText = "Name";
            dgUserList.Columns["USERSURNAME"].HeaderText = "Surname";
            dgUserList.Columns["USERPHONE"].HeaderText = "Phone";
            dgUserList.Columns["USEREMAIL"].HeaderText = "Email";
            dgUserList.Columns["ROLENAME"].HeaderText = "Role";
            dgUserList.Columns["ROLEID"].Visible = false;
            dgUserList.Columns["USERADDRESS"].Visible = false;

            cbRole.DataSource = urs.GetAll();
            cbRole.DisplayMember = "ROLENAME";
            cbRole.ValueMember = "ROLEID";

        }

        private UserService us = new UserService();
        private UserroleService urs = new UserroleService();
        private void btnProdSave_Click(object sender, EventArgs e)
        {
            var User = new USER
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
                us.Insert(User);
                MessageBox.Show("User inserted!");
                dgUserList.DataSource = us.GetAll();
                txbAddress.Clear();
                txbEmail.Clear();
                txbName.Clear();
                txbPhone.Clear();
                txbSurName.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(lblSifre.Text);
            var userEx = us.GetById(userid);
            if (userEx != null)
            {
                userEx.USERID = userid;
                userEx.USERNAME = txbName.Text;
                userEx.USERSURNAME = txbSurName.Text;
                userEx.USERPHONE = txbPhone.Text;
                userEx.USEREMAIL = txbEmail.Text;
                userEx.USERADDRESS = txbAddress.Text;
                userEx.USERROLEID = 3;
              

            }
            try
            {
                us.Update(userEx);
                MessageBox.Show("User updated!");
                dgUserList.DataSource = us.GetAll();
                txbAddress.Clear();
                txbEmail.Clear();
                txbName.Clear();
                txbPhone.Clear();
                txbSurName.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            if (lblSifre.Text != "label1")
            {
                int userId = Convert.ToInt32(lblSifre.Text);
                try
                {
                    us.Delete(userId);
                    MessageBox.Show("User deleted!");
                    dgUserList.DataSource = us.GetAll();
                    txbAddress.Clear();
                    txbEmail.Clear();
                    txbName.Clear();
                    txbPhone.Clear();
                    txbSurName.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Failed: " + ex.Message);
                }
            }
        }

        private void dgUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow dgrow = dgUserList.Rows[rowIndex];
                int userId = Convert.ToInt32(dgrow.Cells[0].Value?.ToString());
                string name = dgrow.Cells[1].Value?.ToString();
                string surname = dgrow.Cells[2].Value?.ToString();
                string phone = dgrow.Cells[3].Value?.ToString();
                string email = dgrow.Cells[4].Value?.ToString();
                string address = dgrow.Cells[5].Value?.ToString();
                string role = urs.GetRoleName(Convert.ToInt32(dgrow.Cells[6].Value?.ToString()));
                lblSifre.Text = userId.ToString();
                txbName.Text = name;
                txbSurName.Text = surname;
                txbPhone.Text = phone;
                txbEmail.Text = email;
                txbAddress.Text = address;
                cbRole.SelectedValue = role; ;

            }
        }
    }
}
