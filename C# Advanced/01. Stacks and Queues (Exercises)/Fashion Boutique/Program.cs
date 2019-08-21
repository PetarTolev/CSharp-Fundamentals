namespace Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clothesValues = new Stack<int>(input);

            int rackCapacity = capacity;
            int count = 0;
            while (clothesValues.Count != 0)
            {
                if (rackCapacity >= clothesValues.Peek())
                {
                    rackCapacity -= clothesValues.Pop();
                    continue;
                }
                rackCapacity = capacity;
                count++;
            }

            Console.WriteLine(count + 1);
        }
    }
}
