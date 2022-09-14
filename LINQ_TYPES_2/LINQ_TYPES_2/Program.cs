using System;
using System.Collections.Generic;
using System.Linq; // Provides class and interfaces that support linq queries
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TYPES_2
    // LINQ DEMONSTRATION
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num= new int[] { 0, 2, 1, 5, 9, 12 };
            var result = from a in num where a < 4 orderby a select a;//known as LINQ Expression
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
        }
    }
}
