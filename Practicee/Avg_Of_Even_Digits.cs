using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    public class Avg_Of_Even_Digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            int count = 0;
            double avg=0;
            for (int i =0; i<=num; i++)
            {
                int digit=num%10;
                while (digit % 2 == 0)
                {
                    sum = sum + digit;
                    count++;
                }
                num = num / 10;



            }
                avg=sum / count;
            Console.WriteLine(avg);



        }
    }
}
