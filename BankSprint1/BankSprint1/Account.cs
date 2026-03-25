namespace BankSprint1
{
    public abstract class Account
    {
        protected int accountID;
        protected double balance;
        protected string lastStatus;

        public Account(int id, double initialBalance)
        {
            accountID = id;
            balance = initialBalance;
            lastStatus = "Ready";
        }

        public virtual string Deposit(double amount)
        {
            balance += amount;
            lastStatus = "Deposit Successful";
            return lastStatus;
        }

        public abstract string Withdraw(double amount);
        public abstract double CalculateInterest();

        public string GetAccountInfo()
        {
            return $"ID: {accountID} | Balance: {balance:C} | Status: {lastStatus}";
        }
    }
}
