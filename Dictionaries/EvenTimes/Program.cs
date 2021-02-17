using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!nums.ContainsKey(number))
                {
                    nums.Add(number, 0);
                }
                nums[number]++;
            }
            var result = nums.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
            Console.WriteLine(result);
        }
    }
}
