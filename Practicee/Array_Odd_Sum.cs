using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Odd_Sum
    {
        public static int isOddSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {

                    sum = sum + arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };

            int sum = isOddSum(a);
            Console.WriteLine(sum);
        }
    }
}

