using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();

            while (input != "END")
            {
                string[] info = input.Split(", ");
                var direction = info[0];
                var car = info[1];
                if (direction == "IN")
                {
                    cars.Add(car);
                }
                else if (direction == "OUT")
                {
                    cars.Remove(car);
                }
                input = Console.ReadLine();
            }
            if (cars.Count != 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
