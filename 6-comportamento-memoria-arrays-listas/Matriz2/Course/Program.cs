using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array elements:");
            int[,] mat = new int[m, n];

            for (int row = 0; row < mat.GetLength(0); row++)
            {
                string[] values = Console.ReadLine().Split();

                for (int col = 0; col < values.Length; col++)
                {
                    mat[row, col] = int.Parse(values[col]);
                }
            }

            Console.Write("Enter the value to be searched: ");
            int x = int.Parse(Console.ReadLine());

            for (int r = 0; r < mat.GetLength(0); r++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (x == mat[r, c])
                    {
                        Console.WriteLine("Position {0},{1}:", r, c);

                        //left
                        if (c > 0)
                        {
                            Console.WriteLine("Left: {0}", mat[r, c - 1]);
                        }
                        //up
                        if (r > 0)
                        {
                            Console.WriteLine("Up: {0}", mat[r - 1, c]);
                        }
                        //right
                        if (c < mat.GetLength(0) - 1)
                        {
                            Console.WriteLine("Right: {0}", mat[r, c + 1]);
                        }
                        //down
                        if (r < mat.GetLength(1) - 1)
                        {
                            Console.WriteLine("Down: {0}", mat[r + 1, c]);
                        }
                    }
                }
            }
        }
    }
}
