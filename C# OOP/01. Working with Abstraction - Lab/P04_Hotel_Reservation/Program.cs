namespace P04_Hotel_Reservation
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var pricePerDay = double.Parse(input[0]);
            var numberOfDays = int.Parse(input[1]);
            var season = Enum.Parse<Season>(input[2]);
            var discount = Discount.None;
            
            if (input.Length == 4)
            {
                discount = Enum.Parse<Discount>(input[3]);
            }

            var priceCalculator = new PriceCalculator(pricePerDay, numberOfDays, season, discount);
            Console.WriteLine(priceCalculator.CalculatePrice().ToString("F2"));
        }
    }
}