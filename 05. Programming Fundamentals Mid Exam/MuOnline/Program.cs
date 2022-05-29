using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split("|").ToList();
            List<string> currentRoom = new List<string>();
            int health = 100;
            int bitcoins = 0;
            int room = 0;
            while (room <= rooms.Count-1)
            {
                currentRoom = rooms[room].Split().ToList();
                int num = int.Parse(currentRoom[1]);
                if (currentRoom[0] == "potion")
                {
                    if (health < 100)
                    {
                        int heal = 0;
                        if (health + num >= 100)
                        {
                            heal = 100-health;
                            health = 100;
                            Console.WriteLine($"You healed for {heal} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            health += num;
                            Console.WriteLine($"You healed for {num} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                    }
                }
                else if (currentRoom[0] == "chest")
                {
                    Console.WriteLine($"You found {num} bitcoins.");
                    bitcoins += num;
                }
                else
                {
                    if (health - num > 0)
                    {
                        Console.WriteLine($"You slayed {currentRoom[0]}.");
                        health -= num;
                    }
                    else if(health-num <=0)
                    {
                        Console.WriteLine($"You died! Killed by {currentRoom[0]}.");
                        Console.WriteLine($"Best room: {room+1}");
                        return;
                    }
                }
                room++;
            }
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
        }
    }
}
