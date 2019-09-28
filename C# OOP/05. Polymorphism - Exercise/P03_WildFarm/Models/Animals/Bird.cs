namespace P03_WildFarm.Models.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, double wingSize)
        {
            base.Name = name;
            base.Weight = weight;
            this.WingSize = wingSize;
        }

        public double WingSize { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + $", {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
