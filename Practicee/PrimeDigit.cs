using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class PrimeDigit
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i < num; i++)
            {
                int digit = num % 10;
                if (digit % i == 0)
                {
                    count++;
                }

                if (count == 2)
                {
                    Console.WriteLine(digit);
                }
            }
        }
    }
}
