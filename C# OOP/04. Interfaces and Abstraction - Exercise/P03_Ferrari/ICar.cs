namespace P03_Ferrari
{
    public interface ICar
    {
        string DriversName { get; set; }

        string PushBrakes();

        string PushGasPedal();
    }
}
