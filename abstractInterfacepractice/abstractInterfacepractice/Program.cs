using System;

namespace abstractInterfacepractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            AbstractInterface aI = new AbstractInterface();
            aI.AbsFunction_1();
            Console.WriteLine("---------------");
            aI.AbsFunction_2();
            Console.WriteLine("---------------");
            aI.Function1();
            Console.WriteLine("---------------");
            aI.String_1 = "String 1";
            Console.WriteLine("\n" + aI.String_1);
        }
    }
}
