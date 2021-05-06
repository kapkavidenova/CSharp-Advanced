using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
    
        private const double CarAirContitionerModifier = 0.9;
        public Car(double fuel, double consumption) 
            : base(fuel, consumption, CarAirContitionerModifier)
        {       
        }
    }
}
