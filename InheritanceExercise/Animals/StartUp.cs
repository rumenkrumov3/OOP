using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {           
            string animal = Console.ReadLine();
            var data = Console.ReadLine().Split();

            while(animal != "Beast!")
            {
                if(animal == "Dog")
                {
                    Dog dog = new Dog(data[0], int.Parse(data[1]), data[2]);
                    if (dog.Age != 0)
                    {
                        Console.WriteLine(dog.ToString());
                    }
                }
                else if (animal == "Cat")
                {
                    Cat cat = new Cat(data[0], int.Parse(data[1]), data[2]);
                    if (cat.Age != 0)
                    {
                        Console.WriteLine(cat.ToString());
                    }
                }
                else if (animal == "Frog")
                {
                    Frog frog = new Frog(data[0], int.Parse(data[1]), data[2]);
                    if (frog.Age != 0)
                    {
                        Console.WriteLine(frog.ToString());
                    }
                }
                else if (animal == "Kitten")
                {
                    Kitten kitten = new Kitten(data[0], int.Parse(data[1]), data[2]);
                    if(kitten.Age != 0)
                    {
                        Console.WriteLine(kitten.ToString());
                    }                  
                }
                else if (animal == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(data[0], int.Parse(data[1]), data[2]);
                    if (tomcat.Age != 0)
                    {
                        Console.WriteLine(tomcat.ToString());
                    }
                }

                animal = Console.ReadLine();
                if(animal == "Beast!")
                {
                    break;
                }
                data = Console.ReadLine().Split();
            }
        }
    }
}
