namespace P05_Pizza_Calories.Models
{
    using System;

    public class Dough
    {
        private const string whiteFloorType = "white";
        private const string wholegrainFloorType = "wholegrain";

        private const string crispyBackingTechniqueType = "crispy";
        private const string chewyBackingTechniqueType = "chewy";
        private const string homemadeBackingTechniqueType = "homemade";

        private string flourType;
        private string backingTechnique;
        private double weight;

        public Dough(string flourType, string backingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BackingTechnique = backingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;

            private set
            {
                if (value.ToLower() != whiteFloorType && value.ToLower() != wholegrainFloorType)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BackingTechnique
        {
            get => this.backingTechnique;

            private set
            {
                if (value.ToLower() != crispyBackingTechniqueType && 
                    value.ToLower() != chewyBackingTechniqueType && 
                    value.ToLower() != homemadeBackingTechniqueType)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.backingTechnique = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        private double GetWeightModifier()
        {
            double weight = 1;

            switch (this.flourType.ToLower())
            {
                case whiteFloorType:
                    weight *= 1.5;
                    break;
                case wholegrainFloorType:
                    weight *= 1;
                    break;
            }

            switch (this.backingTechnique.ToLower())
            {
                case crispyBackingTechniqueType:
                    weight *= 0.9;
                    break;
                case chewyBackingTechniqueType:
                    weight *= 1.1;
                    break;
                case homemadeBackingTechniqueType:
                    weight *= 1;
                    break;
            }

            return weight;
        }

        public double CalculateCalories()
        {
            double calories = 2 * this.weight * GetWeightModifier();

            return calories;
        }
    }
}
