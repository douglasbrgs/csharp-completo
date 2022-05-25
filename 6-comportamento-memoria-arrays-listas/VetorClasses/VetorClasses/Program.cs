using System;
using System.Globalization;

namespace VetorClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product[] products = new Product[qtd];

            for (int i = 0; i < qtd; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products[i] = new Product(name, price);
            }

            double sum = 0.0;

            for (int i = 0; i < qtd; i++)
            {
                sum += products[i].Price;
            }

            double average = sum / qtd;

            Console.WriteLine("AVERAGE PRICE = " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
