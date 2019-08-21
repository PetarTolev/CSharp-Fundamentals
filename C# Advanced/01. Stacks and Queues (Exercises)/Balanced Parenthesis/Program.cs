namespace Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> parenthesis = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    parenthesis.Push(input[i]);
                }
                else
                {
                    char a = parenthesis.Pop();

                    if (a == 40 && input[i] == 41)
                    {
                        continue;
                    }

                    if (a == 91 && input[i] == 93)
                    {
                         continue;
                    }

                    if (a == 123 && input[i] == 125)
                    {
                        continue;
                    }

                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
