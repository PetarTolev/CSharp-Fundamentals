namespace P03_Ferrari
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string driversName = Console.ReadLine();

            ICar ferrari = new Ferrari(driversName);

            Console.WriteLine(ferrari);
        }
    }
}
