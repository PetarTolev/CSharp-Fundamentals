namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food
    {
        protected Food(string symbol, int foodPoints, Coordinate coordinate)
        {
            this.FoodSymbol = symbol;
            this.FoodPoints = foodPoints;
            this.FoodCoordinate = coordinate;
        }

        public int FoodPoints { get; set; }

        public string FoodSymbol { get; set; }

        public Coordinate FoodCoordinate { get; set; }

    }
}
