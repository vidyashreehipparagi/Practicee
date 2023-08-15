using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Character_Toggle
    {
        static void Main(string[] args)
        {
            //Array Character Toggle
            Console.WriteLine("Enetr characters of an array");
            char[] ch = new char[10];
            
            for (int i = 0; i <ch.Length; i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] - 32);

                }
            }
            Console.WriteLine(ch);
        }

    }
}
