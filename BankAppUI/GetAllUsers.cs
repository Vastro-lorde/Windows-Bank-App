using System;
using System.Windows.Forms;
using BankAppCore.Interfaces;

namespace BankAppUI
{
    public partial class GetAllUsers : Form
    {
        private readonly IUsers _users;
        public GetAllUsers(IUsers users)
        {
            InitializeComponent();
            _users = users;
        }

        private async void GetAllUsers_Load(object sender, EventArgs e)
        {
            var users = await _users.GetAllUsers();
            if(users != null)
            {
                foreach (var item in users)
                {
                    string[] row = new string[5];

                    row[0] = item.Id;
                    row[1] = item.FullName;
                    row[2] = item.EmailAddress;
                    row[3] = item.MobileNumber;
                    row[4] = item.Age.ToString();

                    dgUsers.Rows.Add(row);
                }

            }
            
        }
    }
}
