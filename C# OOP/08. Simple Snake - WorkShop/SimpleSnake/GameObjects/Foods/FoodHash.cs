namespace SimpleSnake.GameObjects.Foods
{
    public class FoodHash : Food
    {
        private const int Points = 3;
        private const string Symbol = "#";

        public FoodHash(Coordinate coordinate) 
            : base(Symbol, Points, coordinate)
        {
        }
    }
}
