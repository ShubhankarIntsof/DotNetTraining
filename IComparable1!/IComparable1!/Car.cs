using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable1_
{
    class Car: IComparable<Car>
    {

        public string name; 
        public int year; 


        public Car(string name, int year)
        {
            this.name = name;
            this.year = year;
        }


        public int CompareTo(Car obj)
        {
            if (this.year > obj.year)
                return 1;
            else if (this.year > obj.year)
                return -1;
            else
                return 0;
        }

        public class CarMakeComparer : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.name.CompareTo(y.name);
            }
        }

        public class CarMakeComparerDesc : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return -x.name.CompareTo(y.name);
            }
        }




    }
}
