using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livingregion, string breed) : base(name, weight, livingregion)
        {
            Breed = breed;
        }

        public string Breed { get; set; }
    }
}
