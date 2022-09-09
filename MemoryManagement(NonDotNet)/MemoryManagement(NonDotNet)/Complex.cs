using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement_NonDotNet_
{
    class Complex
    {
        int real;
        int imaginary;
        public Complex()
        {
            real = 0;
            imaginary = 1;

        }

        public void SetValue(int x, int y)
        {
            real = x;
            imaginary = y;
        }
        public void Display()
        {
            Console.WriteLine("Real and Imaginary are " + real + " " + imaginary);
        }
        ~Complex()
        {
            Console.WriteLine("Destructor is Called");

        }
    }
}
