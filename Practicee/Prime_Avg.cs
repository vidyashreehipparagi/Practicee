﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Prime_Avg
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter number");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    int count = 0;
        //    int digit;
        //    int sum = 0;
        //    //  int avg;

        //    while (num > 0)
        //    {

        //        digit = num % 10;

        //        for (int i = 1; i <= digit; i++)
        //        {
        //            if (digit % i == 0)
        //            {
        //                sum = sum + digit;
        //                count++;
        //               // Console.WriteLine(sum);
        //            }
        //        }
        //        num = num / 10;
        //    }
        //    if (count == 2)
        //    {
        //        for(int i = 1; i <= digit; i++)
        //        {

        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int num = 1234567895;
        //    int sum = 0;
        //    int count = 0;
        //    while(num > 0)
        //    {
        //     int digit=num% 10;
        //        if(digit==2||digit==3||digit==5||digit==7)
        //        {
        //            Console.WriteLine(digit);
        //            sum =sum+digit;
        //            count++;
        //        }
        //        num=num/10;
        //    }
        //    int avg=sum/count;
        //    Console.WriteLine("Avg= "+avg);

        //}
        static bool CheckPrime(int n)
        {
            if (n == 1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0, sum = 0;
            double avg = 0;
            int temp = num;

            while (temp > 0)
            {
                int digit = temp % 10;
                if (CheckPrime(digit))
                {
                    Console.WriteLine("Prime is =" + digit);
                    sum += digit;
                    count++;
                }
                temp /= 10;
            }
            avg = sum / count;
            Console.WriteLine("\n\nAverage of Prime =" + avg);
        }

    }
}

