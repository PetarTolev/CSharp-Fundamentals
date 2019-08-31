namespace p03_Count_Uppercase_Words
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] result = input.Where(x => x.First() >= 65 && x.First() <= 90).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
