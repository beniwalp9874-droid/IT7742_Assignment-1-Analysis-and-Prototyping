using System.Collections.Generic;

namespace BankSprint1
{
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }

        private List<Account> accounts = new List<Account>();

        public Customer()
        {
            accounts.Add(new EverydayAccount(1, 1000));
            accounts.Add(new InvestmentAccount(2, 2000));
            accounts.Add(new OmniAccount(3, 1500));
        }

        public List<Account> GetAccounts() => accounts;
    }
}
