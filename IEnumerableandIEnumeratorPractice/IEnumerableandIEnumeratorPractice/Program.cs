using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableandIEnumeratorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IEnumerable and IEnumerator");
            List<string> Month = new List<string>();
            Month.Add("January");
            Month.Add("Febreuary");
            Month.Add("March");
            Month.Add("April");

            IEnumerable<string> iEnumerableofString = Month;

            //IEnumerable<string> iEnumerableofString = new IEnumerable()
            //{
            //    "w","w"
            //};
            //using IEnumerable Box

            foreach (string AllMonths in iEnumerableofString)
            {
                Console.WriteLine(AllMonths);
            }

            // Creating IEnumerator of string
            IEnumerator<string> IEnumeratorofString = Month.GetEnumerator();
            //displaying all the items form IEnumerator Object

            while (IEnumeratorofString.MoveNext())
            {
                Console.WriteLine(IEnumeratorofString.Current);
            }
            
            


        }
    }
}
