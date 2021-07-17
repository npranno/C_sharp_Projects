using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class optional
    {
        public static int parameters(int one, int two = 0) //'int two' is optional so if the user only enters one input, it automatically sets to 0
        {
            int total = one + two;
            return total;
        }
    }
}
