using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        public static void GetInfo<T,A>(T name,A Age, T Address)where T : class where A : struct
        {
            Console.WriteLine("Parameter name: " + name + " Type: " + name.GetType());
            Console.WriteLine("Parameter age: " + Age + " Type: " + Age.GetType());
            Console.WriteLine("Parameter address: " + Address + " Type: " + Address.GetType());
        } 
        static void Main(string[] args)
        {
            GetInfo<string, int>("Tran van tiep", 20, "Mo Duc - Quang Ngai");
            Console.ReadKey();
        }
    }
}
