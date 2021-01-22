using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] capacityCup = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] bottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(capacityCup);
            Stack<int> watter = new Stack<int>(bottles);
            int wastedWater = 0;

            while (cups.Count>0 && watter.Count>0)
            {
                int currentWatter = watter.Pop();
                int currentCup = cups.Peek();

                if (currentWatter>=currentCup)
                {
                    cups.Dequeue();
                    wastedWater += currentWatter - currentCup;
                }
                else if(currentWatter<currentCup && watter.Any())
                {
                    while (currentWatter < currentCup && watter.Any())
                    {
                    currentWatter += watter.Pop();//
                    }
                    if (currentWatter>= currentCup)
                    {
                    cups.Dequeue();
                    wastedWater += currentWatter - currentCup;
                    }
                }
            }
            if (cups.Count==0)
            {
                Console.Write("Bottles: ");
                Console.WriteLine(string.Join(" ", watter));
                //Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if (watter.Count==0 && cups.Count>0)
            {
                Console.Write("Cups: ");
                Console.WriteLine(string.Join(" ", cups));
            }
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
