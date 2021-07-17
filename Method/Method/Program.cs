using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            optional numbers = new optional(); //instantiates class 'optional'
            Console.WriteLine("Please enter a whole number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a new number. This is optional.\n" +
                "If you would like to skip this, press Enter to see your total:");

            int total; //declared from 'optional' class so Main() recognizes it
            var finalInput = int.TryParse(Console.ReadLine(), out int input2); //bool

            if (finalInput)
            {
                total = optional.parameters(input1, input2);
            }
            else
            {
                total = optional.parameters(input1);
            }

            Console.WriteLine("Your total is: " + total);
            Console.ReadLine();
        }
    }
}
