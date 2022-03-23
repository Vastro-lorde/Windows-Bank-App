using System;
using System.ComponentModel;
using System.Windows.Forms;
using BankAppCore.Models;
using BankAppCore.Interfaces;
using BankAppCore.Helper;

namespace BankAppUI
{
    public partial class Register : Form
    {
        private readonly IUsers _users;
        private readonly IUtilities _utility;

        public Register(IUsers users, IUtilities utilities)
        {            
            _users = users;
            InitializeComponent();
            _utility = utilities;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Users person = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    FullName = txtFirstName.Text + " " + txtLastName.Text,
                    EmailAddress = txtEmail.Text,
                    MobileNumber = txtPhone.Text,
                    Password = _utility.ComputeSha256Hash(txtPassword.Text),
                    Age = Convert.ToInt16(txtAge.Text),
                    IsActive = true
                };
                var check = await _users.AddUser(person);
                if(check)
                {
                    MessageBox.Show("User was successfully added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProviderApp.SetError(txtFirstName, "Name should not be left blank!");
            }
            else if(!Validators.CheckName(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProviderApp.SetError(txtFirstName, "Please First Name should start with capital letter");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderApp.SetError(txtLastName, "Last name should not be left blank!");
            }
            else if (!Validators.CheckName(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProviderApp.SetError(txtLastName, "Please Last Name should start with capital letter");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProviderApp.SetError(txtEmail, "Email should not be left blank!");
            }
            else if (!Validators.CheckEmail(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProviderApp.SetError(txtEmail, "Please Enter Correct Email Format, abc@abc.abc");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtEmail, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProviderApp.SetError(txtPassword, "Password should not be left blank!");
            }
            else if (!Validators.CheckPassword(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProviderApp.SetError(txtPassword, "Please your password should contain 6 character with atleast one special character, digit and UPPERCASE");
            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(txtPassword, "");
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
