namespace P03_WildFarm.Models.Foods
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity)
        {
            base.Type = "Vegetable";
            base.Quantity = quantity;
        }
    }
}
