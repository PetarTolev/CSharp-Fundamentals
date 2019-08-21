namespace Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> inputQueue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int capacity = input[0];
                int distance = input[1];

                inputQueue.Enqueue(capacity - distance);
            }

            int index = 0;

            while (true)
            {
                Queue<int> copyQueue = new Queue<int>(inputQueue);
                int fuel = -1;

                while (copyQueue.Any())
                {
                    if (copyQueue.Peek() > 0 && fuel == -1)
                    {
                        fuel = copyQueue.Dequeue();
                        inputQueue.Enqueue(inputQueue.Dequeue());
                    }
                    else if (copyQueue.Peek() < 0 && fuel == -1)
                    {
                        copyQueue.Enqueue(copyQueue.Dequeue());
                        inputQueue.Enqueue(inputQueue.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copyQueue.Dequeue();
                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }
                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;
            }
        }
    }
}
