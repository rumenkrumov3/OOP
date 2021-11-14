using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main()
        {
            var nameOfPizza = Console.ReadLine().Split();
            Pizza pizza = new Pizza(nameOfPizza[1]);
            var DoughInput = Console.ReadLine().Split();
            pizza.Dough = new Dough(DoughInput[1], DoughInput[2], double.Parse(DoughInput[3]));

            var ToppingsInput = Console.ReadLine();

            while(ToppingsInput != "END")
            {
                var toppingsInput2 = ToppingsInput.Split();
                var topping = new Toppings(toppingsInput2[1], double.Parse(toppingsInput2[2]));
                if(topping.FlagForInvalidTopping == false)
                {
                    pizza.Add(topping);
                }
                else
                {
                    break;
                }
                ToppingsInput = Console.ReadLine();
            }

            if(pizza.Toppings.Count != 0 && pizza.Toppings.Count <= 10)
            {
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories()} Calories.");
            }
        }
    }
}
