namespace P12_Google
{
    using System;

    public class Car
    {
        public Car(string carModel, int carSpeed)
        {
            this.CarModel = carModel;
            this.CarSpeed = carSpeed;
        }

        public string CarModel { get; set; }

        public int CarSpeed { get; set; }

        public override string ToString()
        {
            return $"Car:{Environment.NewLine}{this.CarModel} {this.CarSpeed}";
        }
    }
}
