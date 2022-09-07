using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractInterfacepractice
{
    interface Interface_
    {
        public void Function1();
        public void Function2();
    }

    abstract class Abstract_

    {
        public string String_1 = "String1";
        public string String_2 = "String2";

        public abstract void AbsFunction_1();
        public abstract void AbsFunction_15();

        public virtual void AbsFunction_2()
        {
            Console.Write("Function 2");
        }
    }
    class AbstractInterface : Abstract_, Interface_
    {
        public override void AbsFunction_2()
        {
            base.AbsFunction_2();
            Console.Write("\n Overidden Abs Function 2 Interface");

        }
        public override void AbsFunction_1()
        {
            Console.Write("AbsFunction 1 Interface");
        }

        public override void AbsFunction_15()
        {
            Console.Write("AbsFunction 15 Interface");
        }

        public void Function1()
        {
            Console.Write("Function 1 Interface");
        }
    

        public void Function2()
        {
            Console.Write("Function 2 Interface");
        }

         

    }
}
