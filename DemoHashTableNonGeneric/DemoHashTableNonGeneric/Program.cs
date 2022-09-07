using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoHashTableNonGeneric
{
    class Program
    {

        public void empDetails(params object[] val)
        {
            Console.WriteLine("Inside Show Function");
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }

        }

        static int square(int val)
        {
            return val * val;
        }
        static void Main(string[] args)
        {
            //Program myData = new Program();
            //myData.empDetails("Shubham", "22", "e@e.com");

            //Program myData1 = new Program();
            //myData.empDetails("Shubham1", "221", "e@e.com");

            //Console.WriteLine(square(6));

            MyClass emp1 = new MyClass();
            emp1.name = "Yash";
            Console.WriteLine($"Name is : {emp1.name} Department is : {emp1.dept}");



            //Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            //Dictionary<string, float> PriceList = new Dictionary<string, float>();
            //AuthorList.Add("Book1", (Int32)1111);
            //AuthorList.Add("Book2", (Int32)2222);
            //AuthorList.Add("Book3", (Int32)3333);

            //PriceList.Add("Book1", (float)10.0);
            //PriceList.Add("Book2", (float)20.0);
            //PriceList.Add("Book3", (float)30.0);

            //AuthorList.Remove("Book1");
            //PriceList.Remove("Book1");

            //foreach (KeyValuePair <string, Int16> items in AuthorList)
            //{
            //    Console.WriteLine($"key: {items.Key}, value: {items.Value}");
            //}

            //foreach (KeyValuePair<string, float> items in PriceList)
            //{
            //    Console.WriteLine($"key: {items.Key}, value: {items.Value}");
            //}

            //if (AuthorList.ContainsKey("Book2"))
            //{
            //    Console.WriteLine(" FINDING :" + AuthorList["Book2"]);
            //}

            //AuthorList.Clear();
            //PriceList.Clear();

            //Console.WriteLine("AuthorList Count is: " + AuthorList.Count());
            //Console.WriteLine("PriceList Count is: " + PriceList.Count());


            //String Implementation
            //int[][] arr = new int[3][];
            //arr[0] = new int[] { 1, 3, 5, 7, 9 };
            //arr[1] = new int[] { 0, 2, 4, 6 };
            //arr[2] = new int[] { 11, 22 };




            //for (int i = 0; i < arr.Length; i++)
            {

                //    for (int j = 0; j < arr[i].Length; j++)
                //    {
                //        Console.Write(arr[i][j] + " ");

                //    }
                //    Console.WriteLine();
                //}



            }
        }

    }
}
