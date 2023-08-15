using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Even_Sum
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = {1,2,3,4,5,6};
        //    int sum = 0;
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            sum=sum+ arr[i];
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
        public static int isEvenSum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(i%2==0)
                {

                    sum = sum + arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };

            int sum=isEvenSum(a);
            Console.WriteLine(sum);
        }
        }
    }

