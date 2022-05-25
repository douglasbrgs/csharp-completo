using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter square matrix order: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            int negativeNumbersCount = 0;

            Console.WriteLine("Enter the elements of the square matrix:");

            for (int row = 0; row < mat.GetLength(0); row++)
            {
                string[] values = Console.ReadLine().Split();

                for (int col = 0; col < values.Length; col++)
                {
                    int number = int.Parse(values[col]);
                    mat[row, col] = number;

                    if (number < 0)
                    {
                        negativeNumbersCount++;
                    }
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            Console.Write("Negative numbers = {0}", negativeNumbersCount);

            //Console.WriteLine(matriz.Length); // total de elementos
            //Console.WriteLine(matriz.Rank); // numero de dimensoes
            //Console.WriteLine(matriz.GetLength(0)); // numero de elementos na dimensao (0)
            //Console.WriteLine(matriz.GetLength(1)); // numero de elementos na dimensao (1)
        }
    }
}
