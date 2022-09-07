using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace ConsoleCultureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culInf = new CultureInfo("smn-FI");
            CultureInfo currCulture = Thread.CurrentThread.CurrentCulture;

            DateTime currTime = DateTime.Now;
            string dateInUSA = currTime.ToString("D", culInf);
            string dateLocal = currTime.ToString("D", currCulture);
            Console.WriteLine(currCulture);
            Console.WriteLine(dateLocal);
            Console.WriteLine(dateInUSA);

        }
    }
}
