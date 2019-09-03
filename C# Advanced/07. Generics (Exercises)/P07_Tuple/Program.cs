namespace P07_Tuple
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] firstInput = Console.ReadLine().Split();
            string firstName = firstInput[0];
            string secondNames = firstInput[1];
            string address = firstInput[2];

            string name = $"{firstName} {secondNames}";

            Tuple<string, string> firstTuple = new Tuple<string, string>(name, address);

            string[] secondInput = Console.ReadLine().Split();
            string name2 = secondInput[0];
            int liters = int.Parse(secondInput[1]);

            Tuple<string, int> secondTuple = new Tuple<string, int>(name2, liters);

            string[] thirdInput = Console.ReadLine().Split();
            int integer = int.Parse(thirdInput[0]);
            double number = double.Parse(thirdInput[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(integer, number);

            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());
        }
    }
}
