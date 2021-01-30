using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string snake = Console.ReadLine();
            char[,] snakes = new char[rows, cols];
            int currentLetter = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        snakes[row, col] = snake[currentLetter];
                        currentLetter++;

                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }

                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        snakes[row, col] = snake[currentLetter];
                        currentLetter++;

                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(snakes[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
