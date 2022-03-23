using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankAppCore.Models;
using BankAppCore.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BankAppUI
{
    public partial class CreateAccount : Form
    {
        private readonly IAccount _account;
        private readonly IUtilities _utility;
        private IServiceProvider _serviceProvider;
        public CreateAccount(IAccount account, IUtilities utilities, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _account = account;
            _utility = utilities;
            _serviceProvider = serviceProvider;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Accounts account = new ()
            {
                AccountNumber = _utility.RandomDigits(),
                AccountType = rdbSaving.Checked ? "Saving" : "Current",
                Balance = Convert.ToDouble(txtInitailAmt.Text),
                UserId = GlobalVariable.GlobalUser.Id
            };

            try
            {
                bool check = await _account.AddAccount(account);
                MessageBox.Show("Account Added Successfully!!");
                this.Hide();
                Customer customer = _serviceProvider.GetRequiredService<Customer>();
                customer.Show();
                customer.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
