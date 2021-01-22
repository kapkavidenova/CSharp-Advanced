using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenTime = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            bool crash = false;
            string crashCar = string.Empty;
            int hitIndex = -1;
            int passedCars = 0;

            while (input!="END")
            {
                if (input!="green")
                {
                    cars.Enqueue(input);
                }
                else if (input =="green")
                {
                    int currentGreenTime = greenTime;

                   while (currentGreenTime>0 && cars.Any())
                    {
                        string car = cars.Peek();
                        int carLength = car.Length;

                        currentGreenTime -= car.Length;
                        if (currentGreenTime>=0)
                        {
                            cars.Dequeue();
                            passedCars++;
                        }
                        else
                        {
                            int leftTime = Math.Abs(currentGreenTime);
                            if (leftTime<=freeTime)
                            {
                                cars.Dequeue();
                                passedCars++;
                            }
                            else
                            {
                                crash = true;
                                crashCar = car;
                                hitIndex = carLength - leftTime + freeTime;
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            if (crash)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashCar} was hit at {crashCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
