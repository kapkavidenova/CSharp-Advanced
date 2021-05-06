using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double CarAirContitionerModifier = 0.9;
        public Car(double tankCapacity, double fuel, double consumption) 
            : base(tankCapacity, fuel, consumption, CarAirContitionerModifier)
        {       
        }
    }
}
