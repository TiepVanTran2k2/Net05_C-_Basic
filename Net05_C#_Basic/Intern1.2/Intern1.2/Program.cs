using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list number father
            List<int> listNumber = new List<int>()
            {
                1,2,3,4,5
            };
            //create list number son
            List<int> listSmallNumber = new List<int>()
            {
                6,7,8
            };
            //add list
            listNumber.AddRange(listSmallNumber);
            // remove list from index 5 --> 6
            listNumber.RemoveRange(5, 2);

            //Get the index of element 5 and then assign another value
            int index =  listNumber.IndexOf(5);
            if (index <= listNumber.Count && index > -1)
            {
                for (int i = 0; i < listNumber.Count; i++)
                {
                    if(i == index)
                    {
                        listNumber[i] = 9;
                    }
                }
            }
            //count element in list number
            Console.WriteLine("Number element: " + listNumber.Count);
            foreach (var a in listNumber)
            {
                Console.Write(a+" ");
            }

            // save list number into array number
            int[] arrayNumber = new int[listNumber.Count];
            for (int i = 0; i < listNumber.Count; i++)
            {
                arrayNumber[i] = listNumber[i];
            }
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.WriteLine(arrayNumber[i]);
            }
            Console.ReadKey();
        }
    }
}
