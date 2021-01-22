using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "1")
                {
                    stack.Push(result);
                    result += commands[1];
                }
                else if (commands[0] == "2")
                {
                    stack.Push(result);
                    int num = int.Parse(commands[1]);
                    result = result.Substring(0, result.Length - num);
                }
                else if (commands[0] == "3")
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(result[index-1]);
                }
                else if (commands[0] == "4")
                {
                    if (stack.Count>0)
                    {
                        result = stack.Pop();
                    }
                    else
                    {
                        result = string.Empty;
                    }
                }
            }
        }
    }
}
