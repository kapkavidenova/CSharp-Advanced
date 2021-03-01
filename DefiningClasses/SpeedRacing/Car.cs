using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double ConsumptionForKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public bool Drive (double distance )
        {
            double neededFuel = distance * ConsumptionForKilometer;

            if (neededFuel >this.FuelAmount)
            {
                return false;
            }
            this.FuelAmount -= neededFuel;
            this.TravelledDistance += distance;
            return true;
        }
    }
}
