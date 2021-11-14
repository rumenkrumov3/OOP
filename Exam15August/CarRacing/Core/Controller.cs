using CarRacing.Core.Contracts;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Core
{
    class Controller : IController
    {
        private IRepository<ICar> cars;
        private RacerRepository<Racer> racers;
        private IMap map;
        public Controller()
        {
            cars = new CarRepository<ICar>;
        }
        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
           if(type == "SuperCar")
            {
                ICar car = new SuperCar(make, model, VIN, horsePower);
                cars.Add(car);
                return $"Successfully added car {car.Make} {car.Model} ({car.VIN}).";
            }
           else if (type == "TunedCar")
            {
                ICar car = new TunedCar(make, model, VIN, horsePower);
                cars.Add(car);
                return $"Successfully added car {car.Make} {car.Model} ({car.VIN}).";
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidCarType);
            }
        }

        public string AddRacer(string type, string username, string carVIN)
        {
            var car = cars.Models.Where(x => x.VIN == carVIN).FirstOrDefault();
            if(car == null)
            {
                return "Car cannot be found!";
            }
            if (type == "ProfessionalRacer")
            {
                IRacer racer = new ProfessionalRacer(username, car);
                racers.Add(racer);
                return $"Successfully added racer {racer.Username}.";
            }
            else if (type == "StreetRacer")
            {
                IRacer racer = new StreetRacer(username, car);
                racers.Add(racer);
                return $"Successfully added racer {racer.Username}.";
            }
            else
            {
                return "Invalid racer type!";
            }
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            var racerOne = racers.Racers.Where(x => x.Username == racerOneUsername).FirstOrDefault();
            var racerTwo = racers.Racers.Where(x => x.Username == racerTwoUsername).FirstOrDefault();

            if(racerOne != null && racerTwo != null)
            {
                racerOne.Race();
                racerTwo.Race();
                return "";
            }
            else if (racerOne == null)
            {
                return $"Racer {racerOneUsername} cannot be found!";
            }
            else if (racerTwo == null)
            {
                return $"Racer {racerTwoUsername} cannot be found!";
            }
            else
            {
                return "";
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in racers.Racers)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
