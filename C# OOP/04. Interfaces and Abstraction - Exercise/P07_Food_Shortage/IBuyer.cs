namespace P07_Food_Shortage
{
    public interface IBuyer
    {
        string Name { get; }

        int Food { get; }

        void BuyFood();
    }
}
