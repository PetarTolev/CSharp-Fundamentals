namespace PersonsInfo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfPlayers = int.Parse(Console.ReadLine());

            Team team = new Team("");

            for (int i = 0; i < numberOfPlayers; i++)
            {
                string[] playerProps = Console.ReadLine().Split();
                string firstName = playerProps[0];
                string lastName = playerProps[1];
                int age = int.Parse(playerProps[2]);
                decimal salary = decimal.Parse(playerProps[3]);

                Person person = new Person(firstName, lastName, age, salary);

                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
