namespace P03_WildFarm.Models.Foods
{
    public class Meat : Food
    {
        public Meat(int quantity)
        {
            base.Type = "Meat";
            base.Quantity = quantity;
        }
    }
}
