namespace Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> elements = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                foreach (var element in input)
                {
                    if (elements.ContainsKey(element))
                    {
                        elements[element]++;
                    }
                    else
                    {
                        elements.Add(element, 1);
                    }
                }
            }

            foreach (var element in elements.OrderBy(x => x.Key))
            {
                Console.Write(element.Key + " ");
            }
            Console.WriteLine();
        }
    }
}
