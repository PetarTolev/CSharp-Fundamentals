namespace P04_Hotel_Reservation
{
    public class PriceCalculator
    {
        private double pricePerDay;
        private int numberOfDays;
        private Season season;
        private Discount discount;
        
        public PriceCalculator(double pricePerDay, int numberOfDays, Season season, Discount discount)
        {
            this.pricePerDay = pricePerDay;
            this.numberOfDays = numberOfDays;
            this.season = season;
            this.discount = discount;
        }

        public double CalculatePrice()
        {
            var multiplier = (int) season;
            var discountMultiplier = (double) this.discount / 100;

            var discount = pricePerDay * numberOfDays * multiplier * discountMultiplier;

            var result = pricePerDay * numberOfDays * multiplier - discount;

            return result;
        }
    }
}