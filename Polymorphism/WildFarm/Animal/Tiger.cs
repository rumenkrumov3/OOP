using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingregion, string breed) : base(name, weight, livingregion, breed)
        {
            this.Name = name;
        }

        public override bool Eat(string foodtype, int foodQuantity)
        {
            if (foodtype != "Meat")
            {
                Console.WriteLine($"Tiger does not eat {foodtype}!");
                return false;
            }
            else
            {
                this.Weight += 1 * foodQuantity;
                return true;
            }
        }
        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
        public override string ToString()
        {
            return $"Tiger [{this.Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
