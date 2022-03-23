using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.Models;

namespace BankAppCore.Interfaces
{
    public interface IUserInRole
    {
        Task<bool> AddUserToRole(string userId, int roleId);

        Task<string> GetUserRoles(string userId);

        Task<List<Roles>> GetAllRoles();
    }
}
