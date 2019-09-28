namespace P01_RawData
{
    public class Tire
    {
        public Tire(double tirePresure, int tireAge)
        {
            this.TirePresure = tirePresure;
            this.TireAge = tireAge;
        }

        public double TirePresure { get; set; }

        public int TireAge { get; set; }
    }
}