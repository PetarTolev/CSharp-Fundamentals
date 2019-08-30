namespace Folder_Size
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            var dir = new DirectoryInfo(@"..\..\..\06. Folder Size\TestFolder\TestFolder2");

            double folderSizeSum = 0;

            foreach (var file in dir.GetFiles())
            {
                folderSizeSum += file.Length;
            }

            using (var writer = new StreamWriter(@"..\..\..\06. Folder Size\output.txt"))
            {
                writer.WriteLine(folderSizeSum / 1024 / 1024);
            }
        }
    }
}
