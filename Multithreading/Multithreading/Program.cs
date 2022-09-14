using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class MyThread
    {
        public static void Thread1Display()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("First Thread {0}\t",i);
            }
        }
        public static void Thread2Display()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Second Thread {0}\t",i);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multithreading");
            //MyThread obj1 = new MyThread();
            //Thread thread1 = new Thread(new ThreadStart(obj1.Thread1Display));
            //thread1.Start();
            Thread a = new Thread(MyThread.Thread1Display);
            //a.Start();
            Thread b = new Thread(MyThread.Thread2Display);
            a.Start();
            b.Start();
            Console.WriteLine("Both Threads are running and executing corresponding process");
                

        }
    }
}
