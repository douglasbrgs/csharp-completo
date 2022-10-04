using Composicao3.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Composicao3.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> items = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem orderItem in items)
            {
                sum += orderItem.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:yyyy"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());

            sb.AppendLine("Order Items: ");
            foreach (OrderItem orderItem in items)
            {
                sb.AppendLine(orderItem.ToString());
            }

            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
