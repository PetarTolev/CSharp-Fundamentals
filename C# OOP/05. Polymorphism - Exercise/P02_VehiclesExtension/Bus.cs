namespace P02_VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsupmtion, double tankCapacity) 
            : base(fuelQuantity, fuelConsupmtion, tankCapacity)
        {
            base.FuelConsumption += 1.4;
        }

        public string DriveEmpty(double distance)
        {
            double consumptionWithoutPeople = base.FuelConsumption -= 1.4;

            double consumedFuel = distance * consumptionWithoutPeople;

            if (this.FuelQuantity < consumedFuel)
            {
                return "Bus needs refueling";
            }

            this.FuelQuantity -= consumedFuel;
            return $"Bus travelled {distance} km";
        }

        public override string Drive(double distance)
        {
            return $"Bus {base.Drive(distance)}";
        }
    }
}
