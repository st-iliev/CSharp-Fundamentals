using System;

namespace _02._Programming_Fundamentals_Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int studentPerHour = num1 + num2 + num3;
            int students = int.Parse(Console.ReadLine());
            int hourCount = 0;
            while (students>0)
            {
                hourCount++;
                if (hourCount % 4 == 0)
                {
                    continue;
                }
                students -= studentPerHour;
            }
            Console.WriteLine($"Time needed: {hourCount:F0}h.");

        }
    }
}
