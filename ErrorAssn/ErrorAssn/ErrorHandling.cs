using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorAssn
{
    class AgeException : Exception
    {
        public AgeException(string Message) : base(Message)
        {

        }
    }

    class ErrorHandling
    {
        public void ChkAge(int Age)
        {
            if(Age < 20)
            {
                throw (new AgeException("Age less than 20 ErrorHandling Class Exception"));

            }
            else
            {
                Console.WriteLine($"Age is {Age}");
            }
        }
        
    }
}


