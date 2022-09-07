using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListNonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList Implementation - Non generic Collection");
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);

            arlist1[1] = "chill";
            Console.WriteLine(arlist1[1]);
            foreach(var item in arlist1)
            {
                Console.WriteLine(item);
            }

            //STACK


            Stack<int> myStack = new Stack<int>();
            //Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            Console.WriteLine("STACK");
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Contains(2));


            foreach (var item in myStack)
                Console.WriteLine(item);

            //QUEUE


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine("QUEUE");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Contains(5));




            foreach (var item in queue)
                Console.WriteLine(item);

            //queue.Clear();
            queue.Enqueue(6);
            queue.Reverse();
            Console.WriteLine("After Clear");


            foreach (var item in queue)
                Console.WriteLine(item);







            HashSet<string> hashSet = new HashSet<string>();
            //HashSet hashSet = new HashSet();
            hashSet.Add("A");
            hashSet.Add("B");
            hashSet.Add("B");

            Console.WriteLine("HASHSET");
            hashSet.Remove("B");

            //if (hashSet.Contains("B"))
            //{
            //    hashSet.Remove("B");
            //}

            foreach (var item in hashSet)
                Console.WriteLine(item);




        }
    }
}
