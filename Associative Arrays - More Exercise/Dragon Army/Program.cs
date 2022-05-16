using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<double>>> dragons = new Dictionary<string, Dictionary<string, List<double>>>();
            int dragonNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < dragonNumbers; i++)
            {
                string[] dragonData = Console.ReadLine().Split();
                string type = dragonData[0];
                string name = dragonData[1];
                if (dragonData[2] == "null")
                {
                    dragonData[2] = "45";
                }
                double damage = double.Parse(dragonData[2]);
                if (dragonData[3] == "null")
                {
                    dragonData[3] = "250";
                }
                double health = double.Parse(dragonData[3]);
                if (dragonData[4] =="null")
                {
                    dragonData[4] = "10";
                }
                double armor = double.Parse(dragonData[4]);
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<double>> { { name, new List<double> { damage, health, armor } } });
                }
                else if (dragons[type].ContainsKey(name))
                {
                    dragons[type].Remove(name);
                    dragons[type].Add(name, new List<double> { damage, health, armor });
                }
                else
                {
                    dragons[type].Add(name, new List<double> { damage, health, armor });
                }

            }
            foreach (KeyValuePair<string, Dictionary<string, List<double>>> dragonType in dragons)
            {
                double avgDamage = 0d;
                double avgHealth = 0d;
                double avgArmor = 0d;
                double count = 0d;
                foreach (KeyValuePair<string, List<double>> stats in dragonType.Value)
                {
                    List<double> dragonStats = stats.Value;
                    avgDamage += dragonStats[0];
                    avgHealth += dragonStats[1];
                    avgArmor += dragonStats[2];
                    count++;
                }
                Console.WriteLine($"{dragonType.Key}::({avgDamage / count:F2}/{avgHealth / count:F2}/{avgArmor / count:F2})");

                foreach (var item in dragonType.Value.OrderBy(s => s.Key))
                {
                    List<double> dragonInfo = item.Value;
                    Console.WriteLine($"-{item.Key} -> damage: {dragonInfo[0]}, health: {dragonInfo[1]}, armor: {dragonInfo[2]}");
                }
            }
        }
    }
}
