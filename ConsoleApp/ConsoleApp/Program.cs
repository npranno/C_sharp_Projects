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

            bool trueOrFalse = true;
            while (trueOrFalse == true)
            {
                Console.WriteLine(trueOrFalse);
                break;
              
            }

            string password = string.Empty;
            do
            {
                Console.WriteLine("Please enter your password:");
                password = Console.ReadLine();
            }
            while (password != "TheTechAcademy");
          

            Console.WriteLine("Thank you! You have accessed the system.");
            Console.ReadLine();

            
        }
    }
}
