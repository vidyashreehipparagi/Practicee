using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class StringInitial
    {
        static void Main(string[] args)
        {
            //komal Sandeep Gupta
            //K.S.Gupta
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            string[]s=str.Split(' ');
            string result = "";
            for(int i=0;i<s.Length;i++)
            {
                if (i == s.Length - 1)
                {
                    result=result + s[i];
                }
                else

                {
                    char[] ch = s[i].ToCharArray();
                    for(int j=0; j<1; j++)
                    {
                        result = result + ch[j]+ ".";
                    }
                }
            }
            Console.WriteLine(result);


        }
    }
}
