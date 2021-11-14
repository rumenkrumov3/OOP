using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string bakingTechnique;
        private string flour;
        private double weight;
        private decimal caloriesPerGram;

        public Dough(string flour, string bakingTechnique, double weight)
        {
            this.Flour = flour;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.CaloriesPerGram = CalculateCaloriesPerGram();
        }

        public string Flour
        {
            get
            {
                return this.flour;
            }
            private set
            {
                if(value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    Console.WriteLine("Invalid type of dough");
                }
                else
                {
                    this.flour = value.ToLower();
                }
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    Console.WriteLine("Invalid type of baking");
                }
                else
                {
                    this.bakingTechnique = value.ToLower();
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
                if(value < 1 || value > 200)
                {
                    Console.WriteLine("Dough weight should be in the range [1..200].");
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
            double bakingTechnique = 0;

            switch (this.Flour)
            {
                case "white": 
                    flour = 1.5;
                    break;
                case "wholegrain":
                    flour = 1.0;
                    break;
            }
            switch (this.BakingTechnique)
            {
                case "crispy":
                    bakingTechnique = 0.9;
                    break;
                case "chewy":
                    bakingTechnique = 1.1;
                    break;
                case "homemade":
                    bakingTechnique = 1.0;
                    break;
            }

            calories = $"{(weight * 2 * flour * bakingTechnique):F2}";

            return decimal.Parse(calories);
        }
    }
}
