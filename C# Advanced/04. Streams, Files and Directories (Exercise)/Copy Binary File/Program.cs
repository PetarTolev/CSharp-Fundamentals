namespace Copy_Binary_File
{
    using System.IO; 

    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream(@"../../../copyMe.png", FileMode.Open))
            { 
                using (var writer = new FileStream(@"../../../output.png", FileMode.OpenOrCreate))
                {
                    while (true)
                    {
                        byte[] buffer = new byte[4096];

                        int biteSize = reader.Read(buffer, 0, buffer.Length);

                        if (biteSize == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, biteSize);
                    }
                }
            }
        }
    }
}
