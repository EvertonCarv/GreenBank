namespace GrennBank.Models
{
    public class Account
    {
        private Client client;

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }

        private string accountnumber;

        public string AccountNumber
        {
            get { return accountnumber; }
            set { accountnumber = value; }
        }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}