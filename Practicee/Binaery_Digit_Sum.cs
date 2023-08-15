using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Binaery_Digit_Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int index = 0;
            while(num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for(int i=1; i <= index; i++)
                {
                    power =2*power;

                }
                int ans = power * digit;
                sum=sum + ans;
                num = num / 10;
                index++;
            }
            Console.WriteLine("sum= "+sum);
        }
    }
}
