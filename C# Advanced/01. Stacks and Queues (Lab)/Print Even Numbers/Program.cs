namespace Print_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> evenNums = new Queue<int>();

            foreach (var n in input)
            {
                if (n % 2 == 0)
                {
                    evenNums.Enqueue(n);
                }
            }

            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
