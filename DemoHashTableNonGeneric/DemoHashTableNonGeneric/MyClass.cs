using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHashTableNonGeneric
{
    class MyClass
    {
        public string name;
        public string dept;
        public MyClass()
        {
            dept = "Training and Placement";
        }
        public MyClass(string name,string dept)
        {
            this.name = name;
            this.dept = dept;
        }
    }
}
