using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter 5 Elememts");
            for(int i=0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //reading and displaying
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(array[i]);

                
            }

            //deleting
            //int[] array1;

            //for (int i = 0; i < 3; i++)
            //{
            //    array[i] = array1[i];


            //}

            //sum
            Console.WriteLine("Sum");
            Console.WriteLine(array.Sum());
            //sorting
            Console.WriteLine("sorting ");
            Array.Sort(array);

            //displaying array using foreach
            Console.WriteLine("displaying using for each");

            foreach (var items in array)
            {
                Console.WriteLine(items);
            }
            

            Console.WriteLine("Mininum is " + array.Min() + " and maximum is " + array.Max());
            


        }
    }
}
