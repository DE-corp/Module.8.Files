using Microsoft.VisualBasic.FileIO;
using System;


namespace Module._8.Files
{
    class Program
    {
        static void ToTrash(string inputdir)
        {
            FileSystem.DeleteDirectory(inputdir, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }
    
        static void Main(string[] args)
        {
            string indir = @"C:\Users\Dell\Desktop\Тестовая папка";
            ToTrash(indir);
        }
    }
}
