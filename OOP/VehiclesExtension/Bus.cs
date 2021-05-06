using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private const double BusAirConditionModifier = 1.4;
        public Bus(double tankCapacity, double fuel, double consumption) 
            : base(tankCapacity, fuel, consumption, BusAirConditionModifier)
        {
        }
        public void TurnOnAirConditioner()
        {
            this.AirConditionerModifier = BusAirConditionModifier;
        }

        public void TurnOffAirConditioner()
        {
            this.AirConditionerModifier = 0;
        }
    }
}
