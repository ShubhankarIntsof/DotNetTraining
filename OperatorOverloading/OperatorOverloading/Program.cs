using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Calculator c1 = new Calculator(10, 20);
            c1.Print(); 
            Calculator c2 = new Calculator(20, 30);
            c2.Print();
            Calculator c4 = new Calculator(11, 22);
            c4.Print();
            Calculator c3 = new Calculator();
            c3.Print();
            c3 = c1 + c2;
            c3.Print(); 
        }
    }
}
