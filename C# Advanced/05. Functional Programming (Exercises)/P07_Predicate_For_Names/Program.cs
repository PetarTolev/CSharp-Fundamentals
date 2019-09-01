namespace P07_Predicate_For_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int nameLength = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, bool> filter = n => n.Length <= nameLength;

            names = names.Where(x => filter(x)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
