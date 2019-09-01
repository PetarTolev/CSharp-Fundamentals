namespace P10_Predicate_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<string> people = Console.ReadLine().Split().ToList();
            Predicate<string> predicate;

            while (true)
            {
                string inputCommandLine = Console.ReadLine();

                if (inputCommandLine == "Party!")
                {
                    break;
                }

                string[] commandProps = inputCommandLine.Split();
                string command = commandProps[0];
                string criteria = commandProps[1];
                string prop = commandProps[2];

                predicate = GetPredicate(criteria, prop);

                switch (command)
                {
                    case "Remove":
                        people.RemoveAll(predicate);
                        break;

                    case "Double":
                        var peopleToAdd = people.FindAll(predicate);

                        foreach (var person in peopleToAdd)
                        {
                            int index = people.IndexOf(person);
                            people.Insert(index + 1, person);
                        }

                        break;
                }
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party! ");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static Predicate<string> GetPredicate(string criteria, string prop)
        {
            switch (criteria)
            {
                case "StartsWith":
                    return p => p.StartsWith(prop);

                case "EndsWith":
                    return p => p.EndsWith(prop);

                case "Length":
                    return p => p.Length == int.Parse(prop);
            }

            return null;
        }
    }
}
