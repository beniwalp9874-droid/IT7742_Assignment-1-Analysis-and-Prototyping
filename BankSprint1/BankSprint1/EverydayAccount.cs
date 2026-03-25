namespace BankSprint1
{
    public class EverydayAccount : Account
    {
        public EverydayAccount(int id, double balance) : base(id, balance) { }

        public override string Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                lastStatus = "Withdrawal Successful";
            }
            else
            {
                lastStatus = "Insufficient Funds";
            }
            return lastStatus;
        }

        public override double CalculateInterest() => 0;
    }
}
