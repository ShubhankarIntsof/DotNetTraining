using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    class Program 
    {
        public static void Free()
        {
            Complex C3 = new Complex();
        }
        static void Main(string[] args)
        {
            Complex C = new Complex();
            C.SetValue(2, 4);
            C.Display();
            C.Dispose();


        }

    }
}
