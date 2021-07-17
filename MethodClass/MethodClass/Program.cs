using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            class_method class_Method = new class_method(); //instantiate class 'class_method'
            Console.WriteLine("Please enter two whole numbers -- One to multiply by 5, and one to print to the screen.");

            //this try catch sequence catches any user errors such as formatting
            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                class_Method.numbers(num1: num1, num2: num2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
