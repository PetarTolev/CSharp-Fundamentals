namespace P13_TriFunction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();

            Func<string, char[]> stringToCharArr = x => x.ToCharArray();
            Func<char, int> charToInt = x => (int)x;
            Func<string, bool> finalFunc = x => stringToCharArr(x).Select(charToInt).Sum() >= n;

            Console.WriteLine(input.FirstOrDefault(finalFunc));
        }
    }
}
