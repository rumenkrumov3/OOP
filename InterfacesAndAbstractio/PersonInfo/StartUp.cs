using System;
using System.Collections.Generic;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, IBuyer> citizens = new Dictionary<string, IBuyer>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split();
                if(input.Length == 4)
                {
                    var citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    citizens.Add(input[0], citizen);
                }
                else if (input.Length == 3)
                {
                    var rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    citizens.Add(input[0], rebel);
                }
            }

            var input2 = Console.ReadLine();
            while(input2 != "End")
            {
                if (citizens.ContainsKey(input2))
                {
                    citizens[input2].BuyFood();
                }
                else
                {

                }

                input2 = Console.ReadLine();
            }

            var totalfood = 0;
            foreach (var item in citizens)
            {
                totalfood += item.Value.Food;
            }

            Console.WriteLine(totalfood);
        }
    }
}
