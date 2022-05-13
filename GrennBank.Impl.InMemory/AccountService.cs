using GreenBank.Abstractions;
using GrennBank.Models;
using System.Linq;

namespace GrennBank.Impl.InMemory
{
    List<Account> Accounts = new List<Account>();

    public class AccountService : IAccountService
    {
        public Task<bool> AddItemAsync(Account item)
        {
            Accounts.Add(item);
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            Accounts = Accounts.Where(x =>  x.Id != id).ToList(); 
        }

        public Task<Account> GetItemAsync(string id)
        {
            return Accounts.Where(x => x.Id == id).FirstOrDefault(); 
        }

        public Task<IEnumerable<Account>> GetItemsAsync(bool forceRefresh = false)
        {
            return Accounts;
        }

        public bool Transfer(string sourceAccountNumber, string targetAccountNumber, decimal amount)
        {
            
        }

        public Task<bool> UpdateItemAsync(Account item)
        {
            Account acc = Accounts.Where(x => x.AccountNumber == item.AccountNumber).FirstOrDefault();
            acc = item;
            return true;
        }

        public bool Withdraw(string accountNumber, decimal amount)
        {
            
        }
    }
}