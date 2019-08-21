namespace Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNSX = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int s = inputNSX[1];
            int x = inputNSX[2];

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(nums);

            for (int i = 0; i < s; i++)
            {
                if (stack.Count != 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count != 0)
                {
                    Console.WriteLine(stack.Min());
                    return;
                }
                Console.WriteLine(0);
            }
        }
    }
}
