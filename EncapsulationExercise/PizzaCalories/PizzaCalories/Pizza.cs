using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Toppings> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            toppings = new List<Toppings>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(value.Length > 15)
                {
                    Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine($"Pizza name is empty");
                }
                else
                {
                    this.name = value;
                }             
            }
        }

        public int CountOFToppings
        {
            get
            {
                return toppings.Count;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public List<Toppings> Toppings
        {
            get
            {
                return this.toppings;
            }
            set
            {
                this.toppings = value;
            }
        }

        public void Add(Toppings topping)
        {
            if(toppings.Count > 10)
            {
                Console.WriteLine("Number of toppings should be in range [0..10].");
            }
            else
            {
                toppings.Add(topping);
            }
        }
        public decimal TotalCalories()
        {
            decimal totalCalories = 0;
            totalCalories += dough.CaloriesPerGram;
            foreach (var item in toppings)
            {
                totalCalories += item.CaloriesPerGram;
            }
            return totalCalories;
        }



    }
}
