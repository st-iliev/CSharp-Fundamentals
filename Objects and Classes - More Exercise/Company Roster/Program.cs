using System;
using System.Linq;
using System.Collections.Generic;

namespace Objects_and_Classes___More_Exercise
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<string> departments = new List<string>();
            int numberOfEmployees = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();
                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string department = employeeInfo[2];
                Employee newEmployee = new Employee(name, salary, department);
                employees.Add(newEmployee);
                departments.Add(department);
            }
            departments = departments.Distinct().ToList();
            string departmentHighestAve = "";
            double highestAveSalary = double.MinValue;
            foreach (var item in departments)
            {
                double aveSalary = employees.Where(s => s.Department == item).Select(s => s.Salary).Average();
                if (aveSalary > highestAveSalary)
                {
                    departmentHighestAve = item;
                    highestAveSalary = aveSalary;
                }
            }
            Console.WriteLine($"Highest Average Salary: {departmentHighestAve}");
            var departmentSord = employees.Where(s => s.Department == departmentHighestAve);
            foreach (var item in departmentSord.OrderByDescending(s=>s.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:F2}");
            }
        }
    }
}
