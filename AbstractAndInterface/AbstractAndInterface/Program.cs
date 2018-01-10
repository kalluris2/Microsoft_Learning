using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeClass Employee = new FullTimeClass()
            {
                Id = 1023,
                FirstName = "Mark",
                LastName = "Henry",
                AnnualSalary = 92000
            };
            Console.WriteLine(Employee.FullName());
            Console.WriteLine(Employee.MonthlySalary());
            Console.WriteLine("------------------");
            ContractEmployee cEmployee = new ContractEmployee()
            {
                Id = 5243,
                FirstName = "Subash",
                LastName = "Gali",
                HourlyRate = 42,
                TotalHours = 160
            };
            Console.WriteLine(cEmployee.FullName());
            Console.WriteLine(cEmployee.MonthlySalary());

            Console.ReadLine();
        }
    }
}
