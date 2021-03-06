using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : IVehicle
    {
        private double fuelquantity;
        private double fuelconsumption;
        private double tankcapacity;

        public Truck(double fuelQuantity, double fuelConsumption, double tankcapacity)
        {
            if (fuelQuantity <= tankcapacity)
            {
                TankCapacity = tankcapacity;
                FuelQuantity = fuelQuantity;
            }
            else
            {
                TankCapacity = tankcapacity;
            }
            FuelConsumption = fuelConsumption + 1.6;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelquantity;
            }
            set
            {
                if (value > TankCapacity)
                {
                    this.fuelquantity = 0;
                }
                else
                {
                    this.fuelquantity = value;
                }
            }
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuelconsumption;
            }
            set
            {
                this.fuelconsumption = value;
            }
        }

        public double TankCapacity
        {
            get { return this.tankcapacity; }
            set { this.tankcapacity = value; }
        }

        public void Drive(double kilometers)
        {
            double fuel = kilometers * FuelConsumption;
            if (fuel < FuelQuantity)
            {
                FuelQuantity -= fuel;
                Console.WriteLine($"Truck travelled {kilometers} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double liters)
        {
            double difference = TankCapacity - FuelQuantity;
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (liters > difference)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                FuelQuantity += liters * 0.95;
            }
        }
    }
}

