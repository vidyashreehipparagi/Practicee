using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Disarium_Number
    {
        static void Main(string[] args)
        {
            int num = 135;
            int count = 0;
           int sum = 0;
           
            int temp = num;
            while (num > 0)
            {
               num=num/10;
                count++;
            }
         
            num = temp;
            while (num > 0)

            {
                int digit = num % 10;
                int power = 1;

                for (int i = 1; i <= count; i++)

                {
                    power = power * digit;

                }
                sum = sum + power;
                count--;
                num = num / 10;
            }
      

            if (sum == temp)
            {
                Console.WriteLine("Dissarium Number");
            }
            else
            {
                Console.WriteLine("not Dissarium Number");
            }
        }
    }
    }

