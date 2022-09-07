using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    
    class Calculator
    {
        public int number1, number2;
        public Calculator() { }
        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
            
        }

        public static Calculator operator + (Calculator c1)
        {
            //c1.number1 = -c1.number1;
            //c1.number2 = -c1.number2;
            return c1;
        }

        public static Calculator operator +(Calculator c1, Calculator c2)
        {
            Calculator cal = new Calculator();
            cal.number1 = c1.number1 + c1.number2;
            cal.number2 = c2.number1 + c2.number2;
            return cal;

        }
        public void Print()
        {
            Console.WriteLine("Calculator " + number1 + " " + number2 );
        }


    }
}
