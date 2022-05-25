using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine();

            DateTime d2 = new DateTime(2022, 05, 06);
            Console.WriteLine(d2);
            DateTime d3 = new DateTime(2022, 05, 06, 20, 50, 3);
            Console.WriteLine(d3);
            DateTime d4 = new DateTime(2022, 05, 06, 20, 50, 3, 500);
            Console.WriteLine(d4);
            Console.WriteLine();

            DateTime d5 = DateTime.Now;
            Console.WriteLine(d5);
            DateTime d6 = DateTime.Today;
            Console.WriteLine(d6);
            DateTime d7 = DateTime.UtcNow;
            Console.WriteLine(d7);
            Console.WriteLine();

            DateTime d8 = DateTime.Parse("2022-05-06");
            Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse("2022-05-06 13:05:58");
            Console.WriteLine(d9);
            DateTime d10 = DateTime.Parse("06/05/2022");
            Console.WriteLine(d10);
            DateTime d11 = DateTime.Parse("06/05/2022 13:05:58");
            Console.WriteLine(d11);
            Console.WriteLine();

            DateTime d12 = DateTime.ParseExact("2022-05-06", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);
            DateTime d13 = DateTime.ParseExact("06/05/2022 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d13);
        }
    }
}
