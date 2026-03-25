namespace BankSprint1
{
    public class InvestmentAccount : Account
    {
        private double interestRate = 0.05;
        private double failedFee = 10;

        public InvestmentAccount(int id, double balance) : base(id, balance) { }

        public override string Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                lastStatus = "Withdrawal Successful";
            }
            else
            {
                balance -= failedFee;
                lastStatus = "Failed - Fee Applied";
            }
            return lastStatus;
        }

        public override double CalculateInterest()
        {
            double interest = balance * interestRate;
            balance += interest;
            return interest;
        }
    }
}
