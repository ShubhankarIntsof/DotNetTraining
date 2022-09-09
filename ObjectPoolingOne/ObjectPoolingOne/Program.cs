using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolingOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fa = new Factory();
            Employee myEmp = fa.GetEmployee();
            Console.WriteLine("First Object is Created");
            Employee myEmp1 = fa.GetEmployee();
            Console.WriteLine("First Object is Created");
            Employee myEmp2 = fa.GetEmployee();
            Console.WriteLine("First Object is Created");
            Employee myEmp3 = fa.GetEmployee();
            Console.WriteLine("First Object is Created");
            Employee myEmp4 = fa.GetEmployee();
            Console.WriteLine("First Object is Created");
        }
    }
}
