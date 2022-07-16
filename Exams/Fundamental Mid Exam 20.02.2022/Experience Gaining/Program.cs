using System;

namespace Fundamental_Min_Exam_20._02._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperiance = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            double currentExperiance = 0;
            int battleCount = 0;
            for (int i = 1; i <= countOfBattles; i++)
            {
                double experiance = double.Parse(Console.ReadLine());
                if (i % 3 == 0 && i > 0)
                {
                    currentExperiance += experiance * 0.15;
                }
                if (i % 5 == 0 && i > 0)
                {
                    currentExperiance -= experiance * 0.1;
                }
                if (i % 15 == 0 && i > 0)
                {
                    currentExperiance += experiance * 0.05;
                }
                currentExperiance += experiance;
                battleCount++;
                if (neededExperiance <= currentExperiance)
                {
                    break;
                }
            }
            if (neededExperiance <= currentExperiance)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleCount} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperiance-currentExperiance:F2} more needed.");
            }
        }
    }
}
