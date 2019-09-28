namespace P03_WildFarm.Models.Foods
{
    public class Fruit : Food
    {
        public Fruit(int quantity)
        {
            base.Type = "Fruit";
            base.Quantity = quantity;
        }
    }
}
