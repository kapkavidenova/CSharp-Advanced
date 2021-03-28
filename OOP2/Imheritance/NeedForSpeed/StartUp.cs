using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SportCar car = new SportCar(200, 100);

            car.Drive(25);
            
        }
    }
}
