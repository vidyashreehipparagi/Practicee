using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class ArraySort2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 5, 8, 6, 7, 2, 3, 4, 9, 11, 10 };
            int temp = 0;
           
            for (int i = 0; i <arr.Length/2;i++)
            {
                for (int j = i + 1; j <arr.Length/2; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;


                    }
                }
                Console.WriteLine(arr[i]);
            }
           
            for (int i =arr.Length/2+1;i <arr.Length;i++)
            {
                for (int j = i + 1; j <arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;


                    }
                }
                Console.WriteLine(arr[i]);
            }

        }
    }
}
