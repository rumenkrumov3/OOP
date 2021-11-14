using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    class SuperCar : Car
    {
        private double availableFuel = 80;
        private double fuelConsumption = 10;
        public SuperCar(string make, string model, string vin, int horsePower) : base()
        {
            this.Make = make;
            this.Model = model;
            this.VIN = vin;
            this.HorsePower = horsePower;
            this.FuelAvailable = availableFuel;
            this.FuelConsumptionPerRace = fuelConsumption;
        }

    }
}
