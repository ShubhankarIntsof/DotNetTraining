using System;
using System.Collections.Generic;

namespace Assesment1Q2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for Unique Element");


            int[] arr = new int[30];
            int n;
            Console.Write("Enter The Elements in Array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Input {n} elements in the array :\n ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var d = new Dictionary<int, int>();
            foreach (var res in arr)
            {
                if (d.ContainsKey(res))
                    d[res]++;
                else
                    d[res] = 1;
            }

            
            foreach (var val in d)
            {
                if(val.Value == 1)
                {
                    Console.WriteLine($"{val.Key} is unique");
                }
            }
               
        }
    }
}
