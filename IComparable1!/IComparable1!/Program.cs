using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IComparable1_.Car;

namespace IComparable1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] arrayofCars = new Car[3]
            {
                new Car("Bonda",1977),
                new Car("Cord",1932),
                new Car("Aiat",1988),

            };

            //Array.Sort(arrayofCars);

            CarMakeComparer carComparer = new CarMakeComparer();
            CarMakeComparerDesc carComparerDesc = new CarMakeComparerDesc();

            Array.Sort(arrayofCars, carComparerDesc);

            foreach (Car c in arrayofCars)
            {
                Console.WriteLine(c.name + "\t\t" + c.year);
            }
        }
    }
}
