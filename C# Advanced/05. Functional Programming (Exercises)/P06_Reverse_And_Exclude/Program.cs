namespace P06_Reverse_And_Exclude
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int divider = int.Parse(Console.ReadLine());

            Func<int, bool> filter = x => x % divider != 0;

            int[] result = nums.Where(filter).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
