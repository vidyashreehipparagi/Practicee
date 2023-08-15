using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class StringWord_Frequency
    {
        static void Main(string[] args)
        {
            string s = "I Love India ";
            string[] str = s.Split();
            int i, j, k;

            for (i = 0; i < str.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (k = i - 1; k >= 0; k--)
                {
                    if (str[k] == str[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < str.Length; j++)
                    {
                        if (str[j] == str[i])
                        {
                            count++;
                        }
                    }


                    Console.WriteLine(str[i] + " " + count);
                }
            }


        }

            //  string s2 = " ";


        }
    }

