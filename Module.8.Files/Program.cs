using System.IO;
using System;


namespace Module._8.Files
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Dell\Desktop\C#\Apps\Module.8.Files\Module.8.Files\Program.cs";
            var fileInfo = new FileInfo(FilePath);

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"Время последнего запуска: {DateTime.Now}");
            }

            using StreamReader sr = fileInfo.OpenText();
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}

