using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string first = firstName;
            string last = lastName;
            Console.WriteLine("I, " + first + last + "...");
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("Hereby resign from my position. Effective immediately.");
            Console.ReadLine();
        }
    }
}
