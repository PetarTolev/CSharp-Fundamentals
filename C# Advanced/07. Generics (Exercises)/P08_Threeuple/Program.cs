namespace P08_Threeuple
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] firstInput = Console.ReadLine().Split();
            string name = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];
            string town = firstInput[3];

            Tuple<string, string, string> firstTuple = new Tuple<string, string, string>(name, address, town);

            string[] secondInput = Console.ReadLine().Split();
            string name2 = secondInput[0];
            int number = int.Parse(secondInput[1]);
            bool drunkOrNot = IsDrunk(secondInput[2]);

            Tuple<string, int, bool> secondTuple = new Tuple<string, int, bool>(name2, number, drunkOrNot);

            string[] thirdInput = Console.ReadLine().Split();
            string name3 = thirdInput[0];
            double balance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(name3, balance, bankName);

            Console.WriteLine(firstTuple.ToString());
            Console.WriteLine(secondTuple.ToString());
            Console.WriteLine(thirdTuple.ToString());
        }

        public static bool IsDrunk(string input)
        {
            if (input == "drunk")
            {
                return true;
            }

            return false;
        }
    }
}
