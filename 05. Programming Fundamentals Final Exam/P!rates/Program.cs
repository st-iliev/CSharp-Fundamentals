using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();
            Dictionary<string, int> citiesGold = new Dictionary<string, int>();
            string[] cities = Console.ReadLine().Split("||");
            while (cities[0] != "Sail")
            {
                if (citiesPopulation.ContainsKey(cities[0]))
                {
                    citiesPopulation[cities[0]] += int.Parse(cities[1]);
                    citiesGold[cities[0]] += int.Parse(cities[2]);
                }
                else
                {
                    citiesPopulation.Add(cities[0], int.Parse(cities[1]));
                    citiesGold.Add(cities[0], int.Parse(cities[2]));
                }
                cities = Console.ReadLine().Split("||");
            }
            string[] commands = Console.ReadLine().Split("=>");
            while (commands[0] != "End")
            {
                if (commands[0] == "Plunder")
                {
                    int people = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);
                    if (citiesPopulation.ContainsKey(commands[1]))
                    {
                        if (citiesPopulation[commands[1]] - people > 0)
                        {
                            citiesPopulation[commands[1]] -= people;
                        }
                        else
                        {
                            people = citiesPopulation[commands[1]];
                            citiesPopulation[commands[1]] = 0;
                        }
                        if (citiesGold[commands[1]] - gold > 0)
                        {
                            citiesGold[commands[1]] -= gold;
                        }
                        else
                        {
                            gold = citiesGold[commands[1]];
                            citiesGold[commands[1]] = 0;
                        }
                        Console.WriteLine($"{commands[1]} plundered! {gold} gold stolen, {people} citizens killed.");
                        if (citiesPopulation[commands[1]] == 0 || citiesGold[commands[1]] == 0)
                        {
                            Console.WriteLine($"{commands[1]} has been wiped off the map!");
                            citiesPopulation.Remove(commands[1]);
                            citiesGold.Remove(commands[1]);
                        }
                    }
                }
                else if (commands[0] == "Prosper")
                {
                    int gold = int.Parse(commands[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesGold[commands[1]] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {commands[1]} now has {citiesGold[commands[1]]} gold.");
                    }
                }
                commands = Console.ReadLine().Split("=>");
            }
            if (citiesPopulation.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesPopulation.Count} wealthy settlements to go to:");
                foreach (var item in citiesPopulation)
                {
                    foreach (var kvp in citiesGold)
                    {
                        if (item.Key == kvp.Key)
                        {
                            Console.WriteLine($"{item.Key} -> Population: {item.Value} citizens, Gold: {kvp.Value} kg");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
