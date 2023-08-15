using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Search
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[10];
        //    Console.WriteLine("Enter elements of an array");
        //    int count = 0;
        //    for (int i=0; i<arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("Enter number to search");
        //    int num=Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i <arr.Length; i++)
        //    {

        //        if (arr[i]==num)
        //        {
        //            count++;

        //        }

        //    }
        //    if (count > 0)
        //    {
        //        Console.WriteLine(num+" number is present in given array");
        //    }
        //    else
        //    {
        //            Console.WriteLine(num+"is not present in number");

        //    }

        //}



        static int index;
        public static bool SearchNumber(int[] a,int num)
        {
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] == num)
                {
                    index = 1;
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 8, 7, 9, 10 };
            Console.WriteLine( "Enter number to search");
            int num=Convert.ToInt32(Console.ReadLine());
            if (Array_Search.SearchNumber(arr, num))
            {
                Console.WriteLine(num+" is presen in an array");
            }
            else
            {
                Console.WriteLine(num+" is not present in an array");
            }
        }
        }
    }



