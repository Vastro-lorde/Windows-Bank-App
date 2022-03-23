using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.Helper;
using BankAppCore.Interfaces;
using BankAppCore.Models;

namespace BankAppCore.Services
{
    public class UserService : IUsers
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string userFile = "Users.json";

        public UserService(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddUser(Users model)
        {
            try
            {

                return await _dbContext.WriteJson(model, userFile);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<List<Users>> GetAllUsers()
        {
            try
            {

                return (List<Users>)await _dbContext.ReadJson<Users>(userFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Users> GetUserById(string Id)
        {
            List<Users> users = (List<Users>)await _dbContext.ReadJson<Users>(userFile);
            if (users != null)
            {
                foreach (var user in users)
                {
                    if (user.Id == Id)
                    {
                        return user;
                    }
                }
            }

            return null;
        }


    }
}
