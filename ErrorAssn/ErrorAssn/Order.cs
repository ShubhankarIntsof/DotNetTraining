using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorAssn
{   class OutOfStockException : Exception
    {
        public OutOfStockException(string message) : base(message)
        {

        }

    }
    class Order
    {
        public void ChkOrder(int Order)
        {
            if (Order > 5)
            {
                throw (new AgeException("Out Of Stock Order Class Exception"));

            }
            else
            {
                Console.WriteLine($"No of Order is {Order}");
            }
        }
    }
}
