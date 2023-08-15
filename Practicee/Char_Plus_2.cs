using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Char_Plus_2
    {
        public static char[] ToggleArray(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'X')
                {
                    ch[i] = (char)(ch[i] +2);
                }
                else if (ch[i] == 'Y' || ch[i] == 'Z')
                {
                    ch[i] = (char)(ch[i] -24);
                }
                else if (ch[i] >= 'a' && ch[i] <= 'x')
                {
                    ch[i] = (char)(ch[i] +2);

                }
                else if (ch[i] == 'y' || ch[i] == 'z')
                {
                    ch[i] = (char)(ch[i]-24);
                }
            }
            return ch;
        }
        static void Main(string[] args)
        {
            char[] c = { 'p', 'A', 'r', 't', 'z' };
            char[] ans = Char_Plus_2.ToggleArray(c);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
