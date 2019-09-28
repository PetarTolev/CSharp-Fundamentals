namespace P06_Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == playerName);

            if (player != null)
            {
                this.players.Remove(player);
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
            }
        }

        public double CalculateRating()
        {
            double totalRating = 0;

            foreach (var player in this.players)
            {
                totalRating += player.CalculateRating();
            }

            return Math.Ceiling(totalRating / this.players.Count);
        }
    }
}
