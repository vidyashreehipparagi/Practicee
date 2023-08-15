using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class StringSplit
    {
        static void Main(string[] args)
        {
            //string split
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string[] s1=s.Split(' ');
            int i, j;
            for (i = 0; i <s1.Length; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write(" "+s1[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
