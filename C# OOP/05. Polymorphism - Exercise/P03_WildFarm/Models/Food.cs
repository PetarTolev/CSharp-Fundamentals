namespace P03_WildFarm.Models
{
    public abstract class Food
    {
        public string Type { get; protected set; }

        public int Quantity { get; protected set; }
    }
}
