using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string biggestKeg = "";
            for (int i = 1; i <= numberOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                double heightOfKeg = double.Parse(Console.ReadLine());
                double volume =Math.PI *Math.Pow((radiusOfKeg),2)* heightOfKeg;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = modelOfKeg;

                }
            }
            Console.WriteLine($"{biggestKeg}");
        }
    }
}
