using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int barrel = int.Parse(Console.ReadLine());
            int[] bulletsValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(bulletsValue);
            Queue<int> locks = new Queue<int>(locksValue);
            int totalCountBullet = 0;
                int countBulet = 0; 

            while(bullets.Count>0 && locks.Count>0)
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                totalCountBullet++;
                countBulet++;

                if (currentBullet<=currentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else if(currentBullet >currentLock)
                {
                    Console.WriteLine("Ping!");
                }
                if (countBulet == barrel && bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                    countBulet = 0;
                }
            }
            if (locks.Count==0)
            {
                int earnedMoney = intelligence - totalCountBullet * priceBullet;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
            else if (bullets.Count==0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
 
        }
    }
}
