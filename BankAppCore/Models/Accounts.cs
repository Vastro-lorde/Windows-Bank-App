using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppCore.Models
{
    public class Accounts
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public string AccountType { get; set; }

        public string UserId { get; set; }        

    }
}
