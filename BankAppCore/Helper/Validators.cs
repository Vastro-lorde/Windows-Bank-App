using System.Text.RegularExpressions;
using BankAppCore.Interfaces;


namespace BankAppCore.Helper
{
    public class Validators 
    {
        public static bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";

            return PerformRegEx(strRegex, name);
        }

        public static bool CheckEmail(string email)
        {
            /*regular expression for Identifying email using RFC 5322 format if we omit IP addresses, domain-specific addresses.*/
            string strRegex = @"\A[a-zA-Z0-9]+(?:\.[a-z0-9!#$%&'*+/=?^_‘{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\z";
            return PerformRegEx(strRegex, email);

        }

        public static bool CheckPassword(string password)
        {
            /*This regex checks to make sure the password contains Minimum six characters, at least one uppercase letter, one lowercase letter, one number and one special character:*/
            string strRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }


        private static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new(pattern);


            if (re.IsMatch(value))
                return (true);
            else
                return (false);
        }

    }
}
