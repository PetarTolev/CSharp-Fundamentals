namespace Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            using (var textReader = new StreamReader(@"..\..\..\03. Word Count\text.txt"))
            {
                while (true)
                {
                    Regex rgx = new Regex("[^a-zA-Z0-9 ]");

                    var text = textReader.ReadLine();

                    if (text == null)
                    {
                        break;
                    }

                    string[] input = rgx.Replace(text, "")
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.ToLower())
                        .ToArray();

                    List<string> words = new List<string>();

                    using (var wordsReader = new StreamReader(@"..\..\..\03. Word Count\words.txt"))
                    {
                        words = wordsReader.ReadToEnd().Split().ToList();
                    }

                    foreach (var w in input)
                    {
                        if (words.Contains(w))
                        {
                            if (result.ContainsKey(w))
                            {
                                result[w]++;
                            }
                            else
                            {
                                result.Add(w, 1);
                            }
                        }
                    }
                }
            }

            using (var writer = new StreamWriter(@"..\..\..\03. Word Count\Output.txt", true))
            {
                foreach (var kvp in result.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
