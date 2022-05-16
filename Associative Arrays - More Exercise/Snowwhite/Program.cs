using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();
            string[] dwarfData = Console.ReadLine().Split(" <:> ");
            while (dwarfData[0] != "Once upon a time")
            {
                string dwarfName = dwarfData[0];
                string dwarfHatColor = dwarfData[1];
                int dwarfPhysics = int.Parse(dwarfData[2]);
                if (!dwarfs.ContainsKey(dwarfHatColor))
                {
                    dwarfs.Add(dwarfHatColor, new Dictionary<string, int> { { dwarfName, dwarfPhysics } });
                }
                else if (dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    if (dwarfs[dwarfHatColor][dwarfName] < dwarfPhysics)
                    {
                        dwarfs[dwarfHatColor][dwarfName] = dwarfPhysics;
                    }
                }
                else if (!dwarfs[dwarfHatColor].ContainsKey(dwarfName))
                {
                    dwarfs[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                }
                dwarfData = Console.ReadLine().Split(" <:> ");
            }
            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var hatColor in dwarfs.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in hatColor.Value)
                {
                    sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);
                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
           
        }
    }
}