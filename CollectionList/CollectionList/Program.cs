using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add("Chicago");
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            //cities.Add("Chicago");
            
            Console.WriteLine(cities.Capacity);

        }
    }
}
