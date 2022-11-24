namespace Heranca3.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance = Balance * InterestRate;
        }

        //"override" indica que esta sobrescrevendo um método da superclasse
        public override void WithDraw(double amount)
        {
            //"base" chama a implementação do método na superclasse
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
