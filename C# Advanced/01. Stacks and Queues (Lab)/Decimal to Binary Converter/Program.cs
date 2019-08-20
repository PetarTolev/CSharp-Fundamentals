namespace Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            Stack<int> binaryNum = new Stack<int>();

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    binaryNum.Push(0);
                    num /= 2;
                }
                else
                {
                    binaryNum.Push(1);
                    num /= 2;
                }
            }

            Console.WriteLine(string.Join("", binaryNum));
        }
    }
}
