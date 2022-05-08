using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionY = int.Parse(Console.ReadLine());
            decimal powerOriginal = (decimal)(powerN * 0.5);
            int countPocked = 0;
            while (powerN >= distanceM)
            {
                if (powerOriginal == powerN)
                {
                    if (exhaustionY != 0)
                    {
                        powerN /= exhaustionY;
                    }
                }
                if (powerN >= distanceM)
                {            
                    powerN -= distanceM;
                    countPocked++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(powerN);
            Console.WriteLine(countPocked);
        }
    }
}
