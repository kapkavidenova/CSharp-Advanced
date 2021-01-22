using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                if (input.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (input.Contains("Add"))
                {
                    var commands = input.Split("Add ",StringSplitOptions.RemoveEmptyEntries);
                    if (!queue.Contains(commands[0]))
                    {
                        queue.Enqueue(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is already contained!");
                    }
                }
                else if (input.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
