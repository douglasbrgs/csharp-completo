using Heranca1.Entities;

namespace Heranca1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1234, "Bob Brown", 150.00, 200.00);

            Console.WriteLine(account.Balance);

            //Encapsulamento
            //account.Balance = 300.00;

        }
    }
}