using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Please enter a number.");
            string input = Console.ReadLine();
            Console.WriteLine("\nNow dividing the list of numbers in the databse (10, 20, 30, 40, 50, 60) by the number you have entered,\none moment please...");
            Console.WriteLine();
            try
            {
                foreach (int number in numbers) // try/catch allows the program to catch potential errors from user input, and provide them with directions on how to fix it
                {
                    int input2 = Convert.ToInt32(input);
                    int number3 = number / input2;
                    Console.WriteLine(number + " divided by " + input + " equals " + number3);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Please enter a whole number.");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR: You cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine(); //finally makes sure that the program stops and shows the exact error and message and displays it to the user
            }
        }
    }
}
