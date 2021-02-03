using System;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chess = new char[n, n];
            FillChess(chess);
            int countReplaced = 0;
            int rowMax = 0;
            int colMax = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char current = chess[row, col];
                        int countAttacks = 0;

                        if (current == 'K')
                        {
                            countAttacks = GetAttacks(chess, row, col, countAttacks);

                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                rowMax = row;
                                colMax = col;
                            }
                        }
                    }
                }
                if (maxAttacks > 0)
                {
                    chess[rowMax, colMax] = '0';
                    countReplaced++;
                }

                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }
        }

        private static int GetAttacks(char[,] chess, int row, int col, int countAttacks)
        {
            if (IsInside(chess, row - 2, col + 1) && chess[row - 2, col + 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chess, row - 2, col - 1) && chess[row - 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chess, row + 1, col + 2) && chess[row + 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chess, row + 1, col - 2) && chess[row + 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chess, row - 1, col + 2) && chess[row - 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chess, row - 1, col - 2) && chess[row - 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chess, row + 2, col - 1) && chess[row + 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chess, row + 2, col + 1) && chess[row + 2, col + 1] == 'K')
            {
                countAttacks++;
            }

            return countAttacks;
        }

        //private static void PrintChess(char[,] chess)
        //{
        //    for (int row = 0; row < chess.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < chess.GetLength(1); col++)
        //        {
        //            Console.Write(chess[row, col]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        public static void FillChess(char[,] chess)
        {
            for (int row = 0; row < chess.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < chess.GetLength(1); col++)
                {
                    chess[row, col] = currentRow[col];
                }
            }
        }
        static bool IsInside(char[,] chess, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chess.GetLength(0)
                && targetCol >= 0 && targetCol < chess.GetLength(1);
        }
    }
}
                







