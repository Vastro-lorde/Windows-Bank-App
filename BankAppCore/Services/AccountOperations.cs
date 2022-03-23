using System;
using System.Threading.Tasks;
using BankAppCore.Interfaces;
using BankAppCore.Models;



namespace BankAppCore.Services
{
    public class AccountOperation : IAccountOperation
    {
        private readonly IAccount _account;
        private readonly ITransactions _transactions;
        public AccountOperation(ITransactions transactions, IAccount account)
        {
            _transactions = transactions;
            _account = account;
        }


        public async Task<bool> Deposit(string accNum, string amt)
        {
            try
            {
                Accounts account = await _account.GetAccountDetails(accNum);
                if (Convert.ToDouble(amt) < 0)
                {
                    return false;
                }
                // Deposits the money.
                account.Balance += Convert.ToDouble(amt);
                bool check = await _account.UpdateAccount(account);
                if (check)
                {
                    Transactions trans = new()
                    {
                        AccountNumber = accNum,
                        Description = "Deposit Money",
                        Amount = amt,
                        Balance = account.Balance.ToString()

                    };

                    await _transactions.AddTransaction(trans);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> Withdraw(string accNum, string amount)
        {
            bool response = false;
            try
            {
                Accounts account = await _account.GetAccountDetails(accNum);
                double minBalance = account.AccountType == "Saving" ? 1000.0 : 0.0;
                double amt = Convert.ToDouble(amount);
                if (amt <= account.Balance - minBalance)
                {
                    account.Balance -= amt;
                    bool check = await _account.UpdateAccount(account);
                    if (check)
                    {
                        Transactions trans = new Transactions()
                        {
                            AccountNumber = accNum,
                            Description = "Withdraw Money",
                            Amount = amount,
                            Balance = account.Balance.ToString()

                        };

                        await _transactions.AddTransaction(trans);
                    }
                    response = true;
                }
                else if (amt > account.Balance - minBalance)
                {
                    response = false;
                }


            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }




    }
}
