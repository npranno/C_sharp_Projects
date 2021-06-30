using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to package express. Please follow the instructions below.\n");
            Console.WriteLine("What is the weight of your package in pounds?");
            int packageWeight = (Convert.ToInt32(Console.ReadLine()));

            if (packageWeight > 50)
            {
                Console.WriteLine("Your package is too heavy to ship via Package Express. Have a good day\nHit any key to end.");
                Console.ReadKey();
                return;
                
            }

            Console.WriteLine("What is the height of your package in inches?");
            double packageHeight = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("What is the length of your package in inches?");
            double packageLength = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("What is the length of your package in inches?");
            double packageWidth = (Convert.ToDouble(Console.ReadLine()));

            if (packageHeight + packageLength + packageWidth> 50)
            {
                Console.WriteLine("Your package is too big to be shipped via Package Express\nHit any key to end.");
                Console.ReadKey();
                return;
            }

            double quote = ((packageLength * packageHeight * packageWidth) * packageWeight / 100);

            Console.WriteLine("Your shipping total is $" + quote + ".");
            Console.ReadKey();
            return;
        }
    }
}
