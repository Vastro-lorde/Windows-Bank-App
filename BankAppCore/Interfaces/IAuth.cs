using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BankAppCore.Models;

namespace BankAppCore.Interfaces
{
    public interface IAuth
    {
        Task<Dictionary<string, Users>> Login(string email, string password);

    }
}
