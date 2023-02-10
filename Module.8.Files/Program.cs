using System;
using System.IO;

namespace Module._8.Files
{
    class Program
    {
        static void DirCounter(string dir, out int count)
        {
            count = 0;
            try
            {
                var dirs = Directory.GetDirectories(dir);
                var files = Directory.GetFiles(dir);
                count = dirs.Length + files.Length;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            string dir = @"C:\9787";

            DirCounter(dir, out int count);

            Console.Write($"Количество файлов и папок: {count}");

        }
    }
}
