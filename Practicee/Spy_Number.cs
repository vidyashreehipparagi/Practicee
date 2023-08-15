using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Spy_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr number");
            int num=Convert.ToInt32(Console.ReadLine());
            
            int sum = 0, digit;
            int product = 1;
            while (num > 0) { 
                digit = num % 10;
                sum =sum+digit;
                product = product * digit;
                num = num / 10;
            }
            if (sum == product)
            {
                Console.WriteLine("spy number");
            }
            else
            {
                Console.WriteLine("Not spy number");
            }
        }
    }
}
