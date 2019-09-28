namespace P06_Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                Team team;

                string[] splitedInput = input
                    .Split(';');
                string command = splitedInput[0];
                string teamName = splitedInput[1];
                string playerName;

                try
                {
                    switch (command)
                    {
                        case "Team":
                            team = new Team(teamName);

                            teams.Add(team);
                            break;
                        case "Add":

                            team = teams.FirstOrDefault(x => x.Name == teamName);

                            if (team != null)
                            {
                                playerName = splitedInput[2];
                                double endurance = double.Parse(splitedInput[3]);
                                double sprint = double.Parse(splitedInput[4]);
                                double dribble = double.Parse(splitedInput[5]);
                                double passing = double.Parse(splitedInput[6]);
                                double shooting = double.Parse(splitedInput[7]);

                                Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                                team.AddPlayer(player);
                            }
                            else
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }

                            break;
                        case "Remove":
                            playerName = splitedInput[2];

                            team = teams.FirstOrDefault(x => x.Name == teamName);

                            if (team != null)
                            {
                                team.RemovePlayer(playerName);
                            }
                            else
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }

                            break;
                        case "Rating":

                            team = teams.FirstOrDefault(x => x.Name == teamName);

                            if (team != null)
                            {
                                double rating = team.CalculateRating();

                                if (double.IsNaN(rating))
                                {
                                    Console.WriteLine($"{teamName} - {0}");
                                }
                                else
                                {
                                    Console.WriteLine($"{teamName} - {rating}");
                                }
                            }
                            else
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                
            }

            

        }

    }
}
