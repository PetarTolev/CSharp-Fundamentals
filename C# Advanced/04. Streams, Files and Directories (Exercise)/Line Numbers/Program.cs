namespace Line_Numbers
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = 1;

            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    int punctuationCount = 0;
                    int characterCount = 0;
                    var lineArr = line.ToCharArray();

                    foreach (var c in lineArr)
                    {
                        if (char.IsPunctuation(c))
                        {
                            punctuationCount++;
                        }
                        else if (!char.IsWhiteSpace(c))
                        {
                            characterCount++;
                        }
                    }

                    using (var writer = new StreamWriter(@"../../../output.txt", true))
                    {
                        writer.WriteLine($"Line {lineCount}: {line} ({characterCount})({punctuationCount})");
                    }

                    lineCount++;
                }
            }
        }
    }
}
