namespace Simple_Calculator
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");

            Stack<string> nums = new Stack<string>();

            foreach (var obj in input)
            {
                nums.Push(obj);
            }

            int sum = 0;

            while (nums.Count != 0)
            {
                int num = int.Parse(nums.Pop());

                if (nums.Count == 0)
                {
                    sum += num;
                    break;
                }

                if (nums.Peek() == "-")
                {
                    sum -= num;
                    nums.Pop();
                }
                else if (nums.Peek() == "+")
                {
                    sum += num;
                    nums.Pop();
                }
            }
            Console.WriteLine(sum);
        }
    }
}
