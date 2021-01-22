using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;
            if (input.Length%2 !=0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '(' 
                    || ch == '[' 
                    || ch == '{')
                {
                    stack.Push(ch);
                }
                else 
                {
                    if (!stack.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    char currentOpen = stack.Pop();
                    if (currentOpen == '(' && ch != ')')
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");
                        return;
                    }
                    if (currentOpen == '[' && ch != ']')
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");
                        return;
                    }
                    if (currentOpen == '{' && ch != '}')
                    {
                        isBalanced = false;
                        Console.WriteLine("NO");
                        return;
                    }

                }
            }
                if (stack.Count == 0)
                {
                    Console.WriteLine("YES");
                }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
