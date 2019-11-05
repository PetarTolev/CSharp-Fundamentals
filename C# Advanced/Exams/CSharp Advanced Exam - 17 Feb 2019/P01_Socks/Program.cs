namespace P01_Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] leftInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] rightInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            Stack<int> leftStack = new Stack<int>(leftInput);
            Stack<int> rightStack = new Stack<int>(rightInput);

            List<int> pairs = new List<int>();

            while (leftStack.Any() && rightStack.Any())
            {
                int leftNum = leftStack.Peek();
                int rightNum = rightStack.Peek();

                if (leftNum < rightNum)
                {
                    leftStack.Pop();
                }
                else if (leftNum > rightNum)
                {
                    pairs.Add(leftStack.Pop() + rightStack.Pop());
                }
                else
                {
                    rightStack.Pop();
                    leftStack.Push(leftStack.Pop() + 1);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}