using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Calulation c1 = new Calulation();
            Console.WriteLine(c1.add(3, 5));
            Console.WriteLine(c1.add(3.44f, 5.99f));
            //Console.WriteLine(c1.subtract(3, 5));

        }
    }
}
