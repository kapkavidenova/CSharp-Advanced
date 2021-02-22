using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            HashSet<Car> cars = new HashSet<Car>();

            for (
                int i = 0; i < n; i++)

            {
                Engine engine = null;
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = input[0];
                int power = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (input.Length == 3)
                {
                    string thirdParam = input[2];

                    if (Char.IsDigit(thirdParam, 0))
                    {
                        int displasment = int.Parse(thirdParam);
                        engine = new Engine(model, power, displasment);
                    }
                    else
                    {
                        string efficiency = thirdParam;
                        engine = new Engine(model, power, efficiency);
                    }
                }
                else if (input.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                if (engine != null)
                {
                engines.Add(engine);

                }
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Car car = null;
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = input[0];
                Engine engine = engines.First(x=>x.Model == input[1]);

                if (input.Length == 4)
                {
                    double weight = double.Parse(input[2]);
                    string color = input[3];
                    car = new Car(model, engine, weight, color);
                }
                else if (input.Length == 3)
                {

                    if (char.IsLetter(input[2],0))
                    {
                        string color = input[2];
                        car = new Car(model, engine, color);
                    }
                    else
                    {
                        double weight = double.Parse(input[2]);
                        car = new Car(model, engine, weight);
                    }
 
                }
                else if (input.Length == 2)
                {
                    car = new Car(model, engine);
                }
                if (car != null)
                {
                    cars.Add(car);
                }
            }
            foreach (var car in cars)
            {
            Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == null)
                {
                    Console.WriteLine("    Displacement: n/a");
                }
                else
                {

                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                if (car.Engine.Efficiency == null)
                {
                    Console.WriteLine("    Efficiency: n/a");
                }
                else
                {

                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                if (car.Weight == null)
                {
                    Console.WriteLine("  Weight: n/a");
                }
                else
                {

                Console.WriteLine($"  Weight: {car.Weight}");
                }
                if (car.Color == null)
                {
                    Console.WriteLine("  Color: n/a");
                }
                else
                {

                Console.WriteLine($"  Color: {car.Color}");
                }
            }
        }
    }
}
