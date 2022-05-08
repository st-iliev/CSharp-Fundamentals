using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());
            double lightsaberPrice = (Math.Ceiling(students * 0.1) + students) * lightsaber;
            double robePrice = students * robe;
            double beltPrice = 0;
            if (students >= 6)
            {
                int freeBelts = students/6;
                beltPrice = belt * (students - freeBelts);
            }
            else
            {
            beltPrice = belt * students;
            }
            double sum = lightsaberPrice + robePrice + beltPrice;
            if (budget >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sum-budget:F2}lv more.");
            }




        }
    }
}
