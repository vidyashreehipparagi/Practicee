using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Dictonary_Frequency
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Red");
            dict.Add(2, "Blue");
            dict.Add(3, "Black");
            dict.Add(4, "Red");
            dict.Add(5, "Black");
            foreach (KeyValuePair<int,string> item in dict)
            {
                Console.WriteLine();
            }


        }
    }
}
