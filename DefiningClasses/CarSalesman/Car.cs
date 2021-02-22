﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, double weight)
        : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
        : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, double weight, string color)
        : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;

        }
        public string  Model { get; set; }

        public Engine Engine { get; set; }

        public double? Weight { get; set; }

        public string Color { get; set; }
    }
}
