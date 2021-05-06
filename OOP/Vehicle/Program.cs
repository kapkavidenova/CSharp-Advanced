using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
 
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string command = parts[0];
                string type = parts[1];
                double parameter = double.Parse(parts[2]);

                if (command == "Drive")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Drive(parameter);
                        }
                        else
                        {
                            truck.Drive(parameter);
                        }

                        Console.WriteLine($"{type} travelled {parameter} km");
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }

                else
                {
                    if (type == nameof(Car))
                    {
                        car.Refuel(parameter);
                    }
                    else
                    {
                        truck.Refuel(parameter);
                    }
                }
     
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static Vehicle CreateVehicle()
        {
            string[] parts = Console.ReadLine().Split();
            string type = parts[0];
            double fuel = double.Parse(parts[1]);
            double consumpion = double.Parse(parts[2]);

            Vehicle vehicle = null;

            if (type ==nameof(Car))
            {
                vehicle = new Car(fuel, consumpion);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(fuel, consumpion);
            }

            return vehicle;
        }
    }
}
