using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Toppings
    {
        private string flour;
        private double weight;
        private decimal caloriesPerGram;

        public Toppings(string flour, double weight)
        {
            this.Weight = weight;
            this.Flour = flour;          
            if(Flour == null || Weight == 0)
            {
                FlagForInvalidTopping = true;
            }
            this.CaloriesPerGram = CalculateCaloriesPerGram();
        }

        public bool FlagForInvalidTopping { get; set; }
        private string Flour
        {
            get
            {
                return this.flour;
            }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    Console.WriteLine($"Cannot place {value} on top of your pizza.");
                }
                else
                {
                    this.flour = value.ToLower();
                }                
            }
        }
        private double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    Console.WriteLine($"{Flour} weight should be in the range [1..50].");
                }
                else
                {
                    this.weight = value;
                }
            }
        }

        public decimal CaloriesPerGram
        {
            get
            {
                return this.caloriesPerGram;
            }
            private set
            {
                this.caloriesPerGram = value;
            }
        }

        private decimal CalculateCaloriesPerGram()
        {
            string calories;
            double flour = 0;

            switch (this.Flour)
            {
                case "meat":
                    flour = 1.2;
                    break;
                case "veggies":
                    flour = 0.8;
                    break;
                case "cheese":
                    flour = 1.1;
                    break;
                case "sauce":
                    flour = 0.9;
                    break;
            }

            calories = $"{(weight * 2 * flour):F2}";

            return decimal.Parse(calories);
        }
    }
}
