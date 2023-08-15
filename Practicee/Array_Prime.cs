using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Prime
    {
        static void Main(string[] args)
        {
            int[]arr=new int[10];
            Console.WriteLine("Enter elemts of an array");
            //int count = 0;
            //int prime;
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
                int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count++;
                       
                        break;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine("prime no =" + arr[i]);
                    sum = sum + arr[i];
                  
                }
            }
            Console.WriteLine("avg "+sum/count);
        }
    }
}
