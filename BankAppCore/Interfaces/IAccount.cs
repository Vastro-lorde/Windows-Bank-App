using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.Models;


namespace BankAppCore.Interfaces
{
    public interface IAccount
    {
        Task<List<Accounts>> GetAllAccounts();
        Task<bool> UpdateAccount(Accounts model);
        Task<List<Accounts>> GetAllAccountByAUser(string Id);

        Task<bool> AddAccount(Accounts model);
        Task<Accounts> GetAccountDetails(string accNum);




    }
}
