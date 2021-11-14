﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
            this.Gender = "Male";
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }

        public override string ToString()
        {
            return $"Tomcat{Environment.NewLine}" +
                $"{Name} {Age} {Gender}{Environment.NewLine}" +
                ProduceSound();
        }
    }
}
