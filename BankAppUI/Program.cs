using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppCore.Interfaces;
using BankAppCore.Services;
using BankAppCore.Helper;
using Microsoft.Extensions.DependencyInjection;

namespace BankAppUI
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Home>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUsers, UserService>();
            services.AddScoped<IAccount, AccountService>();
            services.AddScoped<ITransactions, TransactionsService>();
            services.AddScoped<IUserInRole, UserRolesService>();
            services.AddScoped<IAuth, AuthService>();
            services.AddScoped<IAccountOperation, AccountOperation>();
            services.AddScoped<IReadWriteToJson, ReadWriteToJson>();
            services.AddScoped<IUtilities, Utilities>();
            services.AddScoped<Home>();
            services.AddScoped<Admin>();
            services.AddScoped<Customer>();
            services.AddScoped<Register>();
            services.AddScoped<GetAllUsers>();
            services.AddScoped<UserRole>();
            services.AddScoped<CreateAccount>();
            services.AddScoped<AccountStatement>();
            services.AddScoped<Transfer>();



        }
    }
}
