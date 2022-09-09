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

            fw.ReadData();
        }
    }
}
