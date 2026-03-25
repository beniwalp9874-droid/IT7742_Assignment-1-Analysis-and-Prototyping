namespace BankSprint1
{
    public class OmniAccount : Account
    {
        private double interestRate = 0.03;
        private double overdraftLimit = 500;
        private double failedFee = 15;

        public OmniAccount(int id, double balance) : base(id, balance) { }

        public override string Withdraw(double amount)
        {
            if (balance - amount >= -overdraftLimit)
            {
                balance -= amount;
                lastStatus = "Withdrawal Successful";
            }
            else
            {
                balance -= failedFee;
                lastStatus = "Overdraft Limit Exceeded";
            }
            return lastStatus;
        }

        public override double CalculateInterest()
        {
            if (balance > 1000)
            {
                double interest = balance * interestRate;
                balance += interest;
                return interest;
            }
            return 0;
        }
    }
}
