using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingAssesment
{
    class Program
    {
        Thread T1;
        Thread T2;

        [Obsolete]
        static void Main(string[] args)
        {
            Program p = new Program();
            p.T1 = new Thread(new ThreadStart(p.T1Fxn));
            p.T2 = new Thread(new ThreadStart(p.T2Fxn));

            Console.WriteLine("Thread 1 is alive Status : {0}", p.T1.IsAlive);

            Console.WriteLine("Thread 2 is alive Status : {0}", p.T2.IsAlive);
            p.T2.Start();
            p.T1.Start();
        }

        public void T1Fxn()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread 1 {0}",i);
                Console.WriteLine("T1 Current State : {0}", T1.ThreadState);
                Console.WriteLine("");
                Thread.Sleep(1000);
            }
        }

        [Obsolete]
        public void T2Fxn()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 3)
                {
                    T1.Suspend();
                    Console.WriteLine("Thread Suspended");
     
                    
                }else if(i == 5)
                {
                    T1.Resume();
                    Console.WriteLine("Thread Resumed");
                }

                Console.WriteLine("Watching from Thread 2");
                Console.WriteLine("**Thread 2 {0}", i);
                Console.WriteLine("**Thread 2 is alive Status : {0}", T2.IsAlive);
                Console.WriteLine("**T2 Current State: {0}", T2.ThreadState);
                Console.WriteLine("----Thread 1 is alive Status : {0}", T1.IsAlive);
                Console.WriteLine("----T1 Current State : {0}", T1.ThreadState);
                Console.WriteLine("");
                Thread.Sleep(500);
            }
        }
    }
}
