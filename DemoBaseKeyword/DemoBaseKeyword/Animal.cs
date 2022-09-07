using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBaseKeyword
{
    internal class Animal
    {
        public string Color = "Yellow";
        public virtual void Speak()
        {
            Console.WriteLine("Animals Speak From their heart !!!");
           // return "Animals Speak From their heart !!!";
        }
    }

    class Dog : Animal
    {
        public string Color = "Black";

        public override void Speak()
        {
            Console.WriteLine("Dogs are very talkative");
            Console.WriteLine("base class speak method() says");
             base.Speak();

        }

        public void showColor()
        {
            Console.WriteLine($"Color coming from BaseClass is {base.Color}");
            Console.WriteLine($"Color define in current is {Color}");
        }

    }
    class Labrador : Dog
    {
        public void showColor1()
        {
            string Color = "Brown";
            Console.WriteLine($"Color coming from BaseClass in Labrador is {base.Color}");
            Console.WriteLine($"Color define in current labrador is {Color}");
        }

    }
}

