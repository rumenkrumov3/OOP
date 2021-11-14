using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingregion) : base(name, weight, livingregion)
        {
        }

        public override bool Eat(string foodtype, int foodQuantity)
        {
            if (foodtype != "Vegetable" && foodtype != "Fruit")
            {
                Console.WriteLine($"Mouse does not eat {foodtype}!");
                return false;
            }
            else
            {
                this.Weight += Math.Abs(0.10 * foodQuantity);
                return true;
            }
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return $"Mouse [{this.Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
