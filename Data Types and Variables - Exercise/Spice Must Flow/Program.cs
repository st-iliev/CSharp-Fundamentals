using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int startinYield = int.Parse(Console.ReadLine());
            int leavingYield = 0;
            int countDays = 0;
            if (startinYield < 100)
            {
                Console.WriteLine(countDays);
                Console.WriteLine(leavingYield);
            }
            else
            {
                while (startinYield >= 100)
                {
                    leavingYield += startinYield - 26;
                    startinYield -= 10;
                    countDays++;
                }
                leavingYield -= 26;
                Console.WriteLine(countDays);
                Console.WriteLine(leavingYield);
            }
        }
    }
}
