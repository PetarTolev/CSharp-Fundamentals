namespace Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Queue<long> queue = new Queue<long>();

            queue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                long s = queue.Peek();
                queue.Enqueue(s + 1);
                queue.Enqueue(2 * s + 1);
                queue.Enqueue(s + 2);

                Console.Write(queue.Dequeue() + " ");
            }
            Console.WriteLine();
        }
    }
}
