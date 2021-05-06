using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {

        protected Vehicle(double fuel, double consumption, double airConditionerModifier)
        {
            this.Fuel = fuel;
            this.Consumption = consumption;
            this.AirConditionerModifier = airConditionerModifier;
        }
        public double Fuel { get; private set; }

        public double Consumption { get; private set; }

        private double AirConditionerModifier { get;set; }

        public void Drive(double distance)
        {
            double requiredFuel = (this.Consumption + this.AirConditionerModifier) *distance;

            if (requiredFuel>this.Fuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }
            this.Fuel -= requiredFuel;
        }


        public virtual void Refuel(double amount)
        {
            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:F2}";
        }
    }
}
