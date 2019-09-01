namespace P02_Knights_of_Honor
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, string> format = y => $"Sir {y}";

            Action<List<string>> print = x =>
                Console.WriteLine(string.Join(Environment.NewLine, x.Select(format)));

            print(names);
        }
    }
}
