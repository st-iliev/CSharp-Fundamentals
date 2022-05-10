using System;
using System.Collections.Generic;

namespace _3
{
    class Car
    {
        public Car(string model,double fuelAmount,double fuelPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelPerKilometer = fuelPerKilometer;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKilometer { get; set; }
        public double TravelDistance { get; set; }
        public double CurrentDistance { get; set; }
        public void Distance(double amountOfKm)
        {
            double neededFuel = amountOfKm * FuelPerKilometer;
            if (neededFuel <= FuelAmount)
            {
                CurrentDistance = amountOfKm;
                TravelDistance += amountOfKm;
                FuelAmount -= neededFuel;             
            }
            else
            {
                CurrentDistance = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelPerKilometer = double.Parse(carInfo[2]);
                Car newCar = new Car(model, fuelAmount, fuelPerKilometer);
                cars.Add(newCar);
            }
            string[] command = Console.ReadLine().Split();
            while (command[0]!="End")
            {
                string model = command[1];
                double amountOfKm = double.Parse(command[2]);
                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Distance(amountOfKm);
                        if (car.CurrentDistance == 0)
                        {
                            Console.WriteLine($"Insufficient fuel for the drive");
                        }                        
                    }
                }
                command = Console.ReadLine().Split();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelDistance}");
            }
        }
    }
}
