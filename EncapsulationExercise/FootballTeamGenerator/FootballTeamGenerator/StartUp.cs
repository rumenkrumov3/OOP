using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(';');
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            bool flagForAddingTeam = false;
            bool flagForRating = false;

            while(input[0] != "END")
            {
                if(input[0] == "Add")
                {
                    foreach (var item in teams)
                    {
                        if(item.Key == input[1])
                        {
                            flagForAddingTeam = true;
                        }
                    }

                    if(flagForAddingTeam == true)
                    {
                        string playerName = input[2];
                        decimal endurance = decimal.Parse(input[3]);
                        decimal sprint = decimal.Parse(input[4]);
                        decimal dribble = decimal.Parse(input[5]);
                        decimal passing = decimal.Parse(input[6]);
                        decimal shooting = decimal.Parse(input[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        
                        if(!player.FlagForIncorrectness == true)
                        {
                            teams[input[1]].AddPlayer(player);
                        }
                        flagForAddingTeam = false;
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "Remove")
                {
                    string playerName = input[2];
                    teams[input[1]].RemovePlayer(playerName, input[1]);
                }
                else if (input[0] == "Rating")
                {
                    foreach (var item in teams)
                    {
                        if (item.Key == input[1])
                        {
                            flagForRating = true;
                        }
                    }
                    if(flagForRating == true)
                    {
                        teams[input[1]].Rating();
                        flagForRating = false;
                    }
                    else
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "Team")
                {
                    Team teamche = new Team(input[1]);
                    teams.Add(input[1],teamche);
                }
                input = Console.ReadLine().Split(';');
            }
        }
    }
}
