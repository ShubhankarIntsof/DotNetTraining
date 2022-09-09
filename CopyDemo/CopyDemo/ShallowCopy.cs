using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDemo
{
    class ShallowCopy :ICloneable
    {
        public int I { get; set; }
        public int J { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
