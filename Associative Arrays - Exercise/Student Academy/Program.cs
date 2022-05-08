using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> grade = new Dictionary<string, List<double>>();
           
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!grade.ContainsKey(studentName))
                {
                    grade.Add(studentName, new List<double>());
                    grade[studentName].Add(studentGrade);
                    
                }
                else if (grade.ContainsKey(studentName))
                {
                    grade[studentName].Add(studentGrade);
                }
            }
            foreach (var item in grade)
            {
                if (item.Value.Average() >= 4.50)
                {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
                }
            }
        }
    }
}
