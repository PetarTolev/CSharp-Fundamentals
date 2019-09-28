namespace P03_WildFarm.Factories
{
    using Models;
    using Models.Animals.Birds;
    using Models.Animals.Mammals;
    using Models.Animals.Mammals.Felines;
    using System;

    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string input)
        {
            string[] props = input
                .Split();

            string type = props[0];
            string name = props[1];
            double weight = double.Parse(props[2]);
            string livingRegion;

            if (type == "Owl" || type == "Hen") //birds
            {
                double wingSize = double.Parse(props[3]);

                switch (type)
                {
                    case "Owl":
                        return new Owl(name, weight, wingSize);
                    case "Hen":
                        return new Hen(name, weight, wingSize);
                }
            }
            else if (type == "Mouse" || type == "Dog") //mammal
            {
                livingRegion = props[3];

                switch (type)
                {
                    case "Mouse":
                        return new Mouse(name, weight, livingRegion);
                    case "Dog":
                        return new Dog(name, weight, livingRegion);
                }
            }
            else if (type == "Cat" || type == "Tiger") //feline
            {
                livingRegion = props[3];
                string breed = props[4];

                switch (type)
                {
                    case "Cat":
                        return new Cat(name, weight, livingRegion, breed);
                    case "Tiger":
                        return new Tiger(name, weight, livingRegion, breed);
                }
            }
            else
            {
                throw new ArgumentException($"{type} is not a valid Animal type.");
            }

            return null;
        }
    }
}
