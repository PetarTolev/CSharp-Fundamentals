using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Pascal_Triangle
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            long[][] arr = new long[n][];

            arr[0] = new long[1];
            arr[1] = new long[2];

            arr[0][0] = 1;
            arr[1][0] = 1;
            arr[1][1] = 1;

            for (int row = 2; row < n ; row++)
            {
                arr[row] = new long[row + 1]; 
                arr[row][0] = 1;
                arr[row][arr[row].Length - 1] = 1;
                for (int col = 1; col < arr[row].Length - 1; col++)
                {
                    arr[row][col] = arr[row - 1][col] + arr[row - 1][col - 1];
                }
            }

            foreach (var a in arr)
            {
                Console.WriteLine(string.Join(" ", a));
            }
        }
    }
}
