using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate T GetInfoStudent<T>();
    class student
    {
        public int StudentId = 1;
        public string Name = "Tran Van Tiep";
        public int Age = 20;
        public string Gender = "Male";
        public string GetId()
        {
            return StudentId+"";
        }
        public string GetName()
        {
            return Name;
        }
        public string GetAge()
        {
            return Age+"";
        }
        public string GetGender()
        {
            return Gender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student students = new student();
            GetInfoStudent<string> getId = new GetInfoStudent<string>(students.GetId);
            GetInfoStudent<string> getName = new GetInfoStudent<string>(students.GetName);
            GetInfoStudent<string> getAge = new GetInfoStudent<string>(students.GetAge);
            GetInfoStudent<string> getGender = new GetInfoStudent<string>(students.GetGender);
            Console.WriteLine("Id:{0} \t Name: {1} \t Age: {2} \t Gender: {3}",getId(),getName(),getAge(),getGender());            
            Console.ReadLine();
        }
    }
}
