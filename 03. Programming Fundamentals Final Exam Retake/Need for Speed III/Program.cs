using System;
using System.Linq;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string,int> carDistance = new Dictionary<string,int>();
            Dictionary<string,int> carFuel = new Dictionary<string,int>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|");
                carDistance.Add(carInfo[0], int.Parse(carInfo[1]));
                carFuel.Add(carInfo[0], int.Parse(carInfo[2]));
            }
            string[] commands = Console.ReadLine().Split(" : ");
            while (commands[0] != "Stop")
            {
                if (commands[0] == "Drive")
                {
                    int distance = int.Parse(commands[2]);
                    int fuel = int.Parse(commands[3]);
                    if (carFuel[commands[1]] < fuel)
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    else
                    {
                        carFuel[commands[1]] -= fuel;
                        carDistance[commands[1]] += distance;
                        Console.WriteLine($"{commands[1]} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (carDistance[commands[1]] >= 100000)
                        {
                            carFuel.Remove(commands[1]);
                            carDistance.Remove(commands[1]);
                            Console.WriteLine($"Time to sell the {commands[1]}!");
                        }
                    }
                }
                else if (commands[0] == "Refuel")
                {
                    int fuel = int.Parse(commands[2]);
                    if (carFuel[commands[1]] + fuel <= 75)
                    {
                        carFuel[commands[1]] += fuel;
                        Console.WriteLine($"{commands[1]} refueled with {fuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{commands[1]} refueled with {75 - carFuel[commands[1]]} liters");
                        carFuel[commands[1]] += 75 - carFuel[commands[1]];
                    }
                }
                else if (commands[0] == "Revert")
                {
                    int distance = int.Parse(commands[2]);
                    if (carDistance[commands[1]] - distance < 10000)
                    {
                        carDistance[commands[1]] = 10000;
                    }
                    else
                    {
                        carDistance[commands[1]] -= distance;
                        Console.WriteLine($"{commands[1]} mileage decreased by {distance} kilometers");
                    }

                }
                    commands = Console.ReadLine().Split(" : ");  
            }
            foreach (var car in carDistance.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))                   
            {
                foreach (var fuel in carFuel)
                {
                    if (car.Key == fuel.Key)
                    {
                        Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {fuel.Value} lt.");
                    }
                }
            }
        }
    }
}
