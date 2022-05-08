using System;
using System.Collections.Generic;
using System.Linq;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> courses = new Dictionary<string,List<string>>();
            string[] courseInfo = Console.ReadLine().Split(" : ").ToArray();
            while (courseInfo[0] != "end")
            {
                string courseName = courseInfo[0];
                string studentName = courseInfo[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName,new List<string>());
                    courses[courseName].Add(studentName);
                    
                }
                else
                {
                    courses[courseName].Add(studentName);
                }



                courseInfo = Console.ReadLine().Split(" : ").ToArray();
            }
            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", item.Value)}");
            }
        }
    }
}
