using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boxes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> box = new Stack<int>(boxes);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currentCapacity = capacity;

            while (box.Count>0)
            {
                int currentBox = box.Pop();
                currentCapacity -= currentBox;

                if (currentCapacity<=0)
                {
                    racks++;
                    currentCapacity = capacity - currentBox;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
