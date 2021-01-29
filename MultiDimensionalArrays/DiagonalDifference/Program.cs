using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sum1 = 0;
            int sum2 = 0;

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (row == col)
                    {
                        sum1 += matrix[row, col];
                    }
                    if (col == n - 1 - row)
                    {
                        sum2 += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
