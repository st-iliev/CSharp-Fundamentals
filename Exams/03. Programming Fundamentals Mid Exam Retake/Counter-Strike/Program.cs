using System;

namespace _03._Programming_Fundamentals_Mid_Exam_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int distnace = int.Parse(Console.ReadLine());
            int battleWon = 0;
            string text = "";
            while (distnace > 0)
            {
                if (energy - distnace >= 0)
                {
                    energy -= distnace;
                    battleWon++;
                    if (battleWon % 3 == 0)
                    {
                        energy += battleWon;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleWon} won battles and {energy} energy");
                    return;
                }
                text = Console.ReadLine();
                if (text == "End of battle")
                {
                    Console.WriteLine($"Won battles: {battleWon}. Energy left: {energy}");
                    return;
                }
                distnace = int.Parse(text);
            }
        }
    }
}
