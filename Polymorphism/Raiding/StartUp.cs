using System;
using System.Collections.Generic;

namespace Raiding
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> raid = new List<BaseHero>();
            int totalpower = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string herotype = Console.ReadLine();

                if(herotype == "Druid")
                {
                    Druid druid = new Druid(name);
                    Console.WriteLine(druid.CastAbility());
                    raid.Add(druid);
                }
                else if (herotype == "Rogue")
                {
                    Rogue rogue = new Rogue(name);
                    Console.WriteLine(rogue.CastAbility());
                    raid.Add(rogue);
                }
                else if (herotype == "Warrior")
                {
                    Warrior warrior = new Warrior(name);
                    Console.WriteLine(warrior.CastAbility());
                    raid.Add(warrior);
                }
                else if (herotype == "Paladin")
                {
                    Paladin paladin = new Paladin(name);
                    Console.WriteLine(paladin.CastAbility());
                    raid.Add(paladin);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
            }

            foreach (var item in raid)
            {
                totalpower += item.Power;
            }

            int bossDMG = int.Parse(Console.ReadLine());

            if(totalpower >= bossDMG)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
