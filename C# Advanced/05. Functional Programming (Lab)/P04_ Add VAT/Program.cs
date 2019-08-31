namespace P04__Add_VAT
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double[] result = input.Select(x => x * 1.2).ToArray();

            foreach (var d in result)
            {
                Console.WriteLine($"{d:F2}");
            }
        }
    }
}
