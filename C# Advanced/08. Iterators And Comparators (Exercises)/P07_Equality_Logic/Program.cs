namespace P07_Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
