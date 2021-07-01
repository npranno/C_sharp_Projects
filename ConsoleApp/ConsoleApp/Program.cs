using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = string.Empty;
            do
            {
                Console.WriteLine("Please enter your password:");
                password = Console.ReadLine();
            }
            while (password != "TheTechAcademy");
          

            Console.WriteLine("Thank you!");
            Console.ReadLine();

            
        }
    }
}
