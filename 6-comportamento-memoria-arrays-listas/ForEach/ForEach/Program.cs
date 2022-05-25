using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach (string item in vect)
            {
                Console.WriteLine(item);
            }
        }
    }
}
