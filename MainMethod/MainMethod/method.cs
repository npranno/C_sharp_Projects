using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class method
    {
        //multiple methods having the same name but different data types
        public int number(int add) //int which uses whole numbers
        {
            int total1 = add + 5;
            return total1;
        }
        public int number(decimal multiply) //decimal which is defined by using the 'm' symbol
        {
            int total2 = Convert.ToInt32(multiply) * 5; //ToInt32 converts string value to integer
            return total2;
        }
        public int number(string divide) //string value
        {
            int total2 = Convert.ToInt32(divide) / 5;
            return total2;
        }
    }
}
