using System;

namespace delegate_practice
{
    
    internal class Program
    {
        public delegate void delmethod();//Declaration of Delegates
        public static void display()
        {
            Console.WriteLine("Inside Display()");
        }
        public static void show()
        {
            Console.WriteLine("Inside Show()");
        }

        public void print()
        {
            Console.WriteLine("We are in Print");          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Single Cast Delegates");
            //Assigning static methods

            delmethod del1 = Program.show;
            delmethod del2 = new delmethod(Program.display);

            Program obj1 = new Program();

            delmethod del3 = obj1.print;

            del1();
            del2();
            del3();

        }
    }
}
