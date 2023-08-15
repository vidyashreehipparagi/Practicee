using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Exponential
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enterr base");
            int basePower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enterr Expo");

            int expo = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <=expo; i++)
            {
                power = power*basePower;
            }
            Console.WriteLine(power);
        }
    }
}
