using System.IO;
using System;


namespace Module._8.Files
{
    class Program
    {
        static readonly string FilePath = "BinaryFile.bin";

        static void BinaryRead()
        {
            if (File.Exists(FilePath))
            {
                using BinaryReader br = new(new FileStream(FilePath, FileMode.Open));
                Console.WriteLine(br.ReadString());
            }
        }

        static void BinaryWrite()
        {
            using BinaryWriter br = new(new FileStream(FilePath, FileMode.Open));
            br.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
        }

        static void Main(string[] args)
        {
            BinaryWrite();
            BinaryRead();
        }
    }
}

