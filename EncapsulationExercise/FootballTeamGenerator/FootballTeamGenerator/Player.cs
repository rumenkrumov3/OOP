using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player : Stats
    {
        private string name;
        public Player(string name, decimal endurance, decimal sprint, decimal dribbling, decimal passing, decimal shooting) : base(endurance, sprint, dribbling, passing, shooting)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        internal decimal SkillLevel()
        {
            string skillLevel = $"{((Endurance + Sprint + Dribble + Passing + Shooting) / 5):F2}";
            decimal value = Math.Round(decimal.Parse(skillLevel));
            return value;
        }

        
    }
}
