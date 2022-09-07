using System;

namespace MultiCastDelegate
{
    public delegate void delmethod(int x, int y);
    class Program
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("You are implementing Add()");
            Console.WriteLine(x + y);
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("You are implementing Subtract");
            Console.WriteLine(x - y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MultiCast Delegate");

            Program obj1 = new Program();
            delmethod del1 = obj1.Add;

            delmethod del1 = obj1.Add;

            //Multicasting delegates is like this

            del1 += new delmethod(obj1.Subtract); 

            del1(45, 25);

            Console.WriteLine("After removing red for Add()");

            del1 -= new delmethod(obj1.Add);
            del1(20, 25);


        }
    }
}
