namespace P06_Football_Team_Generator
{
    using System;

    public class Player
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;

        public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public double Endurance
        {
            get => this.endurance;

            private set { this.endurance = ValidateStat(value, nameof(Endurance)); }
        }

        public double Sprint
        {
            get => this.sprint;

            private set { this.sprint = ValidateStat(value, nameof(Sprint)); }
        }

        public double Dribble
        {
            get => this.dribble;

            private set { this.dribble = ValidateStat(value, nameof(Dribble)); }
        }

        public double Passing
        {
            get => this.passing;

            private set { this.passing = ValidateStat(value, nameof(Passing)); }
        }

        public double Shooting
        {
            get => this.shooting;

            private set { this.shooting = ValidateStat(value, nameof(Shooting)); }
        }

        private double ValidateStat(double value, string name)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }

            return value;
        }

        public double CalculateRating()
        {
            double totalRating = (this.endurance + this.sprint + this.dribble + this.passing + this.shooting) / 5;

            return Math.Ceiling(totalRating);
        }
    }
}
