using System;
using Vehicles;

namespace Polymorphism
{
    public class StartUp
    {
        static void Main()
        {
            var carData = Console.ReadLine().Split();
            var truckData = Console.ReadLine().Split();
            var busData = Console.ReadLine().Split();
            int lines = int.Parse(Console.ReadLine());

            IVehicle car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));
            IVehicle truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));
            Bus bus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

            for (int i = 0; i < lines; i++)
            {
                var data = Console.ReadLine().Split();

                if(data[0] == "Drive")
                {
                    if(data[1] == "Car")
                    {
                        car.Drive(double.Parse(data[2]));
                    }
                    else if (data[1] == "Truck")
                    {
                        truck.Drive(double.Parse(data[2]));
                    }
                    else if (data[1] == "Bus")
                    {
                        bus.Drive(double.Parse(data[2]));
                    }
                }
                else if (data[0] == "Refuel")
                {
                    if(data[1] == "Car")
                    {
                        car.Refuel(double.Parse(data[2]));
                    }
                    else if (data[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(data[2]));
                    }
                    else if (data[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(data[2]));
                    }
                }
                else if (data[0] == "DriveEmpty")
                {
                    bus.DriveEmpty(double.Parse(data[2]));
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
