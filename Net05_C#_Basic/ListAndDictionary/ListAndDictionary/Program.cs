using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDictionary
{
    class Student
    {
        public int StudentId;
        public string Name;
        public int Age;
        public string Class;
    }
    class ComparerAgeStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Age.CompareTo(y.Age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> ListStudents = new List<Student>()
            {
                new Student{ StudentId = 1, Name = "Nguyen Van A", Age= 17, Class = "Math"},
                new Student{ StudentId = 2, Name = "Nguyen Van B", Age= 17, Class = "Math"},
                new Student{ StudentId = 3, Name = "Nguyen Van C", Age= 20, Class = "Biological"},
                new Student{ StudentId = 4, Name = "Nguyen Van D", Age= 18, Class = "English"},
                new Student{ StudentId = 5, Name = "Nguyen Van A", Age= 19, Class = "Literary"},
            };
            const string searchName = "Nguyen Van B";
            var searchStudent = ListStudents.FindAll(x => x.Name == searchName).ToList();
            if(searchStudent.Count == 0)
            {
                Console.WriteLine("Can not find student have name: {0}", searchName);
            }
            else
            {
                Console.WriteLine("Find {0} student have name: {1}", searchStudent.Count, searchName);
                foreach(var StudentItem in searchStudent)
                {
                    Console.WriteLine("Id: {0} \t Name: {1} \t Age: {2} \t Class: {3}",
                        StudentItem.StudentId, StudentItem.Name, StudentItem.Age, StudentItem.Class);
                }
            }
            Console.WriteLine("\nList student not sort: ");
            ListStudents.ForEach(x => Console.WriteLine("Id: {0} \t Name: {1} \t Age: {2} \t Class: {3}",
                x.StudentId, x.Name, x.Age, x.Class));
            Console.WriteLine("\nList student sort Age student: ");
            ListStudents.Sort(new ComparerAgeStudent());
            ListStudents.ForEach(x => Console.WriteLine("Id: {0} \t Name: {1} \t Age: {2} \t Class: {3}",
                x.StudentId, x.Name, x.Age, x.Class));
            const int indexRemove = 1;
            ListStudents.RemoveAt(indexRemove);
            Console.WriteLine("\nList student remove student at Index {0}: ",indexRemove);
            ListStudents.Sort(new ComparerAgeStudent());
            ListStudents.ForEach(x => Console.WriteLine("Id: {0} \t Name: {1} \t Age: {2} \t Class: {3}",
                x.StudentId, x.Name, x.Age, x.Class));
            Console.ReadKey();
        }
    }
}
