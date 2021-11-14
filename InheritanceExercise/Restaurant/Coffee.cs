using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(double coffeMilliliters, decimal coffePrice, double Caffeine) : base(coffePrice, coffeMilliliters)
        {
            this.Caffeine = Caffeine;
        }

        public double CoffeeMilliliters { get; set; } = 50;

        public decimal CoffeePrice { get; set; } = 3.50m;

        public double Caffeine { get; set; }
    }
}
