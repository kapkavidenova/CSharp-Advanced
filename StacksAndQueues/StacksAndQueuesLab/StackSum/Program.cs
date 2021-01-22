using System;
using System.Collections.Generic;
using System.Linq;


namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> nums = new Stack<int>(arr);
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commands = command.Split();
                int num1 = int.Parse(commands[1]);

                if (commands[0] == "add")
                {
                    int num2 = int.Parse(commands[2]);
                    nums.Push(num1);
                    nums.Push(num2);
                }
                else if (commands[0] == "remove")
                {
                    if (nums.Count >= num1)
                    {
                        for (int i = 0; i < num1; i++)
                        {
                            nums.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int sum = nums.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
