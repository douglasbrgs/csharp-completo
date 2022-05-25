using System;
using System.Globalization;

namespace Vetores1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double average = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
