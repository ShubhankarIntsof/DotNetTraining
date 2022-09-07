using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling


{
    class TempIsZeroException : Exception

    {
        
        public TempIsZeroException(string Message) : base(Message)
        {
           
        }
    }

    class Temperature
    {
        int temperature = 0;
        public void showTemp()
        {
            if(temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temp Found"));

            }
            else
            {
                Console.WriteLine("Temperature : {0}", temperature);
            }
        }

    }
}
