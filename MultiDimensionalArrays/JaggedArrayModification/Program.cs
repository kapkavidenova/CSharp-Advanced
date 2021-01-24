using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] input = Console.ReadLine().Split();
                jagged[row] = new int[input.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(input[col]);
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commands = command.Split();
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }
                else if (commands[0] == "Add")
                {
                    jagged[row][col] += value;
                }
                else if (commands[0] == "Subtract")
                {
                    jagged[row][col] -= value;
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
