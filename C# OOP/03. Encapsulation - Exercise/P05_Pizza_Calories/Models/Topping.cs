namespace P05_Pizza_Calories.Models
{
    using System;

    public class Topping
    {
        private const string meetType = "meat";
        private const string veggiesType = "veggies";
        private const string cheeseType = "cheese";
        private const string sauceType = "sauce";

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;

            private set
            {
                if (value.ToLower() != meetType && 
                    value.ToLower() != veggiesType && 
                    value.ToLower() != cheeseType &&
                    value.ToLower() != sauceType)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private double GetMultiplier()
        {
            switch (this.type.ToLower())
            {
                case meetType:
                    return 1.2;
                case veggiesType:
                    return 0.8;
                case cheeseType:
                    return 1.1;
                case sauceType:
                    return 0.9;
            }

            return 0;
        }

        public double CalculateCalories()
        {
            double result = this.weight * 2 * GetMultiplier();

            return result;
        }
    }
}
