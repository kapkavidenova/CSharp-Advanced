using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> stack = new Stack<string>(input);

            while (stack.Count>1)
            {
            int firstNumber = int.Parse(stack.Pop());
            string symbol = stack.Pop();
            int secondNumber = int.Parse(stack.Pop());

                if (symbol =="+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }
                else
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }
            Console.WriteLine(stack.Peek()); 
        }
    }
}
