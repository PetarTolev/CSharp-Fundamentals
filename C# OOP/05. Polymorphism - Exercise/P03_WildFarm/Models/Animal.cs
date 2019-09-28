namespace P03_WildFarm.Models
{
    public abstract class Animal
    {
        public string Type { get; protected set; }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public virtual string ProduceSound()
        {
            return null;
        }

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.Type} [{this.Name}";
        }
    }
}
