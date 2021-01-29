using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            int count = 0;

            NewMethod(rows, cols, matrix);

            Console.WriteLine(count);
            //private static void isEqual(char[,] matrix, int row, int col)
            //{
            //    if (matrix[row, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col])
            //    {
            //        for (int i = 0; i < matrix.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < matrix.GetLength(1); j++)
            //            {
            //                Console.Write(matrix[i, j] + " ");

            //            }
            //            Console.WriteLine();
            //        }
            //    }

        }

        private static void NewMethod(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
