using System.Collections.Generic;

namespace P06_Strategy_Pattern
{
    using System;

    public class Program
    {
        public static void Main()
        {
            SortedSet<Person> sortedByName = new SortedSet<Person>(new PersonNameLengthComparer());
            SortedSet<Person> sortedByAge = new SortedSet<Person>(new PersonAgeComparer());

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                sortedByName.Add(person);
                sortedByAge.Add(person);
            }
            
            foreach (var person in sortedByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in sortedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
