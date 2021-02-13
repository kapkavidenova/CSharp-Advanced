using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < numbers[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());               
                firstSet.Add(num);
            }

            for (int i = 0; i < numbers[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }
              
            var result = firstSet.Intersect(secondSet);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
