using GrennBank.Models;

namespace GreenBank.Abstractions
{
    public interface IAccountService : IDataStore<Account>
    {
        /// <summary>
        /// Withdraw from account the designated amount.
        /// </summary>
        /// <param name="accountNumber">The account number</param>
        /// <param name="amount">Amount of money</param>
        /// <returns><c>True</c> if the account balance has suficient funds, <c>false</c> otherwise.</returns>
        bool Withdraw(string accountNumber, decimal amount);

        /// <summary>
        /// Transfer the amount from source account to target account.
        /// </summary>
        /// <param name="sourceAccountNumber">Sourece account</param>
        /// <param name="targetAccountNumber">Target account</param>
        /// <param name="amount">Amount of money to be transfered</param>
        /// <returns><c>True</c> if the source account balance has suficient funds, <c>false</c> otherwise.</returns>
        bool Transfer(string sourceAccountNumber, string targetAccountNumber, decimal amount);
    }
}