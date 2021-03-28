using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelComsumption = 10;
        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }
        public override double FuelConsumption => DefaultFuelComsumption;
    }
}
