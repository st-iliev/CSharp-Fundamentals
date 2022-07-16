using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroHp = new Dictionary<string, int>();
            Dictionary<string, int> heroMp = new Dictionary<string, int>();
            for (int i = 0; i < numbersOfHeroes; i++)
            {
                string[] heroStats = Console.ReadLine().Split();
                heroHp.Add(heroStats[0], int.Parse(heroStats[1]));
                heroMp.Add(heroStats[0], int.Parse(heroStats[2]));
            }
            string[] actions = Console.ReadLine().Split(" - ");
            while (actions[0]!="End")
            {
                if (actions[0] == "CastSpell")
                {
                    if (heroMp[actions[1]] >= int.Parse(actions[2]))
                    {
                        heroMp[actions[1]] -= int.Parse(actions[2]);
                        Console.WriteLine($"{actions[1]} has successfully cast {actions[3]} and now has {heroMp[actions[1]]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{actions[1]} does not have enough MP to cast {actions[3]}!");
                    }
                }
                else if (actions[0] == "TakeDamage")
                {
                    if (heroHp[actions[1]] > int.Parse(actions[2]))
                    {
                        heroHp[actions[1]] -= int.Parse(actions[2]);
                        Console.WriteLine($"{actions[1]} was hit for {actions[2]} HP by {actions[3]} and now has {heroHp[actions[1]]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{actions[1]} has been killed by {actions[3]}!");
                        heroHp.Remove(actions[1]);
                        heroMp.Remove(actions[1]);           
                    }
                }
                else if (actions[0] == "Recharge")
                {
                    if (heroMp[actions[1]] + int.Parse(actions[2]) <= 200)
                    {
                        heroMp[actions[1]] += int.Parse(actions[2]);
                        Console.WriteLine($"{actions[1]} recharged for {actions[2]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{actions[1]} recharged for {200- heroMp[actions[1]]} MP!");
                        heroMp[actions[1]] = 200;
                    }
                }
                else if (actions[0] == "Heal")
                {
                    if (heroHp[actions[1]] + int.Parse(actions[2]) <= 100)
                    {
                        heroHp[actions[1]] += int.Parse(actions[2]);
                        Console.WriteLine($"{actions[1]} healed for {actions[2]} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{actions[1]} healed for {100 - heroHp[actions[1]]} HP!");
                        heroHp[actions[1]] = 100;
                    }
                }
                    actions = Console.ReadLine().Split(" - ");
            }
            foreach (var hero1 in heroHp)
            {
                foreach (var hero2 in heroMp)
                {
                    if (hero1.Key == hero2.Key)
                    {
                        Console.WriteLine($"{hero1.Key}");
                        Console.WriteLine($"  HP: {hero1.Value}");
                        Console.WriteLine($"  MP: {hero2.Value}");
                    }
                }
            }
        }
    }
}
