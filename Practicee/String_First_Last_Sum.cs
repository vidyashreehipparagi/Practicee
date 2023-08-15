using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    public class String_First_Last_Sum
    {
        static void Main(string[] args)
        {
            //write code to take one string from user which contains
            //number calculate the first 3 digit sum and last digit sum
            //if both the sum are same then display valid string otherwise throgh custom exceptiopn
            Console.WriteLine("Enter number string");
            string s=Console.ReadLine();
            int sum = 0;
           // while (s.Length == 3)
           //{
                for (int i = 0; i <3 ; i++)
                {
                    if (s[i]>='A' && s[i] <= 'Z' || s[i] >= 'a' && s[i]<='z')
                    {
                        Console.WriteLine("Enterr number only");
                    }
                    else if (s[i] >= '0' && s[i] <= '9')
                    {
                        sum = sum + ((int)char.GetNumericValue(s[i]));
                    }
                        
                }
            Console.WriteLine(sum);
            // }
        }
    }
}
