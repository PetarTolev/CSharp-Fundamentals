namespace P02_CarsSalesman
{
    using System.Collections.Generic;
    using System.Linq;

    public class CarFactory
    {
        public Car Create(string[] parameters, List<Engine> engines)
        {
            string model = parameters[0];
            string engineModel = parameters[1];
            Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

            var weight = -1;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
            {
                return new Car(model, engine, weight);
            }
            else if (parameters.Length == 3)
            {
                var color = parameters[2];

                return new Car(model, engine, color);
            }
            else if (parameters.Length == 4)
            {
                var color = parameters[3];

                return new Car(model, engine, int.Parse(parameters[2]), color);
            }
            else
            {
                return new Car(model, engine);
            }
        }
    }
}