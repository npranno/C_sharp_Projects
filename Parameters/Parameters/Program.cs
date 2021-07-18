using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            Employee<int> employeeId = new Employee<int>();

            employee.Things.Add("Nick");
            employee.Things.Add("Bob");
            employee.Things.Add("Courtney");
            employeeId.Things.Add(10);
            employeeId.Things.Add(11);
            employeeId.Things.Add(12);

            foreach (string name in employee.Things)
            {
                Console.WriteLine(name);
            }
            foreach (int Id in employee.Things)
            {
                Console.WriteLine(Id);
            }
            Console.ReadLine();
        }
    }
}
