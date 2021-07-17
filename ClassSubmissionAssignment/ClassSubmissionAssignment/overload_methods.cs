using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class overload_methods
    {
        public void divide(int inNumber) //user input of number
        {
            int total = inNumber / 2;
            Console.WriteLine(total); //outputs user input divided by 2
        }
        public static void divide(int inNum1, out int outNum2) //outputs user number, overload, uses 'out' to output user input /2
        {
            int total = outNum2 = inNum1 / 2;
            Console.WriteLine(total);
        }
        public static class empty //declares static class
        {

        }
    }
}
