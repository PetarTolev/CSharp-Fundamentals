namespace SimpleSnake.GameObjects.Foods
{
    public class FoodAsterisk : Food
    {
        private const int Points = 1;
        private const string Symbol = "*";

        public FoodAsterisk(Coordinate coordinate) 
            : base(Symbol, Points, coordinate)
        {
        }
    }
}
