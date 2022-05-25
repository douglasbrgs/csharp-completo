using System;
using System.Globalization;

namespace RoomRent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] rooms = new Student[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qty = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            for (int i = 0; i < qty; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int selectedRoom = int.Parse(Console.ReadLine());

                if (rooms[selectedRoom] == null)
                {
                    rooms[selectedRoom] = new Student(name, email);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
                }
            }
        }
    }
}
