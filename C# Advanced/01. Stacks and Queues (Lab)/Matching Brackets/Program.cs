namespace Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    for (int j = indexes.Peek(); j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                    indexes.Pop();
                }
            }
        }
    }
}