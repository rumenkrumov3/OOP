using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProject
{
    public class Person
    {
        public Person(string name, int age)
        {
            if(age > 0)
            {
                this.Age = age;
            }
      
            this.Name = name;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}, Age: {Age}");

            return sb.ToString();
        }
    }
}
