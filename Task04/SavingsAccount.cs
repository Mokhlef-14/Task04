namespace Task04
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string Name= "Unnamed Account", double Balance = 0.0 ,double interestRate=0.0)
            :base(Name,Balance)
        {
            InterestRate = interestRate;
        }

        public double InterestRate { get; set; }

        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + InterestRate);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Interest Rate: {InterestRate}";
        }

       
    }
}
