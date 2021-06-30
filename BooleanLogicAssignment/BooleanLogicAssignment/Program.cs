using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you qualify for car insurance?\nPlease press enter to continue.\n");
            
            Console.WriteLine("What is your age?: ");
            string age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?\nPlease answer either true or false: ");
            string dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?: ");
            string tickets = Console.ReadLine();

            bool qualify = (Convert.ToInt32(age) > 16) && (Convert.ToBoolean(dui) != true && (Convert.ToInt32(tickets) < 3));

            Console.WriteLine("Qualification Status: ");
            Console.WriteLine(qualify);
            Console.ReadLine();

        }
    }
}
