namespace SimpleSnake.GameObjects.Foods
{
    public class FoodDollar : Food
    {
        private const int Points = 2;
        private const string Symbol = "$";

        public FoodDollar(Coordinate coordinate)
            : base(Symbol, Points, coordinate)
        {
        }
    }
}
