using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBaseKeyword
{
    class Program: Animal
    {

        static void Main(string[] args)
        {
            Console.WriteLine("he");
            Dog ginger = new Dog();
            ginger.showColor();
            ginger.Speak();

            Labrador ginger1 = new Labrador();
            ginger1.showColor1();
            






        }
    }
}
