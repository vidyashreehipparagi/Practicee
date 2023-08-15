using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class KM_Number
    {
        static void Main(string[] args)
        {
            int num = 145;
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int fact = 1;// to find factorial of each digit
                int digit = num %10;
                for(int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                sum=sum + fact;
                num = num / 10;
            }
            if(sum==temp)
            {
                Console.WriteLine("Km number");
            }
            else
            {
                Console.WriteLine("not km ");
            }
        }
    }
}
