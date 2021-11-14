using System;
using System.Collections.Generic;
using WildFarm.Animal;

namespace WildFarm
{
    class StartUp
    {
        static void Main()
        {
            var animalData = Console.ReadLine().Split();
            var fruits = Console.ReadLine().Split();
            List<IAnimal> list = new List<IAnimal>();

            while(animalData[0] != "End")
            {
                string animalType = animalData[0];
                string animalName = animalData[1];
                string livingRegion = string.Empty;
                string breed = string.Empty;
                double animalWeight = 0;
                double wingSize = 0;
                int foodEaten = 0;

                if(animalType == "Owl")
                {
                    animalWeight = double.Parse(animalData[2]);
                    wingSize = double.Parse(animalData[3]);
                    Owl owl = new Owl(animalName, animalWeight, wingSize);
                    owl.ProduceSound();
                    if (owl.Eat(fruits[0], int.Parse(fruits[1])))
                    {
                        owl.FoodEaten += int.Parse(fruits[1]);
                    }                                         
                    list.Add(owl);
                }
                else if (animalType == "Hen")
                {
                    animalWeight = double.Parse(animalData[2]);
                    wingSize = double.Parse(animalData[3]);
                    Hen hen = new Hen(animalName, animalWeight, wingSize);
                    hen.ProduceSound();
                    if (hen.Eat(fruits[0], int.Parse(fruits[1])))
                    {
                        hen.FoodEaten += int.Parse(fruits[1]);
                    }                   
                    list.Add(hen);
                }
                else if (animalType == "Cat")
                {
                    animalWeight = double.Parse(animalData[2]);
                    livingRegion = animalData[3];
                    breed = animalData[4];
                    Cat cat = new Cat(animalName, animalWeight, livingRegion, breed);
                    cat.ProduceSound();
                    if (cat.Eat(fruits[0], int.Parse(fruits[1])))
                    {
                        cat.FoodEaten += int.Parse(fruits[1]);
                    }

                    list.Add(cat);
                }
                else if (animalType == "Tiger")
                {
                    animalWeight = double.Parse(animalData[2]);
                    livingRegion = animalData[3];
                    breed = animalData[4];
                    Tiger tiger = new Tiger(animalName, animalWeight, livingRegion, breed);
                    tiger.ProduceSound();
                    if (tiger.Eat(fruits[0], int.Parse(fruits[1])))
                    {
                        tiger.FoodEaten += int.Parse(fruits[1]);
                    }
                    list.Add(tiger);
                }
                else if (animalType == "Mouse")
                {
                    animalWeight = double.Parse(animalData[2]);
                    livingRegion = animalData[3];
                    Mouse mouse = new Mouse(animalName, animalWeight, livingRegion);
                    mouse.ProduceSound();
                    if (mouse.Eat(fruits[0], int.Parse(fruits[1])))
                    {
                        mouse.FoodEaten += int.Parse(fruits[1]);
                    }
                    list.Add(mouse);
                }
                else if (animalType == "Dog")
                {
                    animalWeight = double.Parse(animalData[2]);
                    livingRegion = animalData[3];
                    Dog dog = new Dog(animalName, animalWeight, livingRegion);
                    dog.ProduceSound();
                    if (dog.Eat(fruits[0], int.Parse(fruits[1])))
                    {
                        dog.FoodEaten += int.Parse(fruits[1]);
                    }
                    list.Add(dog);
                }
                animalData = Console.ReadLine().Split();
                if(animalData[0] == "End")
                {
                    break;
                }
                fruits = Console.ReadLine().Split();
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
