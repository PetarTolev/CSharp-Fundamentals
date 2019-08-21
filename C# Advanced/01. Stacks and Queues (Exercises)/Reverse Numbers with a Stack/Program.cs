namespace Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var i in input)
            {
                stack.Push(i);
            }

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
