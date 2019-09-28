namespace P03_WildFarm.Models.Foods
{
    public class Seeds: Food
    {
        public Seeds(int quantity)
        {
            base.Type = "Seeds";
            base.Quantity = quantity;
        }
    }
}
