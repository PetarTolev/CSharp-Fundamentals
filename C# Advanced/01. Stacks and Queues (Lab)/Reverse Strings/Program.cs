namespace Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversedString = new Stack<char>();

            foreach (var c in input)
            {
                reversedString.Push(c);
            }

            while (reversedString.Count != 0)
            {
                Console.Write(reversedString.Pop());
            }
            Console.WriteLine();
        }
    }
}
