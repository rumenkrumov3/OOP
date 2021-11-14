using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main()
        {
            char[] symbols = { ' ', ',', '.', ':', '\t', '=', ';' };
            var people = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            List<Person> personList = new List<Person>();
            List<Product> productsList = new List<Product>();

            for (int i = 0; i < people.Length; i+=2)
            {
                var person = new Person(people[i], int.Parse(people[i+1]));
                if(!person.FlagForIncorrectData == true)
                {
                    personList.Add(person);
                }               
            }
            for (int i = 0; i < products.Length; i += 2)
            {
                var product = new Product(products[i], int.Parse(products[i+1]));
                if(!product.FlagForIncorrectProductData == true)
                {
                    productsList.Add(product);
                }
            }

            var input = Console.ReadLine();

            while(input != "END")
            {
                var commands = input.Split();
                
                if(personList != null)
                {
                    foreach (var item in personList)
                    {
                        foreach (var product in productsList)
                        {
                            if (item.Name == commands[0] && product.Name == commands[1])
                            {
                                item.AddProduct(product);
                            }
                        }

                    }
                }              
                input = Console.ReadLine();
            }

            if(personList != null)
            {
                foreach (var person in personList)
                {

                    if (person.Products.Count == 0 && person.Money == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else if (person.Products.Count == 0 && person.Money > 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else if (person.Products.Count > 0)
                    {
                        Console.WriteLine($"{person.Name} - {string.Join((", "), person.Products)}");
                    }
                }
            }
        }
    }
}
