using System.Threading.Tasks;

namespace BankAppCore.Interfaces
{
    public interface IAccountOperation
    {
        Task<bool> Deposit(string accNum, string amt);
        Task<bool> Withdraw(string accNum, string amount);
    }
}