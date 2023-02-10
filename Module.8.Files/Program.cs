using System;
using System.Collections.Generic;

namespace Module._8.Files
{
    class Disk
    {
        public string Name { get; set; }
        public long Volume { get; set; }
        public long FreeSpace { get; set; }

        public Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public Disk(string Name, long Volume, long FreeSpace)
        {
            this.Name = Name;
            this.Volume = Volume;
            this.FreeSpace = FreeSpace;
        }

        public void CreateFolder(string FolderName)
        {
            Folders.Add(FolderName, new Folder());
        }

    }

    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
        public string Name { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var disk = new Disk("C", 1024, 512);
            disk.CreateFolder("Новая папка");
            disk.CreateFolder("Новая папка1");
            disk.CreateFolder("Новая папка2");
            disk.CreateFolder("Новая папка3");

            Console.WriteLine(disk.Folders.Count);

        }
    }
}
