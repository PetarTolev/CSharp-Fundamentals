namespace Stack_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] input = Console.ReadLine().Split();
            string command = input[0].ToLower();

            Stack<int> numsForSum = new Stack<int>(numbers);

            while (command != "end")
            {
                if (command == "add")
                {
                    int firstNum = int.Parse(input[1]);
                    int secondNum = int.Parse(input[2]);

                    numsForSum.Push(firstNum);
                    numsForSum.Push(secondNum);
                }
                else if (command == "remove")
                {
                    int numsForRemove = int.Parse(input[1]);

                    if (numsForRemove < numsForSum.Count)
                    {
                        for (int i = 0; i < numsForRemove; i++)
                        {
                            numsForSum.Pop();
                        }
                    }
                }

                input = Console.ReadLine().Split();
                command = input[0].ToLower();
            }

            Console.WriteLine($"Sum: {numsForSum.Sum()}");
        }
    }
}
