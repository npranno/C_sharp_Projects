using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee : Person
    {
        public override void SayName()
        {
            string first = firstName;
            string last = lastName;
            Console.WriteLine(first + last);
            Console.ReadLine();
        }
    }
}
