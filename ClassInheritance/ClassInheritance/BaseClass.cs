using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class BaseClass
    {
        public string name;
        public string subject;
        
        public BaseClass()
        {
            Console.WriteLine("You are inside Base Class");
        }

        public void read(string name, string subject)
        {
            this.name = name;
            this.subject = subject;

            Console.WriteLine($"I am {name} and my subject is {subject}");
        }


    }
    class Child : BaseClass {

        public Child()
        {
            Console.WriteLine("This is Child Class");

        }
    }

    class GrandChild : Child
    {
        public GrandChild()
        {
            Console.WriteLine("I am on multi level Inheritance");
        }
    }

}
