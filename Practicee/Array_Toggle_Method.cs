using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Array_Toggle_Method
    {
       public static char[] ToggleArray(char[] ch)
        {
            for(int i=0; i<ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 'a' - 'A');
                }
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] + 'A' - 'a');

                }
            }
            return ch;
        }
        static void Main(string[] args)
        {
            char[] c = { 'h', 'E', 'L', 'l', 'o' };
            char[]ans= Array_Toggle_Method.ToggleArray(c);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
