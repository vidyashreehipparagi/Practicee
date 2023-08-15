using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    public class Array_Prime_Method
    {
        public static bool IsPrimeNumber(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {

                    return false;
                    break;
                }
            }
            return true;
            
        }
        static void Main(string[] args)
        {
            int[] a = {2, 6, 4, 5};
            int sum = 0;
            int count = 0;
            for(int i=0; i < a.Length; i++)
            {
                if (Array_Prime_Method.IsPrimeNumber(a[i])) 
                {
                    Console.WriteLine(a[i]);
                    sum = sum + a[i];
                    count++;

                    
                }
            }
            Console.WriteLine("avg= "+sum/count);
        }
    }
}
