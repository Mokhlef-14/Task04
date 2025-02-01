namespace Task04
{
    class CheckingAccount : Account
    {
        public CheckingAccount(string Name = "Unnamed Account", double Balance = 0.0, double fee=0.0)
        {
            Fee = fee;
        }

        public double Fee { get; set; }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }

        public override string ToString()
        {
            return $"Account Name: {Name}, Balance: {Balance:C}";
        }
    }
}
