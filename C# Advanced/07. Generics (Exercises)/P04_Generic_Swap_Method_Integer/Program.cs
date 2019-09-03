namespace P04_Generic_Swap_Method_Integer
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int content = int.Parse(Console.ReadLine());

                box.Add(content);
            }

            int[] inputIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = inputIndexes[0];
            int secondIndex = inputIndexes[1];

            SwapElements(box.Elements, firstIndex, secondIndex);

            Console.WriteLine(box.ToString());
        }

        static void SwapElements<T>(List<T> elements ,int firstIndex, int secondIndex)
        {
            T backUpElement = elements[firstIndex];

            elements[firstIndex] = elements[secondIndex];

            elements[secondIndex] = backUpElement;
        }
    }
}
