using System;

namespace Assesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coding Assesmant 1");

            int[] Arr = new int[10];
            int i, Len, sum = 0;


            Console.Write("Input the number of elements to be stored in the array :");
            Len = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < Len; i++)
            {
                Console.Write("Enter Elements One by One : ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < Len; i++)
            {
                sum += Arr[i];
            }

            Console.Write($"Sum is {sum}");
        }
    }
}
