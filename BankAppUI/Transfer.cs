using System;
using System.Windows.Forms;
using BankAppCore.Interfaces;

namespace BankAppUI
{
    public partial class Transfer : Form
    {
        private readonly IAccountOperation _accountOperation;
        private readonly IAccount _account;
        public Transfer(IAccount account, IAccountOperation accountOperation)
        {
            InitializeComponent();
            _accountOperation = accountOperation;
            _account = account;
        }

        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                bool deposit = await _accountOperation.Withdraw(cmbSender.Text, txtTransferAmt.Text);

                if (deposit)
                {
                    bool withdraw = await _accountOperation.Deposit(txtReciever.Text, txtTransferAmt.Text);
                    if (withdraw)
                    {
                        MessageBox.Show("Transfer is successfull");
                    }
                    else
                    {
                        await _accountOperation.Deposit(cmbSender.Text, txtTransferAmt.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient Fund");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Transfer_Load(object sender, EventArgs e)
        {
            cmbSender.Items.Clear();
            var accounts = await _account.GetAllAccountByAUser(GlobalVariable.GlobalUser.Id);
            if (accounts != null)
            {
                foreach (var item in accounts)
                {
                    cmbSender.Items.Add(item.AccountNumber);
                }
            }
        }
    }
}
