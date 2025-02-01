namespace Task04
{
    public class TrustAccount : SavingsAccount
    {
        private int withdrawalCount; 
        private const int maxWithdrawals = 3; 
        private const double maxWithdrawalPercentage = 0.20; 

        public TrustAccount(string Name = "Unnamed Trust Account", double Balance = 0.0, double InterestRate = 0.0)
            : base(Name, Balance, InterestRate)
        {
            withdrawalCount = 0;
        }

        public override bool Withdraw(double amount)
        {
            
            if (withdrawalCount >= maxWithdrawals)
            {
                Console.WriteLine("Withdrawal failed: Exceeded maximum number of withdrawals for the year.");
                return false;
            }

            
            if (amount > Balance * maxWithdrawalPercentage)
            {
                Console.WriteLine($"Withdrawal failed: Amount exceeds 20% of the account balance ({Balance * maxWithdrawalPercentage:C}).");
                return false;
            }

            
            if (base.Withdraw(amount))
            {
                withdrawalCount++;
                return true;
            }
            return false;
        }

        public override bool Deposit(double amount)
        {
            // Add a $50 bonus for deposits of $5000 or more
            if (amount >= 5000)
            {
                Balance += 50; // Add bonus
            }
            return base.Deposit(amount);
        }

        public override string ToString()
        {
            return $"Account Name: {Name}, Balance: {Balance:C}, Withdrawals this year: {withdrawalCount}";
        }
    }
}
