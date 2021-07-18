using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week\n(make sure to capitalize the first letter):");//prompt user to enter day of the week
            string day = Console.ReadLine();

            try //try/catch block
            {
                daysOfTheWeek days = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), day); // Assign the value/values to the variable of the enum data type
                Console.WriteLine("Today is {0}", day);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }



        }
        enum daysOfTheWeek //create enum for days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
