using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.Models;

namespace BankAppCore.Interfaces
{
    public interface ITransactions
    {
        Task<bool> AddTransaction(Transactions model);

        Task<List<Transactions>> GetAllTransactionsForAnAccount(string accNum);
    }
}
