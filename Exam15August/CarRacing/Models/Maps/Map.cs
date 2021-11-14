using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (racerOne == null && racerTwo == null)
            {
                return "Race cannot be completed because both racers are not available!";
            }
            else if (racerOne == null)
            {
                return $"{racerTwo.Username} wins the race! {racerOne.Username} was not available to race!";
            }
            else if (racerTwo == null)
            {
                return $"{racerOne.Username} wins the race! {racerTwo.Username} was not available to race!";
            }

            double racerOneScore = 0;
            double racerTwoScore = 0;
            if (racerOne.RacingBehavior == "strict" && racerTwo.RacingBehavior == "strict")
            {
                racerOneScore = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.2;
                racerTwoScore = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.2;
            }
            else if (racerOne.RacingBehavior == "strict" && racerTwo.RacingBehavior == "aggressive")
            {
                racerOneScore = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.2;
                racerTwoScore = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.1;
            }
            else if (racerOne.RacingBehavior == "aggressive" && racerTwo.RacingBehavior == "strict")
            {
                racerOneScore = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.1;
                racerTwoScore = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.2;
            }
            else
            {
                racerOneScore = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.1;
                racerTwoScore = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * 1.1;
            }



            if(racerOneScore > racerTwoScore)
            {
                return $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerOne.Username} is the winner!";
            }
            else
            {
                return $"{racerOne.Username} has just raced against {racerTwo.Username}! {racerTwo.Username} is the winner!";
            }
        }
    }
}
