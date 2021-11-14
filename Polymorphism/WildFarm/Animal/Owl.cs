using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override bool Eat(string foodtype, int foodQuantity)
        {            
            if(foodtype != "Meat")
            {
                Console.WriteLine($"Owl does not eat {foodtype}!");
                return false;
            }
            else
            {
                this.Weight += Math.Abs(0.25 * foodQuantity);
                return true;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override string ToString()
        {
            return $"Owl [{this.Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
