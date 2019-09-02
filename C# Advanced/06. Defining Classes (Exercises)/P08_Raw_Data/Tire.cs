namespace P08_Raw_Data
{
    public class Tire
    {
        public Tire(decimal tirePressure, int tireAge)
        {
            this.TirePressure = tirePressure;
            this.TireAge = tireAge;
        }

        public decimal TirePressure { get; set; }

        public int TireAge { get; set; }
    }
}
