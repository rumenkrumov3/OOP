using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingregion, string breed) : base(name, weight, livingregion, breed)
        {
            this.Name = name;
        }

        public override bool Eat(string foodtype, int foodQuantity)
        {
            if (foodtype != "Vegetable" && foodtype != "Meat")
            {
                Console.WriteLine($"Cat does not eat {foodtype}!");
                return false;
            }
            else
            {
                this.Weight += Math.Abs(0.30 * foodQuantity);
                return true;
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"Cat [{this.Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
