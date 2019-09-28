namespace P01_Rhombus_of_Stars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                PrintRow(i, num);
            }

            for (int i = num - 1; i >= 1; i--)
            {
                PrintRow(i, num);
            }
        }

        private static void PrintRow(int row, int n)
        {
            Console.WriteLine($"{new string(' ', n - row)}{new string('s', row).Replace("s", "* ")}");
        }
    }
}