namespace P07_Speed_Racing
{
    public class Car
    {
        public Car(string model, int fuelAmount, decimal fuelConspumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConspumption = fuelConspumption;
            this.TraveledDistance = 0;
        }

        public string Model { get; set; }

        public decimal FuelAmount { get; set; }

        public decimal FuelConspumption { get; set; }

        public int TraveledDistance { get; set; }

        public static bool CanMoveDistance(Car currentCarInformation, int amountOfKm)
        {
            decimal fuelAmount = currentCarInformation.FuelAmount;
            decimal fuelConspumption = currentCarInformation.FuelConspumption;

            if (amountOfKm * fuelConspumption <= fuelAmount)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TraveledDistance}";
        }
    }
}
