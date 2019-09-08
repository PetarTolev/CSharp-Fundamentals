namespace P05_Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<Person> personsList = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] personProps = input.Split();

                string name = personProps[0];
                int age = int.Parse(personProps[1]);
                string town = personProps[2];

                Person person = new Person(name, age, town);

                personsList.Add(person);
            }

            int n = int.Parse(Console.ReadLine());

            int countOfEqualPeople = 0;

            foreach (var person in personsList)
            {
                if (person.CompareTo(personsList[n - 1]) == 0)
                {
                    countOfEqualPeople++;
                }
            }

            if (countOfEqualPeople == 1)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine($"{countOfEqualPeople} {personsList.Count - countOfEqualPeople} {personsList.Count}");
        }
    }
}