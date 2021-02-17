using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split().ToArray();
                for (int j = 0; j < compounds.Length; j++)
                {
                    set.Add(compounds[j]);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
