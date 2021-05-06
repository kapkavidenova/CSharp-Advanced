using System;
using System.Globalization;
using System.Threading;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)

        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            Vehicle car = CreateVehicle();
            Vehicle truck = CreateVehicle();
            Vehicle bus = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string command = parts[0];
                string type = parts[1];
                double parameter = double.Parse(parts[2]);
                try
                {
                    if (type == nameof(Car))
                    {
                        ProcessCommand(car, command, parameter);
                    }
                    else if (type == nameof(Truck))
                    {
                        ProcessCommand(truck, command, parameter);
                    }
                    else 
                    {
                        ProcessCommand(bus, command, parameter);
                    }
                }
                catch (Exception ex)
                when (ex is InvalidOperationException || ex is ArgumentException)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommand(Vehicle vehicle, string command, double parameter)
        {
            if (command == "Drive")
            {                 
                        vehicle.Drive(parameter);
 

                    Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }

            else if(command == "DriveEmpty")
            {             
                    ((Bus)vehicle).TurnOffAirConditioner();
                    vehicle.Drive(parameter);
                    ((Bus)vehicle).TurnOnAirConditioner();

                Console.WriteLine($"{vehicle.GetType().Name} travelled {parameter} km");
            }
            else
            {
                vehicle.Refuel(parameter);

            }
        }

        private static Vehicle CreateVehicle()
        {
            string[] parts = Console.ReadLine().Split();
            string type = parts[0];
            double fuel = double.Parse(parts[1]);
            double consumpion = double.Parse(parts[2]);
            double tankCapacity = double.Parse(parts[3]);

            Vehicle vehicle = null;

            if (type == nameof(Car))
            {
                vehicle = new Car(tankCapacity, fuel, consumpion);
            }
            else if (type == nameof(Truck))
            {
                vehicle = new Truck(tankCapacity, fuel, consumpion);
            }
            else if (type == nameof(Bus))
            {
                vehicle = new Bus(tankCapacity, fuel, consumpion);
            }

            return vehicle;
        }
    }


}
