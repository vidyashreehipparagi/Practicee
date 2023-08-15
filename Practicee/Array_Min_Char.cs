using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Min_Char
    {
        public static char MinChar(char[] c)
        {
            char min = c[0];
            for (int i = 0; i <c.Length; i++)
            {
                if (c[i] < min)
                {
                    min = c[i];
                }

            }
            return min;
        }
        static void Main(string[] args)
        {
            char[] ch = { 'V', 'i', 'd', 'y', 'A' };
            char a=Array_Min_Char.MinChar(ch);
            Console.WriteLine(a);
        }
    }
}
