namespace P03_Custom_Min_Function
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getSmallestNum = i => i.Min();

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(getSmallestNum(input));
        }
    }
}
