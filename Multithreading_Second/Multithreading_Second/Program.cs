using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Second
{
    class Program
    {
        static void Print()
        {
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine("Worker Thread {0}", i);
                Thread.Sleep(1000);
            }
            
        }
        static void Main(string[] args)
        {
            Thread workerThread = new Thread(new ThreadStart(Print));
            workerThread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main Thread {i}");
                Thread.Sleep(200);
            }
            Console.ReadKey();
        }
    }
}
