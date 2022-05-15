using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Employee
    {
        private int Id;
        private string Name;
        private float Salary;
        private string Role;
        public static int count_check = 0;
        const int Amercement = 500000;
        public int id { get {count_check += 1; return Id; } set { Id = value;} }
        public string name { get { count_check += 1; return Name; } set { Name = value;} }
        public float salary { 
            get { if (Role == "Admin") { count_check += 1; } else { count_check += 40; }; return Salary; } 
            set { Salary = value; } 
        }
        public string role { get { return Role; } set { Role = value; } }
        public Employee(int id, string name, float salary, string role)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Role = role;
        }
        public void PrintNotify()
        {
            if(count_check > 40)
            {
                Console.WriteLine("Please fines: " + Amercement);
            }
            else
            {
                Console.WriteLine("Count check violate: " + count_check);
            }
        }
    }
}
