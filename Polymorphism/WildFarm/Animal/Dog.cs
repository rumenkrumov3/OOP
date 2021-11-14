using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingregion) : base(name, weight, livingregion)
        {
        }

        public override bool Eat(string foodtype, int foodQuantity)
        {
            if (foodtype != "Meat")
            {
                Console.WriteLine($"Dog does not eat {foodtype}!");
                return false;
            }
            else
            {
                this.Weight += Math.Abs(0.40 * foodQuantity);
                return true;
            }
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return $"Dog [{this.Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
