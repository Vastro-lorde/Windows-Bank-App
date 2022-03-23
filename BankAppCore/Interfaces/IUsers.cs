using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.Models;

namespace BankAppCore.Interfaces
{
    public interface IUsers
    {
        Task<List<Users>> GetAllUsers();
        Task<bool> AddUser(Users model);
        Task<Users> GetUserById(string Id);


    }
}

