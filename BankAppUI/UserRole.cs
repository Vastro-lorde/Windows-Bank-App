using System;
using System.Windows.Forms;
using BankAppCore.Interfaces;

namespace BankAppUI
{
    public partial class UserRole : Form
    {
        private readonly IUserInRole _role;
        public UserRole(IUserInRole role)
        {
            InitializeComponent();
            _role = role;
        }

        private async void UserRole_Load(object sender, EventArgs e)
        {
            var roles = await _role.GetAllRoles();
           
            if (roles != null)
            {
                foreach (var item in roles)
                {
                    cmbRole.Items.Add(item.RoleName);
                }   
            }
        }

        private async void btnAddUserRole_Click(object sender, EventArgs e)
        {
            var result = await _role.AddUserToRole(txtUserId.Text, cmbRole.SelectedIndex + 1);

            if(result)
            {
                MessageBox.Show("Successfull");
            }
            else
            {
                MessageBox.Show("failed try again");
            }
        }
    }
}
