using System;
using System.Linq;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToArray();
  
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];                   
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                  
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                        return;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}

