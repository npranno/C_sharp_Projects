using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person, IQuittable
    {
        public Employee()
        {
            firstName = "Sample";
            lastName = "Student";
        }

        public void Quit()
        {
            Console.WriteLine("The employee above has decided to quit.");
            Console.WriteLine();
        }
    }
}
