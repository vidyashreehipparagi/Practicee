using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Zero_Shift
    {
      
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 0, 5, 0, 8, 9, 7, 0, 6, 0 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] != 0)
            //    {
            //        continue;
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[j] == 0)
            //            {
            //                continue;
            //                arr[i] = arr[j];
            //                arr[j] = 0;
            //                break;
            //            }
            //        }
            //    }
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            int[] arr = new int[8];
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("________________");
            for (int i= 0; i <arr.Length;i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i]!=0)//not equal to is used when we want all zeero at first and equal to at last
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }

        }
    }
}
