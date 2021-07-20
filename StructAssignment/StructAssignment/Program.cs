using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number numberObject = new Number();
            numberObject.Amount = 20.5m;

            Console.WriteLine(numberObject.Amount);
            Console.ReadLine();
        }
    }
}
