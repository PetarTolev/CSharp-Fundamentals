namespace P03_Stack
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = input[0];
                string[] elements = input.Skip(1).ToArray();

                switch (command)
                {
                    case "Pop":
                        if (stack.Count() == 0)
                        {
                            Console.WriteLine("No elements");
                            break;
                        }
                        else
                        {
                            stack.Pop();
                        }
                        break;

                    case "Push":

                        stack.Push(elements);
                        break;

                    case "END":
                        foreach (var element in stack)
                        {
                            Console.WriteLine(element);
                        }

                        foreach (var element in stack)
                        {
                            Console.WriteLine(element);
                        }
                        return;
                }
            }
        }
    }
}