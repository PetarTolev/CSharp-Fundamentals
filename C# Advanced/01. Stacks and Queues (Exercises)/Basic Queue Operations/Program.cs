namespace Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNSX = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = inputNSX[0];
            int s = inputNSX[1];
            int x = inputNSX[2];

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count != 0)
                {
                    Console.WriteLine(queue.Min());
                    return;
                }
                Console.WriteLine(0);
            }
        }
    }
}
