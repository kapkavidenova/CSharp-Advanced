using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double consumptionForKilometer = double.Parse(input[2]);

                Car currentCar = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    ConsumptionForKilometer = consumptionForKilometer
                };
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] splitted = command.Split(" ");
                string model = splitted[1];
                //double fuelAmount = double.Parse(splitted[2]);
                double distance = double.Parse(splitted[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);

                //car.Drive(distance);
                bool isDrive = car.Drive(distance);
                if (isDrive == false)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
