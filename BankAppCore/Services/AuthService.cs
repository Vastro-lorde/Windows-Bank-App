using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.Helper;
using BankAppCore.Interfaces;
using BankAppCore.Models;

namespace BankAppCore.Services
{
    public class AuthService : IAuth
    {

        private readonly IUsers _users;
        private readonly IUserInRole _userInRole;
        private readonly IUtilities _utility;


        public AuthService(IUsers users, IUserInRole userInRole, IUtilities utilities)
        {
            _users = users;
            _userInRole = userInRole;
            _utility = utilities;
        }
        public async Task<Dictionary<string, Users>> Login(string email, string password)
        {
            string hashPassword = _utility.ComputeSha256Hash(password);
            var users = await _users.GetAllUsers();
            var result = new Dictionary<string, Users>();
            foreach (var item in users)
            {
                if (item.EmailAddress == email && item.Password == hashPassword)
                {
                     string role = await _userInRole.GetUserRoles(item.Id);
                     result[role] = item;
                    return result;

                    
                }
                    
            }

            return null;

        }
    }
}
