using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealthCap = int.Parse(Console.ReadLine());
            List<string> command = Console.ReadLine().Split().ToList();
            while (command[0] != "Retire")
            {
                if (command[0] == "Fire")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);
                    if (index >= 0 && index < warShip.Count)
                    {
                        if (warShip[index] - damage <= 0)
                        {
                            Console.WriteLine($"You won! The enemy ship has sunken.");
                            return;
                        }
                        else
                        {
                            warShip[index] -= damage;
                        }
                    }
                }
                else if (command[0] == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);
                    if (startIndex >= 0 && startIndex < pirateShip.Count &&
                        endIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine($"You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }

                }
                else if (command[0] == "Repair")
                {
                    int index = int.Parse(command[1]);
                    int health = int.Parse(command[2]);
                    if (index >= 0 && index < pirateShip.Count)
                    {
                        if (pirateShip[index] < maxHealthCap)
                        {
                            if (pirateShip[index] + health >= maxHealthCap)
                            {
                                pirateShip[index] = maxHealthCap;
                            }
                            else
                            {
                                pirateShip[index] += health; 
                            }
                        }
                    }

                }
                else if (command[0] == "Status")
                {
                    decimal currentHealth = maxHealthCap * 0.2M;
                    int repairCount = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < currentHealth)
                        {
                            repairCount++;
                        }
                    }
                    Console.WriteLine($"{repairCount} sections need repair.");
                }
                    command = Console.ReadLine().Split().ToList();
            }
            int statusPirate = 0;
            int statusWar = 0;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                statusPirate += pirateShip[i];      
            }
            for (int i = 0; i < warShip.Count; i++)
            {
                statusWar += warShip[i];

            }
            Console.WriteLine($"Pirate ship status: {statusPirate}");
            Console.WriteLine($"Warship status: {statusWar}");

        }
    }
}
