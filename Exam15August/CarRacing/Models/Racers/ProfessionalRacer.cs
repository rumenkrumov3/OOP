using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    class ProfessionalRacer : Racer
    {
        private int drivingExpirience = 30;
        private string racingBehavior = "strict";
        public ProfessionalRacer(string username, ICar car) : base()
        {
            this.Username = username;
            this.DrivingExperience = drivingExpirience;
            this.RacingBehavior = racingBehavior;
            this.Car = car;
        }
        public override void Race()
        {
            DrivingExperience += 10;
        }
    }
}
