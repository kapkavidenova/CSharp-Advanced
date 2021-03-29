using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double DefaultMilliters = 50;

        private const decimal DefaultPrice = 3.50m;

        
        public Coffee(string name, double caffeine) 
            : base(name, DefaultPrice, DefaultMilliters)
        {
            this.Caffeint = caffeine;
        }
        public double CoffeeMilliters => DefaultMilliters;

        public decimal CoffeePrice => DefaultPrice;

        public double Caffeint { get; set; }
    }
}
