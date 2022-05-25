using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco"); // inserir em uma posição empurra os demais para frente
            list.Add("Peter");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("List count: " + list.Count);
            Console.WriteLine();

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);
            Console.WriteLine();

            Console.WriteLine("Cinco Caracteres:");
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Remove 'Alex':");
            list.Remove("Alex");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Remove todos começados por 'M':");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Remove posição 1:");
            list.RemoveAt(1);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Remove um elemento a partir do índice 1:");
            list.RemoveRange(1, 1);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
