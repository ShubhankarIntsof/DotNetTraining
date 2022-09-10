using System;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Working with Streams");
            FileWrite fw = new FileWrite();
            //fw.WriteData();
            Console.WriteLine("Reading Data from the file");
            fw.ReadData();
        }
    }
}
