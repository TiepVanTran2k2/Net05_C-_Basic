using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.Practice.T02.Problem03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo học sinh mới
            Student student = new Student(0001, "Nguyen Van A", 10, 10, 10);

            student.Graduate();
            Console.WriteLine(student.GetCertificate());

            Console.ReadKey();
        }
    }
}
