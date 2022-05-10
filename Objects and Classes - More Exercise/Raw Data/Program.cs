using System;
using System.Collections.Generic;

namespace _4
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;

        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> car = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Engine newEngine = new Engine(engineSpeed, enginePower);
                Cargo newCargo = new Cargo(cargoWeight, cargoType);
                Car newCar = new Car(model, newEngine, newCargo);
                car.Add(newCar);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var item in car)
                {
                    if (item.Cargo.CargoType == "fragile")
                    {
                        if (item.Cargo.CargoWeight < 1000)
                        {
                            Console.WriteLine($"{item.Model}");
                        }
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var item in car)
                {
                    if (item.Cargo.CargoType == "flamable")
                    {
                        if (item.Engine.EnginePower > 250)
                        {
                            Console.WriteLine($"{item.Model}");
                        }
                    }
                }
            }
        }
    }
}

