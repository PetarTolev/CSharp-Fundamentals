namespace Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (charsCount.ContainsKey(c))
                {
                    charsCount[c]++;
                }
                else
                {
                    charsCount.Add(c, 1);
                }
            }

            foreach (var kvp in charsCount.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
