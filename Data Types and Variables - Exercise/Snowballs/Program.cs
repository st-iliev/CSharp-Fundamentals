using System;
using System.Numerics;

namespace _11_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfSnowballs = int.Parse(Console.ReadLine());
            if (numbersOfSnowballs == 0)
            {
                Console.WriteLine($"0 : 0 = 0 (0)");
                return;
            }
            BigInteger maxValue = -1;
            double currentSnowballSnow = 0;
            double currentSnowballTime = 0;
            double currentSnowballQuality = 0;
            for (int i = 1; i <= numbersOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    currentSnowballSnow = snowballSnow;
                    currentSnowballTime = snowballTime;
                    currentSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{currentSnowballSnow} : {currentSnowballTime} = {maxValue} ({currentSnowballQuality})");

        }
    }
}
