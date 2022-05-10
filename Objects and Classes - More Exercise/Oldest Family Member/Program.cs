using System;
using System.Linq;
using System.Collections.Generic;

namespace _2
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Family
    {
        public Family()
        {
            this.People = new List<Person>();
        }
        public List<Person> People;
        public void AddMember(Person member)
        {
            this.People.Add(member);
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(s => s.Age).FirstOrDefault();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Family persons = new Family();
            int numberOfPersons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPersons; i++)
            {
                string[] person = Console.ReadLine().Split();
                string name = person[0];
                int age = int.Parse(person[1]);
                Person currentPerson = new Person(name, age);
                persons.AddMember(currentPerson);
            }
            var oldestPerson = persons.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
