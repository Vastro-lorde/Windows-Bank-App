using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppCore.Interfaces;
using BankAppCore.Models;

namespace BankAppCore.Services
{
    public class TransactionsService : ITransactions
    {

        private readonly IReadWriteToJson _dbContext;
        private readonly string transactionFile = "Transactions.json";

        public TransactionsService(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddTransaction(Transactions model)
        {
            try
            {

                return await _dbContext.WriteJson(model, transactionFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Transactions>> GetAllTransactionsForAnAccount(string accNum)
        {
            List<Transactions> transactions = (List<Transactions>)await _dbContext.ReadJson<Transactions>(transactionFile);
            List<Transactions> result = new List<Transactions>();
            if (transactions != null)
            {
                foreach (var item in transactions)
                {
                    if (item.AccountNumber == accNum)
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }
    }
}
