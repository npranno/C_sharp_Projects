using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;//current dateTime by using the .Now
            Console.WriteLine("Current date and time: " + currentDateTime);//print current date and time to console
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();
            DateTime futureDateTime = currentDateTime.AddHours(Convert.ToInt32(number));
            Console.WriteLine("In " + number + " hours, it will be " + futureDateTime);
            Console.ReadLine();
        }
    }
}
