namespace Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsWithPass = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> usersProps = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] props = input.Split(":");
                string nameOfContest = props[0];
                string passOfContest = props[1];

                if (!contestsWithPass.ContainsKey(nameOfContest))
                {
                    contestsWithPass.Add(nameOfContest, passOfContest);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] props = input.Split("=>");
                string nameOfContest = props[0];
                string passOfContest = props[1];
                string username = props[2];
                int points = int.Parse(props[3]);

                if (contestsWithPass.ContainsKey(nameOfContest) && contestsWithPass[nameOfContest] == passOfContest)
                {
                    if (usersProps.ContainsKey(username))
                    {
                        if (usersProps[username].ContainsKey(nameOfContest))
                        {
                            if (usersProps[username][nameOfContest] < points)
                            {
                                usersProps[username][nameOfContest] = points;
                            }
                        }
                        else
                        {
                            usersProps[username].Add(nameOfContest, points);
                        }
                    }
                    else
                    {
                        var contestWithPoints = new Dictionary<string, int>();
                        contestWithPoints.Add(nameOfContest, points);

                        usersProps.Add(username, contestWithPoints);
                    }
                }
            }

            string nameOfBestCandidate = "";
            int pointOfBestCandicate = 0;

            foreach (var user in usersProps)
            {
                if (pointOfBestCandicate < user.Value.Values.Sum())
                {
                    nameOfBestCandidate = user.Key;
                    pointOfBestCandicate = user.Value.Values.Sum();
                }
            }

            Console.WriteLine($"Best candidate is {nameOfBestCandidate} with total {pointOfBestCandicate} points.");
            Console.WriteLine("Ranking: ");

            foreach (var kvpUsers in usersProps.OrderBy(x => x.Key))
            {
                string name = kvpUsers.Key;
                Dictionary<string, int> contestWithPoints = kvpUsers.Value;

                Console.WriteLine(name);

                foreach (var kvpContestWithPoints in contestWithPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {kvpContestWithPoints.Key} -> {kvpContestWithPoints.Value}");
                }
            }
        }
    }
}
