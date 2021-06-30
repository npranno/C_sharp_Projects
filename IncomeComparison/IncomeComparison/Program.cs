using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1\nHourly Rate?");
            string person1Hourly = Console.ReadLine();
            int hourly1 = Convert.ToInt32(person1Hourly);
            Console.WriteLine("Hours worked per week?");
            string person1Hours = Console.ReadLine();
            int hours1 = Convert.ToInt32(person1Hours);
            Console.WriteLine("Person 2\nHourly Rate?");
            string person2Hourly = Console.ReadLine();
            int hourly2 = Convert.ToInt32(person2Hourly);
            Console.WriteLine("Hours worked per week?");
            string person2Hours = Console.ReadLine();
            int hours2 = Convert.ToInt32(person2Hours);
            Console.WriteLine("Annual Salary of Person 1:");
            int person1Salary = ((hourly1 * hours1) * 52);
            Console.WriteLine(person1Salary);
            Console.WriteLine("Annual Salary of Person 2:");
            int person2Salary = ((hourly2 * hours2) * 52);
            Console.WriteLine(person2Salary);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = person1Salary > person2Salary;
            Console.WriteLine(isMore);
            Console.ReadLine();

        }
    }
}
