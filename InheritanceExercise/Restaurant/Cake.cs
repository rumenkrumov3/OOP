using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public Cake(string name, double grams, double calories, decimal price) : base(name, price, grams, calories)
        {
            this.Gramss = grams;
            this.Caloriess = calories;
            this.Pricee = price;
        }

        public double Gramss { get; set; } = 250;
        public double Caloriess { get; set; } = 1000;

        public decimal Pricee { get; set; } = 5;
    }
}
