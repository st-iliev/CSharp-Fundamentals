using System;

namespace _06._Programming_Fundamentals_Mid_Exam_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double targetPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    totalPlunder +=dailyPlunder*0.5;
                }
                 if (i % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.3;
                }   
            }
            if (totalPlunder >= targetPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(totalPlunder/targetPlunder)*100:F2}% of the plunder.");
            }

        }
    }
}
