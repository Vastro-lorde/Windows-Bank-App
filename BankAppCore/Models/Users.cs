﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppCore.Models
{
    public class Users
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public int Age { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;

        List<Accounts> Accounts { get; set; }
    }
}
