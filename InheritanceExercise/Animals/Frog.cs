﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public string ProduceSound()
        {
            return "Ribbit";
        }

        public override string ToString()
        {
            return $"Frog{Environment.NewLine}" +
                $"{Name} {Age} {Gender}{Environment.NewLine}" +
                ProduceSound();
        }
    }
}
