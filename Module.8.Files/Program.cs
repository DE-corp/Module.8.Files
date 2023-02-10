using System;
using System.IO;

namespace Module._8.Files
{
    class Program
    {
        static void DirCounter(string dir)
        {
            try
            {
                var dirInfo = new DirectoryInfo(dir);
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                var newDirectory = new DirectoryInfo(dir + "Новая директория");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

                newDirectory.Delete();
                Console.WriteLine("Директория удалена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            string dir = @"C:\";
            DirCounter(dir);
        }
    }
}
