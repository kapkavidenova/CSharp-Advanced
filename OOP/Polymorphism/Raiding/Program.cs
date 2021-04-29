using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> heroes = new List<BaseHero>();

            for (int i = 0; i < n; i++)
            {
                while (heroes.Count<n)
                {
                    string name = Console.ReadLine();
                    string type = Console.ReadLine();

                    BaseHero hero = CreatHero(type, name);

                    if (hero == null)
                    {
                        Console.WriteLine("Invalid hero!");
                        continue;
                    }
                    heroes.Add(hero);
                }

                int bossHealtPoints = int.Parse(Console.ReadLine());

                foreach (var hero in heroes)
                {
                    Console.WriteLine(hero.CastAbality());
                    bossHealtPoints -= hero.Power;
                }
                if (bossHealtPoints<=0)
                {
                    Console.WriteLine("Victory!");
                }
                else
                {
                    Console.WriteLine("Defeat...");
                }
            }
        }

        private static BaseHero CreatHero(string type, string name)
        {
            BaseHero hero = null;

            if (type == nameof(Druid))
            {
                hero = new Druid(name);
            }
            else if (type == nameof(Paladin))
            {
                hero = new Paladin(name);
            }
            else if (type == nameof(Rogue))
            {
                hero = new Rogue(name);
            }
            else if (type == nameof(Warrior))
            {
                hero = new Warrior(name);
            }

            return hero;
        }
    }
}
