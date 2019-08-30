namespace Line_Numbers
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"..\..\..\02. Line Numbers\Input.txt"))
            {
                using (var writer = new StreamWriter(@"..\..\..\02. Line Numbers\Output.txt", true))
                {
                    int count = 1;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        string newLine = $"{count}. {line}";

                        writer.WriteLine(newLine);

                        count++;
                    }
                }
            }
        }
    }
}
