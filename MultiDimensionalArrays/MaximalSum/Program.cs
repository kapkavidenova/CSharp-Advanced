using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix);
            int n = 3;
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;


            for (int row = 0; row < rows - n + 1; row++)
            {
                for (int col = 0; col < cols - n + 1; col++)
                {
                    int sum = 0;

                    for (int squareRow = row; squareRow < row + n; squareRow++)
                    {
                        for (int squareCol = col; squareCol <col+n; squareCol++)
                        {
                            sum += matrix[squareRow, squareCol];
                        }
                    }
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = maxRow; i < maxRow + n; i++)
            {
                for (int j = maxCol; j < maxCol + n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
    }
}
