using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProject
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if(age > 0)
            {
                this.Age = age;
            }
            this.Name = name;
        }
    }
}
