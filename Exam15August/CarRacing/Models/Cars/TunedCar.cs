using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    class TunedCar : Car
    {
        private double availableFuel = 65;
        private double fuelConsumption = 7.5;
        public TunedCar(string make, string model, string vin, int horsePower) : base()
        {
            this.Make = make;
            this.Model = model;
            this.VIN = vin;
            this.HorsePower = horsePower;
            this.FuelAvailable = availableFuel;
            this.FuelConsumptionPerRace = fuelConsumption;
        }

        public override void Drive()
        {
            FuelAvailable -= FuelConsumptionPerRace;
            var variable = (this.HorsePower / 100) * 3;
            this.HorsePower = Math.Abs(HorsePower - variable);
        }
    }
}
