using System;
using System.Collections.Generic;
using System.Linq;

namespace _6
{
    public class Car
    {
        public Car(string type, string model, string color, int hoursePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HoursePower = hoursePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HoursePower { get; set; }

    }
    public class Truck
    {
        public Truck(string type, string model, string color, int hoursePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HoursePower = hoursePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HoursePower { get; set; }
    }
    public class Catalogue
    {
        public Catalogue()
        {
            this.Car = new List<Car>();
            this.Truck = new List<Truck>();
        }
        public List<Car> Car { get; set; }
        public List<Truck> Truck { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalogue vehicles = new Catalogue();
            string[] vehicleInfo = Console.ReadLine().Split();
            while (vehicleInfo[0] != "End")
            {
                string type = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int hoursePower = int.Parse(vehicleInfo[3]);
                if (type == "car")
                {
                    Car newCar = new Car(type, model, color, hoursePower);
                    vehicles.Car.Add(newCar);
                }
                else if (type == "truck")
                {
                    Truck newTruck = new Truck(type, model, color, hoursePower);
                    vehicles.Truck.Add(newTruck);

                }
                vehicleInfo = Console.ReadLine().Split();
            }
            string vehicleModel = Console.ReadLine();
            while (vehicleModel != "Close the Catalogue")
            {
                if (vehicles.Car.Any(s => s.Model == vehicleModel))
                {
                    foreach (Car item in vehicles.Car)
                    {
                        if (item.Model == vehicleModel)
                        {
                            Console.WriteLine($"Type: Car");
                            Console.WriteLine($"Model: {item.Model}");
                            Console.WriteLine($"Color: {item.Color}");
                            Console.WriteLine($"Horsepower: {item.HoursePower}");
                        }
                    }
                }
                else if (vehicles.Truck.Any(s => s.Model == vehicleModel))
                {

                    foreach (Truck item in vehicles.Truck)
                    {
                        if (item.Model == vehicleModel)
                        {
                            Console.WriteLine($"Type: Truck");
                            Console.WriteLine($"Model: {item.Model}");
                            Console.WriteLine($"Color: {item.Color}");
                            Console.WriteLine($"Horsepower: {item.HoursePower}");
                        }
                    }
                }
                vehicleModel = Console.ReadLine();
            }
            double averageHP = 0;
            double totalHP = 0;
            if (vehicles.Car.Count > 0)
            {
            foreach (Car item in vehicles.Car)
            {
                totalHP += item.HoursePower;
            }
            averageHP = totalHP / vehicles.Car.Count;
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            averageHP = 0;
            totalHP = 0;
            if (vehicles.Truck.Count > 0)
            {
            foreach (Truck item in vehicles.Truck)
            {
                totalHP += item.HoursePower;
            }
            averageHP = totalHP / vehicles.Truck.Count;
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
