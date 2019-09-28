namespace P02_VehiclesExtension
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConspumption, double tankCapacity) 
            : base (fuelQuantity, fuelConspumption, tankCapacity)
        {
            base.FuelConsumption += 0.9;
        }

        public override string Drive(double distance)
        {
            return $"Car {base.Drive(distance)}";
        }
    }
}
