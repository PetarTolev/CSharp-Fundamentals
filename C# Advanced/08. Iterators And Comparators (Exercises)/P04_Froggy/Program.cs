namespace P04_Froggy
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] stoneValues = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(stoneValues);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}