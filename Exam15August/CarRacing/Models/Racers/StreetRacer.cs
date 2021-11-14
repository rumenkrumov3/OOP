using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    class StreetRacer : Racer
    {
        private int drivingExpirience = 10;
        private string racingBehavior = "aggressive";
        public StreetRacer(string username, ICar car) : base()
        {
            this.Username = username;
            this.DrivingExperience = drivingExpirience;
            this.RacingBehavior = racingBehavior;
            this.Car = car;
        }
        public override void Race()
        {
            DrivingExperience += 5;
        }
    }
}
