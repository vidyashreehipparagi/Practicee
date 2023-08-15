using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class ArrayReverse
    {
        //array Reverse
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = arr.Length - 1;
         
            for(int i = 0; i < arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }
            foreach (int item in arr)
            {



                Console.WriteLine(item);
            }




        }
    }
}
