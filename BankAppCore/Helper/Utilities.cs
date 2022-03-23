using System;
using System.Security.Cryptography;
using System.Text;
using BankAppCore.Interfaces;

namespace BankAppCore.Helper
{
    public class Utilities : IUtilities
    {
        public string RandomDigits()
        {
            // Generates a random string number of 10 digits that always start with 2.
            var random = new Random();
            string s = "2";
            for (int i = 0; i < 9; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
