using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class String_Reverse
    {
        static void Main(string[] args)
        {
            ////String Reverse
            //Console.WriteLine("Enter string");
            //string s=Console.ReadLine();

            //for(int i = s.Length-1; i >= 0; i--)
            //{
            //    Console.Write(s[i]);
            //}
            //Console.WriteLine();
            Console.WriteLine("Enter string");
            string s=Console.ReadLine();
            string str1 = "";
            for(int i=s.Length-1; i>=0; i--)
            {
                str1 = str1 + s[i];
            }
            Console.WriteLine("------After reverse-------\n");
            Console.WriteLine(str1);

        }
    }
}
