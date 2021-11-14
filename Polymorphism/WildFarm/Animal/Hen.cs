using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override bool Eat(string foodtype, int foodQuantity)
        {
            if (foodtype == "Vegetable" || foodtype == "Meat" || foodtype == "Fruit" || foodtype == "Seeds")
            {
                this.Weight += Math.Abs(0.30 * foodQuantity);
                return true;
            }
            else
            {
                Console.WriteLine($"Hen does not eat {foodtype}!");
                return false;
            }
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }

        public override string ToString()
        {
            return $"Hen [{this.Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
