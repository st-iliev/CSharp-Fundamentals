using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentNumbers = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < studentNumbers; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();
                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                double grade = double.Parse(studentsInfo[2]);
                Student student = new Student();
                student.Firstname = firstName;
                student.Lastname = lastName;
                student.Grade = grade;
                students.Add(student);
            }
            students = students.OrderByDescending(s => s.Grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Firstname} {student.Lastname}: {student.Grade:F2}");
            }
        }
    }
}
