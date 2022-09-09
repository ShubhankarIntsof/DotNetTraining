using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolingOne
{
    internal class Factory
    {
        private static int _PoolMaxSize = 2;
        private static readonly Queue ObjPool = new Queue(_PoolMaxSize);
        public Employee GetEmployee()
        {
            Employee OEmployee = new Employee();
            if(Employee.Counter >= _PoolMaxSize && ObjPool.Count > 0)
            {
                OEmployee = RetriveFromPool();
            }
            else
            {
                OEmployee = GetNewEmployee();
            }
            return OEmployee;
        }
        protected Employee RetriveFromPool()
        {
            Employee OEmp;
            //if there is any object in collection
            if(ObjPool.Count > 0)
            {
                OEmp = (Employee) ObjPool.Dequeue();
                Employee.Counter--;
                Console.WriteLine("Coming From pool");
            }
            else
            {
                OEmp = new Employee();
            }
            return (OEmp);
        }
        private Employee GetNewEmployee()
        {
            
            Employee E = new Employee();
            ObjPool.Enqueue(E);
            Console.WriteLine("Coming From New EMployee");
            return E;
        }

    }
    internal class Employee
    {
        public static int Counter = 0;
        public Employee()
        {
            ++Counter;
        }
        private string _FirstName;

        public string Firstname
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;

            }

        }
        
    }
}
