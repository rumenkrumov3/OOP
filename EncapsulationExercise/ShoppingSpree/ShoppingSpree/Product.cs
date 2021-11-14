using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private int cost;
        private bool flagForIncorrectProductData;

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public bool FlagForIncorrectProductData
        {
            get
            {
                return this.flagForIncorrectProductData;
            }
            private set
            {
                this.flagForIncorrectProductData = value;
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
                    flagForIncorrectProductData = true;
                }
            }
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                this.cost = value;
            }
        }
    }
}
