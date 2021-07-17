using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            method math = new method(); //calls class 'method'
            Console.WriteLine("Passing in integer 5 and adding 5: " + math.number(5)); //calling a method by using class, method name, and parameters
            Console.WriteLine("Passing in decimal 5.5 and multiplying by 5: " + math.number(5.5m));  //total is rounded to 30
            Console.WriteLine("Passing in integer 6 as a string: " + math.number("6")); //total is rounded to 1
            Console.ReadLine();
        }
    }
}
