using System;

namespace MemoryManagement_NonDotNet_
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex C = new Complex();
            C.SetValue(2, 4);
            C.Display();
        }
    }
}
