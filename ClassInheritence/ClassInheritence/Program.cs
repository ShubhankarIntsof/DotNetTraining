using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(11,"Shubham");
            Console.WriteLine($"Age is : {stu.Age} and name is: {stu.Name}");

            stu[0] = "hari"; ;
            stu[1] = "Mike";
            stu[2] = "Bob";
            stu[3] = "Kumar";


            for (int i=0; i<7; i++)
            {
                Console.WriteLine(stu[i]);
            }

            //Console.WriteLine(stu[0]);
            //Console.WriteLine(stu[1]);
            //Console.WriteLine();
        }
    }
}
