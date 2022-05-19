using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL_Practice.T102.Problem02
{
    class MaxContiguousSubarray
    {
        public void InputArray()
        {
            int[] inputArray = new int[100];
            Console.Write("Input length array: ");
            int LengthArray = int.Parse(Console.ReadLine());
            string print = "";
            for (int i = 0; i < LengthArray; i++)
            {
                Console.Write("Input Array[{0}]: ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
                print += inputArray[i] + " , ";
            }
            Console.WriteLine("\nArray: " + print);

            Console.Write("Sub length: ");
            int subLength = int.Parse(Console.ReadLine());
            int maxSum = FindMaxSubArray(inputArray, subLength);
            Console.WriteLine("Max sum array element: " + maxSum);

        }
        static public int FindMaxSubArray(int[] inputArray, int subLength)
        {
            int MaxSum = 0;

            int[] copy = new int[100];
            int location = 0;
            int Jump = 0;
            string print = "";
            int sum = 0;


            if (subLength > 1)
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    print += inputArray[i] + " ";
                    sum += inputArray[i];
                    Jump += 1;
                    if (location < subLength)
                    {
                        if (Jump == subLength)
                        {
                            copy[location] = sum;
                            sum = 0;
                            Jump = 0;
                            location += 1;
                            i = location - 1;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
            }

            if (subLength > location)
            {
                Console.WriteLine("Sublength large than Array length can slip");
            }
            else
            {
                for (int i = 0; i < copy.Length; i++)
                {
                    if (MaxSum < copy[i])
                    {
                        MaxSum = copy[i];
                    }
                }
            }

            return MaxSum;
        }
    }
}
