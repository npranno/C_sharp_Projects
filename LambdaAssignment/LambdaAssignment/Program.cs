using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> a = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName = "Long", ID = 001 },
                new Employee() {FirstName = "Nick", LastName = "Pranno", ID = 002 },
                new Employee() {FirstName = "Joe", LastName = "Brown", ID = 003 },
                new Employee() {FirstName = "John", LastName = "Jones", ID = 004 },
                new Employee() {FirstName = "Marty", LastName = "McFly", ID = 005 },
                new Employee() {FirstName = "Jim", LastName = "Jones", ID = 006 },
                new Employee() {FirstName = "Frank", LastName = "Miller", ID = 007 },
                new Employee() {FirstName = "Connie", LastName = "Wilson", ID = 008 },
                new Employee() {FirstName = "Jules", LastName = "Verne", ID = 009 },
                new Employee() {FirstName = "Courtney", LastName = "Davenport", ID = 010 }
            };

            List<Employee> b = new List<Employee>();

            foreach (Employee employee in a)//new list of all employees with first name "Joe"
            {
                if (employee.FirstName == "Joe")
                {
                    b.Add(employee);

                }
            }

            List<Employee> c = a.Where(x => x.FirstName == "Joe").ToList();//same thing, but with Lambda expression

            List<Employee> d = a.Where(x => x.ID > 5).ToList();//using lambda, make list where all employees where ID is greater than 5

            Console.WriteLine(a.Count);
            Console.WriteLine(b.Count);
            Console.WriteLine(c.Count);
            Console.WriteLine(d.Count);

            Console.ReadLine();
        }
    }

}
