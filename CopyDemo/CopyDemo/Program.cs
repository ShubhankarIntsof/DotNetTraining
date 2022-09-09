using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deep Copying Taking Place");
            ShallowCopy obj = new ShallowCopy();
            ShallowCopy objClone = obj;
            obj.I = 101;
            Console.WriteLine($"Obj Value: {obj.I} \t Clone Value: {objClone.I}");

            Console.WriteLine("--------------------After using Clone------------------------");
            ShallowCopy obj2 = (ShallowCopy) obj.Clone();
            obj.I = 201;
            Console.WriteLine("After Using Clone()");
            Console.WriteLine($"Obj Value: {obj2.I}");
        }
    }
}
