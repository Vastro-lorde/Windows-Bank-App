using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppCore.Interfaces;
using BankAppCore.Models;

namespace BankAppCore.Services
{
    public class AccountService : IAccount
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string accountFile = "Accounts.json";

        public AccountService(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddAccount(Accounts model)
        {
            try
            {

                return await _dbContext.WriteJson(model, accountFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Accounts> GetAccountDetails(string accNum)
        {
            var accounts = await GetAllAccounts();
            foreach (var item in accounts)
            {
                if (item.AccountNumber == accNum)
                    return item;
            }

            return null;
        }

        public async Task<List<Accounts>> GetAllAccountByAUser(string Id)
        {
            List<Accounts> accounts = (List<Accounts>)await _dbContext.ReadJson<Accounts>(accountFile);
            List<Accounts> result = new List<Accounts>();
            if (accounts != null)
            {
                foreach (var account in accounts)
                {
                    if (account.UserId == Id)
                    {
                        result.Add(account);
                    }
                }
            }

            return result;
        }

        public async Task<List<Accounts>> GetAllAccounts()
        {
            try
            {

                return (List<Accounts>)await _dbContext.ReadJson<Accounts>(accountFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateAccount(Accounts model)
        {
            var accounts = await GetAllAccounts();
            if (accounts != null)
            {
                foreach (var item in accounts)
                {
                    if (item.AccountNumber == model.AccountNumber)
                        item.Balance = model.Balance;
                }

                return await _dbContext.UpdateJson<Accounts>(accounts, accountFile);
            }

            return false;
        }
    }
}
