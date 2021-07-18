using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            person.SayName();

            IQuittable student = new Employee();
            student.Quit();
        }
    }
}
