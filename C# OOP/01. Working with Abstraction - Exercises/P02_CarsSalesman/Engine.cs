namespace P02_CarsSalesman
{
    using System.Text;

    public class Engine
    {
        private const string defaultEfficiencyValue = "n/a";
        private const int defaultDisplacementValue = -1;

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
            : this(model, power, defaultDisplacementValue, defaultEfficiencyValue)
        {
        }

        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, defaultEfficiencyValue)
        {
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power, defaultDisplacementValue, efficiency)
        {
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Model
        {
            get { return this.model; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {this.model}:");
            sb.AppendLine($"    Power: {this.power}");
            string displacement = this.displacement == defaultDisplacementValue ? defaultEfficiencyValue : this.displacement.ToString();
            sb.AppendLine($"    Displacement: {displacement}");
            sb.AppendLine($"    Efficiency: {this.efficiency}");

            return sb.ToString();
        }
    }
}