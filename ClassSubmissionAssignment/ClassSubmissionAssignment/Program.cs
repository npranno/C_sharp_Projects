using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            overload_methods number = new overload_methods(); //access to *non-static* methods in 'overload_methods' class
            Console.WriteLine("Please enter a number to divide it by 2:");

            try
            {
                int input = Convert.ToInt32(Console.ReadLine()); //user input
                number.divide(input); //calls first method and divides user input by 2
                overload_methods.divide(input, out input); //calls second method and divides user input by 2
            }
            catch
            {
                Console.WriteLine("Please enter a whole Number.");
            }
            Console.ReadLine();
        }
    }
}
