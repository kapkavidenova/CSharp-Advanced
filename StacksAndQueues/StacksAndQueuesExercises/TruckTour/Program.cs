using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                queue.Enqueue(arr);  
            }
            int count = 0;

            while (true)
            {
                int total = 0;
                bool isFound = true;

                for (int i = 0; i < n; i++)
                {
                    int[] currentPump = queue.Dequeue();
                    total += currentPump[0];

                    if (total < currentPump[1])
                    {
                        isFound = false;
                    }
                    total -= currentPump[1];
                    queue.Enqueue(currentPump);
                }
                if (isFound)
                {
                    break;
                }
                count++;
                queue.Enqueue(queue.Dequeue());
            }
            Console.WriteLine(count);
        }
    }
}
