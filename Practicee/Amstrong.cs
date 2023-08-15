using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Amstrong
    {
        static void Main(string[] args)
        {
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (num > 0)
            {
                int digit = num % 10;
                sum=sum+digit*digit*digit;
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("Amstrong number");
            }
            else
            {
                Console.WriteLine("Not amrstrong number");
            }
        }
    }
}
