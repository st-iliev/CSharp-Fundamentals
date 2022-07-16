using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    public class plant
    {
        public int rarity;
        public List<double> raiting = new List<double>();
        public double averagerating;
        public void AverageRaiting(double number)
        {
            double currentRaiting = 0;
            raiting.Add(number);
            for (int i = 0; i < raiting.Count; i++)
            {
                currentRaiting += raiting[i];
            }
            averagerating = currentRaiting / raiting.Count;
           
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictionary<string, plant> plants = new Dictionary<string, plant>();
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] currentPlant = Console.ReadLine().Split("<->");
                if (!plants.ContainsKey(currentPlant[0]))
                {
                    plants.Add(currentPlant[0], new plant());
                    plants[currentPlant[0]].rarity = int.Parse(currentPlant[1]);
                }
                else
                {
                    plants[currentPlant[0]].rarity = int.Parse(currentPlant[1]);
                }
            }
            string[] commands = Console.ReadLine().Split(new char[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            while (commands[0] != "Exhibition")
            {
                if (commands[0] == "Rate")
                {
                    string name = commands[1].Trim();
                    if (plants.ContainsKey(name))
                    {
                        plants[name].AverageRaiting(double.Parse(commands[2]));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commands[0] == "Update")
                {
                    string name = commands[1].Trim();
                    if (plants.ContainsKey(name))
                    {
                        plants[name].rarity = int.Parse(commands[2]);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commands[0] == "Reset")
                {
                    string name = commands[1].Trim();
                    if (plants.ContainsKey(name))
                    {
                        plants[name].raiting.Clear();
                        plants[name].averagerating = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                commands = Console.ReadLine().Split(new char[] { ':', '-' });
            }
            Console.WriteLine($"Plants for the exhibition:");
            
            foreach (var item in plants.OrderByDescending(s=>s.Value.rarity).ThenByDescending(s=>s.Value.averagerating))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.rarity}; Rating: {item.Value.averagerating:F2}");
            }
        }
    }
}