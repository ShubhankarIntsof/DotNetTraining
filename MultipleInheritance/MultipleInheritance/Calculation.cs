using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal interface IBasicCalculator
    {
        int add(int a, int b);
        int subtract(int a, int b);
    }

    interface IScientificCalc
    {
        float add(float a, float b);
        float subtract(float a, float b);
    }

    class Calulation : IBasicCalculator, IScientificCalc
    {
        public int add(int a, int b)
        {
            Console.WriteLine("Add method from Ibasiccalc");
            //throw new NotImplementedException();
            return a + b;
        }

        public float add(float a, float b)

        {
            Console.WriteLine("Add method from IScientificcalc");
            //throw new NotImplementedException();
            return a + b;
        }

        public int subtract(int a, int b)
        {
            Console.WriteLine("sub method from Ibasiccalc");
            //throw new NotImplementedException();
            return b - a; 
        }

        public float subtract(float a, float b)
        {
            Console.WriteLine("Subtract method from IScientificcalc");
            //throw new NotImplementedException();
            return b - a;
        }
    }
}
