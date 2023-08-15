using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Reverse
    {
        private static object n;

        //static void Main(string[] args)
        //{//Array Reverse
        //    Console.WriteLine("Enter elements of an array");
        //    int[] arr = new int[10];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    int j = arr.Length - 1;
        //   for(int i=0; i < arr.Length; i++)
        //    {
        //       int temp = arr[i];
        //        arr[i] = arr[j];
        //        arr[j] = temp;
        //        j--;
        //    }
        //    Console.WriteLine();

        //}
        public static bool IsReverse(int[] a)
        {
           
            int j = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
                //return false;
                //break;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < a.Length; i++)
            {


                if (Array_Reverse.IsReverse(a))
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
           
        }

    }

