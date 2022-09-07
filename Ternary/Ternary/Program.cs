using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ternary Operator");

            int x = 20;
            int y = 30;
            //String y = "Hello";
            //var result = x == y ? "Equal" : "Not Equal";
            //Console.WriteLine(result);

            //Nested Ternary operator


            var result2 = x == y ? "Equal" :
                           x > y ? "x Greater" :
                            x < y ? "y Greater" : "Something is wrong";
            Console.WriteLine(result2);
        }
    }
}
