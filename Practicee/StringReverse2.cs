using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class StringReverse2
    {
        static void Main(string[] args)
        {
            //string reverse first and last letter should remail same and only middle word should reverse
            //I Love India Country--->Input
           // I evoL aidnI Country--->Output
            
            int i, j;
            Console.WriteLine("Enter String");
            string str=Console.ReadLine();
            string[] arr = str.Split(' ');
            string reverseValue = " ";
            for (i = 0; i < arr.Length; i++)
            {
                if (i == 0 || i == arr.Length - 1)
                {
                    reverseValue += arr[i];
                }
                else

                {
                    string word1 = arr[i];
                    string reverseWord = " ";
                    for(j=word1.Length-1;j>=0;j--)
                    {
                        reverseWord += word1[j];
                    }
                    reverseValue += reverseWord;

                }
            }
            Console.WriteLine(reverseValue);


        }
    }
}
