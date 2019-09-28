namespace P02_CarsSalesman
{
    using System.Text;

    public class Car
    {
        private const int defaultWeightValue = -1;
        private const string defaultColorValue = "n/a";

        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
            : this(model, engine, defaultWeightValue, defaultColorValue)
        {
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine, weight, defaultColorValue)
        {
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine, defaultWeightValue, color)
        {
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.model}:");
            sb.Append(this.engine);
            string weight = this.weight == -1 ? "n/a" : this.weight.ToString();
            sb.AppendLine($"  weight: {weight}");
            sb.AppendLine($"  color: {this.color}");

            return sb.ToString().TrimEnd();
        }
    }
}