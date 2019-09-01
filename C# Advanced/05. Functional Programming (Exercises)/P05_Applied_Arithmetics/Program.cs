namespace P05_Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> add = x => x.Select(n => n += 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(n => n *= 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(n => n -= 1).ToList();
            Action<List<int>> printNums = x => Console.WriteLine(string.Join(" ", x));

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    nums = add(nums);
                }
                else if (command == "multiply")
                {
                    nums = multiply(nums);
                }
                else if (command == "subtract")
                {
                    nums = subtract(nums);
                }
                else if (command == "print")
                {
                    printNums(nums);
                }
            }
        }
    }
}
