using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            methods math = new methods();
            Console.WriteLine("Please enter a number you would like to have\nAdded, Subtracted, Multiplied, and Divided by 5:");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input + " plus 5 is " + math.math1(input) + "."); //calls method and passes user input as a parameter
            Console.WriteLine(input + " minus 5 is " + math.math2(input) + ".");
            Console.WriteLine(input + " multiplied by 5 is " + math.math3(input) + ".");
            Console.WriteLine(input + " divided by 5 is " + math.math4(input) + ".");
            Console.ReadLine();
        }
    }
}
