using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            GrandChild childObj = new GrandChild();
            childObj.read("MyName", "MySubject");
            CousinClass cousinObj = new CousinClass("2ndName",33);
            cousinObj.read();
            
        }
    }
}
