namespace Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            List<int> nNums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                nNums.Add(int.Parse(Console.ReadLine()));
            }
            
            List<int> mNums = new List<int>();

            for (int i = 0; i < m; i++)
            {
                mNums.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> resultNums = new HashSet<int>();

            foreach (var i in nNums)
            {
                if (mNums.Contains(i))
                {
                    resultNums.Add(i);
                }
            }

            foreach (var i in mNums)
            {
                if (nNums.Contains(i))
                {
                    resultNums.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", resultNums));
        }
    }
}
