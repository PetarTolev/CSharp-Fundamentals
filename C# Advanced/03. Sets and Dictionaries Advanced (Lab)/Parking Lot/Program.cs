namespace Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputProps = input.Split(",");
                string direction = inputProps[0];
                string carNumber = inputProps[1];

                if (direction == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else
                {
                    carNumbers.Remove(carNumber);
                }
            }

            if (carNumbers.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, carNumbers));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
