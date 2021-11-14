using ExplicitInterfaces.Interfaces;
using System;

namespace ExplicitInterfaces
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while(input != "End")
            {
                var input2 = input.Split();
                string Name = input2[0];
                string Contry = input2[1];
                int Age = int.Parse(input2[2]);
                IPerson iperson = new Citizen(Name, Contry, Age);
                IResident iresident = new Citizen(Name, Contry, Age);
                Console.WriteLine(iperson.GetName());
                Console.WriteLine(iresident.GetName());
                input = Console.ReadLine();
            }
        }
    }
}
