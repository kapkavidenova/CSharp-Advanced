using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputL = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] inputIngr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queueL = new Queue<int>(inputL);
            Stack<int> stackIngr = new Stack<int>(inputIngr);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["Bread"] = 25;
            dict["Cake"] = 50;
            dict["Pastry"] = 25;
            dict["Fruit Pie"] = 25;
            

            while (queueL.Count>0 || stackIngr.Count>0)
            {
                int currentL = queueL.Dequeue();
                int gradient = stackIngr.Pop();
            }
 
        }
    }
}
