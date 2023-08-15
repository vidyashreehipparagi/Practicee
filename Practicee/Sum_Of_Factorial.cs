using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Sum_Of_Factorial
    {
        static void Main(string[] args)
        {
            int i;
            int fact=1;
            int sum=0 ;
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= num; i++)
            {
                fact= fact * i;

            sum = sum + fact;
            }
            Console.WriteLine("FACTORIAL = "+fact);
            Console.WriteLine("SUM = "+sum);
        }
    }
}
