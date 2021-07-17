using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class methods
    {
        public int math1(int add) //public makes it usable throught the entire project
        {
            int total = add + 5;
            return total;
        }
        public int math2(int subtract)
        {
            int total = subtract - 5;
            return total;
        }
        public int math3(int multiply)
        {
            int total = multiply * 5;
            return total;
        }
        public int math4(int divide)
        {
            int total = divide / 5;
            return total;
        }
    }
}
