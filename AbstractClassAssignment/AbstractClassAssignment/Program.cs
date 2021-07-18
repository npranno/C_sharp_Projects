using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            person.SayName();
        }
    }
}
