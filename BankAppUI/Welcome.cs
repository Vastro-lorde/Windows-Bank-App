using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppCore.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BankAppUI
{
    public partial class Home : Form
    {
        private readonly IAuth _auth;
        private IServiceProvider _serviceProvider;
        
        public Home(IAuth auth, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _auth = auth;
            _serviceProvider = serviceProvider;


        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await _auth.Login(txtEmail.Text, txtPassword.Text);
                if(user != null)
                {
                    GlobalVariable.UserRole = user.Keys.SingleOrDefault();
                    GlobalVariable.GlobalUser = user[GlobalVariable.UserRole];

                    if (GlobalVariable.GlobalUser.IsAdmin)
                    {

                        this.Hide();
                        Admin admin = _serviceProvider.GetRequiredService<Admin>();
                        admin.Show();

                    }
                    else
                    {
                        this.Hide();
                        Customer customer = _serviceProvider.GetRequiredService<Customer>();
                        customer.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Invalid Credientail");
                }                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
        }
    }
}
