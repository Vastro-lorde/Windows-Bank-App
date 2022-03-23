using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace BankAppUI
{
    public partial class Admin : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Admin(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            GetAllUsers getAllUsers = _serviceProvider.GetRequiredService<GetAllUsers>();
            getAllUsers.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Register register = _serviceProvider.GetRequiredService<Register>();
            register.ShowDialog();
        }

        private void btnAddUserRole_Click(object sender, EventArgs e)
        {
            UserRole userRole = _serviceProvider.GetRequiredService<UserRole>();
            userRole.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home fm = _serviceProvider.GetRequiredService<Home>();
            fm.Show();
        }
    }
}
