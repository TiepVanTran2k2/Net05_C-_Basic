using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Tran Van Tiep", 1000000, "Employee");
            Console.WriteLine("Id: " + employee.id);
            Console.WriteLine("Name: " + employee.name);
            Console.WriteLine("Salary: " + employee.salary);
            employee.PrintNotify();
            Console.ReadKey();
        }
    }
}
