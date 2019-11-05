namespace SoftUniParking
{
    using System.Linq;
    using System.Collections.Generic;

    public class Parking
    {
        private List<Car> cars;
        private readonly int capacity;

        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }

        public int Count
        {
            get => this.cars.Count;
        }

        public string AddCar(Car car)
        {
            if (this.cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (this.cars.Count == this.capacity)
            {
                return "Parking is full!";
            }

            cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                int index = this.cars.FindIndex(x => x.RegistrationNumber == registrationNumber);
                this.cars.RemoveAt(index);

                return $"Successfully removed {registrationNumber}";
            }
            return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string registrationNumber)
        {
            int index = this.cars.FindIndex(x => x.RegistrationNumber == registrationNumber);

            return this.cars[index];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                this.RemoveCar(registrationNumber);
            }
        }
    }
}
