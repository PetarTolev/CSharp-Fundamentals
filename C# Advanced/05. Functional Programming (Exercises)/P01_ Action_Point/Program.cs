namespace P01_Action_Point
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Action<string> Printing = s => Console.WriteLine(s);

            Console.ReadLine().Split().ToList().ForEach(Printing);
        }
    }
}
