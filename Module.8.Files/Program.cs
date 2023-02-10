using System;

namespace Module._8.Files
{
    class Disk
    {
        public string Name { get; set; }
        public long Volume { get; set; }
        public long FreeSpace { get; set; }

        public Disk(string Name, long Volume, long FreeSpace)
        {
            this.Name = Name;
            this.Volume = Volume;
            this.FreeSpace = FreeSpace;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Disk disk = new Disk("C", 1024, 512);
        }
    }
}
