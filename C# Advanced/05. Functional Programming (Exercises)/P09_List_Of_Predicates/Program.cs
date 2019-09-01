namespace P09_List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToList();
            
            List<Predicate<long>> predicates = new List<Predicate<long>>();
            dividers.ForEach(d => predicates.Add(x => x % d == 0));

            List<long> numbers = new List<long>();

            for (long i = 1; i <= n; i++)
            {
                bool isDivide = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivide = false;
                        break;
                    }
                }

                if (isDivide)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
