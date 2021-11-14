using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private List<Player> players;
        private string name;

        public Team(string name)
        {
            this.Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("A name should not be empty.");
                }
            }
        }

        public void AddPlayer(Player player)
        {
            if(player != null)
            {
                players.Add(player);
            }
        }

        public void RemovePlayer(string name, string teamName)
        {
            bool flag = false;
            foreach (var item in players)
            {
                if(item.Name == name)
                {
                    players.Remove(item);
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                Console.WriteLine($"Player {name} is not in {teamName} team.");
            }
        }

        public void Rating()
        {
            decimal totalRating = 0;

            foreach (var item in players)
            {
                totalRating += item.SkillLevel();
            }

            if(totalRating != 0)
            {
                totalRating = totalRating / players.Count;
                Console.WriteLine($"{Name} - {totalRating}");
            }
            else
            {
                Console.WriteLine($"{Name} - {totalRating}");
            }
        }
    }
}
