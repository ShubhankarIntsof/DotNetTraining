using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Temperature Temp = new Temperature();
            try
            {
                Temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("Error is {0}", e);

                //throw;
            }

            //Console.WriteLine("Exception Handling");
            //int[] arr = { 1, 2, 3, 6 };

            //try

            //{





            //    //Displaying it 

            //    for (int i = 0; i < arr.Length; i++)

            //    {

            //        Console.WriteLine(arr[i]);

            //    }



            //    Console.WriteLine(arr[10]);

            //}

            //catch (IndexOutOfRangeException e)

            //{

            //    Console.WriteLine(" An Exception Has occured : {0},{1}", e.Message, e.StackTrace);

            //    // throw; 

            //}

            //catch (DivideByZeroException e)

            //{

            //    Console.WriteLine("An Exception has occured :{0}", e.Message);

            //}



            //finally

            //{

            //    Console.WriteLine("Finally Blocks runs irrespective of Exception..!!");

            //    for (int i = 0; i < arr.Length; i++)

            //    {

            //        Console.WriteLine("{0}", arr[i]);

            //    }


            //}

            Console.WriteLine("Outside");
        }
    }
}
