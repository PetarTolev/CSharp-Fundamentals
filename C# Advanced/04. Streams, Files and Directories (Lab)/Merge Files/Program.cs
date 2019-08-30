namespace Merge_Files
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> fileOne = new List<int>();
            List<int> fileTwo = new List<int>();

            using (var reader = new StreamReader("../../../04. Merge Files/FileOne.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    fileOne.Add(int.Parse(line));
                }
            }

            using (var reader = new StreamReader("../../../04. Merge Files/FileTwo.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    fileTwo.Add(int.Parse(line));
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Max(fileOne.Count, fileTwo.Count); i++)
            {
                if (fileOne.Count > i)
                {
                    result.Add(fileOne[i]);
                }

                if (fileTwo.Count > i)
                {
                    result.Add(fileTwo[i]);
                }
            }

            using (var writer = new StreamWriter("../../../04. Merge Files/output.txt"))
            {
                foreach (var r in result)
                {
                    writer.WriteLine(r);
                }
            }
        }
    }
}
