using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Even_oddArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
            int[] even = new int[arr.Length];
            int[]odd = new int[arr.Length];
            int i, j=0, k=0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2== 0)
                {
                    even[j]= arr[i];
                    j++;
                }
                else
                {
                    odd[j]= arr[i];
                    k++;
                }
            }
            Console.WriteLine("Even array");
            for (i=0;i<j;i++)
            {
                Console.WriteLine(even[i]);
            }
            Console.WriteLine("Odd array");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine( odd[i]);
            }
        }
    }
}
