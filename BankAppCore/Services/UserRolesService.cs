using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BankAppCore.Helper;
using BankAppCore.Interfaces;
using BankAppCore.Models;

namespace BankAppCore.Services
{
    public class UserRolesService : IUserInRole
    {
        private readonly IReadWriteToJson _dbContext;
        private readonly string userInRoleFile = "UserInRole.json";
        private readonly string roleFile = "Roles.json";

        public UserRolesService(IReadWriteToJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddUserToRole(string userId, int roleId)
        {
            UserInRoles userRole = new UserInRoles()
            {
                RoleId = roleId,
                UserId = userId
            };

            try
            {

                return await _dbContext.WriteJson<UserInRoles>(userRole, userInRoleFile); ;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<List<Roles>> GetAllRoles()
        {
            try
            {

                return (List<Roles>)await _dbContext.ReadJson<Roles>(roleFile);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> GetUserRoles(string userId)
        {
            var userRoles = await _dbContext.ReadJson<UserInRoles>(userInRoleFile);
            var roles = await GetAllRoles();
            List<Roles> roleList = null;
            if (userRoles != null)
            {
                foreach (var item in userRoles)
                {
                    if (item.UserId == userId)
                    {
                        roleList = roles.FindAll(x => x.Id == item.RoleId);
                        return roleList[0].RoleName;
                    }
                }
            }

            return null;
        }


    }
}
