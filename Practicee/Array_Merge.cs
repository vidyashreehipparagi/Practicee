using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Merge
    {
        static void Main(string[] args)
        {
            int[] num1 = { 10,20,30,40,50,60};
            int[] num2 = { 70, 80, 90, 101, 103 };
            int[]num3=new int[num1.Length+num2.Length];
            int count = 0;
            for(int i=0; i<num1.Length; i++)
            {
                num3[count] = num1[i];
                count++;
            }
            for (int i = 0; i <num2.Length; i++)
            {
                num3[count] = num2[i];
                count++;
            }
            foreach(int i in num3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
