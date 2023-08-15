using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class FAciliting_Number
    {//write code to take 3 digit number from user multiply that number with respective 1 2 3
     //whatever the result concat it and check if concatinated string contain zero to 9 numbers only once 
     //if any digit repeate then display number is not faccinating otherwise display facinating number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 digit number");
            int num = Convert.ToInt32(Console.ReadLine());


            int num1 = num * 1;
            int num2 = num * 2;
            int num3 = num * 3;

            string s = "" + num1.ToString() + num2.ToString() + num3.ToString();
            Console.WriteLine(s);
            char[] ch = s.ToCharArray();
            int i, j, k;
            bool isFaccinating = true;
            for (i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool isVisited = false;

                for (k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {

                        isFaccinating = false;
                        break;
                    }

                }
            }
            if (isFaccinating)
            {
                Console.WriteLine(  "Is Faccinating....");
            }
            else
            {
                Console.WriteLine(  "not");
            }



        }
    }
}
