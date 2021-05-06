﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuel;
        protected Vehicle(double tankCapacity, double fuel, double consumption, double airConditionerModifier)
        {
            this.TankCapacity = tankCapacity;
            this.Fuel = fuel;
            this.Consumption = consumption;
            this.AirConditionerModifier = airConditionerModifier;
        }
        public double Fuel
        {
            get => this.fuel;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuel = 0;
                }
                else
                {
                    this.fuel = value;
                }
            }
        }

        public double Consumption { get; private set; }

        public double TankCapacity { get; private set; }

        protected double AirConditionerModifier { get; set; }

        public void Drive(double distance)
        {
            double requiredFuel = (this.Consumption + this.AirConditionerModifier) * distance;

            if (requiredFuel > this.Fuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }
            this.Fuel -= requiredFuel;
        }


        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            if (this.Fuel + amount > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }
            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:F2}";
        }
    }
}
