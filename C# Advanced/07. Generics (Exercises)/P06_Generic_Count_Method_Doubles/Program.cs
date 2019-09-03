using System.Collections.Generic;

namespace P06_Generic_Count_Method_Doubles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Box<decimal> box = new Box<decimal>();

            for (int i = 0; i < numberOfLines; i++)
            {
                decimal content = decimal.Parse(Console.ReadLine());

                box.Add(content);
            }

            decimal givenElement = decimal.Parse(Console.ReadLine());

            Console.WriteLine(GetCountOfGreatestElement(box.Elements, givenElement));
        }

        public static int GetCountOfGreatestElement<T>(List<T> listWithElements, T element) where T : IComparable
        {
            int count = 0;

            foreach (var e in listWithElements)
            {
                if (e.CompareTo(element) == 1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
