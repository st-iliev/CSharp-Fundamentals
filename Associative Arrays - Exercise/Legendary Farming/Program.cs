using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItem = new Dictionary<string, int>()
            {
                { "shards",0 },
                { "motes",0 },
                { "fragments", 0 }
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            while (true)
            {
                string material = " ";
                int quantity = 0;
                string[] materials = Console.ReadLine().Split().Select(s => s.ToLowerInvariant()).ToArray();
                for (int i = 0; i < materials.Length; i += 2)
                {
                    material = materials[i + 1];
                    quantity = int.Parse(materials[i+0]);
                    

                    if (legendaryItem.ContainsKey(material))
                    {
                        legendaryItem[material] += quantity;
                        if (legendaryItem[material] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }
                }

                if (legendaryItem["shards"] >= 250)
                {
                    Console.WriteLine($"Shadowmourne obtained!");
                    legendaryItem["shards"] -= 250;
                    break;
                }
                if (legendaryItem["fragments"] >= 250)
                {
                    Console.WriteLine($"Valanyr obtained!");
                    legendaryItem["fragments"] -= 250;
                    break;
                }
                if (legendaryItem["motes"] >= 250)
                {
                    Console.WriteLine($"Dragonwrath obtained!");
                    legendaryItem["motes"] -= 250;
                    break;
                }
            }
            foreach (var item in legendaryItem.Where(s => s.Value >= 0))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

    }

}
