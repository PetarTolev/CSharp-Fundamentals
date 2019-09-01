namespace P04_Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] startEndNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int start = startEndNums[0];
            int end = startEndNums[1];

            List<int> nums = Enumerable.Range(start, end - start + 1).ToList();

            string condition = Console.ReadLine();

            Predicate<int> filter = x => condition == "odd" ? x % 2 != 0 : x % 2 == 0;

            Console.WriteLine(string.Join(" ", nums.Where(x => filter(x))));
        }
    }
}
