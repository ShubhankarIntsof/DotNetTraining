using System;

namespace Demo_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car obj = new Car();
            Console.WriteLine($"Hello World! My Car's color is {obj.color}");

        }
    }
    class Car
    {
        public string color = "Blue";
    }
}
