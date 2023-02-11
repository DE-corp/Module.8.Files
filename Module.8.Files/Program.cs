using System.IO;
using System;


namespace Module._8.Files
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Dell\Desktop\C#\Apps\Module.8.Files\Module.8.Files\Program.cs";
            var sw = File.OpenText(FilePath);
            var text = sw.ReadToEnd();

            Console.WriteLine(text);
        }
    }
}
