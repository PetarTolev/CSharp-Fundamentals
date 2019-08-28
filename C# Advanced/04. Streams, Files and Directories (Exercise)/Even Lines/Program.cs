namespace Even_Lines
{
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (count % 2 == 0)
                    {
                        Regex pattern = new Regex(@"[-.,!?']");
                        line = pattern.Replace(line, "@");

                        using (var writer = new StreamWriter(@"../../../output.txt", true))
                        {
                            writer.WriteLine(string.Join(" ", line.Split().Reverse()));
                        }
                    }

                    count++;
                }
            }
        }
    }
}
