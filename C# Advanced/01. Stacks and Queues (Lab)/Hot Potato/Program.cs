namespace Hot_Potato
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(input);

            while (queue.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
