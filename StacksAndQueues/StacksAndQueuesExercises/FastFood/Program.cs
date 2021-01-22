using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> ordersTotal = new Queue<int>(orders);
            Console.WriteLine(ordersTotal.Max()); ;

            while (ordersTotal.Count > 0)
            {
                int currentOrder = ordersTotal.Peek();

                if (currentOrder <= foodQuantity)
                {
                    ordersTotal.Dequeue();
                    foodQuantity -= currentOrder;
                }
                else
                {
                    break;
                }
            }
            if (ordersTotal.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", ordersTotal)}");
            }
            else
            {
                Console.WriteLine("Orders complete");

            }
        }
    }
}