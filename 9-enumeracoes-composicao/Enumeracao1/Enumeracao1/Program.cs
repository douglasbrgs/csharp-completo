using Enumeracao1.Entities;
using Enumeracao1.Entities.Enums;

namespace Enumeracao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1234,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txtStatus = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txtStatus);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}