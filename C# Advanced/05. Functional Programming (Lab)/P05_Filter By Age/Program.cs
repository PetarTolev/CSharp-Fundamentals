using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace P05_Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < totalPeople; i++)
            {
                string[] currentPerson = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string currentName = currentPerson[0];
                int currentAge = int.Parse(currentPerson[1]);

                Person person = new Person
                {
                    Name = currentName,
                    Age = currentAge
                };

                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate = null;

            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else if (condition == "younger")
            {
                filterPredicate = p => p.Age < age;
            }

            string format = Console.ReadLine();

            Func<Person, string> selectFunc = null;

            if (format == "name")
            {
                selectFunc = p => $"{p.Name}";
            }
            else if (format == "age")
            {
                selectFunc = p => $"{p.Age}";
            }
            else if (format == "name age")
            {
                selectFunc = p => $"{p.Name} - {p.Age}";
            }
            
            people
                .Where(filterPredicate)
                .Select(selectFunc)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
