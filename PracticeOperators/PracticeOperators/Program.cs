using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 25;
            //int num2 = 35;

            //if (num1 == num2)
            //{
            //    Console.WriteLine("num1 equals num2");
            //}
            //else
            //{
            //    Console.WriteLine("num1 does not equal num2");
            //}
            //Console.ReadLine();

            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("it is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("ummmmmmmm.");
            //}
            //Console.ReadLine();


            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 24 ? "your favorite number is even" : "your favorite number is odd";

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
