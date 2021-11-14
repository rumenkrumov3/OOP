using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private List<string> products;
        private bool flagForIncorrectData;

        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            Products = new List<string>();
        }

        public bool FlagForIncorrectData
        {
            get
            {
                return flagForIncorrectData;
            }
            private set
            {
                this.flagForIncorrectData = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                    flagForIncorrectData = true;
                }
            }
        }

        public int Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if(value < 0)
                {
                    Console.WriteLine("Money cannot be negative");
                    this.money = -1;
                    flagForIncorrectData = true;
                }
                else
                {
                    this.money = value;
                }             
            }
        }
        public List<string> Products
        {
            get
            {
                return this.products;
            }
            private set
            {
                this.products = value;
            }
        }

        public void AddProduct(Product product)
        {
            if(product.Cost <= this.Money)
            {
                Products.Add(product.Name);
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.Money -= product.Cost;
            }
            else if(this.Money != -1 && product.Cost > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
