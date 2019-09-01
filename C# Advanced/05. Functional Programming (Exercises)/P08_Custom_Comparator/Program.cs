namespace P08_Custom_Comparator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, int> sortFunc = (a, b) => a.CompareTo(b);

            Action<int[], int[]> print = (x, y) 
                => Console.WriteLine($"{string.Join(" ", x)} {string.Join(" ", y)}");

            int[] oddNums = input.Where(x => Math.Abs(x) % 2 == 0).ToArray();
            int[] evenNums = input.Where(x => Math.Abs(x) % 2 == 1).ToArray();

            Array.Sort(oddNums, new Comparison<int>(sortFunc));
            Array.Sort(evenNums, new Comparison<int>(sortFunc));

            print(oddNums, evenNums);
        }
    }
}
