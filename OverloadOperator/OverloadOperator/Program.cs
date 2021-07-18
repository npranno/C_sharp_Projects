using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empOne = new Employee();
            empOne.Id = 01;

            Employee empTwo = new Employee();
            empTwo.Id = 02;

            Console.WriteLine(empOne == empTwo);
            Console.ReadLine();
        }
    }
}
