namespace SoftUniParking
{
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make { get => this.make; set => this.make = value; }
        public string Model { get => this.model; set => this.model = value; }
        public int HorsePower { get => this.horsePower; set => this.horsePower = value; }
        public string RegistrationNumber { get => this.registrationNumber; set => this.registrationNumber = value; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Make: {this.Make}");
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"HorsePower: {this.HorsePower}");
            stringBuilder.AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
