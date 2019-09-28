namespace P03_Ferrari
{
    public class Ferrari : ICar
    {
        public Ferrari(string driversName)
        {
            this.DriversName = driversName;
        }

        public string DriversName { get; set; }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public override string ToString()
        {
            return $"488-Spider/{PushBrakes()}/{PushGasPedal()}/{this.DriversName}";
        }
    }
}
