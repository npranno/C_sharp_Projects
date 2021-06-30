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
            Console.ReadLine();
            Console.WriteLine("Person 1\nHourly Rate?");
            Console.ReadLine();
            int person1Hourly = 15;
            Console.WriteLine(person1Hourly);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            Console.ReadLine();
            int person1Hours = 40;
            Console.WriteLine(person1Hours);
            Console.ReadLine();
            Console.WriteLine("Person 2\nHourly Rate?");
            Console.ReadLine();
            int person2Hourly = 20;
            Console.WriteLine(person2Hourly);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            Console.ReadLine();
            int person2Hours = 40;
            Console.WriteLine(person2Hours);
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 1:");
            int person1Salary = ((person1Hourly * person1Hours) * 52);
            Console.ReadLine();
            Console.WriteLine(person1Salary);
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2:");
            int person2Salary = ((person2Hourly * person2Hours) * 52);
            Console.ReadLine();
            Console.WriteLine(person2Salary);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool isMore = person1Salary > person2Salary;
            Console.WriteLine(isMore);
            Console.ReadLine();

        }
    }
}
