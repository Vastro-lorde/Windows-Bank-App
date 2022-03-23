using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankAppCore.Interfaces;

namespace BankAppUI
{
    public partial class AccountStatement : Form
    {
        private readonly IAccount _account;
        private readonly ITransactions _transactions;
        public AccountStatement(ITransactions transactions, IAccount account)
        {
            InitializeComponent();
            _transactions = transactions;
            _account = account;
        }

        private async void cmbChooseAccount_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cmbChooseAccount.Text != "")
            {
                dgAccountStatement.Rows.Clear();
                var trans = await _transactions.GetAllTransactionsForAnAccount(cmbChooseAccount.Text);
                if (trans != null)
                {
                    foreach (var item in trans)
                    {
                        string[] row = new string[5];

                        row[0] = item.AccountNumber;
                        row[1] = item.Description;
                        row[2] = item.Amount;
                        row[3] = item.Balance;
                        row[4] = item.Date.ToString();

                        dgAccountStatement.Rows.Add(row);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please select an Account");
            }
        }

        private async void AccountStatement_Load(object sender, EventArgs e)
        {
            cmbChooseAccount.Items.Clear();
            var accounts = await _account.GetAllAccountByAUser(GlobalVariable.GlobalUser.Id);
            if (accounts != null)
            {
                foreach (var item in accounts)
                {
                    cmbChooseAccount.Items.Add(item.AccountNumber);
                }
            }


        }
    }
}
