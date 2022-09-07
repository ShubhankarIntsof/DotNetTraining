using System;

namespace Assesment1Q7

{

    class permutation
    {
        public void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void prnPermut(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                    Console.Write("{0}", list[i]);
                Console.Write(" ");
            }
            else
                for (i = k; i <= m; i++)
                {
                    swapTwoNumber(ref list[k], ref list[i]);
                    prnPermut(list, k + 1, m);
                    swapTwoNumber(ref list[k], ref list[i]);
                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for permutation using recursion");
            int n, i;
            permutation test = new permutation();
            int[] arr1 = new int[5];

            Console.WriteLine("\n\n all possible permutations of an array :");
            

            Console.Write(" Input the number of elements to store in the array [maximum 5 digits ] :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($" Input {n} number of elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write($" element - {i} : ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write($"\n The Permutations with a combination of {n} digits are : \n");
            test.prnPermut(arr1, 0, n - 1);
            Console.Write("\n\n");
        }
    }
}
