using System;
using System.Collections.Generic;
using System.Linq;

namespace _7
{
    class Person
    {
        public Person(string name, int ID, int age)
        {
            this.Name = name;
            this.ID = ID;
            this.Age = age;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
    }
    class Persons
    {
        public Persons()
        {
            this.allPersons = new List<Person>();
        }

        public List<Person> allPersons = new List<Person>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persons persons = new Persons();
            List<Person> person = new List<Person>();
            string[] input = Console.ReadLine().Split();
            while (input[0]!="End")
            {
                string name = input[0];
                int ID = int.Parse(input[1]);
                int age = int.Parse(input[2]);
                Person searchPerson = person.FirstOrDefault(s => s.ID == ID);
                if (person.Any(s => s.ID == ID))
                {
                    searchPerson.Name = name;
                    searchPerson.Age = age;
                }
                else
                {
                    Person newPerson = new Person(name, ID, age);
                    persons.allPersons.Add(newPerson);
                }
                
                input = Console.ReadLine().Split();
            }
            List<Person> sortedPersons = persons.allPersons.OrderBy(s => s.Age).ToList();
            foreach (Person item in sortedPersons)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
}
