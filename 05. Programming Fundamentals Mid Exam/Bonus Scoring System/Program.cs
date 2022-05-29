using System;

namespace _05._Programming_Fundamentals_Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            double totalBonus = 0;
            double max = 0;
            int studenAttended = 0;
            for (int i = 0; i < students; i++)
            {
                double attendance = double.Parse(Console.ReadLine());
                totalBonus =(attendance / lectures )* (5.0 + bonus);
                if (totalBonus > max)
                {
                    max = totalBonus;
                    studenAttended = (int)attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(max)}.");
            Console.WriteLine($"The student has attended {studenAttended} lectures.");
        }
    }
}
