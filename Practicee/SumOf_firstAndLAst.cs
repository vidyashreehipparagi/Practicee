using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class SumOf_firstAndLAst
    {
        static void Main(string[] args)
        {
            int num = 12365;
            int lastDigit = num % 10;
            int firstDigit=0;
            int sum = 0;
            while(num > 0) { 
            firstDigit= num % 10;
                num = num / 10;
            }
            sum = firstDigit + lastDigit;
            Console.WriteLine(sum);
        }
    }
}
