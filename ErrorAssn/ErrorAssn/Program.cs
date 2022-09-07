using System;

namespace ErrorAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age,Order;
            try
            {
                Console.WriteLine("Enter Order: ");
                Order = Convert.ToInt32(Console.ReadLine());

                Order Ordr = new Order();
                Ordr.ChkOrder(Order);
            }
            finally 
            {

                Console.WriteLine("Enter Age: ");
                Age = Convert.ToInt32(Console.ReadLine());

                ErrorHandling Eh = new ErrorHandling();
                Eh.ChkAge(Age);
            }

        }
    }
}
