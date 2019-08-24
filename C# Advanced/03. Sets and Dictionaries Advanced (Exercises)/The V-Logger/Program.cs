namespace The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, VlogersData> vloggers = new Dictionary<string, VlogersData>();

            while (true)
            {
                string lineFromInput = Console.ReadLine();

                if (lineFromInput == "Statistics")
                {
                    break;
                }

                string[] propsFromInput = lineFromInput.Split();
                string vloger = propsFromInput[0];
                string command = propsFromInput[1];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(vloger))
                    {
                        vloggers.Add(vloger, new VlogersData());
                    }
                }
                else if (command == "followed")
                {
                    string follower = propsFromInput[2];

                    if (vloggers.ContainsKey(vloger) && 
                        vloggers.ContainsKey(follower) &&
                        !vloggers[follower].Followers.Contains(vloger) &&
                        vloger != follower)
                    {
                        vloggers[vloger].Following.Add(follower);
                        vloggers[follower].Followers.Add(vloger);
                    }
                }
            }
            
            int count = 1;

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                Dictionary<string, VlogersData> kvpDictionary = new Dictionary<string, VlogersData>();

                if (count == 1)
                {
                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

                    if (vlogger.Value.Followers.Any())
                    {
                        foreach (var follower in vlogger.Value.Followers.OrderBy(x => x))
                        {
                            Console.WriteLine($"*  {follower}");
                        }
                    }

                    count++;
                    continue;
                }

                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

                count++;
            }
        }
    }

    class VlogersData
    {
        public List<string> Following { get; set; } = new List<string>();

        public List<string> Followers { get; set; } = new List<string>();
    }
}
