using System;

namespace AnonymousDelegate
{
    public delegate string MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Delegate");

            MyDelegate Del1 = delegate{
                Console.WriteLine("Anonymous Delegate method Invoked");
                return ("Invoked");
            };

            Console.WriteLine(Del1());
            

        }
    }
}
