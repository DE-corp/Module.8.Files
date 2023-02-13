using System.IO;
using System;


namespace Module._8.Files
{
    class Program
    {

        static void Main(string[] args)
        {
            string FilePath = "BinaryFile.bin";
            if (File.Exists(FilePath))
            {
                using (BinaryReader br = new BinaryReader(new FileStream(FilePath, FileMode.Open)))
                {
                    Console.WriteLine(br.ReadString());
                }
            }
        }
    }
}

