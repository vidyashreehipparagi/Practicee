using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Alternate
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter elementsof an array");
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
