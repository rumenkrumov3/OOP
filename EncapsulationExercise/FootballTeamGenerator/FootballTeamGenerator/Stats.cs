using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Stats
    {
        private decimal endurance;
        private decimal sprint;
        private decimal dribble;
        private decimal passing;
        private decimal shooting;
        private bool flagForIncorrectness;
        public Stats(decimal endurance, decimal sprint, decimal dribble, decimal passing, decimal shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public bool FlagForIncorrectness
        {
            get
            {
                return this.flagForIncorrectness;
            }
            private set
            {
                this.flagForIncorrectness = value;
            }
        }
        public decimal Endurance
        {
            get
            {
                return this.endurance;
            }
            set
            {
                if(value < 0 || value > 100)
                {
                    Console.WriteLine("Endurance should be between 0 and 100.");
                    flagForIncorrectness = true;
                }
                else
                {
                    this.endurance = value;
                }
            }
        }
        public decimal Sprint
        {
            get
            {
                return this.sprint;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Sprint should be between 0 and 100.");
                    flagForIncorrectness = true;

                }
                else
                {
                    this.sprint = value;
                }
            }
        }
        public decimal Dribble
        {
            get
            {
                return this.dribble;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Dribble should be between 0 and 100.");
                    flagForIncorrectness = true;
                }
                else
                {
                    this.dribble = value;
                }
            }
        }
        public decimal Passing
        {
            get
            {
                return this.passing;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Passing should be between 0 and 100.");
                    flagForIncorrectness = true;
                }
                else
                {
                    this.passing = value;
                }
            }
        }
        public decimal Shooting
        {
            get
            {
                return this.shooting;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Shooting should be between 0 and 100.");
                    flagForIncorrectness = true;
                }
                else
                {
                    this.shooting = value;
                }
            }
        }
    }
}
