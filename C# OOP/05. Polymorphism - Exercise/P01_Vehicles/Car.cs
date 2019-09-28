namespace P01_Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConspumption) 
            : base (fuelQuantity, fuelConspumption)
        {
            base.fuelConsupmtion += 0.9;
        }

        public override string Drive(double distance)
        {
            return $"Car {base.Drive(distance)}";
        }
    }
}
