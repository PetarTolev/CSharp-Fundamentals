namespace P03_WildFarm.Factories
{
    using Models;
    using Models.Foods;
    using System;

    public static class FoodFactory
    {
        public static Food CreateFood(string input)
        {
            string[] props = input
                .Split();
            string type = props[0];
            int quantity = int.Parse(props[1]);

            switch (type)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Fruit":
                    return new Fruit(quantity);
                case "Meat":
                    return new Meat(quantity);
                case "Seeds":
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException("Invalid food!");
            }
        }
    }
}
