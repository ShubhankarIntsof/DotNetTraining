using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{

    class Complex : IDisposable
    {
        int real;
        int imaginary;
        public Complex()
        {
            real = 0;
            imaginary = 1;

        }

        public void SetValue(int x,int y)
        {
            real = x;
            imaginary = y;
        }
        public void Display()
        {
            Console.WriteLine("Real and Imaginary are "+ real + " " + imaginary);
        }

        public void Dispose()
        {
            Dispose(true);
            Console.WriteLine("Dispose() is called to manage unmanaged resources");
            GC.SuppressFinalize(this);
            // it is called to prevent the garbage collector from running the finalizer
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
                Console.WriteLine("Cleaning up all unmanaged resources ");

        }

        ~Complex()
        {
            Console.WriteLine("Destructor is Called");
            Dispose(false);

        }

    }
}
