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
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (var wordsReader = new StreamReader(@"../../../words.txt"))
            {
                while (true)
                {
                    string word = wordsReader.ReadLine();

                    if (word == null)
                    {
                        break;
                    }
                    
                    words.Add(word, 0);
                }
            }

            using (var textReader = new StreamReader(@"../../../text.txt"))
            {
                while (true)
                {
                    string line = textReader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    Regex pattern = new Regex(@"[-,.?!]");
                    line = pattern.Replace(line, "");

                    string[] splitedLine = line.ToLower().Split();

                    foreach (var word in splitedLine)
                    {
                        if (words.ContainsKey(word))
                        {
                            words[word]++;
                        }
                    }
                }
            }

            using (var writer = new StreamWriter(@"../../../actualResult.txt"))
            {
                foreach (var kvp in words.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }

            using (var expectedResultReader = new StreamReader(@"../../../expectedResult.txt"))
            {
                var expectedResult = expectedResultReader.ReadToEnd();

                using (var actualResultReader = new StreamReader(@"../../../actualResult.txt"))
                {
                    var actualResult = actualResultReader.ReadToEnd();

                    if (expectedResult == actualResult)
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
            }
        }
    }
}
