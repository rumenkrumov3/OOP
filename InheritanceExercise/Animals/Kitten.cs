using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = "Female";
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return $"Kitten{Environment.NewLine}" +
                $"{Name} {Age} {Gender}{Environment.NewLine}" +
                ProduceSound();
        }
    }
}
