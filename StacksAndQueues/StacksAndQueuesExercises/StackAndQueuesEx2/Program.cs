using System;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueuesEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = arr[0];
            int s = arr[1];
            int x = arr[2];
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(nums);
         
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
                }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }

            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
