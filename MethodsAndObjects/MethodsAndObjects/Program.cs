using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee() { FirstName = "Sample", LastName = "Student" }; //instantiate and initialize object

            person.SayName(); //calls superclass method on employee object
            Console.ReadLine();
        }
    }
}
