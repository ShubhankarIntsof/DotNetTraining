using System;

//Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.  


namespace Assesment1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [ , ] arr1 = new int[3, 3];


            Console.Write("Enter elements in the matrix :\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter number of position [{i},{j}] : ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Displaying Matrix \n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n");
        }
    }
}
