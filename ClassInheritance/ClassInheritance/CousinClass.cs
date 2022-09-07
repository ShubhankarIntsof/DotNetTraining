using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class CousinClass : BaseClass
    {
        private string name;
        private int age;
        public CousinClass()
        {
            Console.WriteLine("Inside Cousin Class");

        }
        public CousinClass(String name, int age)
        {
            this.name = name;
            this.age = age;
            

            Console.WriteLine("Inside Cousin Class");
            

        }

        public void read()
        {
            Console.WriteLine($"Name is {name} age is {age}");
        }


    }
}
